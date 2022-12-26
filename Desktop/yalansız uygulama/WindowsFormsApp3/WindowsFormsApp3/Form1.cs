using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace WindowsFormsApp3
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        Form2 form2 = new Form2();
        Form3 form3 = new Form3();
        Form4 form4 = new Form4();
        Form5 Form5form5 = new Form5();
        Form6 form6= new Form6();
        Form7 form7= new Form7();

        private void Form1_Load(object sender, EventArgs e)
        {
            int w=Screen.PrimaryScreen.Bounds.Width;
            int h=Screen.PrimaryScreen.Bounds.Height;
            this.Location= new Point(0,0);
            this.Size= new Size(w,h);

        }
        public void form_yi(object obj)
        {
            Application.Run(new Form6());
        }
        public void openmdi(object obj)
        {
            Application.Run(new Form2());
        }
        public void form_azir(object obj)
        {
            Application.Run(new Form3());

        }
        public void form_aatrox(object obj)
        {
            Application.Run(new Form4());
        }
        public void form_varus(object obj)
        {
            Application.Run(new Form5());
        }
        public void form_nasus(object obj)
        {
            Application.Run(new Form7());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void vlcControl1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          



            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(openmdi);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(form_azir);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(form_aatrox);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(form_varus);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            Thread th;
            this.Close();
            th = new Thread(form_yi);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(form_nasus);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }
    }
}
