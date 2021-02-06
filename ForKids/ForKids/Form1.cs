using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForKids
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int x = 40, y = 100, i = 0, satir = 0;
        Random rnd = new Random();
        int rast;
        PictureBox picture = new PictureBox();
        private void button1_Click(object sender, EventArgs e)
        {
            if (i != 0)
            {
                for (int s = rast; s>=1; s--)
                {
                    this.Controls.Remove(this.Controls[picture + s.ToString()]);
                    x = 40;
                    y = 100;
                    satir = 0;
                }
                for( int k=i; k>=1; k-- )
                {
                    this.Controls.Remove(this.Controls[picture + k.ToString()]);
                    x = 100;
                }
                rast = rnd.Next(1, 11);
                label1.Text = rast.ToString();
                for (int k = 1; k <= rast; k++)
                {
                    PictureBox picture = new PictureBox();
                    this.Controls.Add(picture);
                    picture.Name = picture + k.ToString();
                    picture.SetBounds(x, y, 50, 50);
                    picture.Image = Image.FromFile("unnamed.png");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    x = x + 50;
                    satir++;
                    if (satir % 3 == 0)
                    {
                        y = y + 50;
                        satir = 0;
                        x = 40;
                    }
                }

                }
            else
            {
                rast = rnd.Next(1, 11);
                label1.Text = rast.ToString();
                for (int k=1; k<=rast; k++)
                {
                    PictureBox picture = new PictureBox();
                    this.Controls.Add(picture);
                    picture.Name = picture + k.ToString();
                    picture.SetBounds(x, y, 50, 50);
                    picture.Image = Image.FromFile("unnamed.png");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    x = x + 50;
                    satir++;
                    if(satir %3 ==0)
                    {
                        y = y + 50;
                        satir = 0;
                        x = 40;
                        satir = 0;
                    }
                }
            }
            i++;

            }
                
        }


    }

