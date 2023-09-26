namespace WinFormsApp
{
    partial class ScreenMenu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenMenu));
            panel1 = new Panel();
            btnHan = new PictureBox();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            sidebar = new FlowLayoutPanel();
            pnDashboard = new Panel();
            button2 = new Button();
            menuContainer = new FlowLayoutPanel();
            panel4 = new Panel();
            menu = new Button();
            panel2 = new Panel();
            button3 = new Button();
            button1 = new Button();
            panel5 = new Panel();
            button4 = new Button();
            pnAbout = new Panel();
            button5 = new Button();
            pnSettings = new Panel();
            button6 = new Button();
            pnLogout = new Panel();
            button7 = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHan).BeginInit();
            sidebar.SuspendLayout();
            pnDashboard.SuspendLayout();
            menuContainer.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            pnAbout.SuspendLayout();
            pnSettings.SuspendLayout();
            pnLogout.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnHan);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 54);
            panel1.TabIndex = 0;
            // 
            // btnHan
            // 
            btnHan.Image = (Image)resources.GetObject("btnHan.Image");
            btnHan.Location = new Point(10, 15);
            btnHan.Name = "btnHan";
            btnHan.Size = new Size(39, 30);
            btnHan.SizeMode = PictureBoxSizeMode.CenterImage;
            btnHan.TabIndex = 2;
            btnHan.TabStop = false;
            btnHan.Click += btnHan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(55, 21);
            label1.Name = "label1";
            label1.Size = new Size(90, 17);
            label1.TabIndex = 2;
            label1.Text = "WinFormsApp";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // sidebar
            // 
            sidebar.BackColor = SystemColors.ActiveCaptionText;
            sidebar.Controls.Add(pnDashboard);
            sidebar.Controls.Add(menuContainer);
            sidebar.Controls.Add(pnAbout);
            sidebar.Controls.Add(pnSettings);
            sidebar.Controls.Add(pnLogout);
            sidebar.Location = new Point(0, 46);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(181, 405);
            sidebar.TabIndex = 1;
            // 
            // pnDashboard
            // 
            pnDashboard.Controls.Add(button2);
            pnDashboard.Location = new Point(3, 3);
            pnDashboard.Name = "pnDashboard";
            pnDashboard.Size = new Size(151, 36);
            pnDashboard.TabIndex = 10;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-10, -30);
            button2.Name = "button2";
            button2.Padding = new Padding(20, 0, 0, 0);
            button2.Size = new Size(188, 94);
            button2.TabIndex = 8;
            button2.Text = "Dashboard";
            button2.UseVisualStyleBackColor = false;
            // 
            // menuContainer
            // 
            menuContainer.BackColor = Color.Black;
            menuContainer.Controls.Add(panel4);
            menuContainer.Controls.Add(panel2);
            menuContainer.Controls.Add(panel5);
            menuContainer.Location = new Point(0, 42);
            menuContainer.Margin = new Padding(0);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(151, 36);
            menuContainer.TabIndex = 12;
            // 
            // panel4
            // 
            panel4.Controls.Add(menu);
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(151, 36);
            panel4.TabIndex = 11;
            // 
            // menu
            // 
            menu.BackColor = SystemColors.ActiveCaptionText;
            menu.ForeColor = Color.White;
            menu.Image = (Image)resources.GetObject("menu.Image");
            menu.ImageAlign = ContentAlignment.MiddleLeft;
            menu.Location = new Point(-9, -58);
            menu.Margin = new Padding(0);
            menu.Name = "menu";
            menu.Padding = new Padding(20, 0, 0, 0);
            menu.Size = new Size(184, 152);
            menu.TabIndex = 8;
            menu.Text = "Menu";
            menu.UseVisualStyleBackColor = false;
            menu.Click += menu_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(3, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(151, 36);
            panel2.TabIndex = 13;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-16, -29);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Padding = new Padding(25, 0, 0, 0);
            button3.Size = new Size(182, 94);
            button3.TabIndex = 9;
            button3.Text = "Sub Menu 1";
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-17, -29);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Padding = new Padding(25, 0, 0, 0);
            button1.Size = new Size(182, 94);
            button1.TabIndex = 8;
            button1.Text = "Sub Menu 1";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(button4);
            panel5.Location = new Point(3, 81);
            panel5.Name = "panel5";
            panel5.Size = new Size(151, 36);
            panel5.TabIndex = 15;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaptionText;
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-17, -29);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Padding = new Padding(25, 0, 0, 0);
            button4.Size = new Size(182, 94);
            button4.TabIndex = 8;
            button4.Text = "Sub Menu 2";
            button4.UseVisualStyleBackColor = false;
            // 
            // pnAbout
            // 
            pnAbout.Controls.Add(button5);
            pnAbout.Location = new Point(3, 81);
            pnAbout.Name = "pnAbout";
            pnAbout.Size = new Size(151, 36);
            pnAbout.TabIndex = 14;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaptionText;
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(-17, -29);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Padding = new Padding(25, 0, 0, 0);
            button5.Size = new Size(182, 94);
            button5.TabIndex = 8;
            button5.Text = "About";
            button5.UseVisualStyleBackColor = false;
            // 
            // pnSettings
            // 
            pnSettings.Controls.Add(button6);
            pnSettings.Location = new Point(3, 123);
            pnSettings.Name = "pnSettings";
            pnSettings.Size = new Size(151, 36);
            pnSettings.TabIndex = 14;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ActiveCaptionText;
            button6.ForeColor = Color.White;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(-12, -29);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Padding = new Padding(20, 0, 0, 0);
            button6.Size = new Size(182, 94);
            button6.TabIndex = 8;
            button6.Text = "Settings";
            button6.UseVisualStyleBackColor = false;
            // 
            // pnLogout
            // 
            pnLogout.Controls.Add(button7);
            pnLogout.Location = new Point(3, 165);
            pnLogout.Name = "pnLogout";
            pnLogout.Size = new Size(151, 36);
            pnLogout.TabIndex = 14;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ActiveCaptionText;
            button7.ForeColor = Color.White;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(-12, -29);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Padding = new Padding(20, 0, 0, 0);
            button7.Size = new Size(182, 94);
            button7.TabIndex = 8;
            button7.Text = "Logout";
            button7.UseVisualStyleBackColor = false;
            // 
            // menuTransition
            // 
            menuTransition.Tick += menuTransition_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // ScreenMenu
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ScreenMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ScreenMenu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnHan).EndInit();
            sidebar.ResumeLayout(false);
            pnDashboard.ResumeLayout(false);
            menuContainer.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            pnAbout.ResumeLayout(false);
            pnSettings.ResumeLayout(false);
            pnLogout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox btnHam;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private FlowLayoutPanel sidebar;
        private Panel pnDashboard;
        private Button button2;
        private Panel panel4;
        private Button menu;
        private FlowLayoutPanel menuContainer;
        private Panel panel2;
        private Button button1;
        private Panel pnAbout;
        private Button button5;
        private Panel pnSettings;
        private Button button6;
        private Panel pnLogout;
        private Button button7;
        private System.Windows.Forms.Timer menuTransition;
        private Button button3;
        private Panel panel5;
        private Button button4;
        private System.Windows.Forms.Timer sidebarTransition;
        private Button button8;
        private PictureBox btnHan;
    }
}