namespace Inventarios
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
            this.bntSim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntSim
            // 
            this.bntSim.Location = new System.Drawing.Point(41, 24);
            this.bntSim.Name = "bntSim";
            this.bntSim.Size = new System.Drawing.Size(75, 23);
            this.bntSim.TabIndex = 0;
            this.bntSim.Text = "Simulacion";
            this.bntSim.UseVisualStyleBackColor = true;
            this.bntSim.Click += new System.EventHandler(this.bntSim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 496);
            this.Controls.Add(this.bntSim);
            this.Name = "Form1";
            this.Text = "Sistema de Control de Invetarios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntSim;
    }
}

