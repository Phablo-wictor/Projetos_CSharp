using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaCadrasto
{
    public partial class Form1 : Form
    {
        List<Pessoa> pessoas;

        public Form1()
        {
            InitializeComponent();

            pessoas =new List<Pessoa>();

            ComboCE.Items.Add("Casado");
            ComboCE.Items.Add("Solteiro");
            ComboCE.Items.Add("Divociado");
            ComboCE.Items.Add("Viuvo");

            ComboCE.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TxtNome_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int indice = lista.SelectedIndex;
            pessoas.RemoveAt(indice);
            Listar();

        }

        private void button3_Click(object sender, EventArgs e)
        {


            TxtNome.Text = "";
            ComboCE.SelectedIndex = 0;
            TxtTelefone.Text = "";
            CheckCasa.Checked = false;
            checkVeiculo.Checked = false;
            radionM.Checked = true;
            radionF.Checked = false;
            radionOutros.Checked = false;
            lista.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int index = -1;

            foreach (Pessoa pessoa in pessoas)
            {
                if (pessoa.Nome == TxtNome.Text)
                {
                    index = pessoas.IndexOf(pessoa); 

                }
            }

            if (TxtNome.Text == "")
            {
                MessageBox.Show("Preencha o compo Nome!");
                TxtNome.Focus();
                return;
            }

            if (TxtTelefone.Text == "(  )      -")
            {
                MessageBox.Show("Preencha o Campo Telefone");
                TxtTelefone.Focus();
                return;

            }

            char sexo;
            
            if (radionM.Checked)
            {
                sexo = 'M';
            }else if (radionF.Checked)
            {
                sexo = 'F';
            }
            else
            {
                sexo = 'O';
            }

            Pessoa p = new Pessoa();
            p.Nome = TxtNome.Text;
            p.Telefone = TxtTelefone.Text;
            p.DataNacimento = Txtdata.Text;
            p.EstadoCivil = ComboCE.SelectedItem.ToString();
            p.CasaPropria = CheckCasa.Checked;
            p.Veiculo = checkVeiculo.Checked;
            p.Sexo = sexo;

            if (index < 0)
            {
                pessoas.Add(p);
            }
            else
            {
                pessoas[index] = p;
            }

            button3_Click(BtnLimpar, EventArgs.Empty);

            Listar();

        }

        private void Listar()
        {
            lista.Items.Clear();

            foreach (Pessoa p in pessoas)
            {
                lista.Items.Add(p.Nome);

            }
        }

        private void lista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int indice = lista.SelectedIndex;
            Pessoa p = pessoas[indice];

            TxtNome.Text         = p.Nome;
            Txtdata.Text         = p.DataNacimento;
            ComboCE.SelectedItem = p.EstadoCivil;
            TxtTelefone.Text     = p.Telefone;  
            CheckCasa.Checked    = p.CasaPropria;
            checkVeiculo.Checked = p.Veiculo;
            
            switch (p.Sexo)
            {
                case 'M':
                    radionM.Checked = true;
                    break;
                case 'F':
                    radionF.Checked = true;
                    break;
                default:
                    radionOutros.Checked = true;
                    break;
            }
        }
    }
}
