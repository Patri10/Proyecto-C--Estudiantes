namespace Proyecto_estudiantes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boton_agregar = new System.Windows.Forms.Button();
            this.text_legajo_agregar = new System.Windows.Forms.TextBox();
            this.text_nombre = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.boton_buscar = new System.Windows.Forms.Button();
            this.boton_eliminar = new System.Windows.Forms.Button();
            this.text_legajo_bor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_estudiantes = new System.Windows.Forms.Label();
            this.label_legajo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.boton_agregar);
            this.groupBox1.Controls.Add(this.text_legajo_agregar);
            this.groupBox1.Controls.Add(this.text_nombre);
            this.groupBox1.Location = new System.Drawing.Point(122, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Estudiante";
            
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Legajo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre ";
            // 
            // boton_agregar
            // 
            this.boton_agregar.Location = new System.Drawing.Point(67, 87);
            this.boton_agregar.Name = "boton_agregar";
            this.boton_agregar.Size = new System.Drawing.Size(75, 23);
            this.boton_agregar.TabIndex = 3;
            this.boton_agregar.Text = "Agregar";
            this.boton_agregar.UseVisualStyleBackColor = true;
            this.boton_agregar.Click += new System.EventHandler(this.boton_agregar_Click);
            // 
            // text_legajo_agregar
            // 
            this.text_legajo_agregar.Location = new System.Drawing.Point(57, 54);
            this.text_legajo_agregar.Name = "text_legajo_agregar";
            this.text_legajo_agregar.Size = new System.Drawing.Size(100, 20);
            this.text_legajo_agregar.TabIndex = 1;
            // 
            // text_nombre
            // 
            this.text_nombre.Location = new System.Drawing.Point(57, 19);
            this.text_nombre.Name = "text_nombre";
            this.text_nombre.Size = new System.Drawing.Size(100, 20);
            this.text_nombre.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.boton_buscar);
            this.groupBox2.Controls.Add(this.boton_eliminar);
            this.groupBox2.Controls.Add(this.text_legajo_bor);
            this.groupBox2.Location = new System.Drawing.Point(462, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 210);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar o Eliminar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ingrese legajo";
           
            // 
            // boton_buscar
            // 
            this.boton_buscar.Location = new System.Drawing.Point(16, 87);
            this.boton_buscar.Name = "boton_buscar";
            this.boton_buscar.Size = new System.Drawing.Size(84, 23);
            this.boton_buscar.TabIndex = 4;
            this.boton_buscar.Text = "Buscar ";
            this.boton_buscar.UseVisualStyleBackColor = true;
            this.boton_buscar.Click += new System.EventHandler(this.boton_buscar_Click);
            // 
            // boton_eliminar
            // 
            this.boton_eliminar.Location = new System.Drawing.Point(117, 87);
            this.boton_eliminar.Name = "boton_eliminar";
            this.boton_eliminar.Size = new System.Drawing.Size(84, 23);
            this.boton_eliminar.TabIndex = 5;
            this.boton_eliminar.Text = "Eliminar ";
            this.boton_eliminar.UseVisualStyleBackColor = true;
            this.boton_eliminar.Click += new System.EventHandler(this.boton_eliminar_Click);
            // 
            // text_legajo_bor
            // 
            this.text_legajo_bor.Location = new System.Drawing.Point(59, 50);
            this.text_legajo_bor.Name = "text_legajo_bor";
            this.text_legajo_bor.Size = new System.Drawing.Size(100, 20);
            this.text_legajo_bor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(45, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Estudiantes:";
            // 
            // label_estudiantes
            // 
            this.label_estudiantes.AutoSize = true;
            this.label_estudiantes.Location = new System.Drawing.Point(190, 302);
            this.label_estudiantes.Name = "label_estudiantes";
            this.label_estudiantes.Size = new System.Drawing.Size(0, 13);
            this.label_estudiantes.TabIndex = 7;
            // 
            // label_legajo
            // 
            this.label_legajo.AutoSize = true;
            this.label_legajo.Location = new System.Drawing.Point(119, 302);
            this.label_legajo.Name = "label_legajo";
            this.label_legajo.Size = new System.Drawing.Size(0, 13);
            this.label_legajo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Legajo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_legajo);
            this.Controls.Add(this.label_estudiantes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
           
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button boton_agregar;
        private System.Windows.Forms.TextBox text_legajo_agregar;
        private System.Windows.Forms.TextBox text_nombre;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button boton_buscar;
        private System.Windows.Forms.Button boton_eliminar;
        private System.Windows.Forms.TextBox text_legajo_bor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_estudiantes;
        private System.Windows.Forms.Label label_legajo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}

