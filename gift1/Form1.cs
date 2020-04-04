using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gift1
{
    public partial class Form1 : Form
    {
        bool d = false;
        Point start_position = new Point(0, 0);

        Timer tback = new Timer();
        Timer trocket = new Timer();
        Timer tball = new Timer();
        public Form1()
        {
            InitializeComponent();
            BackColor = Color.FromArgb(253, 253, 253);
            tback.Tick += new EventHandler(re);
            tball.Tick += new EventHandler(bal);
            trocket.Tick += new EventHandler(roc);
            def();

        }

        void def()
        {
            linerrockt.Height = 7;
            linerrockt.Width = 910;
            linerrockt.Left = 20;//location 307, 275

            //picture 1


            label2.Top = 10;//location 399, 234
            label2.Visible = false;
            label2.BringToFront();



            pictureBox1.Top = 600;//location 399, 234
            pictureBox1.Visible = false;
            pictureBox1.BringToFront();

            //picture 2 49, -3 size =100
            rocket.Height = 400;
            rocket.Top = 600;
            rocket.Visible = false;
            pictureBox1.ImageLocation = @"C:\Users\nezar\source\repos\gift1\gift1\images\th2DNELSZX.jpg";
            rocket.ImageLocation = @"C:\Users\nezar\source\repos\gift1\gift1\images\th2DNELSZX.jpg";
            anim.HideSync(label1);


            //timer interval
            //timer interval
            tback.Interval = 10;
            tball.Interval = 20;
            trocket.Interval = 30;
            tback.Start();

        }
        //initial
        int wd = 410;
        void re(object sender, EventArgs e)
        {
            linerrockt.Width += wd;
            if (linerrockt.Width < 10)
            {
                wd = 10;
            }
            if (linerrockt.Width > 50)
            {
                tback.Stop();
                trocket.Start();
            }
            anim.ShowSync(label2);
        }

        int dawn = 1, lt = 5, rt = -1;
        void bal(object sender, EventArgs e)
        {
            pictureBox1.Top += dawn;
            label2.Top += dawn;
            if (pictureBox1.Top < 100)
            {
                pictureBox1.Visible = true;
                label2.Visible = true;

                dawn = 325;
            }
            if (pictureBox1.Top > 510)
            {
                tball.Interval = 170;
                rocket.ImageLocation = @"C:\Users\nezar\source\repos\gift1\gift1\images\5.jpg";
                rocket.ImageLocation = @"C:\Users\nezar\source\repos\gift1\gift1\images\5.jpg";
                pictureBox1.Visible = false;
                label1.Visible = false;
                dawn = 5;
                rocket.Top -= dawn;
                if (rocket.Top < -95)
                {
                    linerrockt.Width -= lt;
                    linerrockt.Left += lt;
                    if (linerrockt.Left > 310)
                    {
                        dawn = 1;
                        tball.Stop();
                        //def();
                        this.Hide();
                        Form2 f1 = new Form2();

                        f1.ShowDialog();


                      



                    }
                }

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void roc(object sender, EventArgs e)
        {
            rocket.Top += rt;
            if (rocket.Top > 280)
            {
                rocket.Visible = true;
                rt = -1;
            }
            if (rocket.Top < 170)
            {
                rt = -7;
                trocket.Stop();
                tball.Start();
            }
        }



        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
