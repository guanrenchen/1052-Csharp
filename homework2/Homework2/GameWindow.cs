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
    public partial class GameWindow : Form
    {
        private Button[] button;
        private Splash[] splash;
        private const int GAME_HEIGHT = 400, GAME_WIDTH = 800;
        private const int X = 7, Y = 7;
        private const int TIME_LIMIT = 30, HIT_CHANCE = 30, SCORE_GAIN = 1, HIT_GAIN = 2;
        
        private int time;

        public GameWindow()
        {
            InitializeComponent();
        }

        public void SetPos(Control item, float x, float y, float w, float h)
        {
            item.SetBounds((int)(x*ClientSize.Width), (int)(y*ClientSize.Height), (int)(w* ClientSize.Width), (int)(h*ClientSize.Height));
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            //set game area size
            ClientSize = new Size(GAME_WIDTH, GAME_HEIGHT);

            //set element position
            SetPos(label_HitRemain, 0.65f, 0.20f, 0.20f, 0.05f);
            SetPos(label_Score    , 0.65f, 0.40f, 0.20f, 0.05f);
            SetPos(label_Timer    , 0.65f, 0.60f, 0.20f, 0.05f);
            SetPos(button_Start   , 0.60f, 0.80f, 0.15f, 0.10f);
            SetPos(button_Exit    , 0.75f, 0.80f, 0.15f, 0.10f);

            //hide button prototype
            button1.Hide();
            
            button = new Button[X*Y];
            splash = new Splash[X*Y];
            int index, btnWidth = ClientSize.Height/X, btnHeight = ClientSize.Height/Y;
            for(int i=0; i<Y; ++i)
            {
                for(int j=0; j<X; ++j)
                {
                    index = j + i * X;

                    button[index] = new Button();
                    button[index].SetBounds(j*btnWidth, i*btnHeight, btnWidth, btnHeight);
                    button[index].Click += button1_Click;
                    Controls.Add(button[index]);

                    splash[index] = new Splash(ref button[index], j, i);
                }
            }
            
            Splash.Initialize(ref splash, X, Y, SCORE_GAIN, HIT_GAIN);

            GameReset();
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            button_Start.Enabled = false;
            for (int i = 0; i < button.Length; ++i)
                button[i].Enabled = true;

            timer_Game.Interval = 1000;
            timer_Game.Enabled = true;
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer_Game_Tick(object sender, EventArgs e)
        {
            if(--time <= 0)
                GameOver();
            else
                UpdateStatus();
        }
        

        private void GameOver()
        {
            timer_Game.Enabled = false;
            for (int i=0; i<X*Y; ++i)
                button[i].Enabled = false;
            UpdateStatus();
            TopScore dialog = new TopScore(this, Splash.score);
            dialog.Show();
        }

        public void GameReset()
        {
            for (int i = 0; i < button.Length; ++i)
                button[i].Enabled = false;

            Random random = new Random();
            for (int i = 0; i < splash.Length; ++i)
            {
                splash[i].Reset();
                for (int j = 0, hits = random.Next(Splash.TOTAL_STAGE); j < hits; ++j)
                    splash[random.Next(i)].Hit();
            }
            
            Splash.score = 0;
            Splash.hit = HIT_CHANCE;
            time = TIME_LIMIT;
            UpdateStatus();

            button_Start.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            splash[Array.IndexOf(button, (Button)sender)].Hit();
            if (--Splash.hit <= 0)
                GameOver();
            else
                UpdateStatus();
        }

        private void UpdateStatus()
        {
            label_Score.Text = "Score : " + Splash.score;
            label_HitRemain.Text = "Remain Hits : " + Splash.hit;
            label_Timer.Text = "Time : " + time;
        }
    }
}
