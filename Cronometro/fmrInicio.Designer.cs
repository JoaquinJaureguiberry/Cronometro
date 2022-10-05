namespace Cronometro
{
    partial class fmrInicio
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
            this.btRestablecer = new System.Windows.Forms.Button();
            this.btCronometro = new System.Windows.Forms.Button();
            this.btDetener = new System.Windows.Forms.Button();
            this.lblContador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btRestablecer
            // 
            this.btRestablecer.Location = new System.Drawing.Point(24, 41);
            this.btRestablecer.Name = "btRestablecer";
            this.btRestablecer.Size = new System.Drawing.Size(85, 23);
            this.btRestablecer.TabIndex = 2;
            this.btRestablecer.TabStop = false;
            this.btRestablecer.Text = "Restablecer";
            this.btRestablecer.UseVisualStyleBackColor = true;
            this.btRestablecer.Click += new System.EventHandler(this.btRestablecer_Click);
            // 
            // btCronometro
            // 
            this.btCronometro.Location = new System.Drawing.Point(24, 12);
            this.btCronometro.Name = "btCronometro";
            this.btCronometro.Size = new System.Drawing.Size(85, 23);
            this.btCronometro.TabIndex = 3;
            this.btCronometro.TabStop = false;
            this.btCronometro.Text = "Cronometro";
            this.btCronometro.UseVisualStyleBackColor = true;
            this.btCronometro.Click += new System.EventHandler(this.btCronometro_Click);
            // 
            // btDetener
            // 
            this.btDetener.Location = new System.Drawing.Point(24, 70);
            this.btDetener.Name = "btDetener";
            this.btDetener.Size = new System.Drawing.Size(85, 23);
            this.btDetener.TabIndex = 5;
            this.btDetener.TabStop = false;
            this.btDetener.Text = "Detener";
            this.btDetener.UseVisualStyleBackColor = true;
            this.btDetener.Click += new System.EventHandler(this.btDetener_Click);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblContador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Location = new System.Drawing.Point(166, 37);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(41, 27);
            this.lblContador.TabIndex = 6;
            this.lblContador.Text = "0.0";
            this.lblContador.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // fmrInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(261, 119);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.btDetener);
            this.Controls.Add(this.btCronometro);
            this.Controls.Add(this.btRestablecer);
            this.Name = "fmrInicio";
            this.Text = "FORMULARIO 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btRestablecer;
        private System.Windows.Forms.Button btCronometro;
        private System.Windows.Forms.Button btDetener;
        private System.Windows.Forms.Label lblContador;
    }
}

