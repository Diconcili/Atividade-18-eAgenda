
namespace eAgenda.Windows
{
    partial class TelaTarefa
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
            this.textBoxTituloTarefa = new System.Windows.Forms.TextBox();
            this.labelTituloTarefa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPrioridades = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxDataCriação = new System.Windows.Forms.MaskedTextBox();
            this.labelDataCriação = new System.Windows.Forms.Label();
            this.maskedTextBoxDataConclusão = new System.Windows.Forms.MaskedTextBox();
            this.labelDataConclusão = new System.Windows.Forms.Label();
            this.maskedTextBoxPorcentagem = new System.Windows.Forms.MaskedTextBox();
            this.labelPorcentagem = new System.Windows.Forms.Label();
            this.botãoTarefasConcluídas = new System.Windows.Forms.Button();
            this.botãoTarefasPendentes = new System.Windows.Forms.Button();
            this.botãoCadastrarNovaTarefa = new System.Windows.Forms.Button();
            this.dataGridTarefas = new System.Windows.Forms.DataGridView();
            this.groupBoxTarefa = new System.Windows.Forms.GroupBox();
            this.dataSetTarefas = new System.Data.DataSet();
            this.dataTableTarefa = new System.Data.DataTable();
            this.botãoVisualizarTodasTarefas = new System.Windows.Forms.Button();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioridadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentagemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDeInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDeConclusãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botãoEditar = new System.Windows.Forms.Button();
            this.botãoExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTarefas)).BeginInit();
            this.groupBoxTarefa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTarefas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableTarefa)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTituloTarefa
            // 
            this.textBoxTituloTarefa.Location = new System.Drawing.Point(8, 25);
            this.textBoxTituloTarefa.Name = "textBoxTituloTarefa";
            this.textBoxTituloTarefa.Size = new System.Drawing.Size(171, 20);
            this.textBoxTituloTarefa.TabIndex = 0;
            // 
            // labelTituloTarefa
            // 
            this.labelTituloTarefa.AutoSize = true;
            this.labelTituloTarefa.Location = new System.Drawing.Point(5, 9);
            this.labelTituloTarefa.Name = "labelTituloTarefa";
            this.labelTituloTarefa.Size = new System.Drawing.Size(82, 13);
            this.labelTituloTarefa.TabIndex = 1;
            this.labelTituloTarefa.Text = "Titulo da Tarefa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prioridade da Tarefa";
            // 
            // comboBoxPrioridades
            // 
            this.comboBoxPrioridades.FormattingEnabled = true;
            this.comboBoxPrioridades.Items.AddRange(new object[] {
            "Alta",
            "Normal",
            "Baixa"});
            this.comboBoxPrioridades.Location = new System.Drawing.Point(8, 88);
            this.comboBoxPrioridades.Name = "comboBoxPrioridades";
            this.comboBoxPrioridades.Size = new System.Drawing.Size(100, 21);
            this.comboBoxPrioridades.TabIndex = 3;
            this.comboBoxPrioridades.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrioridades_SelecionarItem);
            // 
            // maskedTextBoxDataCriação
            // 
            this.maskedTextBoxDataCriação.Location = new System.Drawing.Point(243, 25);
            this.maskedTextBoxDataCriação.Mask = "00/00/0000";
            this.maskedTextBoxDataCriação.Name = "maskedTextBoxDataCriação";
            this.maskedTextBoxDataCriação.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxDataCriação.TabIndex = 4;
            this.maskedTextBoxDataCriação.ValidatingType = typeof(System.DateTime);
            // 
            // labelDataCriação
            // 
            this.labelDataCriação.AutoSize = true;
            this.labelDataCriação.Location = new System.Drawing.Point(240, 9);
            this.labelDataCriação.Name = "labelDataCriação";
            this.labelDataCriação.Size = new System.Drawing.Size(83, 13);
            this.labelDataCriação.TabIndex = 5;
            this.labelDataCriação.Text = "Data de criação";
            // 
            // maskedTextBoxDataConclusão
            // 
            this.maskedTextBoxDataConclusão.Location = new System.Drawing.Point(243, 88);
            this.maskedTextBoxDataConclusão.Mask = "00/00/0000";
            this.maskedTextBoxDataConclusão.Name = "maskedTextBoxDataConclusão";
            this.maskedTextBoxDataConclusão.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxDataConclusão.TabIndex = 6;
            this.maskedTextBoxDataConclusão.ValidatingType = typeof(System.DateTime);
            // 
            // labelDataConclusão
            // 
            this.labelDataConclusão.AutoSize = true;
            this.labelDataConclusão.Location = new System.Drawing.Point(240, 72);
            this.labelDataConclusão.Name = "labelDataConclusão";
            this.labelDataConclusão.Size = new System.Drawing.Size(97, 13);
            this.labelDataConclusão.TabIndex = 7;
            this.labelDataConclusão.Text = "Data de conclusão";
            // 
            // maskedTextBoxPorcentagem
            // 
            this.maskedTextBoxPorcentagem.Location = new System.Drawing.Point(425, 54);
            this.maskedTextBoxPorcentagem.Mask = "00000";
            this.maskedTextBoxPorcentagem.Name = "maskedTextBoxPorcentagem";
            this.maskedTextBoxPorcentagem.Size = new System.Drawing.Size(60, 20);
            this.maskedTextBoxPorcentagem.TabIndex = 8;
            this.maskedTextBoxPorcentagem.ValidatingType = typeof(int);
            // 
            // labelPorcentagem
            // 
            this.labelPorcentagem.AutoSize = true;
            this.labelPorcentagem.Location = new System.Drawing.Point(422, 38);
            this.labelPorcentagem.Name = "labelPorcentagem";
            this.labelPorcentagem.Size = new System.Drawing.Size(70, 13);
            this.labelPorcentagem.TabIndex = 9;
            this.labelPorcentagem.Text = "Porcentagem";
            // 
            // botãoTarefasConcluídas
            // 
            this.botãoTarefasConcluídas.Location = new System.Drawing.Point(54, 143);
            this.botãoTarefasConcluídas.Name = "botãoTarefasConcluídas";
            this.botãoTarefasConcluídas.Size = new System.Drawing.Size(111, 35);
            this.botãoTarefasConcluídas.TabIndex = 10;
            this.botãoTarefasConcluídas.Text = "Visualizar tarefas concluídas";
            this.botãoTarefasConcluídas.UseVisualStyleBackColor = true;
            this.botãoTarefasConcluídas.Click += new System.EventHandler(this.botãoTarefasConcluídas_Click);
            // 
            // botãoTarefasPendentes
            // 
            this.botãoTarefasPendentes.Location = new System.Drawing.Point(54, 203);
            this.botãoTarefasPendentes.Name = "botãoTarefasPendentes";
            this.botãoTarefasPendentes.Size = new System.Drawing.Size(111, 35);
            this.botãoTarefasPendentes.TabIndex = 11;
            this.botãoTarefasPendentes.Text = "Visualizar tarefas pendentes";
            this.botãoTarefasPendentes.UseVisualStyleBackColor = true;
            this.botãoTarefasPendentes.Click += new System.EventHandler(this.botãoTarefasPendentes_Click);
            // 
            // botãoCadastrarNovaTarefa
            // 
            this.botãoCadastrarNovaTarefa.Location = new System.Drawing.Point(349, 143);
            this.botãoCadastrarNovaTarefa.Name = "botãoCadastrarNovaTarefa";
            this.botãoCadastrarNovaTarefa.Size = new System.Drawing.Size(111, 35);
            this.botãoCadastrarNovaTarefa.TabIndex = 12;
            this.botãoCadastrarNovaTarefa.Text = "Cadastrar nova tarefa";
            this.botãoCadastrarNovaTarefa.UseVisualStyleBackColor = true;
            this.botãoCadastrarNovaTarefa.Click += new System.EventHandler(this.botãoCadastrarNovaTarefa_Click);
            // 
            // dataGridTarefas
            // 
            this.dataGridTarefas.AutoGenerateColumns = false;
            this.dataGridTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTarefas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.prioridadeDataGridViewTextBoxColumn,
            this.porcentagemDataGridViewTextBoxColumn,
            this.dataDeInicioDataGridViewTextBoxColumn,
            this.dataDeConclusãoDataGridViewTextBoxColumn});
            this.dataGridTarefas.DataMember = "TabelaTarefas";
            this.dataGridTarefas.DataSource = this.dataSetTarefas;
            this.dataGridTarefas.Location = new System.Drawing.Point(6, 25);
            this.dataGridTarefas.Name = "dataGridTarefas";
            this.dataGridTarefas.Size = new System.Drawing.Size(496, 266);
            this.dataGridTarefas.TabIndex = 13;
            // 
            // groupBoxTarefa
            // 
            this.groupBoxTarefa.Controls.Add(this.dataGridTarefas);
            this.groupBoxTarefa.Location = new System.Drawing.Point(8, 255);
            this.groupBoxTarefa.Name = "groupBoxTarefa";
            this.groupBoxTarefa.Size = new System.Drawing.Size(511, 297);
            this.groupBoxTarefa.TabIndex = 14;
            this.groupBoxTarefa.TabStop = false;
            this.groupBoxTarefa.Text = "Tarefas";
            // 
            // dataSetTarefas
            // 
            this.dataSetTarefas.DataSetName = "NewDataSet";
            this.dataSetTarefas.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTableTarefa});
            // 
            // dataTableTarefa
            // 
            this.dataTableTarefa.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6});
            this.dataTableTarefa.TableName = "TabelaTarefas";
            // 
            // botãoVisualizarTodasTarefas
            // 
            this.botãoVisualizarTodasTarefas.Location = new System.Drawing.Point(198, 143);
            this.botãoVisualizarTodasTarefas.Name = "botãoVisualizarTodasTarefas";
            this.botãoVisualizarTodasTarefas.Size = new System.Drawing.Size(111, 35);
            this.botãoVisualizarTodasTarefas.TabIndex = 15;
            this.botãoVisualizarTodasTarefas.Text = "Visualizar todas as tarefas";
            this.botãoVisualizarTodasTarefas.UseVisualStyleBackColor = true;
            this.botãoVisualizarTodasTarefas.Click += new System.EventHandler(this.botãoVisualizarTodasTarefas_Click);
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Id";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Titulo";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Prioridade";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Porcentagem";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Data de Inicio";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "Data de Conclusão";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            // 
            // prioridadeDataGridViewTextBoxColumn
            // 
            this.prioridadeDataGridViewTextBoxColumn.DataPropertyName = "Prioridade";
            this.prioridadeDataGridViewTextBoxColumn.HeaderText = "Prioridade";
            this.prioridadeDataGridViewTextBoxColumn.Name = "prioridadeDataGridViewTextBoxColumn";
            // 
            // porcentagemDataGridViewTextBoxColumn
            // 
            this.porcentagemDataGridViewTextBoxColumn.DataPropertyName = "Porcentagem";
            this.porcentagemDataGridViewTextBoxColumn.HeaderText = "Porcentagem";
            this.porcentagemDataGridViewTextBoxColumn.Name = "porcentagemDataGridViewTextBoxColumn";
            // 
            // dataDeInicioDataGridViewTextBoxColumn
            // 
            this.dataDeInicioDataGridViewTextBoxColumn.DataPropertyName = "Data de Inicio";
            this.dataDeInicioDataGridViewTextBoxColumn.HeaderText = "Data de Inicio";
            this.dataDeInicioDataGridViewTextBoxColumn.Name = "dataDeInicioDataGridViewTextBoxColumn";
            // 
            // dataDeConclusãoDataGridViewTextBoxColumn
            // 
            this.dataDeConclusãoDataGridViewTextBoxColumn.DataPropertyName = "Data de Conclusão";
            this.dataDeConclusãoDataGridViewTextBoxColumn.HeaderText = "Data de Conclusão";
            this.dataDeConclusãoDataGridViewTextBoxColumn.Name = "dataDeConclusãoDataGridViewTextBoxColumn";
            // 
            // botãoEditar
            // 
            this.botãoEditar.Location = new System.Drawing.Point(198, 203);
            this.botãoEditar.Name = "botãoEditar";
            this.botãoEditar.Size = new System.Drawing.Size(111, 35);
            this.botãoEditar.TabIndex = 16;
            this.botãoEditar.Text = "Editar";
            this.botãoEditar.UseVisualStyleBackColor = true;
            this.botãoEditar.Click += new System.EventHandler(this.botãoEditar_Click);
            // 
            // botãoExcluir
            // 
            this.botãoExcluir.Location = new System.Drawing.Point(349, 203);
            this.botãoExcluir.Name = "botãoExcluir";
            this.botãoExcluir.Size = new System.Drawing.Size(111, 35);
            this.botãoExcluir.TabIndex = 17;
            this.botãoExcluir.Text = "Excluir";
            this.botãoExcluir.UseVisualStyleBackColor = true;
            this.botãoExcluir.Click += new System.EventHandler(this.botãoExcluir_Click);
            // 
            // TelaTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 564);
            this.Controls.Add(this.botãoExcluir);
            this.Controls.Add(this.botãoEditar);
            this.Controls.Add(this.botãoVisualizarTodasTarefas);
            this.Controls.Add(this.groupBoxTarefa);
            this.Controls.Add(this.botãoCadastrarNovaTarefa);
            this.Controls.Add(this.botãoTarefasPendentes);
            this.Controls.Add(this.botãoTarefasConcluídas);
            this.Controls.Add(this.labelPorcentagem);
            this.Controls.Add(this.maskedTextBoxPorcentagem);
            this.Controls.Add(this.labelDataConclusão);
            this.Controls.Add(this.maskedTextBoxDataConclusão);
            this.Controls.Add(this.labelDataCriação);
            this.Controls.Add(this.maskedTextBoxDataCriação);
            this.Controls.Add(this.comboBoxPrioridades);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTituloTarefa);
            this.Controls.Add(this.textBoxTituloTarefa);
            this.Name = "TelaTarefa";
            this.Text = "Menu de Tarefas";
            this.Load += new System.EventHandler(this.TelaTarefa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTarefas)).EndInit();
            this.groupBoxTarefa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTarefas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableTarefa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTituloTarefa;
        private System.Windows.Forms.Label labelTituloTarefa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPrioridades;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataCriação;
        private System.Windows.Forms.Label labelDataCriação;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataConclusão;
        private System.Windows.Forms.Label labelDataConclusão;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPorcentagem;
        private System.Windows.Forms.Label labelPorcentagem;
        private System.Windows.Forms.Button botãoTarefasConcluídas;
        private System.Windows.Forms.Button botãoTarefasPendentes;
        private System.Windows.Forms.Button botãoCadastrarNovaTarefa;
        private System.Windows.Forms.DataGridView dataGridTarefas;
        private System.Windows.Forms.GroupBox groupBoxTarefa;
        private System.Data.DataSet dataSetTarefas;
        private System.Data.DataTable dataTableTarefa;
        private System.Windows.Forms.Button botãoVisualizarTodasTarefas;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prioridadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentagemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDeInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDeConclusãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button botãoEditar;
        private System.Windows.Forms.Button botãoExcluir;
    }
}