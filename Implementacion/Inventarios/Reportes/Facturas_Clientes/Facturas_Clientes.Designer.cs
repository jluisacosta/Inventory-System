namespace Inventarios.Reportes.Facturas_Clientes
{
    partial class Facturas_Clientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_generaReporte = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.fecha_Ini = new System.Windows.Forms.DateTimePicker();
            this.fecha_Fin = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Inicial :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Final :";
            // 
            // bt_generaReporte
            // 
            this.bt_generaReporte.Location = new System.Drawing.Point(825, 35);
            this.bt_generaReporte.Name = "bt_generaReporte";
            this.bt_generaReporte.Size = new System.Drawing.Size(128, 27);
            this.bt_generaReporte.TabIndex = 2;
            this.bt_generaReporte.Text = "Generar Reporte";
            this.bt_generaReporte.UseVisualStyleBackColor = true;
            this.bt_generaReporte.Click += new System.EventHandler(this.bt_generaReporte_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(15, 85);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(938, 489);
            this.crystalReportViewer1.TabIndex = 5;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // fecha_Ini
            // 
            this.fecha_Ini.Location = new System.Drawing.Point(91, 38);
            this.fecha_Ini.Name = "fecha_Ini";
            this.fecha_Ini.Size = new System.Drawing.Size(200, 20);
            this.fecha_Ini.TabIndex = 6;
            // 
            // fecha_Fin
            // 
            this.fecha_Fin.Location = new System.Drawing.Point(389, 38);
            this.fecha_Fin.Name = "fecha_Fin";
            this.fecha_Fin.Size = new System.Drawing.Size(200, 20);
            this.fecha_Fin.TabIndex = 7;
            // 
            // Facturas_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 586);
            this.Controls.Add(this.fecha_Fin);
            this.Controls.Add(this.fecha_Ini);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.bt_generaReporte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Facturas_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturas_Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_generaReporte;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.DateTimePicker fecha_Ini;
        private System.Windows.Forms.DateTimePicker fecha_Fin;
    }
}