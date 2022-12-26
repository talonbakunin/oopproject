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
    public partial class Form5 : Form
    {
        public void go_back(object obj)
        {
            Application.Run(new Form1());
        }
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            vlcControl1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Darkin varus=new Darkin();  
            vlcControl1.Visible=true;
            vlcControl1.Play(new Uri(@"C:\Users\elcsa\Desktop\proje için\varus_ascend.mp4"));



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
            Darkin varus = new Darkin();
            vlcControl1.Visible = true;
            vlcControl1.Play(new Uri(@"C:\Users\elcsa\Desktop\proje için\Varus_speak.mp4"));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Darkin varus = new Darkin();
            vlcControl1.Visible = true;
            vlcControl1.Play(new Uri(@"C:\Users\elcsa\Desktop\proje için\varus_dance.mp4"));
        }
    }
}
