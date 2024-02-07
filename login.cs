using System;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaLogin
{
    public partial class LoginForm : Form
    {
        // URL da API do KeyAuth
        private const string keyAuthApiUrl = "https://api.keyauth.com/v1/";

        public LoginForm()
        {
            InitializeComponent();

            // Verifique se h� um token de acesso armazenado ao inicializar o formul�rio
            string savedToken = ConfigurationManager.AppSettings["AccessToken"]; // Acessando as configura��es de aplicativo corretamente
            if (!string.IsNullOrEmpty(savedToken))
            {
                // Se houver um token salvo, fa�a login automaticamente
                FazerLogin(savedToken);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string apiKey = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(apiKey))
            {
                bool autenticado = await VerificarChave(apiKey);

                if (autenticado)
                {
                    MessageBox.Show("Login bem-sucedido!");

                    // Salvar o token de acesso apenas na primeira vez que o usu�rio logar
                    if (string.IsNullOrEmpty(ConfigurationManager.AppSettings["AccessToken"]))
                    {
                        // Abre o arquivo de configura��o para escrita
                        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                        // Adiciona ou atualiza a chave de AccessToken
                        config.AppSettings.Settings["AccessToken"].Value = apiKey;

                        // Salva as altera��es no arquivo de configura��o
                        config.Save(ConfigurationSaveMode.Modified);

                        // Atualiza a configura��o em tempo de execu��o
                        ConfigurationManager.RefreshSection("appSettings");
                    }

                    // Coloque aqui o c�digo para abrir o formul�rio principal ou realizar outras a��es ap�s o login
                }
                else
                {
                    MessageBox.Show("Chave de autoriza��o inv�lida. Tente novamente.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira uma chave de autoriza��o.");
            }
        }

        private async Task<bool> VerificarChave(string apiKey)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(keyAuthApiUrl);

                // Faz uma solicita��o para verificar a chave
                HttpResponseMessage response = await client.GetAsync($"?key={apiKey}");

                if (response.IsSuccessStatusCode)
                {
                    // Se a resposta for bem-sucedida, o usu�rio est� autenticado
                    return true;
                }
                else
                {
                    // Se a resposta for um erro, a chave � inv�lida
                    return false;
                }
            }
        }

        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(48, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(184, 23);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(96, 139);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(83, 23);
            button1.TabIndex = 1;
            button1.Text = "ENTER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(123, 40);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "LOGIN MTD SPOOFER";
            // 
            // LoginForm
            // 
            ClientSize = new System.Drawing.Size(284, 261);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        private void FazerLogin(string apiKey)
        {
            MessageBox.Show("Login bem-sucedido!");
            // Coloque aqui o c�digo para abrir o formul�rio principal ou realizar outras a��es ap�s o login
        }

        private TextBox textBox1;
        private Button button1;
        private Label label1;
    }
}
