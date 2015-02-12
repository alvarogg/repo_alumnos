namespace Alumnos
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
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            this.tmedia = new System.Windows.Forms.TextBox();
            this.tnombre = new System.Windows.Forms.TextBox();
            this.tnota = new System.Windows.Forms.TextBox();
            this.tlista = new System.Windows.Forms.TextBox();
            this.lnombre = new System.Windows.Forms.Label();
            this.lnota = new System.Windows.Forms.Label();
            this.llista = new System.Windows.Forms.Label();
            this.lmedia = new System.Windows.Forms.Label();
            this.bguardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tmedia
            // 
            this.tmedia.Location = new System.Drawing.Point(391, 282);
            this.tmedia.Name = "tmedia";
            this.tmedia.ReadOnly = true;
            this.tmedia.Size = new System.Drawing.Size(100, 20);
            this.tmedia.TabIndex = 0;
            // 
            // tnombre
            // 
            this.tnombre.Location = new System.Drawing.Point(50, 31);
            this.tnombre.Name = "tnombre";
            this.tnombre.Size = new System.Drawing.Size(181, 20);
            this.tnombre.TabIndex = 1;
            // 
            // tnota
            // 
            this.tnota.Location = new System.Drawing.Point(278, 31);
            this.tnota.Name = "tnota";
            this.tnota.Size = new System.Drawing.Size(100, 20);
            this.tnota.TabIndex = 2;
            // 
            // tlista
            // 
            this.tlista.Location = new System.Drawing.Point(50, 73);
            this.tlista.Multiline = true;
            this.tlista.Name = "tlista";
            this.tlista.ReadOnly = true;
            this.tlista.Size = new System.Drawing.Size(465, 190);
            this.tlista.TabIndex = 3;
            // 
            // lnombre
            // 
            this.lnombre.AutoSize = true;
            this.lnombre.Location = new System.Drawing.Point(50, 12);
            this.lnombre.Name = "lnombre";
            this.lnombre.Size = new System.Drawing.Size(85, 13);
            this.lnombre.TabIndex = 4;
            this.lnombre.Text = "Nombre Alumno:";
            // 
            // lnota
            // 
            this.lnota.AutoSize = true;
            this.lnota.Location = new System.Drawing.Point(275, 9);
            this.lnota.Name = "lnota";
            this.lnota.Size = new System.Drawing.Size(33, 13);
            this.lnota.TabIndex = 5;
            this.lnota.Text = "Nota:";
            // 
            // llista
            // 
            this.llista.AutoSize = true;
            this.llista.Location = new System.Drawing.Point(47, 57);
            this.llista.Name = "llista";
            this.llista.Size = new System.Drawing.Size(90, 13);
            this.llista.TabIndex = 6;
            this.llista.Text = "Lista de Alumnos:";
            // 
            // lmedia
            // 
            this.lmedia.AutoSize = true;
            this.lmedia.Location = new System.Drawing.Point(313, 285);
            this.lmedia.Name = "lmedia";
            this.lmedia.Size = new System.Drawing.Size(65, 13);
            this.lmedia.TabIndex = 7;
            this.lmedia.Text = "Nota Media:";
            // 
            // bguardar
            // 
            this.bguardar.Location = new System.Drawing.Point(391, 28);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(124, 23);
            this.bguardar.TabIndex = 8;
            this.bguardar.Text = "GUARDAR ALUMNO";
            this.bguardar.UseVisualStyleBackColor = true;
            this.bguardar.Click += new System.EventHandler(this.bguardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 314);
            this.Controls.Add(this.bguardar);
            this.Controls.Add(this.lmedia);
            this.Controls.Add(this.llista);
            this.Controls.Add(this.lnota);
            this.Controls.Add(this.lnombre);
            this.Controls.Add(this.tlista);
            this.Controls.Add(this.tnota);
            this.Controls.Add(this.tnombre);
            this.Controls.Add(this.tmedia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tmedia;
        private System.Windows.Forms.TextBox tnombre;
        private System.Windows.Forms.TextBox tnota;
        private System.Windows.Forms.TextBox tlista;
        private System.Windows.Forms.Label lnombre;
        private System.Windows.Forms.Label lnota;
        private System.Windows.Forms.Label llista;
        private System.Windows.Forms.Label lmedia;
        private System.Windows.Forms.Button bguardar;
    }
}

