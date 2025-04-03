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
                Nome.Text = "O nome deve ter pelo menos 3 caracteres.";
                lblNome.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                lblNome.Text = "";
                lblNome.ForeColor = SystemColors.ControlText; // Reseta a cor para a padr�o
            }

            // Valida��o do E-mail
            if (string.IsNullOrWhiteSpace(Email.Text) || !Email.Text.Contains("@") || !Email.Text.Contains("."))
            {
                Email.Text = "E-mail inv�lido.";
                lblEmail.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                lblEmail.Text = "";
                lblEmail.ForeColor = SystemColors.ControlText;
            }

            // Valida��o da Idade
            int idade;
            if (!int.TryParse(Idade.Text, out idade) || idade < 18 || idade > 100)
            {
                Idade.Text = "Idade inv�lida. Deve estar entre 18 e 100 anos.";
                lblIdade.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                lblIdade.Text = "";
                lblIdade.ForeColor = SystemColors.ControlText;
            }

            // Valida��o da Senha
            if (string.IsNullOrWhiteSpace(Senha.Text) || Senha.Text.Length < 6)
            {
                Senha.Text = "A senha deve ter pelo menos 6 caracteres.";
                lblSenha.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                lblSenha.Text = "";
                lblSenha.ForeColor = SystemColors.ControlText;
            }

            // Valida��o de Confirma��o de Senha
            if (ConfirmaSenha.Text != Senha.Text)
            {
                ConfirmaSenha.Text = "As senhas n�o coincidem.";
                lblConfirmaSenha.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                lblConfirmaSenha.Text = "";
                lblConfirmaSenha.ForeColor = SystemColors.ControlText;
            }

            // Valida��o do Checkbox de Termos de Uso
            if (!cbxTermo.Checked)
            {
                lblTermo.Text = "Aceite os termos para continuar.";
                lblTermo.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                lblTermo.Text = "";
                lblTermo.ForeColor = SystemColors.ControlText;
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

            // **Removido a limpeza dos labels aqui**
            // lblNome.Text = "";
            // lblEmail.Text = "";
            // lblIdade.Text = "";
            // lblSenha.Text = "";
            // lblConfirmaSenha.Text = "";
            // lblTermo.Text = "";
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

        private void ValidarConfirmaSenha()
        {
            if (ConfirmaSenha.Text != Senha.Text)
            {
                ConfirmaSenha.Text = "As senhas n�o coincidem.";
                lblConfirmaSenha.ForeColor = Color.Red;
            }
            else
            {
                ConfirmaSenha.Text = "";
                ConfirmaSenha.ForeColor = SystemColors.ControlText;
            }
        }

        private void Nome_TextChanged(object sender, EventArgs e)
        {
            ValidarNome();
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            ValidarEmail();
        }

        private void Idade_TextChanged(object sender, EventArgs e)
        {
            ValidarIdade();
        }

        private void cbxTermo_CheckedChanged(object sender, EventArgs e)
        {
            ValidarTermos();
        }

        private void Senha_TextChanged(object sender, EventArgs e)
        {
            // Valida o campo Senha
            if (string.IsNullOrWhiteSpace(Senha.Text) || Senha.Text.Length < 6)
            {
               Senha.Text = "A senha deve ter pelo menos 6 caracteres.";
               Senha.ForeColor = Color.Red;
            }
            else
            {
               Senha.Text = "";
               Senha.ForeColor = SystemColors.ControlText;
            }

            // Tamb�m valida a Confirma��o de Senha, pois a altera��o da Senha pode afet�-la
            ValidarConfirmaSenha();
        }

        private void ValidarNome()
        {
            if (string.IsNullOrWhiteSpace(Nome.Text) || Nome.Text.Trim().Length < 3)
            {
                Nome.Text = "O nome deve ter pelo menos 3 caracteres.";
                Nome.ForeColor = Color.Red;
            }
            else
            {
                Nome.Text = "";
                Nome.ForeColor = SystemColors.ControlText;
            }
        }

        private void ValidarEmail()
        {
            if (string.IsNullOrWhiteSpace(Email.Text) || !Email.Text.Contains("@") || !Email.Text.Contains("."))
            {
                Email.Text = "E-mail inv�lido.";
                Email.ForeColor = Color.Red;
            }
            else
            {
                Email.Text = "";
                Email.ForeColor = SystemColors.ControlText;
            }
        }

        private void ValidarIdade()
        {
            int idade;
            if (!int.TryParse(Idade.Text, out idade) || idade < 18 || idade > 100)
            {
                Idade.Text = "Idade inv�lida. Deve estar entre 18 e 100 anos.";
                Idade.ForeColor = Color.Red;
            }
            else
            {
                Idade.Text = "";
                Idade.ForeColor = SystemColors.ControlText;
            }
        }

        private void ValidarTermos()
        {
            if (!cbxTermo.Checked)
            {
                lblTermo.Text = "Aceite os termos para continuar.";
                lblTermo.ForeColor = Color.Red;
            }
            else
            {
                lblTermo.Text = "";
                lblTermo.ForeColor = SystemColors.ControlText;
            }
        }

        private void ConfirmaSenha_TextChanged(object sender, EventArgs e)
        {
            // Valida o campo ConfirmaSenha comparando com o campo Senha
            ValidarConfirmaSenha();
        }
    }
}