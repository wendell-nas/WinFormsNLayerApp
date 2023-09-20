using WinFormsApp.Telas.Cargos;
using WinFormsApp.Telas.Clientes;

namespace WinFormsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MDIPrincipal());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
    }
}