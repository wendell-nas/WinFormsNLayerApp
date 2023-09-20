namespace WinFormsApp
{
    partial class SplashScreen
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
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            progressBar1.BackColor = SystemColors.MenuHighlight;
            progressBar1.ForeColor = Color.Transparent;
            progressBar1.Location = new Point(191, 578);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(454, 13);
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.TabIndex = 0;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fundo_abstrato_com_design_baixo_poli;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(815, 603);
            Controls.Add(progressBar1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Splash Screen";
            WindowState = FormWindowState.Maximized;
            Shown += SplashScreen_Shown;
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar1;
    }
}