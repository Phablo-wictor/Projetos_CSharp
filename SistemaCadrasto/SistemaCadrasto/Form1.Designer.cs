namespace SistemaCadrasto
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.Txtdata = new System.Windows.Forms.DateTimePicker();
            this.ComboCE = new System.Windows.Forms.ComboBox();
            this.TxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.CheckCasa = new System.Windows.Forms.CheckBox();
            this.checkVeiculo = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radionOutros = new System.Windows.Forms.RadioButton();
            this.radionM = new System.Windows.Forms.RadioButton();
            this.radionF = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lista = new System.Windows.Forms.ListBox();
            this.btnCasdastra = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de Nacimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado Civil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone";
            // 
            // TxtNome
            // 
            this.TxtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(244, 21);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(442, 32);
            this.TxtNome.TabIndex = 4;
            // 
            // Txtdata
            // 
            this.Txtdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtdata.Location = new System.Drawing.Point(244, 59);
            this.Txtdata.Name = "Txtdata";
            this.Txtdata.Size = new System.Drawing.Size(442, 32);
            this.Txtdata.TabIndex = 5;
            // 
            // ComboCE
            // 
            this.ComboCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboCE.FormattingEnabled = true;
            this.ComboCE.Location = new System.Drawing.Point(244, 100);
            this.ComboCE.Name = "ComboCE";
            this.ComboCE.Size = new System.Drawing.Size(297, 33);
            this.ComboCE.TabIndex = 6;
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefone.Location = new System.Drawing.Point(244, 141);
            this.TxtTelefone.Mask = "(00) 00000-0000";
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(297, 32);
            this.TxtTelefone.TabIndex = 7;
            // 
            // CheckCasa
            // 
            this.CheckCasa.AutoSize = true;
            this.CheckCasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckCasa.Location = new System.Drawing.Point(244, 197);
            this.CheckCasa.Name = "CheckCasa";
            this.CheckCasa.Size = new System.Drawing.Size(161, 24);
            this.CheckCasa.TabIndex = 8;
            this.CheckCasa.Text = "Possi Casa Própria";
            this.CheckCasa.UseVisualStyleBackColor = true;
            this.CheckCasa.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkVeiculo
            // 
            this.checkVeiculo.AutoSize = true;
            this.checkVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkVeiculo.Location = new System.Drawing.Point(244, 220);
            this.checkVeiculo.Name = "checkVeiculo";
            this.checkVeiculo.Size = new System.Drawing.Size(131, 24);
            this.checkVeiculo.TabIndex = 9;
            this.checkVeiculo.Text = "Possui Véiculo";
            this.checkVeiculo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radionOutros);
            this.groupBox1.Controls.Add(this.radionM);
            this.groupBox1.Controls.Add(this.radionF);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(244, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 92);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // radionOutros
            // 
            this.radionOutros.AutoSize = true;
            this.radionOutros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radionOutros.Location = new System.Drawing.Point(3, 68);
            this.radionOutros.Name = "radionOutros";
            this.radionOutros.Size = new System.Drawing.Size(56, 17);
            this.radionOutros.TabIndex = 3;
            this.radionOutros.TabStop = true;
            this.radionOutros.Text = "Outros";
            this.radionOutros.UseVisualStyleBackColor = true;
            // 
            // radionM
            // 
            this.radionM.AutoSize = true;
            this.radionM.Checked = true;
            this.radionM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radionM.Location = new System.Drawing.Point(3, 16);
            this.radionM.Name = "radionM";
            this.radionM.Size = new System.Drawing.Size(73, 17);
            this.radionM.TabIndex = 2;
            this.radionM.TabStop = true;
            this.radionM.Text = "Masculino";
            this.radionM.UseVisualStyleBackColor = true;
            // 
            // radionF
            // 
            this.radionF.AutoSize = true;
            this.radionF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radionF.Location = new System.Drawing.Point(3, 43);
            this.radionF.Name = "radionF";
            this.radionF.Size = new System.Drawing.Size(70, 17);
            this.radionF.TabIndex = 1;
            this.radionF.TabStop = true;
            this.radionF.Text = "Feminino ";
            this.radionF.UseVisualStyleBackColor = true;
            this.radionF.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Masculino";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // lista
            // 
            this.lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 20;
            this.lista.Location = new System.Drawing.Point(12, 416);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(769, 104);
            this.lista.TabIndex = 11;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.TxtNome_SelectedIndexChanged);
            this.lista.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lista_MouseDoubleClick);
            // 
            // btnCasdastra
            // 
            this.btnCasdastra.Location = new System.Drawing.Point(17, 344);
            this.btnCasdastra.Name = "btnCasdastra";
            this.btnCasdastra.Size = new System.Drawing.Size(194, 66);
            this.btnCasdastra.TabIndex = 12;
            this.btnCasdastra.Text = "Casdastra/Altera";
            this.btnCasdastra.UseVisualStyleBackColor = true;
            this.btnCasdastra.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(292, 344);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(194, 66);
            this.BtnExcluir.TabIndex = 13;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(567, 344);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(194, 66);
            this.BtnLimpar.TabIndex = 14;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 532);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.btnCasdastra);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkVeiculo);
            this.Controls.Add(this.CheckCasa);
            this.Controls.Add(this.TxtTelefone);
            this.Controls.Add(this.ComboCE);
            this.Controls.Add(this.Txtdata);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Cadastro de Usuario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.DateTimePicker Txtdata;
        private System.Windows.Forms.ComboBox ComboCE;
        private System.Windows.Forms.MaskedTextBox TxtTelefone;
        private System.Windows.Forms.CheckBox CheckCasa;
        private System.Windows.Forms.CheckBox checkVeiculo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radionF;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radionOutros;
        private System.Windows.Forms.RadioButton radionM;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button btnCasdastra;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnLimpar;
    }
}

