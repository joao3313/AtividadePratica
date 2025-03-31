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
            SuspendLayout();
            // 
            // Nome
            // 
            Nome.Location = new Point(187, 71);
            Nome.Name = "Nome";
            Nome.Size = new Size(150, 31);
            Nome.TabIndex = 0;
            // 
            // Email
            // 
            Email.Location = new Point(187, 133);
            Email.Name = "Email";
            Email.Size = new Size(150, 31);
            Email.TabIndex = 0;
            // 
            // Idade
            // 
            Idade.Location = new Point(187, 200);
            Idade.Name = "Idade";
            Idade.Size = new Size(150, 31);
            Idade.TabIndex = 0;
            // 
            // Senha
            // 
            Senha.Location = new Point(187, 267);
            Senha.Name = "Senha";
            Senha.PasswordChar = '*';
            Senha.Size = new Size(150, 31);
            Senha.TabIndex = 0;
            // 
            // ConfirmaSenha
            // 
            ConfirmaSenha.Location = new Point(187, 339);
            ConfirmaSenha.Name = "ConfirmaSenha";
            ConfirmaSenha.PasswordChar = '*';
            ConfirmaSenha.Size = new Size(150, 31);
            ConfirmaSenha.TabIndex = 0;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(39, 77);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(61, 25);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(39, 139);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(61, 25);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "E-Mail";
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Location = new Point(39, 206);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(57, 25);
            lblIdade.TabIndex = 1;
            lblIdade.Text = "Idade";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(39, 273);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(60, 25);
            lblSenha.TabIndex = 1;
            lblSenha.Text = "Senha";
            // 
            // lblConfirmaSenha
            // 
            lblConfirmaSenha.AutoSize = true;
            lblConfirmaSenha.Location = new Point(37, 345);
            lblConfirmaSenha.Name = "lblConfirmaSenha";
            lblConfirmaSenha.Size = new Size(144, 25);
            lblConfirmaSenha.TabIndex = 1;
            lblConfirmaSenha.Text = "Confirmar Senha";
            // 
            // cbxTermo
            // 
            cbxTermo.AutoSize = true;
            cbxTermo.Location = new Point(39, 460);
            cbxTermo.Name = "cbxTermo";
            cbxTermo.Size = new Size(241, 29);
            cbxTermo.TabIndex = 2;
            cbxTermo.Text = "Confirme o termo de Uso";
            cbxTermo.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(331, 483);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(112, 34);
            btnEnviar.TabIndex = 3;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
          
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(505, 483);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(112, 34);
            btnLimpar.TabIndex = 3;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 543);
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
    }
}
