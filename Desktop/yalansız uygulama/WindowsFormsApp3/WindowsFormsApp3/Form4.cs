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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            
            
            vlcControl1.Visible = true;
            Darkin aatrox = new Darkin();
            vlcControl1.Play(new Uri(aatrox.Ascend(@"C:\Users\elcsa\Desktop\proje için\Aatrox_ascension.mp4")));




        }

        private void Form4_Load(object sender, EventArgs e)
        {
            vlcControl1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            vlcControl1.Visible = true;
            Darkin aatrox = new Darkin();
            vlcControl1.Play(new Uri(aatrox.speak(@"C:\Users\elcsa\Desktop\proje için\Aatrox_speak.mp4")));


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

        private void button6_Click(object sender, EventArgs e)
        {

            vlcControl1.Visible = true;
            Darkin aatrox = new Darkin();
            vlcControl1.Play(new Uri(aatrox.speak(@"C:\Users\elcsa\Desktop\proje için\aatrox_dance.mp4")));
        }
    }
}
