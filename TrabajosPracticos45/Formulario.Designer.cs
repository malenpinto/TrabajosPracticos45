namespace TrabajosPracticos45
{
    partial class Formulario
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
            this.TDesde = new System.Windows.Forms.TextBox();
            this.THasta = new System.Windows.Forms.TextBox();
            this.BGenerarFuncion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BNumPares = new System.Windows.Forms.Button();
            this.BNumPrimos = new System.Windows.Forms.Button();
            this.BNumImpares = new System.Windows.Forms.Button();
            this.TBListaNumeros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta";
            // 
            // TDesde
            // 
            this.TDesde.Location = new System.Drawing.Point(100, 82);
            this.TDesde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TDesde.Name = "TDesde";
            this.TDesde.Size = new System.Drawing.Size(72, 20);
            this.TDesde.TabIndex = 2;
            this.TDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDesde_KeyPress);
            // 
            // THasta
            // 
            this.THasta.Location = new System.Drawing.Point(100, 125);
            this.THasta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.THasta.Name = "THasta";
            this.THasta.Size = new System.Drawing.Size(72, 20);
            this.THasta.TabIndex = 3;
            this.THasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.THasta_KeyPress);
            // 
            // BGenerarFuncion
            // 
            this.BGenerarFuncion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGenerarFuncion.Location = new System.Drawing.Point(26, 180);
            this.BGenerarFuncion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BGenerarFuncion.Name = "BGenerarFuncion";
            this.BGenerarFuncion.Size = new System.Drawing.Size(156, 23);
            this.BGenerarFuncion.TabIndex = 4;
            this.BGenerarFuncion.Text = "Generar Función";
            this.BGenerarFuncion.UseVisualStyleBackColor = true;
            this.BGenerarFuncion.Click += new System.EventHandler(this.BGenerarFuncion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lista de Números";
            // 
            // BNumPares
            // 
            this.BNumPares.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNumPares.Location = new System.Drawing.Point(26, 219);
            this.BNumPares.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BNumPares.Name = "BNumPares";
            this.BNumPares.Size = new System.Drawing.Size(156, 23);
            this.BNumPares.TabIndex = 7;
            this.BNumPares.Text = "Números Pares";
            this.BNumPares.UseVisualStyleBackColor = true;
            this.BNumPares.Click += new System.EventHandler(this.BNumPares_Click);
            // 
            // BNumPrimos
            // 
            this.BNumPrimos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNumPrimos.Location = new System.Drawing.Point(26, 298);
            this.BNumPrimos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BNumPrimos.Name = "BNumPrimos";
            this.BNumPrimos.Size = new System.Drawing.Size(156, 23);
            this.BNumPrimos.TabIndex = 8;
            this.BNumPrimos.Text = "Números Primos";
            this.BNumPrimos.UseVisualStyleBackColor = true;
            this.BNumPrimos.Click += new System.EventHandler(this.BNumPrimos_Click);
            // 
            // BNumImpares
            // 
            this.BNumImpares.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNumImpares.Location = new System.Drawing.Point(26, 259);
            this.BNumImpares.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BNumImpares.Name = "BNumImpares";
            this.BNumImpares.Size = new System.Drawing.Size(156, 23);
            this.BNumImpares.TabIndex = 9;
            this.BNumImpares.Text = "Números Impares";
            this.BNumImpares.UseVisualStyleBackColor = true;
            this.BNumImpares.Click += new System.EventHandler(this.BNumImpares_Click);
            // 
            // TBListaNumeros
            // 
            this.TBListaNumeros.FormattingEnabled = true;
            this.TBListaNumeros.Location = new System.Drawing.Point(211, 84);
            this.TBListaNumeros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBListaNumeros.Name = "TBListaNumeros";
            this.TBListaNumeros.Size = new System.Drawing.Size(273, 277);
            this.TBListaNumeros.TabIndex = 10;
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 407);
            this.Controls.Add(this.TBListaNumeros);
            this.Controls.Add(this.BNumImpares);
            this.Controls.Add(this.BNumPrimos);
            this.Controls.Add(this.BNumPares);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BGenerarFuncion);
            this.Controls.Add(this.THasta);
            this.Controls.Add(this.TDesde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TDesde;
        private System.Windows.Forms.TextBox THasta;
        private System.Windows.Forms.Button BGenerarFuncion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BNumPares;
        private System.Windows.Forms.Button BNumPrimos;
        private System.Windows.Forms.Button BNumImpares;
        private System.Windows.Forms.ListBox TBListaNumeros;
    }
}

