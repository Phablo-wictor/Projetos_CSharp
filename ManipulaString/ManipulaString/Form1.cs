using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ManipulaString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string nome = "Phablo Wictor";

            // int indice = nome.IndexOf("o",6);

            int indice = nome.LastIndexOf('o');

            label1.Text = "Indice: " + indice;
        }
    }
}
