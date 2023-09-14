namespace WinFormsApp.Telas.Cargos
{
    partial class CargoView
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
            txtCargo = new TextBox();
            chkStatus = new CheckBox();
            btnSalvar = new Button();
            groupBoxCargo = new GroupBox();
            btnNovoCargo = new Button();
            btnRecarregar = new Button();
            gvCargos = new DataGridView();
            label1 = new Label();
            groupBoxCargo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvCargos).BeginInit();
            SuspendLayout();
            // 
            // txtCargo
            // 
            txtCargo.ImeMode = ImeMode.NoControl;
            txtCargo.Location = new Point(15, 33);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(408, 23);
            txtCargo.TabIndex = 0;
            txtCargo.TextAlign = HorizontalAlignment.Center;
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.Location = new Point(463, 35);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(89, 19);
            chkStatus.TabIndex = 1;
            chkStatus.Text = "Cargo Ativo";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.White;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Location = new Point(576, 30);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(90, 26);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // groupBoxCargo
            // 
            groupBoxCargo.BackColor = SystemColors.ActiveCaption;
            groupBoxCargo.Controls.Add(txtCargo);
            groupBoxCargo.Controls.Add(btnSalvar);
            groupBoxCargo.Controls.Add(chkStatus);
            groupBoxCargo.FlatStyle = FlatStyle.System;
            groupBoxCargo.Location = new Point(12, 57);
            groupBoxCargo.Name = "groupBoxCargo";
            groupBoxCargo.Size = new Size(672, 78);
            groupBoxCargo.TabIndex = 3;
            groupBoxCargo.TabStop = false;
            groupBoxCargo.Text = "Novo Cargo";
            // 
            // btnNovoCargo
            // 
            btnNovoCargo.BackColor = Color.White;
            btnNovoCargo.FlatStyle = FlatStyle.Popup;
            btnNovoCargo.Location = new Point(12, 12);
            btnNovoCargo.Name = "btnNovoCargo";
            btnNovoCargo.Size = new Size(97, 28);
            btnNovoCargo.TabIndex = 4;
            btnNovoCargo.Text = "Novo Cargo";
            btnNovoCargo.UseVisualStyleBackColor = false;
            btnNovoCargo.Click += btnNovoCargo_Click;
            // 
            // btnRecarregar
            // 
            btnRecarregar.BackColor = Color.White;
            btnRecarregar.FlatStyle = FlatStyle.Flat;
            btnRecarregar.Location = new Point(588, 141);
            btnRecarregar.Name = "btnRecarregar";
            btnRecarregar.Size = new Size(90, 27);
            btnRecarregar.TabIndex = 5;
            btnRecarregar.Text = "Recarregar";
            btnRecarregar.UseVisualStyleBackColor = false;
            // 
            // gvCargos
            // 
            gvCargos.BackgroundColor = SystemColors.GradientActiveCaption;
            gvCargos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvCargos.Enabled = false;
            gvCargos.Location = new Point(6, 174);
            gvCargos.Name = "gvCargos";
            gvCargos.RowTemplate.Height = 25;
            gvCargos.Size = new Size(678, 315);
            gvCargos.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 156);
            label1.Name = "label1";
            label1.Size = new Size(149, 15);
            label1.TabIndex = 7;
            label1.Text = "Todos os cargos (GridView)";
            // 
            // CargoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(692, 501);
            Controls.Add(label1);
            Controls.Add(gvCargos);
            Controls.Add(btnRecarregar);
            Controls.Add(btnNovoCargo);
            Controls.Add(groupBoxCargo);
            MaximizeBox = false;
            Name = "CargoView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cargo View";
            groupBoxCargo.ResumeLayout(false);
            groupBoxCargo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gvCargos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCargo;
        private CheckBox chkStatus;
        private Button btnSalvar;
        private GroupBox groupBoxCargo;
        private Button btnNovoCargo;
        private Button btnRecarregar;
        private DataGridView gvCargos;
        private Label label1;
    }
}