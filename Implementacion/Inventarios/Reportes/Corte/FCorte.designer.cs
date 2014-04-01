namespace Inventarios.Reportes.Corte
{
    partial class FCorte
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
            this.crv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // crv
            // 
            this.crv.ActiveViewIndex = -1;
            this.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv.Location = new System.Drawing.Point(12, 65);
            this.crv.Name = "crv";
            this.crv.Size = new System.Drawing.Size(963, 624);
            this.crv.TabIndex = 0;
            this.crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha de consulta :";
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(135, 25);
            this.dtp.MaxDate = new System.DateTime(2014, 12, 31, 0, 0, 0, 0);
            this.dtp.MinDate = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 20);
            this.dtp.TabIndex = 2;
            this.dtp.Value = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(875, 25);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(100, 30);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 3;
            this.buttonX1.Text = "Generar reporte";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // FCorte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 701);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crv);
            this.Name = "FCorte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Corte del día";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}