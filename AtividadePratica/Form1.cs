namespace AtividadePratica
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        // Função para validar todos os campos
        private bool ValidarCampos()
        {
            bool isValid = true;

            // Validação do Nome
            if (Nome.Text.Trim().Length < 3)
            {
                lblNome.Text = "O nome deve ter pelo menos 3 caracteres.";
                lblNome.ForeColor = Color.Red;
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
                lblEmail.ForeColor = Color.Red;
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
                lblIdade.ForeColor = Color.Red;
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
                lblSenha.ForeColor = Color.Red;
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
                lblConfirmaSenha.ForeColor = Color.Red;
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
                cbxTermo.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                cbxTermo.Text = "";
            }

            return isValid;
        }

        // Evento do botão de Enviar
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                // Se todos os campos forem válidos, exibe a mensagem de sucesso
                MessageBox.Show("Cadastro enviado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Chama a função para salvar os dados (substitua com sua lógica real de salvamento)
                SalvarDados();

                // Limpa os campos após envio bem-sucedido
                LimparCampos();
            }
            else
            {
                // Se algum campo estiver inválido, não faz nada e as mensagens de erro já estarão visíveis.
                MessageBox.Show("Por favor, corrija os campos marcados em vermelho.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento do botão Limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        // Função para limpar todos os campos
        private void LimparCampos()
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

        // Função para salvar os dados (substitua com sua lógica real de salvamento)
        private void SalvarDados()
        {
            string nome = Nome.Text;
            string email = Email.Text;
            string idade = Idade.Text;
            string senha = Senha.Text;
            bool aceitouTermos = cbxTermo.Checked;

            // Exemplo de exibição de dados (substitua com seu código de salvar os dados)
            string mensagem = $"Nome: {nome}\nEmail: {email}\nIdade: {idade}\nSenha: {senha}\nAceitou Termos: {aceitouTermos}";
            MessageBox.Show($"Dados a serem salvos:\n{mensagem}", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
