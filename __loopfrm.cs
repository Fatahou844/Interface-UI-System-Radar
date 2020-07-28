using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_RADAR
{

    public partial class __loopfrm : Form
    {
        Radar _radar;
        Timer t = new Timer();
        Random rnd = new Random();
        public __loopfrm()
        {
            InitializeComponent();
            // internal item update timer
            pictureBox1.BackColor = Color.Transparent;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel2.BackColor = Color.Transparent;
            flowLayoutPanel3.BackColor = Color.Transparent;
            flowLayoutPanel4.BackColor = Color.Transparent;
            //pictureBox5.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            t.Interval = 60;
            t.Tick += new EventHandler(t_Tick);
            t.Enabled = true;
        }
        RadarItem item1 = new SquareRadarItem(1, 8, 70, 14);
        RadarItem item2 = new CircleRadarItem(2, 8, -45, 5);
        RadarItem item3 = new TriangleRadarItem(3, 8, 30, 12);
        

        public object pictureBox5 { get; }

        int GetDelta()
        {
            int i = rnd.Next(0, 2);
            if (i == 0)
                i--;
            return i;
        }

        void t_Tick(object sender, EventArgs e)
        {
            // select which of the three items to update
            int i = rnd.Next(1, 4);

            switch (i)
            {
                case 1:
                    item1.Azimuth += GetDelta();
                    item1.Range += GetDelta();
                    _radar.AddItem(item1);
                    break;
                case 2:
                    item2.Azimuth += GetDelta();
                    item2.Range += GetDelta();
                    _radar.AddItem(item2);
                    break;
                case 3:
                    item3.Azimuth += GetDelta();
                    item3.Range += GetDelta();
                    _radar.AddItem(item3);
                    break;
                

            }
        }

        private void __loopfrm_Load(object sender, EventArgs e)
        {
            _radar = new Radar(pictureBox1.Width);
            pictureBox1.Image = _radar.Image;
            _radar.ImageUpdate += new ImageUpdateHandler(_radar_ImageUpdate);
            _radar.DrawScanInterval = 60;
            _radar.DrawScanLine = true;
        }

        void _radar_ImageUpdate(object sender, ImageUpdateEventArgs e)
        {
            // this event is important to catch!
            pictureBox1.Image = e.Image;
        }

     

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconDimin.Visible = false;
            iconMaxim.Visible = true;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconMaxim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconDimin.Visible = true;
            iconMaxim.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_3(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
