
namespace Tela_login {
    partial class F_autentication {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.btn_logar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_sair = new System.Windows.Forms.Button();
            this.link_cadastrar = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(87, 40);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(185, 23);
            this.tb_login.TabIndex = 0;
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(87, 78);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(185, 23);
            this.tb_senha.TabIndex = 1;
            // 
            // btn_logar
            // 
            this.btn_logar.Location = new System.Drawing.Point(197, 107);
            this.btn_logar.Name = "btn_logar";
            this.btn_logar.Size = new System.Drawing.Size(75, 23);
            this.btn_logar.TabIndex = 2;
            this.btn_logar.Text = "Logar";
            this.btn_logar.UseVisualStyleBackColor = true;
            this.btn_logar.Click += new System.EventHandler(this.btn_logar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "SENHA";
            // 
            // tb_sair
            // 
            this.tb_sair.Location = new System.Drawing.Point(87, 107);
            this.tb_sair.Name = "tb_sair";
            this.tb_sair.Size = new System.Drawing.Size(79, 23);
            this.tb_sair.TabIndex = 6;
            this.tb_sair.Text = "Sair";
            this.tb_sair.UseVisualStyleBackColor = true;
            this.tb_sair.Click += new System.EventHandler(this.tb_sair_Click);
            // 
            // link_cadastrar
            // 
            this.link_cadastrar.AutoSize = true;
            this.link_cadastrar.Location = new System.Drawing.Point(134, 133);
            this.link_cadastrar.Name = "link_cadastrar";
            this.link_cadastrar.Size = new System.Drawing.Size(90, 15);
            this.link_cadastrar.TabIndex = 7;
            this.link_cadastrar.TabStop = true;
            this.link_cadastrar.Text = "Cadastrar agora";
            this.link_cadastrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_cadastrar_LinkClicked);
            // 
            // F_autentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 155);
            this.Controls.Add(this.link_cadastrar);
            this.Controls.Add(this.tb_sair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_logar);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.tb_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "F_autentication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autenticação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Button btn_logar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tb_sair;
        private System.Windows.Forms.LinkLabel link_cadastrar;
    }
}

