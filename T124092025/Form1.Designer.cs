namespace T124092025
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Bmostrar = new System.Windows.Forms.Button();
            this.Binsetar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Bbuscar = new System.Windows.Forms.Button();
            this.Bmodificar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Beliminar = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Bcontar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(70, 124);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(151, 228);
            this.listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(384, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // Bmostrar
            // 
            this.Bmostrar.Location = new System.Drawing.Point(256, 177);
            this.Bmostrar.Name = "Bmostrar";
            this.Bmostrar.Size = new System.Drawing.Size(109, 23);
            this.Bmostrar.TabIndex = 2;
            this.Bmostrar.Text = "Mostrar";
            this.Bmostrar.UseVisualStyleBackColor = true;
            this.Bmostrar.Click += new System.EventHandler(this.Bmostrar_Click);
            // 
            // Binsetar
            // 
            this.Binsetar.Location = new System.Drawing.Point(256, 134);
            this.Binsetar.Name = "Binsetar";
            this.Binsetar.Size = new System.Drawing.Size(109, 23);
            this.Binsetar.TabIndex = 3;
            this.Binsetar.Text = "Insertar";
            this.Binsetar.UseVisualStyleBackColor = true;
            this.Binsetar.Click += new System.EventHandler(this.Binsetar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "LISTAENLAZADA SIMPLE";
            // 
            // Bbuscar
            // 
            this.Bbuscar.Location = new System.Drawing.Point(256, 224);
            this.Bbuscar.Name = "Bbuscar";
            this.Bbuscar.Size = new System.Drawing.Size(109, 23);
            this.Bbuscar.TabIndex = 5;
            this.Bbuscar.Text = "Buscar";
            this.Bbuscar.UseVisualStyleBackColor = true;
            this.Bbuscar.Click += new System.EventHandler(this.Bbuscar_Click);
            // 
            // Bmodificar
            // 
            this.Bmodificar.Location = new System.Drawing.Point(256, 274);
            this.Bmodificar.Name = "Bmodificar";
            this.Bmodificar.Size = new System.Drawing.Size(109, 23);
            this.Bmodificar.TabIndex = 6;
            this.Bmodificar.Text = "Modificar";
            this.Bmodificar.UseVisualStyleBackColor = true;
            this.Bmodificar.Click += new System.EventHandler(this.Bmodificar_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(384, 274);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 7;
            // 
            // Beliminar
            // 
            this.Beliminar.Location = new System.Drawing.Point(256, 320);
            this.Beliminar.Name = "Beliminar";
            this.Beliminar.Size = new System.Drawing.Size(109, 23);
            this.Beliminar.TabIndex = 8;
            this.Beliminar.Text = "Eliminar";
            this.Beliminar.UseVisualStyleBackColor = true;
            this.Beliminar.Click += new System.EventHandler(this.Beliminar_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(384, 321);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 9;
            // 
            // Bcontar
            // 
            this.Bcontar.Location = new System.Drawing.Point(256, 370);
            this.Bcontar.Name = "Bcontar";
            this.Bcontar.Size = new System.Drawing.Size(109, 23);
            this.Bcontar.TabIndex = 10;
            this.Bcontar.Text = "Contar";
            this.Bcontar.UseVisualStyleBackColor = true;
            this.Bcontar.Click += new System.EventHandler(this.Bcontar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 546);
            this.Controls.Add(this.Bcontar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Beliminar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Bmodificar);
            this.Controls.Add(this.Bbuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Binsetar);
            this.Controls.Add(this.Bmostrar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "TEX";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Bmostrar;
        private System.Windows.Forms.Button Binsetar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bbuscar;
        private System.Windows.Forms.Button Bmodificar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Beliminar;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Bcontar;
    }
}

