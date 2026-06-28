namespace SimuladorLoteria
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnJugar = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum3 = new System.Windows.Forms.TextBox();
            this.txtNum4 = new System.Windows.Forms.TextBox();
            this.txtNum5 = new System.Windows.Forms.TextBox();
            this.txtNum6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnJugar
            // 
            this.btnJugar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnJugar.BackColor = System.Drawing.Color.Gold;
            this.btnJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugar.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugar.ForeColor = System.Drawing.Color.Black;
            this.btnJugar.Location = new System.Drawing.Point(77, 296);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(226, 73);
            this.btnJugar.TabIndex = 2;
            this.btnJugar.Text = "GENERAR NUMEROS";
            this.btnJugar.UseVisualStyleBackColor = false;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.BackColor = System.Drawing.Color.White;
            this.txtNum1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNum1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum1.ForeColor = System.Drawing.Color.Black;
            this.txtNum1.Location = new System.Drawing.Point(61, 133);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(53, 34);
            this.txtNum1.TabIndex = 3;
            this.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNum1.TextChanged += new System.EventHandler(this.txtNum1_TextChanged);
            // 
            // txtNum2
            // 
            this.txtNum2.BackColor = System.Drawing.Color.White;
            this.txtNum2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNum2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum2.ForeColor = System.Drawing.Color.Black;
            this.txtNum2.Location = new System.Drawing.Point(266, 206);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(52, 34);
            this.txtNum2.TabIndex = 4;
            this.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNum2.TextChanged += new System.EventHandler(this.txtNum2_TextChanged_1);
            // 
            // txtNum3
            // 
            this.txtNum3.BackColor = System.Drawing.Color.White;
            this.txtNum3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNum3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum3.ForeColor = System.Drawing.Color.Black;
            this.txtNum3.Location = new System.Drawing.Point(266, 133);
            this.txtNum3.Name = "txtNum3";
            this.txtNum3.Size = new System.Drawing.Size(52, 34);
            this.txtNum3.TabIndex = 5;
            this.txtNum3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNum3.TextChanged += new System.EventHandler(this.txtNum3_TextChanged_1);
            // 
            // txtNum4
            // 
            this.txtNum4.BackColor = System.Drawing.Color.White;
            this.txtNum4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNum4.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum4.ForeColor = System.Drawing.Color.Black;
            this.txtNum4.Location = new System.Drawing.Point(159, 206);
            this.txtNum4.Name = "txtNum4";
            this.txtNum4.Size = new System.Drawing.Size(52, 34);
            this.txtNum4.TabIndex = 6;
            this.txtNum4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNum4.TextChanged += new System.EventHandler(this.txtNum4_TextChanged_1);
            // 
            // txtNum5
            // 
            this.txtNum5.BackColor = System.Drawing.Color.White;
            this.txtNum5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNum5.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum5.ForeColor = System.Drawing.Color.Black;
            this.txtNum5.Location = new System.Drawing.Point(61, 206);
            this.txtNum5.Name = "txtNum5";
            this.txtNum5.Size = new System.Drawing.Size(52, 34);
            this.txtNum5.TabIndex = 7;
            this.txtNum5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNum5.TextChanged += new System.EventHandler(this.txtNum5_TextChanged);
            // 
            // txtNum6
            // 
            this.txtNum6.BackColor = System.Drawing.Color.White;
            this.txtNum6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNum6.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum6.ForeColor = System.Drawing.Color.Black;
            this.txtNum6.Location = new System.Drawing.Point(159, 133);
            this.txtNum6.Name = "txtNum6";
            this.txtNum6.Size = new System.Drawing.Size(52, 34);
            this.txtNum6.TabIndex = 8;
            this.txtNum6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNum6.TextChanged += new System.EventHandler(this.txtNum6_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "INGRESE SUS NUMEROS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(101, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 38);
            this.label2.TabIndex = 10;
            this.label2.Text = "(Del 1 al 49)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNum6);
            this.Controls.Add(this.txtNum5);
            this.Controls.Add(this.txtNum4);
            this.Controls.Add(this.txtNum3);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.btnJugar);
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "Form1";
            this.Text = "¨Simulador de Loteria¨";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.TextBox txtNum4;
        private System.Windows.Forms.TextBox txtNum5;
        private System.Windows.Forms.TextBox txtNum6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

