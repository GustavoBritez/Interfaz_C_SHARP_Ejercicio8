namespace Ejercicio8
{
    partial class Ejercicio8
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
            this.Anuncio = new System.Windows.Forms.Label();
            this.TX_1 = new System.Windows.Forms.TextBox();
            this.BTN_Tirar = new System.Windows.Forms.Button();
            this.BTN_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Anuncio
            // 
            this.Anuncio.AutoSize = true;
            this.Anuncio.Location = new System.Drawing.Point(29, 9);
            this.Anuncio.Name = "Anuncio";
            this.Anuncio.Size = new System.Drawing.Size(272, 13);
            this.Anuncio.TabIndex = 0;
            this.Anuncio.Text = "Desarrollar un programa que simule la tirada de un dado.";
            // 
            // TX_1
            // 
            this.TX_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_1.Location = new System.Drawing.Point(135, 67);
            this.TX_1.Multiline = true;
            this.TX_1.Name = "TX_1";
            this.TX_1.Size = new System.Drawing.Size(47, 68);
            this.TX_1.TabIndex = 1;
            // 
            // BTN_Tirar
            // 
            this.BTN_Tirar.Location = new System.Drawing.Point(121, 38);
            this.BTN_Tirar.Name = "BTN_Tirar";
            this.BTN_Tirar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Tirar.TabIndex = 2;
            this.BTN_Tirar.Text = "Tirar";
            this.BTN_Tirar.UseVisualStyleBackColor = true;
            this.BTN_Tirar.Click += new System.EventHandler(this.BTN_Tirar_Click);
            // 
            // BTN_Salir
            // 
            this.BTN_Salir.Location = new System.Drawing.Point(255, 136);
            this.BTN_Salir.Name = "BTN_Salir";
            this.BTN_Salir.Size = new System.Drawing.Size(75, 23);
            this.BTN_Salir.TabIndex = 3;
            this.BTN_Salir.Text = "Salir";
            this.BTN_Salir.UseVisualStyleBackColor = true;
            this.BTN_Salir.Click += new System.EventHandler(this.BTN_Salir_Click);
            // 
            // Ejercicio8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 161);
            this.Controls.Add(this.BTN_Salir);
            this.Controls.Add(this.BTN_Tirar);
            this.Controls.Add(this.TX_1);
            this.Controls.Add(this.Anuncio);
            this.Name = "Ejercicio8";
            this.RightToLeftLayout = true;
            this.Text = "Ejercicio 8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Anuncio;
        private System.Windows.Forms.TextBox TX_1;
        private System.Windows.Forms.Button BTN_Tirar;
        private System.Windows.Forms.Button BTN_Salir;
    }
}

