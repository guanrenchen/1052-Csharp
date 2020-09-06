using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework2
{
    public partial class TopScore : Form
    {
        private const int TOP_PLAYER_NUM = 5;
        private const string FILE_PATH = "./topScore.txt";

        private int scoreChallenger;
        private GameWindow gameWindow;
        private Label[] label_TopScore;
        private TopPlayer[] topPlayers;

        class TopPlayer
        {
            public TopPlayer(string player, int score)
            {
                this.player = player;
                this.score = score;
            }

            public string player { get; }
            public int score { get; }
        }

        public TopScore(GameWindow gameWindow, int scoreChallenger)
        {
            InitializeComponent();

            this.gameWindow = gameWindow;
            this.scoreChallenger = scoreChallenger;

            CreateLabels();
            WriteFileToArray(FILE_PATH);
            WriteArrayToLabel();
            
            if (scoreChallenger < topPlayers.Last().score)
            {
                textBox_Challenger.Enabled = false;
                button_Save.Enabled = false;
            }
            else
            {
                textBox_Challenger.Enabled = true;
                button_Save.Enabled = true;
            }

            label_Challenger.Text = "Your Score  :  " + scoreChallenger;

            SetPos(label_Challenger, 0.30f, 0.60f, 1.00f, 0.10f);
            SetPos(textBox_Challenger, 0.00f, 0.70f, 1.00f, 0.10f);
            SetPos(button_Exit, 0.50f, 0.85f, 0.50f, 0.15f);
            SetPos(button_Save, 0.00f, 0.85f, 0.50f, 0.15f);
        }

        public void SetPos(Control item, float x, float y, float w, float h)
        {
            item.SetBounds((int)(x * ClientSize.Width), (int)(y * ClientSize.Height), (int)(w * ClientSize.Width), (int)(h * ClientSize.Height));
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            button_Save.Enabled = false;
            textBox_Challenger.Enabled = false;

            Array.Resize(ref topPlayers, topPlayers.Length + 1);
            topPlayers[topPlayers.Length-1] = new TopPlayer(textBox_Challenger.Text, scoreChallenger);
            Array.Sort(topPlayers, (a, b) => b.score.CompareTo(a.score));
            WriteArrayToLabel();
            WriteArrayToFile(FILE_PATH);
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            gameWindow.GameReset();
            Close();
        }

        private void WriteFileToArray(string path)
        {
            string[] topList = System.IO.File.ReadAllLines(path);
            topPlayers = new TopPlayer[TOP_PLAYER_NUM];
            for (int i = 0; i < TOP_PLAYER_NUM; ++i)
                topPlayers[i] = new TopPlayer(topList[2*i], Convert.ToInt32(topList[2*i+1]));
        }

        private void CreateLabels()
        {
            label_TopScore = new Label[TOP_PLAYER_NUM * 2];
            for (int i = 0; i < label_TopScore.Length; ++i)
            {
                label_TopScore[i] = new Label();
                label_TopScore[i].TextAlign = ContentAlignment.MiddleCenter;
                SetPos(label_TopScore[i], 0.20f + (i % 2) * 0.30f, 0.05f + (i / 2) * 0.10f, 0.30f, 0.10f);
                Controls.Add(label_TopScore[i]);
            }
        }

        private void WriteArrayToLabel()
        {
            Array.Sort(topPlayers, (a, b) => b.score.CompareTo(a.score));
            for (int i=0; i<TOP_PLAYER_NUM; ++i)
            {
                label_TopScore[2*i].Text = topPlayers[i].player;
                label_TopScore[2*i+1].Text = topPlayers[i].score.ToString();
            }
        }

        private void WriteArrayToFile(string path)
        {
            string[] str = new string[TOP_PLAYER_NUM * 2];
            for(int i=0; i<TOP_PLAYER_NUM; ++i)
            {
                str[2 * i] = topPlayers[i].player;
                str[2 * i + 1] = topPlayers[i].score.ToString();
            }
            System.IO.File.WriteAllLines(path, str);
        }

        private void TopScore_Load(object sender, EventArgs e)
        {

        }
    }
}
