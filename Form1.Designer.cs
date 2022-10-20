namespace ListadoContribuyentes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvContribuyentes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNCuenta = new System.Windows.Forms.TextBox();
            this.cmbMesPago = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDeuda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPlanDePago = new System.Windows.Forms.ComboBox();
            this.btnReporte1 = new System.Windows.Forms.Button();
            this.btnReporte2 = new System.Windows.Forms.Button();
            this.btnReporte3 = new System.Windows.Forms.Button();
            this.btnReporte4 = new System.Windows.Forms.Button();
            this.btnReporte5 = new System.Windows.Forms.Button();
            this.btnReporte6 = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContribuyentes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContribuyentes
            // 
            this.dgvContribuyentes.AllowUserToAddRows = false;
            this.dgvContribuyentes.BackgroundColor = System.Drawing.Color.Black;
            this.dgvContribuyentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContribuyentes.Location = new System.Drawing.Point(501, 254);
            this.dgvContribuyentes.Name = "dgvContribuyentes";
            this.dgvContribuyentes.ReadOnly = true;
            this.dgvContribuyentes.Size = new System.Drawing.Size(654, 420);
            this.dgvContribuyentes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(420, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "CONTRIBUYENTES";
            // 
            // txtNCuenta
            // 
            this.txtNCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNCuenta.ForeColor = System.Drawing.Color.White;
            this.txtNCuenta.Location = new System.Drawing.Point(205, 306);
            this.txtNCuenta.Name = "txtNCuenta";
            this.txtNCuenta.Size = new System.Drawing.Size(241, 26);
            this.txtNCuenta.TabIndex = 2;
            this.txtNCuenta.Text = " ";
            // 
            // cmbMesPago
            // 
            this.cmbMesPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbMesPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbMesPago.ForeColor = System.Drawing.Color.White;
            this.cmbMesPago.FormattingEnabled = true;
            this.cmbMesPago.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmbMesPago.Location = new System.Drawing.Point(205, 484);
            this.cmbMesPago.Name = "cmbMesPago";
            this.cmbMesPago.Size = new System.Drawing.Size(241, 28);
            this.cmbMesPago.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nº de cuenta";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(205, 364);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(241, 26);
            this.txtNombre.TabIndex = 7;
            // 
            // txtDeuda
            // 
            this.txtDeuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDeuda.ForeColor = System.Drawing.Color.White;
            this.txtDeuda.Location = new System.Drawing.Point(205, 424);
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.Size = new System.Drawing.Size(241, 26);
            this.txtDeuda.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(60, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(60, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Deuda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(45, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mes pago";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(44, 544);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Plan de pago";
            // 
            // cmbPlanDePago
            // 
            this.cmbPlanDePago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbPlanDePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbPlanDePago.ForeColor = System.Drawing.Color.White;
            this.cmbPlanDePago.FormattingEnabled = true;
            this.cmbPlanDePago.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cmbPlanDePago.Location = new System.Drawing.Point(205, 541);
            this.cmbPlanDePago.Name = "cmbPlanDePago";
            this.cmbPlanDePago.Size = new System.Drawing.Size(241, 28);
            this.cmbPlanDePago.TabIndex = 13;
            // 
            // btnReporte1
            // 
            this.btnReporte1.AutoSize = true;
            this.btnReporte1.BackColor = System.Drawing.Color.Transparent;
            this.btnReporte1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte1.Location = new System.Drawing.Point(104, 134);
            this.btnReporte1.Name = "btnReporte1";
            this.btnReporte1.Size = new System.Drawing.Size(99, 38);
            this.btnReporte1.TabIndex = 14;
            this.btnReporte1.Text = "Reporte 1";
            this.btnReporte1.UseVisualStyleBackColor = false;
            this.btnReporte1.Click += new System.EventHandler(this.btnReporte1_Click);
            // 
            // btnReporte2
            // 
            this.btnReporte2.AutoSize = true;
            this.btnReporte2.BackColor = System.Drawing.Color.Transparent;
            this.btnReporte2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte2.Location = new System.Drawing.Point(280, 134);
            this.btnReporte2.Name = "btnReporte2";
            this.btnReporte2.Size = new System.Drawing.Size(99, 38);
            this.btnReporte2.TabIndex = 15;
            this.btnReporte2.Text = "Reporte 2";
            this.btnReporte2.UseVisualStyleBackColor = false;
            this.btnReporte2.Click += new System.EventHandler(this.btnReporte2_Click);
            // 
            // btnReporte3
            // 
            this.btnReporte3.AutoSize = true;
            this.btnReporte3.BackColor = System.Drawing.Color.Transparent;
            this.btnReporte3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte3.Location = new System.Drawing.Point(457, 134);
            this.btnReporte3.Name = "btnReporte3";
            this.btnReporte3.Size = new System.Drawing.Size(99, 38);
            this.btnReporte3.TabIndex = 16;
            this.btnReporte3.Text = "Reporte 3";
            this.btnReporte3.UseVisualStyleBackColor = false;
            this.btnReporte3.Click += new System.EventHandler(this.btnReporte3_Click);
            // 
            // btnReporte4
            // 
            this.btnReporte4.AutoSize = true;
            this.btnReporte4.BackColor = System.Drawing.Color.Transparent;
            this.btnReporte4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte4.Location = new System.Drawing.Point(634, 134);
            this.btnReporte4.Name = "btnReporte4";
            this.btnReporte4.Size = new System.Drawing.Size(99, 38);
            this.btnReporte4.TabIndex = 17;
            this.btnReporte4.Text = "Reporte 4";
            this.btnReporte4.UseVisualStyleBackColor = false;
            this.btnReporte4.Click += new System.EventHandler(this.btnReporte4_Click);
            // 
            // btnReporte5
            // 
            this.btnReporte5.AutoSize = true;
            this.btnReporte5.BackColor = System.Drawing.Color.Transparent;
            this.btnReporte5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte5.Location = new System.Drawing.Point(810, 134);
            this.btnReporte5.Name = "btnReporte5";
            this.btnReporte5.Size = new System.Drawing.Size(99, 38);
            this.btnReporte5.TabIndex = 18;
            this.btnReporte5.Text = "Reporte 5";
            this.btnReporte5.UseVisualStyleBackColor = false;
            this.btnReporte5.Click += new System.EventHandler(this.btnReporte5_Click);
            // 
            // btnReporte6
            // 
            this.btnReporte6.AutoSize = true;
            this.btnReporte6.BackColor = System.Drawing.Color.Transparent;
            this.btnReporte6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte6.Location = new System.Drawing.Point(986, 134);
            this.btnReporte6.Name = "btnReporte6";
            this.btnReporte6.Size = new System.Drawing.Size(99, 38);
            this.btnReporte6.TabIndex = 19;
            this.btnReporte6.Text = "Reporte 6";
            this.btnReporte6.UseVisualStyleBackColor = false;
            this.btnReporte6.Click += new System.EventHandler(this.btnReporte6_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.AutoSize = true;
            this.btnCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.Location = new System.Drawing.Point(177, 611);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(94, 30);
            this.btnCargar.TabIndex = 20;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.AutoSize = true;
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(343, 611);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(93, 30);
            this.btnBorrar.TabIndex = 21;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1167, 686);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnReporte6);
            this.Controls.Add(this.btnReporte5);
            this.Controls.Add(this.btnReporte4);
            this.Controls.Add(this.btnReporte3);
            this.Controls.Add(this.btnReporte2);
            this.Controls.Add(this.btnReporte1);
            this.Controls.Add(this.cmbPlanDePago);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDeuda);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMesPago);
            this.Controls.Add(this.txtNCuenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvContribuyentes);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Contribuyentes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContribuyentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContribuyentes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNCuenta;
        private System.Windows.Forms.ComboBox cmbMesPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDeuda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPlanDePago;
        private System.Windows.Forms.Button btnReporte1;
        private System.Windows.Forms.Button btnReporte2;
        private System.Windows.Forms.Button btnReporte3;
        private System.Windows.Forms.Button btnReporte4;
        private System.Windows.Forms.Button btnReporte5;
        private System.Windows.Forms.Button btnReporte6;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnBorrar;
    }
}

