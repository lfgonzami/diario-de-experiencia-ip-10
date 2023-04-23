namespace Lab8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbSeleccion = new System.Windows.Forms.ComboBox();
            this.tctSeleccion = new System.Windows.Forms.TabControl();
            this.tabSumatoria = new System.Windows.Forms.TabPage();
            this.LbResultadoN = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.txtbIngreseN = new System.Windows.Forms.TextBox();
            this.lbIngreseN = new System.Windows.Forms.Label();
            this.tabFactorial = new System.Windows.Forms.TabPage();
            this.tabTablas = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTabla = new System.Windows.Forms.Label();
            this.tabNPerfecto = new System.Windows.Forms.TabPage();
            this.lblResultadoPerfecto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbNPerfecto = new System.Windows.Forms.TextBox();
            this.lblNPerfecto = new System.Windows.Forms.Label();
            this.gpbSeleccion = new System.Windows.Forms.GroupBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.tctSeleccion.SuspendLayout();
            this.tabSumatoria.SuspendLayout();
            this.tabTablas.SuspendLayout();
            this.tabNPerfecto.SuspendLayout();
            this.gpbSeleccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSeleccion
            // 
            this.cmbSeleccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeleccion.FormattingEnabled = true;
            this.cmbSeleccion.Location = new System.Drawing.Point(26, 45);
            this.cmbSeleccion.Name = "cmbSeleccion";
            this.cmbSeleccion.Size = new System.Drawing.Size(171, 23);
            this.cmbSeleccion.TabIndex = 0;
            this.cmbSeleccion.SelectedIndexChanged += new System.EventHandler(this.cmbSeleccion_SelectedIndexChanged);
            // 
            // tctSeleccion
            // 
            this.tctSeleccion.Controls.Add(this.tabSumatoria);
            this.tctSeleccion.Controls.Add(this.tabFactorial);
            this.tctSeleccion.Controls.Add(this.tabTablas);
            this.tctSeleccion.Controls.Add(this.tabNPerfecto);
            this.tctSeleccion.Location = new System.Drawing.Point(340, 28);
            this.tctSeleccion.Name = "tctSeleccion";
            this.tctSeleccion.SelectedIndex = 0;
            this.tctSeleccion.Size = new System.Drawing.Size(401, 303);
            this.tctSeleccion.TabIndex = 1;
            // 
            // tabSumatoria
            // 
            this.tabSumatoria.Controls.Add(this.LbResultadoN);
            this.tabSumatoria.Controls.Add(this.lbResultado);
            this.tabSumatoria.Controls.Add(this.txtbIngreseN);
            this.tabSumatoria.Controls.Add(this.lbIngreseN);
            this.tabSumatoria.Location = new System.Drawing.Point(4, 24);
            this.tabSumatoria.Name = "tabSumatoria";
            this.tabSumatoria.Padding = new System.Windows.Forms.Padding(3);
            this.tabSumatoria.Size = new System.Drawing.Size(393, 275);
            this.tabSumatoria.TabIndex = 0;
            this.tabSumatoria.Text = "Sumatoria";
            this.tabSumatoria.UseVisualStyleBackColor = true;
            // 
            // LbResultadoN
            // 
            this.LbResultadoN.AutoSize = true;
            this.LbResultadoN.Location = new System.Drawing.Point(153, 102);
            this.LbResultadoN.Name = "LbResultadoN";
            this.LbResultadoN.Size = new System.Drawing.Size(0, 15);
            this.LbResultadoN.TabIndex = 3;
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbResultado.Location = new System.Drawing.Point(20, 102);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(62, 15);
            this.lbResultado.TabIndex = 2;
            this.lbResultado.Text = "Resultado";
            // 
            // txtbIngreseN
            // 
            this.txtbIngreseN.Location = new System.Drawing.Point(162, 33);
            this.txtbIngreseN.Name = "txtbIngreseN";
            this.txtbIngreseN.Size = new System.Drawing.Size(139, 23);
            this.txtbIngreseN.TabIndex = 1;
            this.txtbIngreseN.TextChanged += new System.EventHandler(this.txtbIngreseN_TextChanged);
            // 
            // lbIngreseN
            // 
            this.lbIngreseN.AutoSize = true;
            this.lbIngreseN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbIngreseN.Location = new System.Drawing.Point(20, 36);
            this.lbIngreseN.Name = "lbIngreseN";
            this.lbIngreseN.Size = new System.Drawing.Size(108, 15);
            this.lbIngreseN.TabIndex = 0;
            this.lbIngreseN.Text = "Ingrese número N";
            // 
            // tabFactorial
            // 
            this.tabFactorial.Location = new System.Drawing.Point(4, 24);
            this.tabFactorial.Name = "tabFactorial";
            this.tabFactorial.Padding = new System.Windows.Forms.Padding(3);
            this.tabFactorial.Size = new System.Drawing.Size(393, 275);
            this.tabFactorial.TabIndex = 1;
            this.tabFactorial.Text = "Factorial";
            this.tabFactorial.UseVisualStyleBackColor = true;
            this.tabFactorial.Click += new System.EventHandler(this.tabFactorial_Click);
            // 
            // tabTablas
            // 
            this.tabTablas.Controls.Add(this.label1);
            this.tabTablas.Controls.Add(this.lbTabla);
            this.tabTablas.Location = new System.Drawing.Point(4, 24);
            this.tabTablas.Name = "tabTablas";
            this.tabTablas.Padding = new System.Windows.Forms.Padding(3);
            this.tabTablas.Size = new System.Drawing.Size(393, 275);
            this.tabTablas.TabIndex = 2;
            this.tabTablas.Text = "Tablas de multiplicar";
            this.tabTablas.UseVisualStyleBackColor = true;
            this.tabTablas.Click += new System.EventHandler(this.tabTablas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tablas de multiplicar del 1 al 10";
            // 
            // lbTabla
            // 
            this.lbTabla.AutoSize = true;
            this.lbTabla.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTabla.Location = new System.Drawing.Point(35, 31);
            this.lbTabla.Name = "lbTabla";
            this.lbTabla.Size = new System.Drawing.Size(0, 21);
            this.lbTabla.TabIndex = 0;
            // 
            // tabNPerfecto
            // 
            this.tabNPerfecto.Controls.Add(this.lblResultadoPerfecto);
            this.tabNPerfecto.Controls.Add(this.label2);
            this.tabNPerfecto.Controls.Add(this.txtbNPerfecto);
            this.tabNPerfecto.Controls.Add(this.lblNPerfecto);
            this.tabNPerfecto.Location = new System.Drawing.Point(4, 24);
            this.tabNPerfecto.Name = "tabNPerfecto";
            this.tabNPerfecto.Padding = new System.Windows.Forms.Padding(3);
            this.tabNPerfecto.Size = new System.Drawing.Size(393, 275);
            this.tabNPerfecto.TabIndex = 3;
            this.tabNPerfecto.Text = "Número perfecto";
            this.tabNPerfecto.UseVisualStyleBackColor = true;
            // 
            // lblResultadoPerfecto
            // 
            this.lblResultadoPerfecto.AutoSize = true;
            this.lblResultadoPerfecto.Location = new System.Drawing.Point(173, 112);
            this.lblResultadoPerfecto.Name = "lblResultadoPerfecto";
            this.lblResultadoPerfecto.Size = new System.Drawing.Size(0, 15);
            this.lblResultadoPerfecto.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Resultado";
            // 
            // txtbNPerfecto
            // 
            this.txtbNPerfecto.Location = new System.Drawing.Point(182, 43);
            this.txtbNPerfecto.Name = "txtbNPerfecto";
            this.txtbNPerfecto.Size = new System.Drawing.Size(139, 23);
            this.txtbNPerfecto.TabIndex = 5;
            // 
            // lblNPerfecto
            // 
            this.lblNPerfecto.AutoSize = true;
            this.lblNPerfecto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNPerfecto.Location = new System.Drawing.Point(40, 46);
            this.lblNPerfecto.Name = "lblNPerfecto";
            this.lblNPerfecto.Size = new System.Drawing.Size(99, 15);
            this.lblNPerfecto.TabIndex = 4;
            this.lblNPerfecto.Text = "Ingrese número ";
            // 
            // gpbSeleccion
            // 
            this.gpbSeleccion.Controls.Add(this.cmbSeleccion);
            this.gpbSeleccion.Location = new System.Drawing.Point(36, 65);
            this.gpbSeleccion.Name = "gpbSeleccion";
            this.gpbSeleccion.Size = new System.Drawing.Size(260, 119);
            this.gpbSeleccion.TabIndex = 2;
            this.gpbSeleccion.TabStop = false;
            this.gpbSeleccion.Text = "Selección";
            this.gpbSeleccion.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(36, 217);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(152, 47);
            this.btnSeleccionar.TabIndex = 3;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 453);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.gpbSeleccion);
            this.Controls.Add(this.tctSeleccion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tctSeleccion.ResumeLayout(false);
            this.tabSumatoria.ResumeLayout(false);
            this.tabSumatoria.PerformLayout();
            this.tabTablas.ResumeLayout(false);
            this.tabTablas.PerformLayout();
            this.tabNPerfecto.ResumeLayout(false);
            this.tabNPerfecto.PerformLayout();
            this.gpbSeleccion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cmbSeleccion;
        private TabControl tctSeleccion;
        private TabPage tabSumatoria;
        private TabPage tabFactorial;
        private GroupBox gpbSeleccion;
        private Button btnSeleccionar;
        private TabPage tabTablas;
        private TabPage tabNPerfecto;
        private Label lbResultado;
        private TextBox txtbIngreseN;
        private Label lbIngreseN;
        private Label LbResultadoN;
        private Label lbTabla;
        private Label lblResultadoPerfecto;
        private Label label2;
        private TextBox txtbNPerfecto;
        private Label lblNPerfecto;
        private Label label1;
    }
}