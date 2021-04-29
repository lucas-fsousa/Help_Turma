
namespace Tela_login.Apresenta {
    partial class F_cadastrar {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_log_cadstrar = new System.Windows.Forms.TextBox();
            this.tb_senha_cadst = new System.Windows.Forms.TextBox();
            this.tb_conf_senha_cadstr = new System.Windows.Forms.TextBox();
            this.btn_cadast_cadst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "SENHA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "RE-SENHA";
            // 
            // tb_log_cadstrar
            // 
            this.tb_log_cadstrar.Location = new System.Drawing.Point(92, 22);
            this.tb_log_cadstrar.Name = "tb_log_cadstrar";
            this.tb_log_cadstrar.Size = new System.Drawing.Size(141, 23);
            this.tb_log_cadstrar.TabIndex = 3;
            // 
            // tb_senha_cadst
            // 
            this.tb_senha_cadst.Location = new System.Drawing.Point(92, 61);
            this.tb_senha_cadst.Name = "tb_senha_cadst";
            this.tb_senha_cadst.PasswordChar = '*';
            this.tb_senha_cadst.Size = new System.Drawing.Size(141, 23);
            this.tb_senha_cadst.TabIndex = 4;
            // 
            // tb_conf_senha_cadstr
            // 
            this.tb_conf_senha_cadstr.Location = new System.Drawing.Point(92, 102);
            this.tb_conf_senha_cadstr.Name = "tb_conf_senha_cadstr";
            this.tb_conf_senha_cadstr.PasswordChar = '*';
            this.tb_conf_senha_cadstr.Size = new System.Drawing.Size(141, 23);
            this.tb_conf_senha_cadstr.TabIndex = 5;
            // 
            // btn_cadast_cadst
            // 
            this.btn_cadast_cadst.Location = new System.Drawing.Point(92, 146);
            this.btn_cadast_cadst.Name = "btn_cadast_cadst";
            this.btn_cadast_cadst.Size = new System.Drawing.Size(78, 23);
            this.btn_cadast_cadst.TabIndex = 6;
            this.btn_cadast_cadst.Text = "Concluir";
            this.btn_cadast_cadst.UseVisualStyleBackColor = true;
            this.btn_cadast_cadst.Click += new System.EventHandler(this.btn_cadast_cadst_Click);
            // 
            // F_cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 188);
            this.Controls.Add(this.btn_cadast_cadst);
            this.Controls.Add(this.tb_conf_senha_cadstr);
            this.Controls.Add(this.tb_senha_cadst);
            this.Controls.Add(this.tb_log_cadstrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "F_cadastrar";
            this.Text = "Cadastrar novo user";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_log_cadstrar;
        private System.Windows.Forms.TextBox tb_senha_cadst;
        private System.Windows.Forms.TextBox tb_conf_senha_cadstr;
        private System.Windows.Forms.Button btn_cadast_cadst;
    }
}