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

            // Verifique se há um token de acesso armazenado ao inicializar o formulário
            string savedToken = ConfigurationManager.AppSettings["AccessToken"]; // Acessando as configurações de aplicativo corretamente
            if (!string.IsNullOrEmpty(savedToken))
            {
                // Se houver um token salvo, faça login automaticamente
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

                    // Salvar o token de acesso apenas na primeira vez que o usuário logar
                    if (string.IsNullOrEmpty(ConfigurationManager.AppSettings["AccessToken"]))
                    {
                        // Abre o arquivo de configuração para escrita
                        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                        // Adiciona ou atualiza a chave de AccessToken
                        config.AppSettings.Settings["AccessToken"].Value = apiKey;

                        // Salva as alterações no arquivo de configuração
                        config.Save(ConfigurationSaveMode.Modified);

                        // Atualiza a configuração em tempo de execução
                        ConfigurationManager.RefreshSection("appSettings");
                    }

                    // Coloque aqui o código para abrir o formulário principal ou realizar outras ações após o login
                }
                else
                {
                    MessageBox.Show("Chave de autorização inválida. Tente novamente.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira uma chave de autorização.");
            }
        }

        private async Task<bool> VerificarChave(string apiKey)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(keyAuthApiUrl);

                // Faz uma solicitação para verificar a chave
                HttpResponseMessage response = await client.GetAsync($"?key={apiKey}");

                if (response.IsSuccessStatusCode)
                {
                    // Se a resposta for bem-sucedida, o usuário está autenticado
                    return true;
                }
                else
                {
                    // Se a resposta for um erro, a chave é inválida
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
            // Coloque aqui o código para abrir o formulário principal ou realizar outras ações após o login
        }

        private TextBox textBox1;
        private Button button1;
        private Label label1;
    }
}
