namespace mp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.si_inventariosDataSet = new mp.si_inventariosDataSet();
            this.inventariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventariosTableAdapter = new mp.si_inventariosDataSetTableAdapters.inventariosTableAdapter();
            this.tableAdapterManager = new mp.si_inventariosDataSetTableAdapters.TableAdapterManager();
            this.inventariosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.inventariosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.inventariosDataGridView = new System.Windows.Forms.DataGridView();
            this.tb_p = new System.Windows.Forms.TextBox();
            this.inventariosDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.si_inventariosDataSet1 = new mp.si_inventariosDataSet1();
            this.inventariosTableAdapter1 = new mp.si_inventariosDataSet1TableAdapters.inventariosTableAdapter();
            this.tb_m = new System.Windows.Forms.TextBox();
            this.tb_c = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.si_inventariosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventariosBindingNavigator)).BeginInit();
            this.inventariosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventariosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventariosDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventariosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.si_inventariosDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Insertar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // si_inventariosDataSet
            // 
            this.si_inventariosDataSet.DataSetName = "si_inventariosDataSet";
            this.si_inventariosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventariosBindingSource
            // 
            this.inventariosBindingSource.DataMember = "inventarios";
            this.inventariosBindingSource.DataSource = this.si_inventariosDataSet;
            // 
            // inventariosTableAdapter
            // 
            this.inventariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.inventariosTableAdapter = this.inventariosTableAdapter;
            this.tableAdapterManager.materiaporproductoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = mp.si_inventariosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // inventariosBindingNavigator
            // 
            this.inventariosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.inventariosBindingNavigator.BindingSource = this.inventariosBindingSource;
            this.inventariosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.inventariosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.inventariosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.inventariosBindingNavigatorSaveItem});
            this.inventariosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.inventariosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.inventariosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.inventariosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.inventariosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.inventariosBindingNavigator.Name = "inventariosBindingNavigator";
            this.inventariosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.inventariosBindingNavigator.Size = new System.Drawing.Size(686, 25);
            this.inventariosBindingNavigator.TabIndex = 8;
            this.inventariosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
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
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
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
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
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
            // inventariosBindingNavigatorSaveItem
            // 
            this.inventariosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.inventariosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("inventariosBindingNavigatorSaveItem.Image")));
            this.inventariosBindingNavigatorSaveItem.Name = "inventariosBindingNavigatorSaveItem";
            this.inventariosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.inventariosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.inventariosBindingNavigatorSaveItem.Click += new System.EventHandler(this.inventariosBindingNavigatorSaveItem_Click_1);
            // 
            // inventariosDataGridView
            // 
            this.inventariosDataGridView.AutoGenerateColumns = false;
            this.inventariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventariosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.categoria,
            this.dataGridViewTextBoxColumn4});
            this.inventariosDataGridView.DataSource = this.inventariosBindingSource;
            this.inventariosDataGridView.Location = new System.Drawing.Point(12, 35);
            this.inventariosDataGridView.Name = "inventariosDataGridView";
            this.inventariosDataGridView.Size = new System.Drawing.Size(365, 227);
            this.inventariosDataGridView.TabIndex = 8;
            // 
            // tb_p
            // 
            this.tb_p.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventariosBindingSource, "id_articulo", true));
            this.tb_p.Location = new System.Drawing.Point(12, 278);
            this.tb_p.Name = "tb_p";
            this.tb_p.Size = new System.Drawing.Size(261, 20);
            this.tb_p.TabIndex = 7;
            // 
            // inventariosDataGridView1
            // 
            this.inventariosDataGridView1.AutoGenerateColumns = false;
            this.inventariosDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventariosDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6});
            this.inventariosDataGridView1.DataSource = this.inventariosBindingSource1;
            this.inventariosDataGridView1.Location = new System.Drawing.Point(411, 35);
            this.inventariosDataGridView1.Name = "inventariosDataGridView1";
            this.inventariosDataGridView1.Size = new System.Drawing.Size(261, 227);
            this.inventariosDataGridView1.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_articulo";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_articulo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn6.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // inventariosBindingSource1
            // 
            this.inventariosBindingSource1.DataMember = "inventarios";
            this.inventariosBindingSource1.DataSource = this.si_inventariosDataSet1;
            // 
            // si_inventariosDataSet1
            // 
            this.si_inventariosDataSet1.DataSetName = "si_inventariosDataSet1";
            this.si_inventariosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventariosTableAdapter1
            // 
            this.inventariosTableAdapter1.ClearBeforeFill = true;
            // 
            // tb_m
            // 
            this.tb_m.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventariosBindingSource1, "id_articulo", true));
            this.tb_m.Location = new System.Drawing.Point(411, 278);
            this.tb_m.Name = "tb_m";
            this.tb_m.Size = new System.Drawing.Size(261, 20);
            this.tb_m.TabIndex = 9;
            // 
            // tb_c
            // 
            this.tb_c.Location = new System.Drawing.Point(12, 315);
            this.tb_c.Name = "tb_c";
            this.tb_c.Size = new System.Drawing.Size(261, 20);
            this.tb_c.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_articulo";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_articulo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "categoria";
            this.categoria.HeaderText = "categoria";
            this.categoria.Name = "categoria";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn4.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 354);
            this.Controls.Add(this.tb_c);
            this.Controls.Add(this.tb_m);
            this.Controls.Add(this.inventariosDataGridView1);
            this.Controls.Add(this.inventariosDataGridView);
            this.Controls.Add(this.inventariosBindingNavigator);
            this.Controls.Add(this.tb_p);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.si_inventariosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventariosBindingNavigator)).EndInit();
            this.inventariosBindingNavigator.ResumeLayout(false);
            this.inventariosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventariosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventariosDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventariosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.si_inventariosDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private si_inventariosDataSet si_inventariosDataSet;
        private System.Windows.Forms.BindingSource inventariosBindingSource;
        private si_inventariosDataSetTableAdapters.inventariosTableAdapter inventariosTableAdapter;
        private si_inventariosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator inventariosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton inventariosBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView inventariosDataGridView;
        private System.Windows.Forms.TextBox tb_p;
        private System.Windows.Forms.DataGridView inventariosDataGridView1;
        private si_inventariosDataSet1 si_inventariosDataSet1;
        private System.Windows.Forms.BindingSource inventariosBindingSource1;
        private si_inventariosDataSet1TableAdapters.inventariosTableAdapter inventariosTableAdapter1;
        private System.Windows.Forms.TextBox tb_m;
        private System.Windows.Forms.TextBox tb_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

