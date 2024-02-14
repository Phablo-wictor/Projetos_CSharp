using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Teste1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text = "Minha Aplicação";
            this.ShowIcon = false;
            this.Size = new Size(800, 400);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(800, 400);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Size = new Size(400, 500);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.MediumBlue;
        }
    }
}
