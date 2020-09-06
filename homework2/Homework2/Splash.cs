using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

public class Splash
{
    public const int TOTAL_STAGE = 4, TOTAL_TYPE = 3;

    public static int score { get; set; }
    public static int hit { get; set; }

    private static int x_bound, y_bound, scoreGain, hitGain;
    private static Random random;
    private static Splash[] splash;
    private static Image[] img;
    
    private Button button;
    private int x, y, stage, type;

	public Splash(ref Button button, int x, int y)
	{
        this.button = button;
        this.x = x;
        this.y = y;
        Reset();
	}

    public static void Initialize(ref Splash[] splash, int x_bound, int y_bound, int scoreGain, int hitGain)
    {
        Splash.splash = splash;
        Splash.x_bound = x_bound;
        Splash.y_bound = y_bound;
        Splash.scoreGain = scoreGain;
        Splash.hitGain = hitGain;
        Splash.random = new Random();

        img = new Image[TOTAL_TYPE];
        img[0] = Image.FromFile("./pics/red.png");
        img[1] = Image.FromFile("./pics/green.png");
        img[2] = Image.FromFile("./pics/blue.png");
    }

    private void setImage()
    {
        if (stage>0 && stage<=TOTAL_STAGE && type>=0 && type<TOTAL_TYPE)
            button.Image = new Bitmap(img[type], new Size(button.Width*stage/(TOTAL_STAGE+1), button.Height*stage/(TOTAL_STAGE+1)));
        else
            button.Image = null;
    }

    private void Hit(int index_x, int index_y)
    {
        if (index_x < 0 || index_x >= x_bound || index_y < 0 || index_y >= y_bound) return;
        splash[index_x + index_y * y_bound].Hit();
    }

    public void Hit()
    {
        switch (stage)
        {
            case 0:
                ++stage;
                type = random.Next(TOTAL_TYPE);
                setImage();
                break;
            case TOTAL_STAGE:
                Burst();
                break;
            default:
                ++stage;
                setImage();
                break;
        }
    }

    private void Burst()
    {
        hit += hitGain;
        switch (type)
        {
            case 0:
                Reset();
                score += scoreGain * 2;
                break;
            case 1:
                Reset();
                score += scoreGain;
                Hit(x+1, y); Hit(x-1, y); Hit(x, y+1); Hit(x, y-1);
                break;
            case 2:
                Reset();
                score += scoreGain;
                Hit(x+1, y+1); Hit(x+1, y-1); Hit(x-1, y+1); Hit(x-1, y-1);
                break;
            default:
                Reset();
                break;
        }
    }

    public void Reset()
    {
        stage = 0;
        type = TOTAL_TYPE;
        setImage();
    }
}
