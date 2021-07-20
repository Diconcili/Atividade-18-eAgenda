
namespace eAgenda.Windows
{
    partial class TelaContato
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelEmpresa = new System.Windows.Forms.Label();
            this.labelCargo = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelNomeContato = new System.Windows.Forms.Label();
            this.textBoxNomeContato = new System.Windows.Forms.TextBox();
            this.textBoxEmailContato = new System.Windows.Forms.TextBox();
            this.textBoxCargo = new System.Windows.Forms.TextBox();
            this.textBoxEmpresa = new System.Windows.Forms.TextBox();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxContatos = new System.Windows.Forms.GroupBox();
            this.dataGridContato = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSetContatos = new System.Data.DataSet();
            this.dataTableContato = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.botãoExcluir = new System.Windows.Forms.Button();
            this.botãoEditar = new System.Windows.Forms.Button();
            this.botãoCadastrar = new System.Windows.Forms.Button();
            this.groupBoxContatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetContatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableContato)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEmpresa
            // 
            this.labelEmpresa.AutoSize = true;
            this.labelEmpresa.Location = new System.Drawing.Point(385, 46);
            this.labelEmpresa.Name = "labelEmpresa";
            this.labelEmpresa.Size = new System.Drawing.Size(48, 13);
            this.labelEmpresa.TabIndex = 19;
            this.labelEmpresa.Text = "Empresa";
            // 
            // labelCargo
            // 
            this.labelCargo.AutoSize = true;
            this.labelCargo.Location = new System.Drawing.Point(244, 71);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(35, 13);
            this.labelCargo.TabIndex = 17;
            this.labelCargo.Text = "Cargo";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(244, 8);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(49, 13);
            this.labelTelefone.TabIndex = 15;
            this.labelTelefone.Text = "Telefone";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(9, 71);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(86, 13);
            this.labelEmail.TabIndex = 12;
            this.labelEmail.Text = "Email do contato";
            // 
            // labelNomeContato
            // 
            this.labelNomeContato.AutoSize = true;
            this.labelNomeContato.Location = new System.Drawing.Point(9, 8);
            this.labelNomeContato.Name = "labelNomeContato";
            this.labelNomeContato.Size = new System.Drawing.Size(90, 13);
            this.labelNomeContato.TabIndex = 11;
            this.labelNomeContato.Text = "Nome do Contato";
            // 
            // textBoxNomeContato
            // 
            this.textBoxNomeContato.Location = new System.Drawing.Point(12, 24);
            this.textBoxNomeContato.Name = "textBoxNomeContato";
            this.textBoxNomeContato.Size = new System.Drawing.Size(171, 20);
            this.textBoxNomeContato.TabIndex = 10;
            // 
            // textBoxEmailContato
            // 
            this.textBoxEmailContato.Location = new System.Drawing.Point(12, 87);
            this.textBoxEmailContato.Name = "textBoxEmailContato";
            this.textBoxEmailContato.Size = new System.Drawing.Size(171, 20);
            this.textBoxEmailContato.TabIndex = 20;
            // 
            // textBoxCargo
            // 
            this.textBoxCargo.Location = new System.Drawing.Point(247, 87);
            this.textBoxCargo.Name = "textBoxCargo";
            this.textBoxCargo.Size = new System.Drawing.Size(100, 20);
            this.textBoxCargo.TabIndex = 22;
            // 
            // textBoxEmpresa
            // 
            this.textBoxEmpresa.Location = new System.Drawing.Point(388, 62);
            this.textBoxEmpresa.Name = "textBoxEmpresa";
            this.textBoxEmpresa.Size = new System.Drawing.Size(127, 20);
            this.textBoxEmpresa.TabIndex = 23;
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(247, 24);
            this.maskedTextBoxTelefone.Mask = "(99) 00000-0000";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxTelefone.TabIndex = 24;
            // 
            // groupBoxContatos
            // 
            this.groupBoxContatos.Controls.Add(this.dataGridContato);
            this.groupBoxContatos.Location = new System.Drawing.Point(12, 213);
            this.groupBoxContatos.Name = "groupBoxContatos";
            this.groupBoxContatos.Size = new System.Drawing.Size(511, 286);
            this.groupBoxContatos.TabIndex = 25;
            this.groupBoxContatos.TabStop = false;
            this.groupBoxContatos.Text = "Contatos";
            // 
            // dataGridContato
            // 
            this.dataGridContato.AutoGenerateColumns = false;
            this.dataGridContato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridContato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.cargoDataGridViewTextBoxColumn,
            this.empresaDataGridViewTextBoxColumn});
            this.dataGridContato.DataMember = "TabelaContatos";
            this.dataGridContato.DataSource = this.dataSetContatos;
            this.dataGridContato.Location = new System.Drawing.Point(6, 19);
            this.dataGridContato.Name = "dataGridContato";
            this.dataGridContato.Size = new System.Drawing.Size(497, 261);
            this.dataGridContato.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // cargoDataGridViewTextBoxColumn
            // 
            this.cargoDataGridViewTextBoxColumn.DataPropertyName = "Cargo";
            this.cargoDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            // 
            // empresaDataGridViewTextBoxColumn
            // 
            this.empresaDataGridViewTextBoxColumn.DataPropertyName = "Empresa";
            this.empresaDataGridViewTextBoxColumn.HeaderText = "Empresa";
            this.empresaDataGridViewTextBoxColumn.Name = "empresaDataGridViewTextBoxColumn";
            // 
            // dataSetContatos
            // 
            this.dataSetContatos.DataSetName = "DataSetContatos";
            this.dataSetContatos.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTableContato});
            // 
            // dataTableContato
            // 
            this.dataTableContato.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6});
            this.dataTableContato.TableName = "TabelaContatos";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Id";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Nome";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Email";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Telefone";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Cargo";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "Empresa";
            // 
            // botãoExcluir
            // 
            this.botãoExcluir.Location = new System.Drawing.Point(24, 138);
            this.botãoExcluir.Name = "botãoExcluir";
            this.botãoExcluir.Size = new System.Drawing.Size(127, 43);
            this.botãoExcluir.TabIndex = 26;
            this.botãoExcluir.Text = "Excluir";
            this.botãoExcluir.UseVisualStyleBackColor = true;
            this.botãoExcluir.Click += new System.EventHandler(this.botãoExcluir_Click);
            // 
            // botãoEditar
            // 
            this.botãoEditar.Location = new System.Drawing.Point(200, 138);
            this.botãoEditar.Name = "botãoEditar";
            this.botãoEditar.Size = new System.Drawing.Size(127, 43);
            this.botãoEditar.TabIndex = 27;
            this.botãoEditar.Text = "Editar";
            this.botãoEditar.UseVisualStyleBackColor = true;
            this.botãoEditar.Click += new System.EventHandler(this.botãoEditar_Click);
            // 
            // botãoCadastrar
            // 
            this.botãoCadastrar.Location = new System.Drawing.Point(362, 138);
            this.botãoCadastrar.Name = "botãoCadastrar";
            this.botãoCadastrar.Size = new System.Drawing.Size(127, 43);
            this.botãoCadastrar.TabIndex = 28;
            this.botãoCadastrar.Text = "Cadastrar";
            this.botãoCadastrar.UseVisualStyleBackColor = true;
            this.botãoCadastrar.Click += new System.EventHandler(this.botãoCadastrar_Click);
            // 
            // TelaContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 511);
            this.Controls.Add(this.botãoCadastrar);
            this.Controls.Add(this.botãoEditar);
            this.Controls.Add(this.botãoExcluir);
            this.Controls.Add(this.groupBoxContatos);
            this.Controls.Add(this.maskedTextBoxTelefone);
            this.Controls.Add(this.textBoxEmpresa);
            this.Controls.Add(this.textBoxCargo);
            this.Controls.Add(this.textBoxEmailContato);
            this.Controls.Add(this.labelEmpresa);
            this.Controls.Add(this.labelCargo);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelNomeContato);
            this.Controls.Add(this.textBoxNomeContato);
            this.Name = "TelaContato";
            this.Text = "Menu de Contatos";
            this.groupBoxContatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetContatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableContato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmpresa;
        private System.Windows.Forms.Label labelCargo;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelNomeContato;
        private System.Windows.Forms.TextBox textBoxNomeContato;
        private System.Windows.Forms.TextBox textBoxEmailContato;
        private System.Windows.Forms.TextBox textBoxCargo;
        private System.Windows.Forms.TextBox textBoxEmpresa;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.GroupBox groupBoxContatos;
        private System.Windows.Forms.DataGridView dataGridContato;
        private System.Data.DataSet dataSetContatos;
        private System.Data.DataTable dataTableContato;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Windows.Forms.Button botãoExcluir;
        private System.Windows.Forms.Button botãoEditar;
        private System.Windows.Forms.Button botãoCadastrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaDataGridViewTextBoxColumn;
    }
}