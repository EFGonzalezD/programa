namespace ProgA2
{
    partial class A2AACC
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
            this.grillaAlumnos = new System.Windows.Forms.DataGridView();
            this.grillaNotas = new System.Windows.Forms.DataGridView();
            this.grillaPromedios = new System.Windows.Forms.DataGridView();
            this.numLegajo = new System.Windows.Forms.NumericUpDown();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnGuardarAlumno = new System.Windows.Forms.Button();
            this.numLegajo2 = new System.Windows.Forms.NumericUpDown();
            this.numNota = new System.Windows.Forms.NumericUpDown();
            this.btnGuardarNota = new System.Windows.Forms.Button();
            this.btnPromedios = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPromedios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLegajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLegajo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNota)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaAlumnos
            // 
            this.grillaAlumnos.AllowUserToAddRows = false;
            this.grillaAlumnos.AllowUserToDeleteRows = false;
            this.grillaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaAlumnos.Location = new System.Drawing.Point(559, 33);
            this.grillaAlumnos.Name = "grillaAlumnos";
            this.grillaAlumnos.ReadOnly = true;
            this.grillaAlumnos.Size = new System.Drawing.Size(301, 96);
            this.grillaAlumnos.TabIndex = 0;
            // 
            // grillaNotas
            // 
            this.grillaNotas.AllowUserToAddRows = false;
            this.grillaNotas.AllowUserToDeleteRows = false;
            this.grillaNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaNotas.Location = new System.Drawing.Point(559, 169);
            this.grillaNotas.Name = "grillaNotas";
            this.grillaNotas.ReadOnly = true;
            this.grillaNotas.Size = new System.Drawing.Size(301, 96);
            this.grillaNotas.TabIndex = 1;
            // 
            // grillaPromedios
            // 
            this.grillaPromedios.AllowUserToAddRows = false;
            this.grillaPromedios.AllowUserToDeleteRows = false;
            this.grillaPromedios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaPromedios.Location = new System.Drawing.Point(289, 310);
            this.grillaPromedios.Name = "grillaPromedios";
            this.grillaPromedios.ReadOnly = true;
            this.grillaPromedios.Size = new System.Drawing.Size(363, 118);
            this.grillaPromedios.TabIndex = 2;
            // 
            // numLegajo
            // 
            this.numLegajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLegajo.Location = new System.Drawing.Point(289, 33);
            this.numLegajo.Name = "numLegajo";
            this.numLegajo.Size = new System.Drawing.Size(264, 45);
            this.numLegajo.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(289, 84);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(264, 45);
            this.txtApellido.TabIndex = 4;
            // 
            // btnGuardarAlumno
            // 
            this.btnGuardarAlumno.Location = new System.Drawing.Point(559, 135);
            this.btnGuardarAlumno.Name = "btnGuardarAlumno";
            this.btnGuardarAlumno.Size = new System.Drawing.Size(301, 28);
            this.btnGuardarAlumno.TabIndex = 5;
            this.btnGuardarAlumno.Text = "Guardar Alumno";
            this.btnGuardarAlumno.UseVisualStyleBackColor = true;
            this.btnGuardarAlumno.Click += new System.EventHandler(this.btnGuardarAlumno_Click);
            // 
            // numLegajo2
            // 
            this.numLegajo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLegajo2.Location = new System.Drawing.Point(289, 169);
            this.numLegajo2.Name = "numLegajo2";
            this.numLegajo2.Size = new System.Drawing.Size(264, 45);
            this.numLegajo2.TabIndex = 6;
            // 
            // numNota
            // 
            this.numNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNota.Location = new System.Drawing.Point(289, 220);
            this.numNota.Name = "numNota";
            this.numNota.Size = new System.Drawing.Size(264, 45);
            this.numNota.TabIndex = 7;
            // 
            // btnGuardarNota
            // 
            this.btnGuardarNota.Location = new System.Drawing.Point(559, 271);
            this.btnGuardarNota.Name = "btnGuardarNota";
            this.btnGuardarNota.Size = new System.Drawing.Size(301, 33);
            this.btnGuardarNota.TabIndex = 8;
            this.btnGuardarNota.Text = "Guardar Nota";
            this.btnGuardarNota.UseVisualStyleBackColor = true;
            this.btnGuardarNota.Click += new System.EventHandler(this.btnGuardarNota_Click);
            // 
            // btnPromedios
            // 
            this.btnPromedios.Location = new System.Drawing.Point(19, 310);
            this.btnPromedios.Name = "btnPromedios";
            this.btnPromedios.Size = new System.Drawing.Size(264, 33);
            this.btnPromedios.TabIndex = 9;
            this.btnPromedios.Text = "Obtener Promedios";
            this.btnPromedios.UseVisualStyleBackColor = true;
            this.btnPromedios.Click += new System.EventHandler(this.btnPromedios_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Legajo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Apellido";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "Legajo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nota";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // A2AACC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 440);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPromedios);
            this.Controls.Add(this.btnGuardarNota);
            this.Controls.Add(this.numNota);
            this.Controls.Add(this.numLegajo2);
            this.Controls.Add(this.btnGuardarAlumno);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.numLegajo);
            this.Controls.Add(this.grillaPromedios);
            this.Controls.Add(this.grillaNotas);
            this.Controls.Add(this.grillaAlumnos);
            this.Name = "A2AACC";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grillaAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPromedios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLegajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLegajo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaAlumnos;
        private System.Windows.Forms.DataGridView grillaNotas;
        private System.Windows.Forms.DataGridView grillaPromedios;
        private System.Windows.Forms.NumericUpDown numLegajo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnGuardarAlumno;
        private System.Windows.Forms.NumericUpDown numLegajo2;
        private System.Windows.Forms.NumericUpDown numNota;
        private System.Windows.Forms.Button btnGuardarNota;
        private System.Windows.Forms.Button btnPromedios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

