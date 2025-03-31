using System;
using System.Drawing;
using System.Windows.Forms;

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
            if (string.IsNullOrWhiteSpace(Nome.Text) || Nome.Text.Trim().Length < 3)
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
            // Valida��o de todos os campos antes de enviar
            if (ValidarCampos())
            {
                // Se todos os campos forem v�lidos, exibe a mensagem de sucesso e salva os dados
                MessageBox.Show("Cadastro enviado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SalvarDados();
                LimparCampos();
            }
            // Caso contr�rio, a fun��o ValidarCampos j� ter� exibido as mensagens de erro nos labels
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

            // *** IMPORTANTE: Substitua este exemplo com a sua l�gica real de salvamento ***
        }

        // Eventos de valida��o em tempo real

        private void Nome_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Nome.Text) || Nome.Text.Trim().Length < 3)
            {
                lblNome.Text = "O nome deve ter pelo menos 3 caracteres.";
                lblNome.ForeColor = Color.Red;
            }
            else
            {
                lblNome.Text = "";
            }
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Email.Text) || !Email.Text.Contains("@") || !Email.Text.Contains("."))
            {
                lblEmail.Text = "E-mail inv�lido.";
                lblEmail.ForeColor = Color.Red;
            }
            else
            {
                lblEmail.Text = "";
            }
        }

        private void Idade_TextChanged(object sender, EventArgs e)
        {
            int idade;
            if (!int.TryParse(Idade.Text, out idade) || idade < 18 || idade > 100)
            {
                lblIdade.Text = "Idade inv�lida. Deve estar entre 18 e 100 anos.";
                lblIdade.ForeColor = Color.Red;
            }
            else
            {
                lblIdade.Text = "";
            }
        }

        private void Senha_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Senha.Text) || Senha.Text.Length < 6)
            {
                lblSenha.Text = "A senha deve ter pelo menos 6 caracteres.";
                lblSenha.ForeColor = Color.Red;
            }
            else
            {
                lblSenha.Text = "";
            }
        }

        private void ConfirmaSenha_TextChanged(object sender, EventArgs e)
        {
            if (ConfirmaSenha.Text != Senha.Text)
            {
                lblConfirmaSenha.Text = "As senhas n�o coincidem.";
                lblConfirmaSenha.ForeColor = Color.Red;
            }
            else
            {
                lblConfirmaSenha.Text = "";
            }
        }

        private void cbxTermo_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbxTermo.Checked)
            {
                cbxTermo.Text = "Voc� precisa confirmar os termos de uso para continuar.";
                cbxTermo.ForeColor = Color.Red;
            }
            else
            {
                cbxTermo.Text = "";
            }
        }
    }
}