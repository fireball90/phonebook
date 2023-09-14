namespace Nevjegyzek
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nevLabel;
            System.Windows.Forms.Label iranyitoszamLabel;
            System.Windows.Forms.Label varosLabel;
            System.Windows.Forms.Label cimLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label mobilszamLabel;
            System.Windows.Forms.Label telefonszamLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.database = new Nevjegyzek.Database();
            this.nevekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nevekBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.nevekBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nevTextBox = new System.Windows.Forms.TextBox();
            this.iranyitoszamTextBox = new System.Windows.Forms.TextBox();
            this.varosTextBox = new System.Windows.Forms.TextBox();
            this.cimTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.mobilszamTextBox = new System.Windows.Forms.TextBox();
            this.telefonszamTextBox = new System.Windows.Forms.TextBox();
            this.nevekDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            nevLabel = new System.Windows.Forms.Label();
            iranyitoszamLabel = new System.Windows.Forms.Label();
            varosLabel = new System.Windows.Forms.Label();
            cimLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            mobilszamLabel = new System.Windows.Forms.Label();
            telefonszamLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nevekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nevekBindingNavigator)).BeginInit();
            this.nevekBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nevekDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nevLabel
            // 
            nevLabel.AutoSize = true;
            nevLabel.BackColor = System.Drawing.Color.Transparent;
            nevLabel.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            nevLabel.ForeColor = System.Drawing.Color.Yellow;
            nevLabel.Location = new System.Drawing.Point(16, 185);
            nevLabel.Name = "nevLabel";
            nevLabel.Size = new System.Drawing.Size(39, 13);
            nevLabel.TabIndex = 3;
            nevLabel.Text = "Nev:";
            // 
            // iranyitoszamLabel
            // 
            iranyitoszamLabel.AutoSize = true;
            iranyitoszamLabel.BackColor = System.Drawing.Color.Transparent;
            iranyitoszamLabel.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            iranyitoszamLabel.ForeColor = System.Drawing.Color.Yellow;
            iranyitoszamLabel.Location = new System.Drawing.Point(16, 222);
            iranyitoszamLabel.Name = "iranyitoszamLabel";
            iranyitoszamLabel.Size = new System.Drawing.Size(111, 13);
            iranyitoszamLabel.TabIndex = 5;
            iranyitoszamLabel.Text = "Iranyitoszam:";
            // 
            // varosLabel
            // 
            varosLabel.AutoSize = true;
            varosLabel.BackColor = System.Drawing.Color.Transparent;
            varosLabel.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            varosLabel.ForeColor = System.Drawing.Color.Yellow;
            varosLabel.Location = new System.Drawing.Point(16, 260);
            varosLabel.Name = "varosLabel";
            varosLabel.Size = new System.Drawing.Size(55, 13);
            varosLabel.TabIndex = 7;
            varosLabel.Text = "Varos:";
            // 
            // cimLabel
            // 
            cimLabel.AutoSize = true;
            cimLabel.BackColor = System.Drawing.Color.Transparent;
            cimLabel.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            cimLabel.ForeColor = System.Drawing.Color.Yellow;
            cimLabel.Location = new System.Drawing.Point(16, 298);
            cimLabel.Name = "cimLabel";
            cimLabel.Size = new System.Drawing.Size(39, 13);
            cimLabel.TabIndex = 9;
            cimLabel.Text = "Cim:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.Color.Transparent;
            emailLabel.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            emailLabel.ForeColor = System.Drawing.Color.Yellow;
            emailLabel.Location = new System.Drawing.Point(16, 401);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(55, 13);
            emailLabel.TabIndex = 11;
            emailLabel.Text = "Email:";
            // 
            // mobilszamLabel
            // 
            mobilszamLabel.AutoSize = true;
            mobilszamLabel.BackColor = System.Drawing.Color.Transparent;
            mobilszamLabel.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            mobilszamLabel.ForeColor = System.Drawing.Color.Yellow;
            mobilszamLabel.Location = new System.Drawing.Point(16, 436);
            mobilszamLabel.Name = "mobilszamLabel";
            mobilszamLabel.Size = new System.Drawing.Size(87, 13);
            mobilszamLabel.TabIndex = 13;
            mobilszamLabel.Text = "Mobilszam:";
            // 
            // telefonszamLabel
            // 
            telefonszamLabel.AutoSize = true;
            telefonszamLabel.BackColor = System.Drawing.Color.Transparent;
            telefonszamLabel.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            telefonszamLabel.ForeColor = System.Drawing.Color.Yellow;
            telefonszamLabel.Location = new System.Drawing.Point(16, 474);
            telefonszamLabel.Name = "telefonszamLabel";
            telefonszamLabel.Size = new System.Drawing.Size(103, 13);
            telefonszamLabel.TabIndex = 15;
            telefonszamLabel.Text = "Telefonszam:";
            // 
            // database
            // 
            this.database.DataSetName = "Database";
            this.database.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nevekBindingSource
            // 
            this.nevekBindingSource.DataMember = "Nevek";
            this.nevekBindingSource.DataSource = this.database;
            // 
            // nevekBindingNavigator
            // 
            this.nevekBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.nevekBindingNavigator.BindingSource = this.nevekBindingSource;
            this.nevekBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.nevekBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.nevekBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.nevekBindingNavigatorSaveItem});
            this.nevekBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.nevekBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nevekBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nevekBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nevekBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nevekBindingNavigator.Name = "nevekBindingNavigator";
            this.nevekBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.nevekBindingNavigator.Size = new System.Drawing.Size(1073, 25);
            this.nevekBindingNavigator.TabIndex = 0;
            this.nevekBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // nevekBindingNavigatorSaveItem
            // 
            this.nevekBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nevekBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("nevekBindingNavigatorSaveItem.Image")));
            this.nevekBindingNavigatorSaveItem.Name = "nevekBindingNavigatorSaveItem";
            this.nevekBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.nevekBindingNavigatorSaveItem.Text = "Save Data";
            this.nevekBindingNavigatorSaveItem.Click += new System.EventHandler(this.nevekBindingNavigatorSaveItem_Click);
            // 
            // nevTextBox
            // 
            this.nevTextBox.BackColor = System.Drawing.Color.White;
            this.nevTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nevTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nevekBindingSource, "Nev", true));
            this.nevTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nevTextBox.ForeColor = System.Drawing.Color.Black;
            this.nevTextBox.Location = new System.Drawing.Point(135, 182);
            this.nevTextBox.Name = "nevTextBox";
            this.nevTextBox.Size = new System.Drawing.Size(298, 20);
            this.nevTextBox.TabIndex = 0;
            // 
            // iranyitoszamTextBox
            // 
            this.iranyitoszamTextBox.BackColor = System.Drawing.Color.White;
            this.iranyitoszamTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iranyitoszamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nevekBindingSource, "Iranyitoszam", true));
            this.iranyitoszamTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iranyitoszamTextBox.ForeColor = System.Drawing.Color.Black;
            this.iranyitoszamTextBox.Location = new System.Drawing.Point(135, 218);
            this.iranyitoszamTextBox.Name = "iranyitoszamTextBox";
            this.iranyitoszamTextBox.Size = new System.Drawing.Size(298, 20);
            this.iranyitoszamTextBox.TabIndex = 1;
            // 
            // varosTextBox
            // 
            this.varosTextBox.BackColor = System.Drawing.Color.White;
            this.varosTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.varosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nevekBindingSource, "Varos", true));
            this.varosTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.varosTextBox.ForeColor = System.Drawing.Color.Black;
            this.varosTextBox.Location = new System.Drawing.Point(135, 255);
            this.varosTextBox.Name = "varosTextBox";
            this.varosTextBox.Size = new System.Drawing.Size(298, 20);
            this.varosTextBox.TabIndex = 2;
            // 
            // cimTextBox
            // 
            this.cimTextBox.BackColor = System.Drawing.Color.White;
            this.cimTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cimTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nevekBindingSource, "Cim", true));
            this.cimTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cimTextBox.ForeColor = System.Drawing.Color.Black;
            this.cimTextBox.Location = new System.Drawing.Point(135, 295);
            this.cimTextBox.Multiline = true;
            this.cimTextBox.Name = "cimTextBox";
            this.cimTextBox.Size = new System.Drawing.Size(298, 83);
            this.cimTextBox.TabIndex = 3;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.White;
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nevekBindingSource, "Email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailTextBox.ForeColor = System.Drawing.Color.Black;
            this.emailTextBox.Location = new System.Drawing.Point(135, 396);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(298, 20);
            this.emailTextBox.TabIndex = 4;
            // 
            // mobilszamTextBox
            // 
            this.mobilszamTextBox.BackColor = System.Drawing.Color.White;
            this.mobilszamTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mobilszamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nevekBindingSource, "Mobilszam", true));
            this.mobilszamTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mobilszamTextBox.ForeColor = System.Drawing.Color.Black;
            this.mobilszamTextBox.Location = new System.Drawing.Point(135, 432);
            this.mobilszamTextBox.Name = "mobilszamTextBox";
            this.mobilszamTextBox.Size = new System.Drawing.Size(298, 20);
            this.mobilszamTextBox.TabIndex = 5;
            // 
            // telefonszamTextBox
            // 
            this.telefonszamTextBox.BackColor = System.Drawing.Color.White;
            this.telefonszamTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telefonszamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nevekBindingSource, "Telefonszam", true));
            this.telefonszamTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.telefonszamTextBox.ForeColor = System.Drawing.Color.Black;
            this.telefonszamTextBox.Location = new System.Drawing.Point(135, 470);
            this.telefonszamTextBox.Name = "telefonszamTextBox";
            this.telefonszamTextBox.Size = new System.Drawing.Size(298, 20);
            this.telefonszamTextBox.TabIndex = 6;
            // 
            // nevekDataGridView
            // 
            this.nevekDataGridView.AutoGenerateColumns = false;
            this.nevekDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nevekDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.nevekDataGridView.DataSource = this.nevekBindingSource;
            this.nevekDataGridView.Location = new System.Drawing.Point(452, 134);
            this.nevekDataGridView.Name = "nevekDataGridView";
            this.nevekDataGridView.Size = new System.Drawing.Size(609, 356);
            this.nevekDataGridView.TabIndex = 16;
            this.nevekDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nevekDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nev";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nev";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Iranyitoszam";
            this.dataGridViewTextBoxColumn3.HeaderText = "Iranyitoszam";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Varos";
            this.dataGridViewTextBoxColumn4.HeaderText = "Varos";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Cim";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cim";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn6.HeaderText = "Email";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Mobilszam";
            this.dataGridViewTextBoxColumn7.HeaderText = "Mobilszam";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Telefonszam";
            this.dataGridViewTextBoxColumn8.HeaderText = "Telefonszam";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Nevjegyzek.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(115, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(451, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Keresés:";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(552, 105);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(509, 20);
            this.searchBox.TabIndex = 7;
            this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBox_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(30)))));
            this.BackgroundImage = global::Nevjegyzek.Properties.Resources.progbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1073, 572);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nevekDataGridView);
            this.Controls.Add(nevLabel);
            this.Controls.Add(this.nevTextBox);
            this.Controls.Add(iranyitoszamLabel);
            this.Controls.Add(this.iranyitoszamTextBox);
            this.Controls.Add(varosLabel);
            this.Controls.Add(this.varosTextBox);
            this.Controls.Add(cimLabel);
            this.Controls.Add(this.cimTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(mobilszamLabel);
            this.Controls.Add(this.mobilszamTextBox);
            this.Controls.Add(telefonszamLabel);
            this.Controls.Add(this.telefonszamTextBox);
            this.Controls.Add(this.nevekBindingNavigator);
            this.Name = "Form1";
            this.Text = "Nevjegyzek";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nevekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nevekBindingNavigator)).EndInit();
            this.nevekBindingNavigator.ResumeLayout(false);
            this.nevekBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nevekDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database database;
        private System.Windows.Forms.BindingSource nevekBindingSource;
        private System.Windows.Forms.BindingNavigator nevekBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton nevekBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nevTextBox;
        private System.Windows.Forms.TextBox iranyitoszamTextBox;
        private System.Windows.Forms.TextBox varosTextBox;
        private System.Windows.Forms.TextBox cimTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox mobilszamTextBox;
        private System.Windows.Forms.TextBox telefonszamTextBox;
        private System.Windows.Forms.DataGridView nevekDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBox;
    }
}

