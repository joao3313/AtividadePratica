namespace AtividadePratica
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        // Fun��o para validar todos os campos
        private bool ValidarCampos()
        {
            bool isValid = true;

            // Valida��o do Nome
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

            // Valida��o do E-mail
            if (string.IsNullOrWhiteSpace(Email.Text) || !Email.Text.Contains("@") || !Email.Text.Contains("."))
            {
                lblEmail.Text = "E-mail inv�lido.";
                lblEmail.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                lblEmail.Text = "";
            }

            // Valida��o da Idade
            int idade;
            if (!int.TryParse(Idade.Text, out idade) || idade < 18 || idade > 100)
            {
                lblIdade.Text = "Idade inv�lida. Deve estar entre 18 e 100 anos.";
                lblIdade.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                lblIdade.Text = "";
            }

            // Valida��o da Senha
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

            // Valida��o de Confirma��o de Senha
            if (ConfirmaSenha.Text != Senha.Text)
            {
                lblConfirmaSenha.Text = "As senhas n�o coincidem.";
                lblConfirmaSenha.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                lblConfirmaSenha.Text = "";
            }

            // Valida��o do Checkbox de Termos de Uso
            if (!cbxTermo.Checked)
            {
                cbxTermo.Text = "Voc� precisa confirmar os termos de uso para continuar.";
                cbxTermo.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                cbxTermo.Text = "";
            }

            return isValid;
        }

        // Evento do bot�o de Enviar
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                // Se todos os campos forem v�lidos, exibe a mensagem de sucesso
                MessageBox.Show("Cadastro enviado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Chama a fun��o para salvar os dados (substitua com sua l�gica real de salvamento)
                SalvarDados();

                // Limpa os campos ap�s envio bem-sucedido
                LimparCampos();
            }
            else
            {
                // Se algum campo estiver inv�lido, n�o faz nada e as mensagens de erro j� estar�o vis�veis.
                MessageBox.Show("Por favor, corrija os campos marcados em vermelho.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento do bot�o Limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        // Fun��o para limpar todos os campos
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

        // Fun��o para salvar os dados (substitua com sua l�gica real de salvamento)
        private void SalvarDados()
        {
            string nome = Nome.Text;
            string email = Email.Text;
            string idade = Idade.Text;
            string senha = Senha.Text;
            bool aceitouTermos = cbxTermo.Checked;

            // Exemplo de exibi��o de dados (substitua com seu c�digo de salvar os dados)
            string mensagem = $"Nome: {nome}\nEmail: {email}\nIdade: {idade}\nSenha: {senha}\nAceitou Termos: {aceitouTermos}";
            MessageBox.Show($"Dados a serem salvos:\n{mensagem}", "Informa��o", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
