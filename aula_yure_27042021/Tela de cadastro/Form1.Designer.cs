
namespace Tela_de_cadastro {
    partial class Form1 {
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
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.masked_cpf = new System.Windows.Forms.MaskedTextBox();
            this.masked_numero = new System.Windows.Forms.MaskedTextBox();
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(29, 14);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(43, 15);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome:";
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(29, 48);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(31, 15);
            this.lbl_cpf.TabIndex = 1;
            this.lbl_cpf.Text = "CPF:";
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Location = new System.Drawing.Point(29, 120);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(59, 15);
            this.lbl_endereco.TabIndex = 2;
            this.lbl_endereco.Text = "Endereço:";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(29, 83);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(54, 15);
            this.lbl_numero.TabIndex = 3;
            this.lbl_numero.Text = "Numero:";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(105, 11);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(255, 23);
            this.tb_nome.TabIndex = 4;
            // 
            // masked_cpf
            // 
            this.masked_cpf.Location = new System.Drawing.Point(105, 45);
            this.masked_cpf.Mask = "000,000,000-00";
            this.masked_cpf.Name = "masked_cpf";
            this.masked_cpf.Size = new System.Drawing.Size(85, 23);
            this.masked_cpf.TabIndex = 5;
            // 
            // masked_numero
            // 
            this.masked_numero.Location = new System.Drawing.Point(105, 80);
            this.masked_numero.Mask = "(99)99999-9999";
            this.masked_numero.Name = "masked_numero";
            this.masked_numero.Size = new System.Drawing.Size(85, 23);
            this.masked_numero.TabIndex = 6;
            // 
            // tb_endereco
            // 
            this.tb_endereco.Location = new System.Drawing.Point(105, 117);
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.Size = new System.Drawing.Size(255, 23);
            this.tb_endereco.TabIndex = 7;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(285, 163);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_adicionar.TabIndex = 8;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 15;
            this.lista.Location = new System.Drawing.Point(29, 201);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(331, 139);
            this.lista.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 363);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.tb_endereco);
            this.Controls.Add(this.masked_numero);
            this.Controls.Add(this.masked_cpf);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.lbl_endereco);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.lbl_nome);
            this.Name = "Form1";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.MaskedTextBox masked_cpf;
        private System.Windows.Forms.MaskedTextBox masked_numero;
        private System.Windows.Forms.TextBox tb_endereco;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.ListBox lista;
    }
}

