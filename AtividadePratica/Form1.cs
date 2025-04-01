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

        // Evento do bot�o de Enviar
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            bool isValid = true; // Flag para verificar se todos os campos s�o v�lidos

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

            // Se todos os campos forem v�lidos, exibe a mensagem de sucesso
            if (isValid)
            {
                MessageBox.Show("Cadastro enviado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();  // Limpa os campos ap�s envio bem-sucedido
            }
            else
            {
                // Caso contr�rio, uma mensagem de erro � exibida
                MessageBox.Show("Por favor, corrija os campos marcados em vermelho.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        // Evento de valida��o do checkbox de termos
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
