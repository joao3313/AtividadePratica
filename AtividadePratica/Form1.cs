namespace AtividadePratica
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        // Função para salvar os dados
        public void SalvarDados()
        {
            // Aqui você escreveria o código para salvar os dados do formulário
            // em um banco de dados, arquivo, etc.
            string nome = Nome.Text;
            string email = Email.Text;
            string idade = Idade.Text;
            string senha = Senha.Text;
            bool aceitouTermos = cbxTermo.Checked;

            // Exemplo de como exibir os dados (para demonstração)
            string mensagem = $"Nome: {nome}\nEmail: {email}\nIdade: {idade}\nSenha: {senha}\nAceitou Termos: {aceitouTermos}";
            MessageBox.Show($"Dados a serem salvos:\n{mensagem}", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // *** IMPORTANTE: Substitua este exemplo com a sua lógica real de salvamento ***
        }

        // Evento do botão de Enviar
        public void btnEnviar_Click(object sender, EventArgs e)
        {
            bool isValid = true; // Flag para verificar se todos os campos são válidos

            // Validação do Nome
            if (Nome.Text.Trim().Length < 3)
            {
                lblNome.Text = "O nome deve ter pelo menos 3 caracteres.";
                isValid = false;
            }
            else
            {
                lblNome.Text = "";
            }

            // Validação do E-mail
            if (string.IsNullOrWhiteSpace(Email.Text) || !Email.Text.Contains("@") || !Email.Text.Contains("."))
            {
                lblEmail.Text = "E-mail inválido.";
                isValid = false;
            }
            else
            {
                lblEmail.Text = "";
            }

            // Validação da Idade
            int idade;
            if (!int.TryParse(Idade.Text, out idade) || idade < 18 || idade > 100)
            {
                lblIdade.Text = "Idade inválida. Deve estar entre 18 e 100 anos.";
                isValid = false;
            }
            else
            {
                lblIdade.Text = "";
            }

            // Validação da Senha
            if (string.IsNullOrWhiteSpace(Senha.Text) || Senha.Text.Length < 6)
            {
                lblSenha.Text = "A senha deve ter pelo menos 6 caracteres.";
                isValid = false;
            }
            else
            {
                lblSenha.Text = "";
            }

            // Validação de Confirmação de Senha
            if (ConfirmaSenha.Text != Senha.Text)
            {
                lblConfirmaSenha.Text = "As senhas não coincidem.";
                isValid = false;
            }
            else
            {
                lblConfirmaSenha.Text = "";
            }

            // Validação do Checkbox de Termos de Uso
            if (!cbxTermo.Checked)
            {
                cbxTermo.Text = "Você precisa confirmar os termos de uso para continuar.";
                isValid = false;
            }
            else
            {
                cbxTermo.Text = "";
            }

            // Se todas as validações passarem, exibe a mensagem de sucesso
            if (isValid)
            {
                // Exibe uma mensagem de sucesso
                MessageBox.Show("Cadastro enviado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Chama a função para salvar os dados
                SalvarDados();

                // Limpa os campos após envio bem-sucedido
                LimparCampos();
            }
        }

        // Evento do botão Limpar
        public void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        // Função para limpar todos os campos
        public void LimparCampos()
        {
            // Limpa os campos de texto
            Nome.Clear();
            Email.Clear();
            Idade.Clear();
            Senha.Clear();
            ConfirmaSenha.Clear();

            // Desmarca o checkbox
            cbxTermo.Checked = false;

            // Limpa os labels de erro
            lblNome.Text = "";
            lblEmail.Text = "";
            lblIdade.Text = "";
            lblSenha.Text = "";
            lblConfirmaSenha.Text = "";
            cbxTermo.Text = "";
        }
    }
}
