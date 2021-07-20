
namespace eAgenda.Windows
{
    partial class TelaMenuPrincipal
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
            this.botãoTarefas = new System.Windows.Forms.Button();
            this.botãoContatos = new System.Windows.Forms.Button();
            this.botãoCompromissos = new System.Windows.Forms.Button();
            this.botãoSair = new System.Windows.Forms.Button();
            this.labelMenuPrincipal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botãoTarefas
            // 
            this.botãoTarefas.Location = new System.Drawing.Point(92, 71);
            this.botãoTarefas.Name = "botãoTarefas";
            this.botãoTarefas.Size = new System.Drawing.Size(147, 54);
            this.botãoTarefas.TabIndex = 0;
            this.botãoTarefas.Text = "Tarefas";
            this.botãoTarefas.UseVisualStyleBackColor = true;
            this.botãoTarefas.Click += new System.EventHandler(this.botãoTarefas_Click);
            // 
            // botãoContatos
            // 
            this.botãoContatos.Location = new System.Drawing.Point(92, 154);
            this.botãoContatos.Name = "botãoContatos";
            this.botãoContatos.Size = new System.Drawing.Size(147, 54);
            this.botãoContatos.TabIndex = 1;
            this.botãoContatos.Text = "Contatos";
            this.botãoContatos.UseVisualStyleBackColor = true;
            this.botãoContatos.Click += new System.EventHandler(this.botãoContatos_Click);
            // 
            // botãoCompromissos
            // 
            this.botãoCompromissos.Location = new System.Drawing.Point(92, 241);
            this.botãoCompromissos.Name = "botãoCompromissos";
            this.botãoCompromissos.Size = new System.Drawing.Size(147, 54);
            this.botãoCompromissos.TabIndex = 2;
            this.botãoCompromissos.Text = "Compromissos";
            this.botãoCompromissos.UseVisualStyleBackColor = true;
            this.botãoCompromissos.Click += new System.EventHandler(this.botãoCompromissos_Click);
            // 
            // botãoSair
            // 
            this.botãoSair.Location = new System.Drawing.Point(92, 323);
            this.botãoSair.Name = "botãoSair";
            this.botãoSair.Size = new System.Drawing.Size(147, 54);
            this.botãoSair.TabIndex = 3;
            this.botãoSair.Text = "Sair";
            this.botãoSair.UseVisualStyleBackColor = true;
            this.botãoSair.Click += new System.EventHandler(this.botãoSair_Click);
            // 
            // labelMenuPrincipal
            // 
            this.labelMenuPrincipal.AutoSize = true;
            this.labelMenuPrincipal.Location = new System.Drawing.Point(127, 26);
            this.labelMenuPrincipal.Name = "labelMenuPrincipal";
            this.labelMenuPrincipal.Size = new System.Drawing.Size(77, 13);
            this.labelMenuPrincipal.TabIndex = 4;
            this.labelMenuPrincipal.Text = "Menu Principal";
            // 
            // TelaMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 414);
            this.Controls.Add(this.labelMenuPrincipal);
            this.Controls.Add(this.botãoSair);
            this.Controls.Add(this.botãoCompromissos);
            this.Controls.Add(this.botãoContatos);
            this.Controls.Add(this.botãoTarefas);
            this.Name = "TelaMenuPrincipal";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botãoTarefas;
        private System.Windows.Forms.Button botãoContatos;
        private System.Windows.Forms.Button botãoCompromissos;
        private System.Windows.Forms.Button botãoSair;
        private System.Windows.Forms.Label labelMenuPrincipal;
    }
}

