using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form7 : Form
    {
        public void go_back(object obj)
        {
            Application.Run(new Form1());
        }
        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ascended nasus= new Ascended();
            vlcControl1.Visible= true;
            vlcControl1.Play(new Uri(nasus.Ascend(@"C:\Users\elcsa\Desktop\proje için\Nasus_ascend.mp4")));
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            vlcControl1.Visible= false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            vlcControl1.Visible = true;
            Ascended nasus = new Ascended();
            vlcControl1.Visible = true;
            vlcControl1.Play(new Uri(nasus.Ascend(@"C:\Users\elcsa\Desktop\proje için\nasus_dance.mp4")));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ascended nasus = new Ascended();
            vlcControl1.Visible = true;
            vlcControl1.Play(new Uri(nasus.speak(@"C:\Users\elcsa\Desktop\proje için\nasus_speak.mp4")));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(go_back);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
