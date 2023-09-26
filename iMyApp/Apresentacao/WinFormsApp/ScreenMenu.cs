using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class ScreenMenu : Form
    {

        public ScreenMenu()
        {
            InitializeComponent();
        }
        bool menuExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 15;
                if (menuContainer.Height >= 133)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }

            }
            else
            {
                menuContainer.Height -= 15;
                if (menuContainer.Height <= 36)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        bool siderbarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (siderbarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 60)
                {
                    sidebarTransition.Stop();
                    siderbarExpand = false;


                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 181)
                {
                    sidebarTransition.Stop();
                    siderbarExpand = true;


                }
            }
        }

        private void btnHan_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }


    }
}
