namespace Vectores
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CrearBtn = new System.Windows.Forms.Button();
            this.MostrarBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.LlenarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GirarArribaBtn = new System.Windows.Forms.Button();
            this.GirarAbajoBtn = new System.Windows.Forms.Button();
            this.BorrarBtn = new System.Windows.Forms.Button();
            this.InvertirBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 149);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(219, 256);
            this.textBox1.TabIndex = 0;
            // 
            // CrearBtn
            // 
            this.CrearBtn.Location = new System.Drawing.Point(481, 169);
            this.CrearBtn.Name = "CrearBtn";
            this.CrearBtn.Size = new System.Drawing.Size(135, 39);
            this.CrearBtn.TabIndex = 1;
            this.CrearBtn.Text = "Crear";
            this.CrearBtn.UseVisualStyleBackColor = true;
            this.CrearBtn.Click += new System.EventHandler(this.CrearBtn_Click);
            // 
            // MostrarBtn
            // 
            this.MostrarBtn.Location = new System.Drawing.Point(481, 382);
            this.MostrarBtn.Name = "MostrarBtn";
            this.MostrarBtn.Size = new System.Drawing.Size(135, 39);
            this.MostrarBtn.TabIndex = 3;
            this.MostrarBtn.Text = "Mostrar";
            this.MostrarBtn.UseVisualStyleBackColor = true;
            this.MostrarBtn.Click += new System.EventHandler(this.MostrarBtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(483, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(481, 260);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(133, 20);
            this.textBox3.TabIndex = 5;
            // 
            // LlenarBtn
            // 
            this.LlenarBtn.Location = new System.Drawing.Point(481, 310);
            this.LlenarBtn.Name = "LlenarBtn";
            this.LlenarBtn.Size = new System.Drawing.Size(132, 40);
            this.LlenarBtn.TabIndex = 6;
            this.LlenarBtn.Text = "Llenar";
            this.LlenarBtn.UseVisualStyleBackColor = true;
            this.LlenarBtn.Click += new System.EventHandler(this.LlenarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Valor inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Texto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tamaño";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(182, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 54);
            this.label4.TabIndex = 10;
            this.label4.Text = "Vector ;v";
            this.label4.Visible = false;
            // 
            // GirarArribaBtn
            // 
            this.GirarArribaBtn.Location = new System.Drawing.Point(653, 101);
            this.GirarArribaBtn.Name = "GirarArribaBtn";
            this.GirarArribaBtn.Size = new System.Drawing.Size(135, 39);
            this.GirarArribaBtn.TabIndex = 11;
            this.GirarArribaBtn.Text = "Girar arriba";
            this.GirarArribaBtn.UseVisualStyleBackColor = true;
            this.GirarArribaBtn.Click += new System.EventHandler(this.GirarArribaBtn_Click);
            // 
            // GirarAbajoBtn
            // 
            this.GirarAbajoBtn.Location = new System.Drawing.Point(653, 169);
            this.GirarAbajoBtn.Name = "GirarAbajoBtn";
            this.GirarAbajoBtn.Size = new System.Drawing.Size(135, 39);
            this.GirarAbajoBtn.TabIndex = 12;
            this.GirarAbajoBtn.Text = "Girar abajo";
            this.GirarAbajoBtn.UseVisualStyleBackColor = true;
            this.GirarAbajoBtn.Click += new System.EventHandler(this.GirarAbajoBtn_Click_1);
            // 
            // BorrarBtn
            // 
            this.BorrarBtn.Location = new System.Drawing.Point(653, 310);
            this.BorrarBtn.Name = "BorrarBtn";
            this.BorrarBtn.Size = new System.Drawing.Size(129, 40);
            this.BorrarBtn.TabIndex = 13;
            this.BorrarBtn.Text = "Borrar";
            this.BorrarBtn.UseVisualStyleBackColor = true;
            this.BorrarBtn.Click += new System.EventHandler(this.BorrarBtn_Click);
            // 
            // InvertirBtn
            // 
            this.InvertirBtn.Location = new System.Drawing.Point(653, 240);
            this.InvertirBtn.Name = "InvertirBtn";
            this.InvertirBtn.Size = new System.Drawing.Size(129, 40);
            this.InvertirBtn.TabIndex = 14;
            this.InvertirBtn.Text = "Invertir";
            this.InvertirBtn.UseVisualStyleBackColor = true;
            this.InvertirBtn.Click += new System.EventHandler(this.InvertirBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InvertirBtn);
            this.Controls.Add(this.BorrarBtn);
            this.Controls.Add(this.GirarAbajoBtn);
            this.Controls.Add(this.GirarArribaBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LlenarBtn);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.MostrarBtn);
            this.Controls.Add(this.CrearBtn);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button CrearBtn;
        private System.Windows.Forms.Button MostrarBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button LlenarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GirarArribaBtn;
        private System.Windows.Forms.Button GirarAbajoBtn;
        private System.Windows.Forms.Button BorrarBtn;
        private System.Windows.Forms.Button InvertirBtn;
    }
}

