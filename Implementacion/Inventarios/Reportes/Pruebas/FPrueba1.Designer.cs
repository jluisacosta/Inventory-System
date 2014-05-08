namespace Inventarios.Reportes.Pruebas
{
    partial class FPrueba1
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ventasEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_inventarios = new Inventarios.dataSet_inventarios();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ventas_EmpleadoTableAdapter = new Inventarios.dataSet_inventariosTableAdapters.Ventas_EmpleadoTableAdapter();
            this.fecha_Fin = new System.Windows.Forms.DateTimePicker();
            this.fecha_Ini = new System.Windows.Forms.DateTimePicker();
            this.bt_generaReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ventasEmpleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_inventarios)).BeginInit();
            this.SuspendLayout();
            // 
            // ventasEmpleadoBindingSource
            // 
            this.ventasEmpleadoBindingSource.DataMember = "Ventas_Empleado";
            this.ventasEmpleadoBindingSource.DataSource = this.dataSet_inventarios;
            // 
            // dataSet_inventarios
            // 
            this.dataSet_inventarios.DataSetName = "dataSet_inventarios";
            this.dataSet_inventarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet_Ventas_Emp";
            reportDataSource1.Value = this.ventasEmpleadoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inventarios.Reportes.Pruebas.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 46);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(942, 622);
            this.reportViewer1.TabIndex = 0;
            // 
            // ventas_EmpleadoTableAdapter
            // 
            this.ventas_EmpleadoTableAdapter.ClearBeforeFill = true;
            // 
            // fecha_Fin
            // 
            this.fecha_Fin.Location = new System.Drawing.Point(339, 12);
            this.fecha_Fin.MaxDate = new System.DateTime(2014, 12, 31, 0, 0, 0, 0);
            this.fecha_Fin.MinDate = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            this.fecha_Fin.Name = "fecha_Fin";
            this.fecha_Fin.Size = new System.Drawing.Size(200, 20);
            this.fecha_Fin.TabIndex = 21;
            // 
            // fecha_Ini
            // 
            this.fecha_Ini.Location = new System.Drawing.Point(12, 12);
            this.fecha_Ini.MaxDate = new System.DateTime(2014, 12, 31, 0, 0, 0, 0);
            this.fecha_Ini.MinDate = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            this.fecha_Ini.Name = "fecha_Ini";
            this.fecha_Ini.Size = new System.Drawing.Size(200, 20);
            this.fecha_Ini.TabIndex = 20;
            this.fecha_Ini.Value = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            // 
            // bt_generaReporte
            // 
            this.bt_generaReporte.Location = new System.Drawing.Point(589, 9);
            this.bt_generaReporte.Name = "bt_generaReporte";
            this.bt_generaReporte.Size = new System.Drawing.Size(128, 27);
            this.bt_generaReporte.TabIndex = 22;
            this.bt_generaReporte.Text = "Generar Reporte";
            this.bt_generaReporte.UseVisualStyleBackColor = true;
            this.bt_generaReporte.Click += new System.EventHandler(this.bt_generaReporte_Click);
            // 
            // FPrueba1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 680);
            this.Controls.Add(this.bt_generaReporte);
            this.Controls.Add(this.fecha_Fin);
            this.Controls.Add(this.fecha_Ini);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FPrueba1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FPrueba1";
            this.Load += new System.EventHandler(this.FPrueba1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventasEmpleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_inventarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ventasEmpleadoBindingSource;
        private dataSet_inventarios dataSet_inventarios;
        private dataSet_inventariosTableAdapters.Ventas_EmpleadoTableAdapter ventas_EmpleadoTableAdapter;
        private System.Windows.Forms.DateTimePicker fecha_Fin;
        private System.Windows.Forms.DateTimePicker fecha_Ini;
        private System.Windows.Forms.Button bt_generaReporte;
    }
}