using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WP_Final.Classes
{
    class Custom
    {
        public static readonly SqlConnection connOpenData =  new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
                                                                @"AttachDbFilename=|DataDirectory|Database\OpenData.mdf;" +
                                                                "Integrated Security=True");
        public static readonly SqlConnection connUsers = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
                                                                  @"AttachDbFilename=|DataDirectory|Database\Access.mdf;" +
                                                                  "Integrated Security=True");

        public static Dictionary<string, string[]> filterList = null;

        public static void BuildFilterList()
        {
            if (filterList != null) return;
            filterList = new Dictionary<string, string[]>();
            filterList.Add("G20", new string[]{"Argentina", "Australia", "Brazil", "Canada", "China",
                                               "France", "Germany", "India", "Indonesia", "Italy",
                                               "Japan", "Mexico", "Russian Federation", "Saudi Arabia", "South Africa",
                                               "Korea, Rep.", "Turkey", "United Kingdom", "United States",
                                               "European Union"});
        }
        
        public static DataTable CsvToDataTable(string filepath)
        {
            List<string> lines = File.ReadAllLines(filepath)
                                 .ToList()
                                 .Where(x => !string.IsNullOrEmpty(x))
                                 .ToList();

            // process & split strings
            if (lines.TrueForAll(x => x.Last() == ','))
                lines = lines.Select(x => x.Remove(x.Length - 1)).ToList();
            bool quoted = lines.TrueForAll(x => x.Contains('"'));
            for (int i = 0; i < lines.Count; ++i) {
                if (!quoted) continue;
                lines[i] = lines[i].Replace("\",\"", "~");
                lines[i] = lines[i].Trim('"');
            }

            List<string[]> rows = lines.Select(x => x.Split(quoted ? '~' : ',')).ToList();
            lines.Clear();

            // Remove rows that don't fit
            int colNum = 0;
            rows.ForEach(x => {if (x.Length > colNum) colNum = x.Length;});
            rows = rows.Where(x => x.Length == colNum).ToList();

            // Create DataTable
            DataTable dt = new DataTable();
            
            //Set column name & allowDBNull
            rows[0].ToList().ForEach(x => dt.Columns.Add(x));
            foreach (DataColumn col in dt.Columns) col.AllowDBNull = true;
            dt.Columns[0].AllowDBNull = false;
            rows.RemoveAt(0);

            //Set datatype
            dt.Columns[0].DataType = typeof(string);
            double result = 0.0f;
            for (int i=1; i < dt.Columns.Count; ++i)
            {
                dt.Columns[i].DataType = typeof(double);
                for (int j = 0; j < rows.Count; ++j)
                {
                    if (string.IsNullOrEmpty(rows[j][i]) || double.TryParse(rows[j][i], out result))
                        continue;
                    dt.Columns[i].DataType = typeof(string);
                    break;
                }
            }

            //set rows (NEED TO BE SURE ABOUT CORRESPONDING TYPE)
            DataRow newRow;
            List<object> itemList = new List<object>();
            rows.ForEach(x => {
                newRow = dt.NewRow();

                itemList.Clear();
                for (int i = 0; i < x.Length; ++i)
                    itemList.Add(string.IsNullOrEmpty(x[i]) ?
                                 DBNull.Value :
                                 StringToObjectOfType(x[i], dt.Columns[i].DataType));
                
                newRow.ItemArray = itemList.ToArray();
                dt.Rows.Add(newRow);
            });

            for (int i = 1; i < dt.Columns.Count; ++i)
                if (!dt.Columns[i].DataType.IsEquivalentTo(typeof(double)))
                    dt.Columns.RemoveAt(i--);

            return dt;
        }

        // UNDER CONSTRUCTION
        public static bool Transpose(DataTable input, out DataTable output)
        {
            // MUST BE {(string), n*(double)} 
            int stringTypeCount = 0;
            foreach (DataColumn col in input.Columns)
                if (col.GetType().IsEquivalentTo(typeof(string)))
                    ++stringTypeCount;
            if (stringTypeCount != 1 ||
                !input.Columns[0].DataType.IsEquivalentTo(typeof(string)))
           {
                output = null;
                return false;
            }
            
            // create new table
            output = new DataTable();
            
            // add & set columns
            output.Columns.Add(input.Columns[0]);
            for (int i = 1; i < input.Rows.Count; ++i)
                output.Columns.Add(new DataColumn(input.Rows[i][0].ToString(), typeof(double)));
            foreach (DataColumn col in output.Columns)
                col.AllowDBNull = true;
            
            // add rows
            List<object> temp = new List<object>();
            DataRow newRow = null;
            for (int i = 1; i < input.Columns.Count; ++i)
            {
                // obtain data for new newRow
                temp.Clear();
                temp.Add(input.Columns[i].ColumnName);
                for (int j = 1; j < input.Rows.Count; ++j)
                    temp.Add(input.Rows[j][i]);
                
                // write data into new newRow
                newRow = output.NewRow();
                newRow.ItemArray = temp.ToArray();
                
                // add new newRow to output table
                output.Rows.Add(newRow);
            }
            return true;
        }

        private static object StringToObjectOfType(string str, Type type)
        {
            switch (type.ToString())
            {
                case "System.Double":
                    double result = 0.0f;
                    return double.TryParse(str, out result) ? (object)result : (object)str;
                case "System.String":
                    return str;
                default:
                    return str;
            }
        }

        public static string CreateSqlTableFromDataTable(string tableName, DataTable table)
        {
            string sql = "CREATE TABLE[" + tableName + "] (\n";
            // columns
            foreach (DataColumn column in table.Columns)
            {
                sql += "[" + column.ColumnName + "] " + SQLGetType(column) + ",\n";
            }
            sql = sql.TrimEnd(new char[] { ',', '\n' }) + "\n";
            // primary keys
            if (table.PrimaryKey.Length > 0)
            {
                sql += "CONSTRAINT[PK_" + tableName + "] PRIMARY KEY CLUSTERED(";
                foreach (DataColumn column in table.PrimaryKey)
                {
                    sql += "[" + column.ColumnName + "],";
                }
                sql = sql.TrimEnd(new char[] { ',' }) + "))\n";
            }
            else
            {
                sql += ")";
            }
            return sql;
        }
        private static string SQLGetType(DataColumn column)
        {
            return GetSqlType(column.DataType, column.MaxLength, 10, 2);
        }
        private static string GetSqlType(object type, int columnSize, int numericPrecision, int numericScale)
        {
            switch (type.ToString())
            {
                case "System.Byte[]": return "VARBINARY(MAX)";
                case "System.Boolean": return "BIT";
                case "System.DateTime": return "DATETIME";
                case "System.DateTimeOffset": return "DATETIMEOFFSET";
                case "System.Decimal":
                    if (numericPrecision != -1 && numericScale != -1)
                        return "DECIMAL(" + numericPrecision + "," + numericScale + ")";
                    else
                        return "DECIMAL";
                case "System.Double": return "FLOAT";
                case "System.Single": return "REAL";
                case "System.Int64": return "BIGINT";
                case "System.Int32": return "INT";
                case "System.Int16": return "INT";
                case "System.String":
                    return "NVARCHAR(" + ((columnSize == -1 || columnSize > 8000) ? "MAX" : columnSize.ToString()) + ")";
                case "System.Byte": return "TINYINT";
                case "System.Guid": return "UNIQUEIDENTIFIER";
                default:
                    throw new Exception(type.ToString() + " not implemented.");
            }
        }
    }
}
