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

        // Evento do botão de Enviar
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            bool isValid = true; // Flag para verificar se todos os campos são válidos

            // Validação do Nome
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

            // Validação do E-mail
            if (string.IsNullOrWhiteSpace(Email.Text) || !Email.Text.Contains("@") || !Email.Text.Contains("."))
            {
                Email.Text = "E-mail inválido.";
                Email.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                Email.Text = "";
            }

            // Validação da Idade
            int idade;
            if (!int.TryParse(Idade.Text, out idade) || idade < 18 || idade > 100)
            {
                Idade.Text = "Idade inválida. Deve estar entre 18 e 100 anos.";
                Idade.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                Idade.Text = "";
            }

            // Validação da Senha
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

            // Validação de Confirmação de Senha
            if (ConfirmaSenha.Text != Senha.Text)
            {
                ConfirmaSenha.Text = "As senhas não coincidem.";
                ConfirmaSenha.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                ConfirmaSenha.Text = "";
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

            // Se todos os campos forem válidos, exibe a mensagem de sucesso
            if (isValid)
            {
                MessageBox.Show("Cadastro enviado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();  // Limpa os campos após envio bem-sucedido
            }
            else
            {
                // Caso contrário, uma mensagem de erro é exibida
                MessageBox.Show("Por favor, corrija os campos marcados em vermelho.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Eventos de validação em tempo real
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
                Email.Text = "E-mail inválido.";
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
                Idade.Text = "Idade inválida. Deve estar entre 18 e 100 anos.";
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
                ConfirmaSenha.Text = "As senhas não coincidem.";
                ConfirmaSenha.ForeColor = Color.Red;
            }
            else
            {
                ConfirmaSenha.Text = "";
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
            Nome.Text = "";
            Email.Text = "";
            Idade.Text = "";
            Senha.Text = "";
            ConfirmaSenha.Text = "";
            cbxTermo.Text = "";
        }

        // Evento de validação do checkbox de termos
        private void cbxTermo_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbxTermo.Checked)
            {
                cbxTermo.Text = "Você precisa confirmar os termos de uso para continuar.";
                cbxTermo.ForeColor = Color.Red;
            }
            else
            {
                cbxTermo.Text = "";
            }
        }

       
    }
}
