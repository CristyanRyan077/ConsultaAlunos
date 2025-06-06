namespace Escola
{
    partial class frmControleDeAlunos
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
            System.Windows.Forms.Label iD_ALUNOLabel;
            System.Windows.Forms.Label nOMELabel;
            System.Windows.Forms.Label tELEFONELabel;
            System.Windows.Forms.Label eMAILLabel;
            System.Windows.Forms.Label cURSOLabel;
            System.Windows.Forms.Label nASCIMENTOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControleDeAlunos));
            this.tcAlunos = new System.Windows.Forms.TabControl();
            this.tpCadastro = new System.Windows.Forms.TabPage();
            this.alunosDataGridView = new System.Windows.Forms.DataGridView();
            this.alunosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.alunosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_ALUNOTextBox = new System.Windows.Forms.TextBox();
            this.nOMETextBox = new System.Windows.Forms.TextBox();
            this.tELEFONETextBox = new System.Windows.Forms.TextBox();
            this.eMAILTextBox = new System.Windows.Forms.TextBox();
            this.cURSOTextBox = new System.Windows.Forms.TextBox();
            this.nASCIMENTODateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tpPesquisas = new System.Windows.Forms.TabPage();
            this.rbCurso = new System.Windows.Forms.RadioButton();
            this.rbAluno = new System.Windows.Forms.RadioButton();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.dtgPesquisas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alunosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.escolaDataSet = new Escola.EscolaDataSet();
            this.cursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunosTableAdapter = new Escola.EscolaDataSetTableAdapters.AlunosTableAdapter();
            this.tableAdapterManager = new Escola.EscolaDataSetTableAdapters.TableAdapterManager();
            this.cursosTableAdapter = new Escola.EscolaDataSetTableAdapters.CursosTableAdapter();
            iD_ALUNOLabel = new System.Windows.Forms.Label();
            nOMELabel = new System.Windows.Forms.Label();
            tELEFONELabel = new System.Windows.Forms.Label();
            eMAILLabel = new System.Windows.Forms.Label();
            cURSOLabel = new System.Windows.Forms.Label();
            nASCIMENTOLabel = new System.Windows.Forms.Label();
            this.tcAlunos.SuspendLayout();
            this.tpCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alunosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingNavigator)).BeginInit();
            this.alunosBindingNavigator.SuspendLayout();
            this.tpPesquisas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escolaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_ALUNOLabel
            // 
            iD_ALUNOLabel.AutoSize = true;
            iD_ALUNOLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_ALUNOLabel.Location = new System.Drawing.Point(34, 46);
            iD_ALUNOLabel.Name = "iD_ALUNOLabel";
            iD_ALUNOLabel.Size = new System.Drawing.Size(64, 18);
            iD_ALUNOLabel.TabIndex = 0;
            iD_ALUNOLabel.Text = "Código:";
            // 
            // nOMELabel
            // 
            nOMELabel.AutoSize = true;
            nOMELabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nOMELabel.Location = new System.Drawing.Point(34, 77);
            nOMELabel.Name = "nOMELabel";
            nOMELabel.Size = new System.Drawing.Size(59, 18);
            nOMELabel.TabIndex = 2;
            nOMELabel.Text = "NOME:";
            // 
            // tELEFONELabel
            // 
            tELEFONELabel.AutoSize = true;
            tELEFONELabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tELEFONELabel.Location = new System.Drawing.Point(34, 108);
            tELEFONELabel.Name = "tELEFONELabel";
            tELEFONELabel.Size = new System.Drawing.Size(91, 18);
            tELEFONELabel.TabIndex = 4;
            tELEFONELabel.Text = "TELEFONE:";
            // 
            // eMAILLabel
            // 
            eMAILLabel.AutoSize = true;
            eMAILLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            eMAILLabel.Location = new System.Drawing.Point(34, 139);
            eMAILLabel.Name = "eMAILLabel";
            eMAILLabel.Size = new System.Drawing.Size(61, 18);
            eMAILLabel.TabIndex = 6;
            eMAILLabel.Text = "EMAIL:";
            // 
            // cURSOLabel
            // 
            cURSOLabel.AutoSize = true;
            cURSOLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cURSOLabel.Location = new System.Drawing.Point(34, 170);
            cURSOLabel.Name = "cURSOLabel";
            cURSOLabel.Size = new System.Drawing.Size(67, 18);
            cURSOLabel.TabIndex = 8;
            cURSOLabel.Text = "CURSO:";
            // 
            // nASCIMENTOLabel
            // 
            nASCIMENTOLabel.AutoSize = true;
            nASCIMENTOLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nASCIMENTOLabel.Location = new System.Drawing.Point(34, 201);
            nASCIMENTOLabel.Name = "nASCIMENTOLabel";
            nASCIMENTOLabel.Size = new System.Drawing.Size(117, 18);
            nASCIMENTOLabel.TabIndex = 10;
            nASCIMENTOLabel.Text = "NASCIMENTO:";
            // 
            // tcAlunos
            // 
            this.tcAlunos.Controls.Add(this.tpCadastro);
            this.tcAlunos.Controls.Add(this.tpPesquisas);
            this.tcAlunos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcAlunos.Location = new System.Drawing.Point(0, 0);
            this.tcAlunos.Name = "tcAlunos";
            this.tcAlunos.SelectedIndex = 0;
            this.tcAlunos.Size = new System.Drawing.Size(583, 525);
            this.tcAlunos.TabIndex = 0;
            // 
            // tpCadastro
            // 
            this.tpCadastro.AutoScroll = true;
            this.tpCadastro.Controls.Add(this.alunosDataGridView);
            this.tpCadastro.Controls.Add(this.alunosBindingNavigator);
            this.tpCadastro.Controls.Add(iD_ALUNOLabel);
            this.tpCadastro.Controls.Add(this.iD_ALUNOTextBox);
            this.tpCadastro.Controls.Add(nOMELabel);
            this.tpCadastro.Controls.Add(this.nOMETextBox);
            this.tpCadastro.Controls.Add(tELEFONELabel);
            this.tpCadastro.Controls.Add(this.tELEFONETextBox);
            this.tpCadastro.Controls.Add(eMAILLabel);
            this.tpCadastro.Controls.Add(this.eMAILTextBox);
            this.tpCadastro.Controls.Add(cURSOLabel);
            this.tpCadastro.Controls.Add(this.cURSOTextBox);
            this.tpCadastro.Controls.Add(nASCIMENTOLabel);
            this.tpCadastro.Controls.Add(this.nASCIMENTODateTimePicker);
            this.tpCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpCadastro.Location = new System.Drawing.Point(4, 22);
            this.tpCadastro.Name = "tpCadastro";
            this.tpCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tpCadastro.Size = new System.Drawing.Size(618, 499);
            this.tpCadastro.TabIndex = 0;
            this.tpCadastro.Text = "Cadastro";
            this.tpCadastro.UseVisualStyleBackColor = true;
            // 
            // alunosDataGridView
            // 
            this.alunosDataGridView.AllowUserToAddRows = false;
            this.alunosDataGridView.AllowUserToDeleteRows = false;
            this.alunosDataGridView.AutoGenerateColumns = false;
            this.alunosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alunosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.alunosDataGridView.DataSource = this.alunosBindingSource;
            this.alunosDataGridView.Location = new System.Drawing.Point(0, 229);
            this.alunosDataGridView.Name = "alunosDataGridView";
            this.alunosDataGridView.ReadOnly = true;
            this.alunosDataGridView.RowHeadersVisible = false;
            this.alunosDataGridView.Size = new System.Drawing.Size(615, 250);
            this.alunosDataGridView.TabIndex = 13;
            // 
            // alunosBindingNavigator
            // 
            this.alunosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.alunosBindingNavigator.BindingSource = this.alunosBindingSource;
            this.alunosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.alunosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.alunosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.alunosBindingNavigatorSaveItem});
            this.alunosBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.alunosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.alunosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.alunosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.alunosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.alunosBindingNavigator.Name = "alunosBindingNavigator";
            this.alunosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.alunosBindingNavigator.Size = new System.Drawing.Size(612, 25);
            this.alunosBindingNavigator.TabIndex = 1;
            this.alunosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // alunosBindingNavigatorSaveItem
            // 
            this.alunosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alunosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("alunosBindingNavigatorSaveItem.Image")));
            this.alunosBindingNavigatorSaveItem.Name = "alunosBindingNavigatorSaveItem";
            this.alunosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.alunosBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.alunosBindingNavigatorSaveItem.Click += new System.EventHandler(this.alunosBindingNavigatorSaveItem_Click);
            // 
            // iD_ALUNOTextBox
            // 
            this.iD_ALUNOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunosBindingSource, "ID_ALUNO", true));
            this.iD_ALUNOTextBox.Enabled = false;
            this.iD_ALUNOTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_ALUNOTextBox.Location = new System.Drawing.Point(156, 42);
            this.iD_ALUNOTextBox.Name = "iD_ALUNOTextBox";
            this.iD_ALUNOTextBox.Size = new System.Drawing.Size(75, 26);
            this.iD_ALUNOTextBox.TabIndex = 1;
            // 
            // nOMETextBox
            // 
            this.nOMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunosBindingSource, "NOME", true));
            this.nOMETextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nOMETextBox.Location = new System.Drawing.Point(156, 73);
            this.nOMETextBox.Name = "nOMETextBox";
            this.nOMETextBox.Size = new System.Drawing.Size(285, 26);
            this.nOMETextBox.TabIndex = 3;
            // 
            // tELEFONETextBox
            // 
            this.tELEFONETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunosBindingSource, "TELEFONE", true));
            this.tELEFONETextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tELEFONETextBox.Location = new System.Drawing.Point(156, 104);
            this.tELEFONETextBox.Name = "tELEFONETextBox";
            this.tELEFONETextBox.Size = new System.Drawing.Size(131, 26);
            this.tELEFONETextBox.TabIndex = 5;
            // 
            // eMAILTextBox
            // 
            this.eMAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunosBindingSource, "EMAIL", true));
            this.eMAILTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eMAILTextBox.Location = new System.Drawing.Point(156, 136);
            this.eMAILTextBox.Name = "eMAILTextBox";
            this.eMAILTextBox.Size = new System.Drawing.Size(285, 26);
            this.eMAILTextBox.TabIndex = 7;
            // 
            // cURSOTextBox
            // 
            this.cURSOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunosBindingSource, "CURSO", true));
            this.cURSOTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cURSOTextBox.Location = new System.Drawing.Point(156, 166);
            this.cURSOTextBox.Name = "cURSOTextBox";
            this.cURSOTextBox.Size = new System.Drawing.Size(285, 26);
            this.cURSOTextBox.TabIndex = 9;
            // 
            // nASCIMENTODateTimePicker
            // 
            this.nASCIMENTODateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.alunosBindingSource, "NASCIMENTO", true));
            this.nASCIMENTODateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nASCIMENTODateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.nASCIMENTODateTimePicker.Location = new System.Drawing.Point(156, 197);
            this.nASCIMENTODateTimePicker.Name = "nASCIMENTODateTimePicker";
            this.nASCIMENTODateTimePicker.Size = new System.Drawing.Size(131, 26);
            this.nASCIMENTODateTimePicker.TabIndex = 11;
            // 
            // tpPesquisas
            // 
            this.tpPesquisas.Controls.Add(this.dtgPesquisas);
            this.tpPesquisas.Controls.Add(this.rbCurso);
            this.tpPesquisas.Controls.Add(this.rbAluno);
            this.tpPesquisas.Controls.Add(this.btnPesquisa);
            this.tpPesquisas.Controls.Add(this.txtPesquisar);
            this.tpPesquisas.Location = new System.Drawing.Point(4, 22);
            this.tpPesquisas.Name = "tpPesquisas";
            this.tpPesquisas.Padding = new System.Windows.Forms.Padding(3);
            this.tpPesquisas.Size = new System.Drawing.Size(575, 499);
            this.tpPesquisas.TabIndex = 1;
            this.tpPesquisas.Text = "Pesquisas";
            this.tpPesquisas.UseVisualStyleBackColor = true;
            // 
            // rbCurso
            // 
            this.rbCurso.AutoSize = true;
            this.rbCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCurso.Location = new System.Drawing.Point(108, 63);
            this.rbCurso.Name = "rbCurso";
            this.rbCurso.Size = new System.Drawing.Size(65, 20);
            this.rbCurso.TabIndex = 2;
            this.rbCurso.TabStop = true;
            this.rbCurso.Text = "Curso";
            this.rbCurso.UseVisualStyleBackColor = true;
            // 
            // rbAluno
            // 
            this.rbAluno.AutoSize = true;
            this.rbAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAluno.Location = new System.Drawing.Point(23, 63);
            this.rbAluno.Name = "rbAluno";
            this.rbAluno.Size = new System.Drawing.Size(64, 20);
            this.rbAluno.TabIndex = 2;
            this.rbAluno.TabStop = true;
            this.rbAluno.Text = "Aluno";
            this.rbAluno.UseVisualStyleBackColor = true;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(434, 13);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 40);
            this.btnPesquisa.TabIndex = 1;
            this.btnPesquisa.Text = "Pesquisa";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(23, 19);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(395, 26);
            this.txtPesquisar.TabIndex = 0;
            // 
            // dtgPesquisas
            // 
            this.dtgPesquisas.AllowUserToAddRows = false;
            this.dtgPesquisas.AllowUserToDeleteRows = false;
            this.dtgPesquisas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPesquisas.Location = new System.Drawing.Point(0, 132);
            this.dtgPesquisas.Name = "dtgPesquisas";
            this.dtgPesquisas.ReadOnly = true;
            this.dtgPesquisas.RowHeadersVisible = false;
            this.dtgPesquisas.Size = new System.Drawing.Size(575, 367);
            this.dtgPesquisas.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_ALUNO";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TELEFONE";
            this.dataGridViewTextBoxColumn3.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 140;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "EMAIL";
            this.dataGridViewTextBoxColumn4.HeaderText = "EMAIL";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 140;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CURSO";
            this.dataGridViewTextBoxColumn5.HeaderText = "Curso";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 160;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NASCIMENTO";
            this.dataGridViewTextBoxColumn6.HeaderText = "NASCIMENTO";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // alunosBindingSource
            // 
            this.alunosBindingSource.DataMember = "Alunos";
            this.alunosBindingSource.DataSource = this.escolaDataSet;
            // 
            // escolaDataSet
            // 
            this.escolaDataSet.DataSetName = "EscolaDataSet";
            this.escolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cursosBindingSource
            // 
            this.cursosBindingSource.DataMember = "Cursos";
            this.cursosBindingSource.DataSource = this.escolaDataSet;
            // 
            // alunosTableAdapter
            // 
            this.alunosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunosTableAdapter = this.alunosTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CursosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Escola.EscolaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cursosTableAdapter
            // 
            this.cursosTableAdapter.ClearBeforeFill = true;
            // 
            // frmControleDeAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 525);
            this.Controls.Add(this.tcAlunos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmControleDeAlunos";
            this.Text = "Controle de Alunos";
            this.Load += new System.EventHandler(this.frmControleDeAlunos_Load);
            this.tcAlunos.ResumeLayout(false);
            this.tpCadastro.ResumeLayout(false);
            this.tpCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alunosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingNavigator)).EndInit();
            this.alunosBindingNavigator.ResumeLayout(false);
            this.alunosBindingNavigator.PerformLayout();
            this.tpPesquisas.ResumeLayout(false);
            this.tpPesquisas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escolaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tcAlunos;
        private System.Windows.Forms.TabPage tpCadastro;
        private System.Windows.Forms.TabPage tpPesquisas;
        private EscolaDataSet escolaDataSet;
        private System.Windows.Forms.BindingSource alunosBindingSource;
        private EscolaDataSetTableAdapters.AlunosTableAdapter alunosTableAdapter;
        private EscolaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator alunosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton alunosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_ALUNOTextBox;
        private System.Windows.Forms.TextBox nOMETextBox;
        private System.Windows.Forms.TextBox tELEFONETextBox;
        private System.Windows.Forms.TextBox eMAILTextBox;
        private System.Windows.Forms.TextBox cURSOTextBox;
        private System.Windows.Forms.DateTimePicker nASCIMENTODateTimePicker;
        private System.Windows.Forms.DataGridView alunosDataGridView;
        private System.Windows.Forms.RadioButton rbCurso;
        private System.Windows.Forms.RadioButton rbAluno;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.BindingSource cursosBindingSource;
        private EscolaDataSetTableAdapters.CursosTableAdapter cursosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridView dtgPesquisas;
    }
}

