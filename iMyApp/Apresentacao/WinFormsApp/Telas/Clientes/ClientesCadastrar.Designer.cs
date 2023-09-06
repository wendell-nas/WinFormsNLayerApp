namespace WinFormsApp.Telas.Clientes
{
    partial class ClientesCadastrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesCadastrar));
            label1 = new Label();
            label2 = new Label();
            dtpNascimento = new DateTimePicker();
            txtNomeConpleto = new TextBox();
            txtCpf = new TextBox();
            label3 = new Label();
            txtTelefone = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            cmbBolsaEstudos = new ComboBox();
            vhkResponsável = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 27);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome Completo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 89);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 1;
            label2.Text = "Data de Nascimento";
            // 
            // dtpNascimento
            // 
            dtpNascimento.Checked = false;
            dtpNascimento.Format = DateTimePickerFormat.Short;
            dtpNascimento.Location = new Point(146, 107);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new Size(114, 23);
            dtpNascimento.TabIndex = 2;
            // 
            // txtNomeConpleto
            // 
            txtNomeConpleto.Location = new Point(146, 45);
            txtNomeConpleto.Name = "txtNomeConpleto";
            txtNomeConpleto.Size = new Size(245, 23);
            txtNomeConpleto.TabIndex = 3;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(407, 45);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(144, 23);
            txtCpf.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(407, 27);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 4;
            label3.Text = "Cpf";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(146, 164);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(155, 23);
            txtTelefone.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(146, 146);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 6;
            label4.Text = "Telefone";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(317, 164);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(234, 23);
            txtEmail.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(317, 146);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 8;
            label5.Text = "Email";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.add_friend;
            pictureBox1.Location = new Point(21, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(146, 202);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 10;
            label6.Text = "Bolsa de Estudos";
            // 
            // cmbBolsaEstudos
            // 
            cmbBolsaEstudos.FormattingEnabled = true;
            cmbBolsaEstudos.Location = new Point(146, 220);
            cmbBolsaEstudos.Name = "cmbBolsaEstudos";
            cmbBolsaEstudos.Size = new Size(155, 23);
            cmbBolsaEstudos.TabIndex = 11;
            // 
            // vhkResponsável
            // 
            vhkResponsável.AutoSize = true;
            vhkResponsável.Location = new Point(146, 258);
            vhkResponsável.Name = "vhkResponsável";
            vhkResponsável.Size = new Size(180, 19);
            vhkResponsável.TabIndex = 12;
            vhkResponsável.Text = "Cliente é o responsável legal?";
            vhkResponsável.UseVisualStyleBackColor = true;
            // 
            // ClienteCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(567, 356);
            Controls.Add(vhkResponsável);
            Controls.Add(cmbBolsaEstudos);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(txtTelefone);
            Controls.Add(label4);
            Controls.Add(txtCpf);
            Controls.Add(label3);
            Controls.Add(txtNomeConpleto);
            Controls.Add(dtpNascimento);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ClienteCadastrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Cliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dtpNascimento;
        private TextBox txtNomeConpleto;
        private TextBox txtCpf;
        private Label label3;
        private TextBox txtTelefone;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label6;
        private ComboBox cmbBolsaEstudos;
        private CheckBox vhkResponsável;
    }
}