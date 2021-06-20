using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form2 : Form
    {
        public string countrycode;
        public List<string> Names = new List<string>();
        public List<string> Numbers = new List<string>();
        public int pos;
        public Form2()
        {
            InitializeComponent();
            //222 126 // 383 146 //559 230 //710
        }
        int X1 = 126; int Y1 = 222;

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            //Labell.Text = $"X: {e.X}  Y: {e.Y}";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var reguest = WebRequest.Create($"https://www.countryflags.io/{countrycode}/flat/64.png");
            using (var response = reguest.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                guna2PictureBox1.Image = Bitmap.FromStream(stream);
            }
            if (pos == 0)
            {
                A4_4_2();
            }
            else if (pos == 1)
            {
                A4_3_3();
            }
            else if (pos == 2)
            {
                A4_5_1();
            }
        }
        private void A4_4_2()
        {
            int i2 = 0;
            int X2 = 391; int Y2 = 320;
            int X3 = 509; int Y3 = 571;
            var Nameee = Names.ToArray();
            var Numbs = Numbers.ToArray();
            for (int i = 0; i < 4; i++)
            {
                UserControl1 us1 = new UserControl1();
                us1.Namee.Text = Nameee[i];
                us1.Number.Text = Numbs[i];
                us1.Location = new Point(Y1 + i * 300, X1);
                Controls.Add(us1);
                i2 = i;
            }
            for (int i = 0; i < 4; i++, i2++)
            {
                UserControl1 us1 = new UserControl1();
                us1.Namee.Text = Nameee[i2];
                us1.Number.Text = Numbs[i2];
                us1.Location = new Point(X2 + i * 200, Y2);
                Controls.Add(us1);
            }
            for (int i = 0; i < 2; i++, i2++)
            {
                UserControl1 us1 = new UserControl1();
                us1.Namee.Text = Nameee[i2];
                us1.Number.Text = Numbs[i2];
                us1.Location = new Point(Y3 + i * 300, X3);
                Controls.Add(us1);
            }
            //777 772
            UserControl1 us = new UserControl1();
            us.Namee.Text = Nameee[Numbs.Length - 1];
            us.Number.Text = Numbs[Numbs.Length - 1];
            us.Location = new Point(700, 636);
            Controls.Add(us);
        }
        private void A4_3_3()
        {
            int i2 = 0;
            int X2 = 517; int Y2 = 320;
            int X3 = 509; int Y3 = 403;
            var Nameee = Names.ToArray();
            var Numbs = Numbers.ToArray();
            for (int i = 0; i < 4; i++)
            {
                UserControl1 us1 = new UserControl1();
                us1.Namee.Text = Nameee[i];
                us1.Number.Text = Numbs[i];
                us1.Location = new Point(Y1 + i * 300, X1);
                Controls.Add(us1);
                i2 = i;
            }
            for (int i = 0; i < 3; i++, i2++)
            {
                UserControl1 us1 = new UserControl1();
                us1.Namee.Text = Nameee[i2];
                us1.Number.Text = Numbs[i2];
                us1.Location = new Point(X2 + i * 200, Y2);
                Controls.Add(us1);
            }
            for (int i = 0; i < 3; i++, i2++)
            {
                UserControl1 us1 = new UserControl1();
                us1.Namee.Text = Nameee[i2];
                us1.Number.Text = Numbs[i2];
                us1.Location = new Point(Y3 + i * 300, X3);
                Controls.Add(us1);
            }
            //777 772
            UserControl1 us = new UserControl1();
            us.Namee.Text = Nameee[Numbs.Length - 1];
            us.Number.Text = Numbs[Numbs.Length - 1];
            us.Location = new Point(700, 636);
            Controls.Add(us);
        }
        private void A4_5_1()
        {
            int i2 = 0;
            int X2 = 331; int Y2 = 320;
            int X3 = 772; int Y3 = 603;
            var Nameee = Names.ToArray();
            var Numbs = Numbers.ToArray();
            for (int i = 0; i < 4; i++)
            {
                UserControl1 us1 = new UserControl1();
                us1.Namee.Text = Nameee[i];
                us1.Number.Text = Numbs[i];
                us1.Location = new Point(Y1 + i * 300, X1);
                Controls.Add(us1);
                i2 = i;
            }
            for (int i = 0; i < 5; i++, i2++)
            {
                UserControl1 us1 = new UserControl1();
                us1.Namee.Text = Nameee[i2];
                us1.Number.Text = Numbs[i2];
                us1.Location = new Point(X2 + i * 200, Y2);
                Controls.Add(us1);
            }
            for (int i = 0; i < 1; i++, i2++)
            {
                UserControl1 us1 = new UserControl1();
                us1.Namee.Text = Nameee[i2];
                us1.Number.Text = Numbs[i2];
                us1.Location = new Point(700, 476);
                Controls.Add(us1);
            }
            //777 772
            UserControl1 us = new UserControl1();
            us.Namee.Text = Nameee[Numbs.Length - 1];
            us.Number.Text = Numbs[Numbs.Length - 1];
            us.Location = new Point(700, 636);
            Controls.Add(us);
        }
    }
}
