namespace Exercicio4
{
    partial class Form_Usuario
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox_Usuario = new System.Windows.Forms.TextBox();
            this.textBox_Senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Sair = new System.Windows.Forms.Button();
            this.button_Acessar = new System.Windows.Forms.Button();
            this.toolTip_Usuario = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // textBox_Usuario
            // 
            this.textBox_Usuario.AccessibleDescription = "";
            this.textBox_Usuario.AccessibleName = "";
            this.textBox_Usuario.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.textBox_Usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Usuario.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_Usuario.Location = new System.Drawing.Point(126, 17);
            this.textBox_Usuario.Name = "textBox_Usuario";
            this.textBox_Usuario.Size = new System.Drawing.Size(205, 20);
            this.textBox_Usuario.TabIndex = 0;
            this.textBox_Usuario.Text = "Informe seu nome de usuário";
            this.toolTip_Usuario.SetToolTip(this.textBox_Usuario, "Nome do usuário");
            this.textBox_Usuario.Enter += new System.EventHandler(this.textBox_Usuario_Enter);
            this.textBox_Usuario.Leave += new System.EventHandler(this.textBox_Usuario_Leave);
            // 
            // textBox_Senha
            // 
            this.textBox_Senha.AccessibleDescription = "";
            this.textBox_Senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Senha.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_Senha.Location = new System.Drawing.Point(126, 55);
            this.textBox_Senha.Name = "textBox_Senha";
            this.textBox_Senha.Size = new System.Drawing.Size(205, 20);
            this.textBox_Senha.TabIndex = 1;
            this.textBox_Senha.Text = "Informe sua senha";
            this.toolTip_Usuario.SetToolTip(this.textBox_Senha, "Senha");
            this.textBox_Senha.Enter += new System.EventHandler(this.textBox_Senha_Enter);
            this.textBox_Senha.Leave += new System.EventHandler(this.textBox_Senha_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // button_Sair
            // 
            this.button_Sair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Sair.AutoSize = true;
            this.button_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sair.Image = global::Exercicio4.Properties.Resources.sair2;
            this.button_Sair.Location = new System.Drawing.Point(232, 93);
            this.button_Sair.Name = "button_Sair";
            this.button_Sair.Size = new System.Drawing.Size(99, 27);
            this.button_Sair.TabIndex = 5;
            this.button_Sair.Text = "Sair";
            this.button_Sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Sair.UseVisualStyleBackColor = true;
            this.button_Sair.Click += new System.EventHandler(this.button_Sair_Click);
            // 
            // button_Acessar
            // 
            this.button_Acessar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Acessar.AutoSize = true;
            this.button_Acessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Acessar.Image = global::Exercicio4.Properties.Resources.chave;
            this.button_Acessar.Location = new System.Drawing.Point(126, 93);
            this.button_Acessar.Name = "button_Acessar";
            this.button_Acessar.Size = new System.Drawing.Size(100, 27);
            this.button_Acessar.TabIndex = 4;
            this.button_Acessar.Text = "Acessar";
            this.button_Acessar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Acessar.UseVisualStyleBackColor = true;
            this.button_Acessar.Click += new System.EventHandler(this.button_Acessar_Click);
            // 
            // Form_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 140);
            this.Controls.Add(this.button_Sair);
            this.Controls.Add(this.button_Acessar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Senha);
            this.Controls.Add(this.textBox_Usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Identificação do Usuário";
            this.Load += new System.EventHandler(this.Form_Usuario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Usuario_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Usuario;
        private System.Windows.Forms.TextBox textBox_Senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Acessar;
        private System.Windows.Forms.Button button_Sair;
        private System.Windows.Forms.ToolTip toolTip_Usuario;
    }
}

