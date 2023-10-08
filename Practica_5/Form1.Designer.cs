namespace Practica_5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Nombre = new System.Windows.Forms.TextBox();
            this.tb_Apellidos = new System.Windows.Forms.TextBox();
            this.tb_Telefono = new System.Windows.Forms.TextBox();
            this.tb_Estatura = new System.Windows.Forms.TextBox();
            this.tb_Edad = new System.Windows.Forms.TextBox();
            this.gb_Genero = new System.Windows.Forms.GroupBox();
            this.rb_Hombre = new System.Windows.Forms.RadioButton();
            this.rb_Mujer = new System.Windows.Forms.RadioButton();
            this.bt_Guardar = new System.Windows.Forms.Button();
            this.bt_Cancelar = new System.Windows.Forms.Button();
            this.gb_Genero.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estatura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Edad";
            // 
            // tb_Nombre
            // 
            this.tb_Nombre.Location = new System.Drawing.Point(126, 29);
            this.tb_Nombre.Name = "tb_Nombre";
            this.tb_Nombre.Size = new System.Drawing.Size(100, 20);
            this.tb_Nombre.TabIndex = 5;
            // 
            // tb_Apellidos
            // 
            this.tb_Apellidos.Location = new System.Drawing.Point(126, 60);
            this.tb_Apellidos.Name = "tb_Apellidos";
            this.tb_Apellidos.Size = new System.Drawing.Size(100, 20);
            this.tb_Apellidos.TabIndex = 6;
            // 
            // tb_Telefono
            // 
            this.tb_Telefono.Location = new System.Drawing.Point(126, 93);
            this.tb_Telefono.Name = "tb_Telefono";
            this.tb_Telefono.Size = new System.Drawing.Size(100, 20);
            this.tb_Telefono.TabIndex = 7;
            // 
            // tb_Estatura
            // 
            this.tb_Estatura.Location = new System.Drawing.Point(126, 126);
            this.tb_Estatura.Name = "tb_Estatura";
            this.tb_Estatura.Size = new System.Drawing.Size(100, 20);
            this.tb_Estatura.TabIndex = 8;
            // 
            // tb_Edad
            // 
            this.tb_Edad.Location = new System.Drawing.Point(126, 159);
            this.tb_Edad.Name = "tb_Edad";
            this.tb_Edad.Size = new System.Drawing.Size(100, 20);
            this.tb_Edad.TabIndex = 9;
            // 
            // gb_Genero
            // 
            this.gb_Genero.Controls.Add(this.rb_Mujer);
            this.gb_Genero.Controls.Add(this.rb_Hombre);
            this.gb_Genero.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Genero.Location = new System.Drawing.Point(74, 219);
            this.gb_Genero.Name = "gb_Genero";
            this.gb_Genero.Size = new System.Drawing.Size(200, 100);
            this.gb_Genero.TabIndex = 10;
            this.gb_Genero.TabStop = false;
            this.gb_Genero.Text = "Genero";
            // 
            // rb_Hombre
            // 
            this.rb_Hombre.AutoSize = true;
            this.rb_Hombre.Location = new System.Drawing.Point(16, 42);
            this.rb_Hombre.Name = "rb_Hombre";
            this.rb_Hombre.Size = new System.Drawing.Size(75, 20);
            this.rb_Hombre.TabIndex = 0;
            this.rb_Hombre.TabStop = true;
            this.rb_Hombre.Text = "Hombre";
            this.rb_Hombre.UseVisualStyleBackColor = true;
            // 
            // rb_Mujer
            // 
            this.rb_Mujer.AutoSize = true;
            this.rb_Mujer.Location = new System.Drawing.Point(116, 42);
            this.rb_Mujer.Name = "rb_Mujer";
            this.rb_Mujer.Size = new System.Drawing.Size(61, 20);
            this.rb_Mujer.TabIndex = 1;
            this.rb_Mujer.TabStop = true;
            this.rb_Mujer.Text = "Mujer";
            this.rb_Mujer.UseVisualStyleBackColor = true;
            // 
            // bt_Guardar
            // 
            this.bt_Guardar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Guardar.Location = new System.Drawing.Point(158, 337);
            this.bt_Guardar.Name = "bt_Guardar";
            this.bt_Guardar.Size = new System.Drawing.Size(75, 38);
            this.bt_Guardar.TabIndex = 11;
            this.bt_Guardar.Text = "Guardar";
            this.bt_Guardar.UseVisualStyleBackColor = true;
            this.bt_Guardar.Click += new System.EventHandler(this.bt_Guardar_Click);
            // 
            // bt_Cancelar
            // 
            this.bt_Cancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cancelar.Location = new System.Drawing.Point(158, 381);
            this.bt_Cancelar.Name = "bt_Cancelar";
            this.bt_Cancelar.Size = new System.Drawing.Size(75, 39);
            this.bt_Cancelar.TabIndex = 12;
            this.bt_Cancelar.Text = "Cancelar";
            this.bt_Cancelar.UseVisualStyleBackColor = true;
            this.bt_Cancelar.Click += new System.EventHandler(this.bt_Cancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 450);
            this.Controls.Add(this.bt_Cancelar);
            this.Controls.Add(this.bt_Guardar);
            this.Controls.Add(this.gb_Genero);
            this.Controls.Add(this.tb_Edad);
            this.Controls.Add(this.tb_Estatura);
            this.Controls.Add(this.tb_Telefono);
            this.Controls.Add(this.tb_Apellidos);
            this.Controls.Add(this.tb_Nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_Genero.ResumeLayout(false);
            this.gb_Genero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Nombre;
        private System.Windows.Forms.TextBox tb_Apellidos;
        private System.Windows.Forms.TextBox tb_Telefono;
        private System.Windows.Forms.TextBox tb_Estatura;
        private System.Windows.Forms.TextBox tb_Edad;
        private System.Windows.Forms.GroupBox gb_Genero;
        private System.Windows.Forms.RadioButton rb_Mujer;
        private System.Windows.Forms.RadioButton rb_Hombre;
        private System.Windows.Forms.Button bt_Guardar;
        private System.Windows.Forms.Button bt_Cancelar;
    }
}

