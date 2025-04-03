namespace AtividadePratica
{
    partial class frmCadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Nome = new TextBox();
            Email = new TextBox();
            Idade = new TextBox();
            Senha = new TextBox();
            ConfirmaSenha = new TextBox();
            lblNome = new Label();
            lblEmail = new Label();
            lblIdade = new Label();
            lblSenha = new Label();
            lblConfirmaSenha = new Label();
            cbxTermo = new CheckBox();
            btnEnviar = new Button();
            btnLimpar = new Button();
            lblTermo = new Label();
            SuspendLayout();
            // 
            // Nome
            // 
            Nome.Location = new Point(131, 43);
            Nome.Margin = new Padding(2);
            Nome.Name = "Nome";
            Nome.Size = new Size(233, 23);
            Nome.TabIndex = 0;
            // 
            // Email
            // 
            Email.Location = new Point(131, 80);
            Email.Margin = new Padding(2);
            Email.Name = "Email";
            Email.Size = new Size(180, 23);
            Email.TabIndex = 0;
            // 
            // Idade
            // 
            Idade.Location = new Point(131, 120);
            Idade.Margin = new Padding(2);
            Idade.Name = "Idade";
            Idade.Size = new Size(86, 23);
            Idade.TabIndex = 0;
            // 
            // Senha
            // 
            Senha.Location = new Point(131, 160);
            Senha.Margin = new Padding(2);
            Senha.Name = "Senha";
            Senha.PasswordChar = '*';
            Senha.Size = new Size(106, 23);
            Senha.TabIndex = 0;
            // 
            // ConfirmaSenha
            // 
            ConfirmaSenha.Location = new Point(131, 203);
            ConfirmaSenha.Margin = new Padding(2);
            ConfirmaSenha.Name = "ConfirmaSenha";
            ConfirmaSenha.PasswordChar = '*';
            ConfirmaSenha.Size = new Size(106, 23);
            ConfirmaSenha.TabIndex = 0;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(27, 46);
            lblNome.Margin = new Padding(2, 0, 2, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(27, 83);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "E-Mail";
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Location = new Point(27, 124);
            lblIdade.Margin = new Padding(2, 0, 2, 0);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(36, 15);
            lblIdade.TabIndex = 1;
            lblIdade.Text = "Idade";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(27, 164);
            lblSenha.Margin = new Padding(2, 0, 2, 0);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 1;
            lblSenha.Text = "Senha";
            // 
            // lblConfirmaSenha
            // 
            lblConfirmaSenha.AutoSize = true;
            lblConfirmaSenha.Location = new Point(26, 207);
            lblConfirmaSenha.Margin = new Padding(2, 0, 2, 0);
            lblConfirmaSenha.Name = "lblConfirmaSenha";
            lblConfirmaSenha.Size = new Size(96, 15);
            lblConfirmaSenha.TabIndex = 1;
            lblConfirmaSenha.Text = "Confirmar Senha";
            // 
            // cbxTermo
            // 
            cbxTermo.AutoSize = true;
            cbxTermo.Location = new Point(26, 290);
            cbxTermo.Margin = new Padding(2);
            cbxTermo.Name = "cbxTermo";
            cbxTermo.Size = new Size(15, 14);
            cbxTermo.TabIndex = 2;
            cbxTermo.UseVisualStyleBackColor = true;
            cbxTermo.Click += cbxTermo_CheckedChanged;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(302, 290);
            btnEnviar.Margin = new Padding(2);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(78, 25);
            btnEnviar.TabIndex = 3;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(405, 290);
            btnLimpar.Margin = new Padding(2);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(78, 25);
            btnLimpar.TabIndex = 3;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lblTermo
            // 
            lblTermo.AutoSize = true;
            lblTermo.Location = new Point(46, 290);
            lblTermo.Name = "lblTermo";
            lblTermo.Size = new Size(141, 15);
            lblTermo.TabIndex = 4;
            lblTermo.Text = "Confirme o termo de Uso";
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 326);
            Controls.Add(lblTermo);
            Controls.Add(btnLimpar);
            Controls.Add(btnEnviar);
            Controls.Add(cbxTermo);
            Controls.Add(lblConfirmaSenha);
            Controls.Add(lblSenha);
            Controls.Add(lblIdade);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            Controls.Add(ConfirmaSenha);
            Controls.Add(Senha);
            Controls.Add(Idade);
            Controls.Add(Email);
            Controls.Add(Nome);
            Margin = new Padding(2);
            Name = "frmCadastro";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Nome;
        private TextBox Email;
        private TextBox Idade;
        private TextBox Senha;
        private TextBox ConfirmaSenha;
        private Label lblNome;
        private Label lblEmail;
        private Label lblIdade;
        private Label lblSenha;
        private Label lblConfirmaSenha;
        private CheckBox cbxTermo;
        private Button btnEnviar;
        private Button btnLimpar;
        private Label lblTermo;
    }
}
