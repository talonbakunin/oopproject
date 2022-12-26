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
    public partial class Form3 : Form
    {
        public void go_back(object obj)
        {
            Application.Run(new Form1());
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(go_back);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            vlcControl1.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ascended azir= new Ascended();
            vlcControl1.Visible= true;
            vlcControl1.Video.AspectRatio = "16.9";

            
            
            
            
            
            vlcControl1.Play(new Uri(azir.Ascend(@"C:\Users\elcsa\Desktop\proje için\Azir Ascension.mp4")));
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            vlcControl1.Visible = true;
            Ascended azir = new Ascended();
            vlcControl1.Play(new Uri(azir.speak(@"C:\Users\elcsa\Desktop\proje için\Azir_speak.mp4")));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            vlcControl1.Visible = true;
            Ascended azir = new Ascended();
            vlcControl1.Play(new Uri(@"C:\Users\elcsa\Desktop\proje için\azir_dance.mp4"));
        }
    }
}
