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
                // Se o login foi bem-sucedido, inicie a aplicação principal
                Application.Run(new Spoofy());
                Application.EnableVisualStyles();
            }
            else
            {
                // Se o login não foi bem-sucedido, encerre a aplicação
                Application.Exit();
            }
            
        }
    }
}