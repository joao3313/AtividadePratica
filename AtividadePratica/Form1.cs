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
                Nome.Text = "O nome deve ter pelo menos 3 caracteres.";
                Nome.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                Nome.Text = "";
            }

            // Valida��o do E-mail
            if (string.IsNullOrWhiteSpace(Email.Text) || !Email.Text.Contains("@") || !Email.Text.Contains("."))
            {
                Email.Text = "E-mail inv�lido.";
                Email.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                Email.Text = "";
            }

            // Valida��o da Idade
            int idade;
            if (!int.TryParse(Idade.Text, out idade) || idade < 18 || idade > 100)
            {
                Idade.Text = "Idade inv�lida. Deve estar entre 18 e 100 anos.";
                Idade.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                Idade.Text = "";
            }

            // Valida��o da Senha
            if (string.IsNullOrWhiteSpace(Senha.Text) || Senha.Text.Length < 6)
            {
                Senha.Text = "A senha deve ter pelo menos 6 caracteres.";
                Senha.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                Senha.Text = "";
            }

            // Valida��o de Confirma��o de Senha
            if (ConfirmaSenha.Text != Senha.Text)
            {
                ConfirmaSenha.Text = "As senhas n�o coincidem.";
                ConfirmaSenha.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                ConfirmaSenha.Text = "";
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
               Nome.Text = "O nome deve ter pelo menos 3 caracteres.";
                Nome.ForeColor = Color.Red;
            }
            else
            {
                Nome.Text = "";
            }
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Email.Text) || !Email.Text.Contains("@") || !Email.Text.Contains("."))
            {
                Email.Text = "E-mail inv�lido.";
                Email.ForeColor = Color.Red;
            }
            else
            {
                Email.Text = "";
            }
        }

        private void Idade_TextChanged(object sender, EventArgs e)
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
            }
        }

        private void Senha_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Senha.Text) || Senha.Text.Length < 6)
            {
                Senha.Text = "A senha deve ter pelo menos 6 caracteres.";
                Senha.ForeColor = Color.Red;
            }
            else
            {
                Senha.Text = "";
            }
        }

        private void ConfirmaSenha_TextChanged(object sender, EventArgs e)
        {
            if (ConfirmaSenha.Text != Senha.Text)
            {
                ConfirmaSenha.Text = "As senhas n�o coincidem.";
                ConfirmaSenha.ForeColor = Color.Red;
            }
            else
            {
                ConfirmaSenha.Text = "";
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
            Nome.Text = "";
            Email.Text = "";
            Idade.Text = "";
            Senha.Text = "";
            ConfirmaSenha.Text = "";
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
