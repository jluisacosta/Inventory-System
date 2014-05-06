namespace Inventarios.Formularios
{
    partial class FEmpleados
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pb_emp = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_email = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_tel = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cb_tipo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tb_direccion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_nombre = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.b_modif = new DevComponents.DotNetBar.ButtonX();
            this.b_baja = new DevComponents.DotNetBar.ButtonX();
            this.b_alta = new DevComponents.DotNetBar.ButtonX();
            this.sgc_emp = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.dti_fecha = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.tb_id = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_depto = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_emp)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dti_fecha)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(986, 736);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupPanel3
            // 
            this.groupPanel3.BackColor = System.Drawing.Color.White;
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.sgc_emp);
            this.groupPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel3.Location = new System.Drawing.Point(3, 235);
            this.groupPanel3.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Padding = new System.Windows.Forms.Padding(15);
            this.groupPanel3.Size = new System.Drawing.Size(980, 498);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel3.TabIndex = 2;
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.White;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.groupPanel1.Controls.Add(this.tableLayoutPanel2);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(3, 3);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Padding = new System.Windows.Forms.Padding(15);
            this.groupPanel1.Size = new System.Drawing.Size(980, 214);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 1;
            this.groupPanel1.Text = "Datos del empleado";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.pb_emp, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(15, 15);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(944, 163);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pb_emp
            // 
            this.pb_emp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_emp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_emp.Location = new System.Drawing.Point(487, 15);
            this.pb_emp.Margin = new System.Windows.Forms.Padding(15);
            this.pb_emp.Name = "pb_emp";
            this.pb_emp.Size = new System.Drawing.Size(206, 133);
            this.pb_emp.TabIndex = 3;
            this.pb_emp.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tb_depto, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.tb_email, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tb_tel, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.cb_tipo, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.tb_direccion, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dti_fecha, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.tb_nombre, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tb_id, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(452, 143);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_email.Border.Class = "TextBoxBorder";
            this.tb_email.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_email.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_email.ForeColor = System.Drawing.Color.Black;
            this.tb_email.Location = new System.Drawing.Point(3, 73);
            this.tb_email.Name = "tb_email";
            this.tb_email.PreventEnterBeep = true;
            this.tb_email.Size = new System.Drawing.Size(220, 20);
            this.tb_email.TabIndex = 24;
            this.tb_email.WatermarkText = "E-mail";
            // 
            // tb_tel
            // 
            this.tb_tel.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_tel.Border.Class = "TextBoxBorder";
            this.tb_tel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_tel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_tel.ForeColor = System.Drawing.Color.Black;
            this.tb_tel.Location = new System.Drawing.Point(229, 38);
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.PreventEnterBeep = true;
            this.tb_tel.Size = new System.Drawing.Size(220, 20);
            this.tb_tel.TabIndex = 23;
            this.tb_tel.WatermarkText = "Teléfono";
            // 
            // cb_tipo
            // 
            this.cb_tipo.DisplayMember = "Text";
            this.cb_tipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.cb_tipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.ItemHeight = 14;
            this.cb_tipo.Location = new System.Drawing.Point(229, 73);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(220, 20);
            this.cb_tipo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_tipo.TabIndex = 22;
            this.cb_tipo.WatermarkText = "Puesto";
            // 
            // tb_direccion
            // 
            this.tb_direccion.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_direccion.Border.Class = "TextBoxBorder";
            this.tb_direccion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_direccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_direccion.ForeColor = System.Drawing.Color.Black;
            this.tb_direccion.Location = new System.Drawing.Point(3, 38);
            this.tb_direccion.Name = "tb_direccion";
            this.tb_direccion.PreventEnterBeep = true;
            this.tb_direccion.Size = new System.Drawing.Size(220, 20);
            this.tb_direccion.TabIndex = 14;
            this.tb_direccion.WatermarkText = "Dirección";
            // 
            // tb_nombre
            // 
            // 
            // 
            // 
            this.tb_nombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_nombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_nombre.Location = new System.Drawing.Point(229, 3);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.PreventEnterBeep = true;
            this.tb_nombre.Size = new System.Drawing.Size(220, 14);
            this.tb_nombre.TabIndex = 18;
            this.tb_nombre.WatermarkText = "Nombre";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.b_modif, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.b_baja, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.b_alta, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(711, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(230, 157);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // b_modif
            // 
            this.b_modif.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.b_modif.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.b_modif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_modif.Location = new System.Drawing.Point(10, 114);
            this.b_modif.Margin = new System.Windows.Forms.Padding(10);
            this.b_modif.Name = "b_modif";
            this.b_modif.Size = new System.Drawing.Size(210, 33);
            this.b_modif.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.b_modif.TabIndex = 2;
            this.b_modif.Text = "Modificación";
            // 
            // b_baja
            // 
            this.b_baja.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.b_baja.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.b_baja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_baja.Location = new System.Drawing.Point(10, 62);
            this.b_baja.Margin = new System.Windows.Forms.Padding(10);
            this.b_baja.Name = "b_baja";
            this.b_baja.Size = new System.Drawing.Size(210, 32);
            this.b_baja.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.b_baja.TabIndex = 2;
            this.b_baja.Text = "Baja";
            // 
            // b_alta
            // 
            this.b_alta.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.b_alta.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.b_alta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_alta.Location = new System.Drawing.Point(10, 10);
            this.b_alta.Margin = new System.Windows.Forms.Padding(10);
            this.b_alta.Name = "b_alta";
            this.b_alta.Size = new System.Drawing.Size(210, 32);
            this.b_alta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.b_alta.TabIndex = 1;
            this.b_alta.Text = "Alta";
            // 
            // sgc_emp
            // 
            this.sgc_emp.BackColor = System.Drawing.Color.White;
            this.sgc_emp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sgc_emp.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.sgc_emp.ForeColor = System.Drawing.Color.Black;
            this.sgc_emp.Location = new System.Drawing.Point(15, 15);
            this.sgc_emp.Name = "sgc_emp";
            this.sgc_emp.Size = new System.Drawing.Size(944, 462);
            this.sgc_emp.TabIndex = 1;
            this.sgc_emp.Text = "superGridControl1";
            // 
            // dti_fecha
            // 
            // 
            // 
            // 
            this.dti_fecha.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dti_fecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_fecha.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dti_fecha.ButtonDropDown.Visible = true;
            this.dti_fecha.Dock = System.Windows.Forms.DockStyle.Top;
            this.dti_fecha.IsPopupCalendarOpen = false;
            this.dti_fecha.Location = new System.Drawing.Point(3, 108);
            // 
            // 
            // 
            this.dti_fecha.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dti_fecha.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_fecha.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dti_fecha.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dti_fecha.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dti_fecha.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dti_fecha.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dti_fecha.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dti_fecha.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dti_fecha.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dti_fecha.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_fecha.MonthCalendar.DisplayMonth = new System.DateTime(2014, 5, 1, 0, 0, 0, 0);
            this.dti_fecha.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dti_fecha.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dti_fecha.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dti_fecha.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dti_fecha.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dti_fecha.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_fecha.MonthCalendar.TodayButtonVisible = true;
            this.dti_fecha.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dti_fecha.Name = "dti_fecha";
            this.dti_fecha.Size = new System.Drawing.Size(220, 20);
            this.dti_fecha.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dti_fecha.TabIndex = 19;
            this.dti_fecha.WatermarkText = "Fecha de nacimiento";
            // 
            // tb_id
            // 
            // 
            // 
            // 
            this.tb_id.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_id.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_id.Location = new System.Drawing.Point(3, 3);
            this.tb_id.Name = "tb_id";
            this.tb_id.PreventEnterBeep = true;
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(220, 14);
            this.tb_id.TabIndex = 25;
            this.tb_id.WatermarkText = "Id empleado";
            // 
            // tb_depto
            // 
            this.tb_depto.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_depto.Border.Class = "TextBoxBorder";
            this.tb_depto.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_depto.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_depto.ForeColor = System.Drawing.Color.Black;
            this.tb_depto.Location = new System.Drawing.Point(229, 108);
            this.tb_depto.Name = "tb_depto";
            this.tb_depto.PreventEnterBeep = true;
            this.tb_depto.ReadOnly = true;
            this.tb_depto.Size = new System.Drawing.Size(220, 20);
            this.tb_depto.TabIndex = 26;
            this.tb_depto.WatermarkText = "Departamento";
            // 
            // FEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1016, 766);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FEmpleados";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Text = "Empleados";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupPanel3.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_emp)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dti_fecha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_direccion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private DevComponents.DotNetBar.ButtonX b_modif;
        private DevComponents.DotNetBar.ButtonX b_baja;
        private DevComponents.DotNetBar.ButtonX b_alta;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_nombre;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_tipo;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_tel;
        private System.Windows.Forms.PictureBox pb_emp;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_email;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl sgc_emp;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dti_fecha;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_id;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_depto;
    }
}