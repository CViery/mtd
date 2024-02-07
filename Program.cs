namespace MTDSpoofer_GUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            LoginForm loginForm = new LoginForm();

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Se o login foi bem-sucedido, inicie a aplica��o principal
                Application.Run(new Spoofy());
                Application.EnableVisualStyles();
            }
            else
            {
                // Se o login n�o foi bem-sucedido, encerre a aplica��o
                Application.Exit();
            }
            
        }
    }
}