using PsicomindClass;

namespace Psicomind
{
    internal static class Program
    {

        public static Usuario Usuario { get; set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Usuario = new();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new FrmPrincipal());

            FrmLogin login = new();
            login.StartPosition = FormStartPosition.CenterScreen;

            if (login.ShowDialog() == DialogResult.OK)
            {
                // Se o login foi bem-sucedido, exibe o formulário principal
                Application.Run(new FrmPrincipal());
            }
            else
            {
                // Se o login falhou ou foi cancelado, encerra a aplicação
                Application.Exit();
            }

        }
    }
}