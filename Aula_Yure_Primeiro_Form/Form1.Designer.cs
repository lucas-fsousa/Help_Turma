
namespace Principal
{
    partial class F_principal
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
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_add_nome = new System.Windows.Forms.TextBox();
            this.btn_lista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(196, 37);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_adicionar.TabIndex = 0;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite seu nome";
            // 
            // tb_add_nome
            // 
            this.tb_add_nome.Location = new System.Drawing.Point(12, 37);
            this.tb_add_nome.Name = "tb_add_nome";
            this.tb_add_nome.Size = new System.Drawing.Size(178, 23);
            this.tb_add_nome.TabIndex = 2;
            // 
            // btn_lista
            // 
            this.btn_lista.Location = new System.Drawing.Point(12, 108);
            this.btn_lista.Name = "btn_lista";
            this.btn_lista.Size = new System.Drawing.Size(259, 23);
            this.btn_lista.TabIndex = 3;
            this.btn_lista.Text = "Verificar lista de nomes";
            this.btn_lista.UseVisualStyleBackColor = true;
            this.btn_lista.Click += new System.EventHandler(this.btn_lista_Click);
            // 
            // F_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(283, 174);
            this.Controls.Add(this.btn_lista);
            this.Controls.Add(this.tb_add_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_adicionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_principal";
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_add_nome;
        private System.Windows.Forms.Button btn_lista;
    }
}

