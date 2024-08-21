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

            // Mantendo a configura��o padr�o do programa ao inicializar
            ApplicationConfiguration.Initialize();

            // Abrindo tela de login 
            FrmLogin login = new();
            login.StartPosition = FormStartPosition.CenterScreen;

            if (login.ShowDialog() == DialogResult.OK)
            {
                // Se o login foi bem-sucedido, exibe o formul�rio principal
                Application.Run(new FrmPrincipal());
            }
            else
            {
                // Se o login falhou ou foi cancelado, encerra a aplica��o
                Application.Exit();
            }



            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //Application.Run(new FrmPrincipal());


        }
    }
}