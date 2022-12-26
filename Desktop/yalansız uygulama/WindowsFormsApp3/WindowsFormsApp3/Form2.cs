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

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void openmdi(object obj)
        {
            Application.Run(new Form1());
        }
        private void vlcControl1_Click(object sender, EventArgs e)
        {
           

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vlcControl1.Visible= true;
            Runeterrarian talon = new Runeterrarian();
           

            vlcControl1.Play(new Uri(talon.dance(@"C:\Users\elcsa\Desktop\proje için\talon_dance.mp4")));




        }

        private void Form2_Load(object sender, EventArgs e)
        {
            vlcControl1.Visible = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(openmdi);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            vlcControl1.Visible=true;
            Runeterrarian talon=new Runeterrarian();
            vlcControl1.Play(new Uri(talon.dance(@"C:\Users\elcsa\Desktop\proje için\talon_speak.mp4")));
        }
    }
}
