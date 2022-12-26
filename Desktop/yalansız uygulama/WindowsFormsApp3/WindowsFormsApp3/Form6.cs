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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        public void go_back(object obj)
        {
            Application.Run(new Form1());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(go_back);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            vlcControl1.Visible = true;
            Runeterrarian yi = new Runeterrarian();
            vlcControl1.Play(new Uri(yi.speak(@"C:\Users\elcsa\Desktop\proje için\yi_speak.mp4")));
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            vlcControl1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            vlcControl1.Visible = true;
            Runeterrarian yi = new Runeterrarian();
            vlcControl1.Play(new Uri(yi.speak(@"C:\Users\elcsa\Desktop\proje için\yi_dance.mp4")));
        }
    }
}
