namespace Practico4
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
            this.LBListaNumeros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta";
            // 
            // TDesde
            // 
            this.TDesde.Location = new System.Drawing.Point(133, 101);
            this.TDesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TDesde.Name = "TDesde";
            this.TDesde.Size = new System.Drawing.Size(95, 22);
            this.TDesde.TabIndex = 2;
            this.TDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDesde_KeyPress);
            // 
            // THasta
            // 
            this.THasta.Location = new System.Drawing.Point(133, 154);
            this.THasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.THasta.Name = "THasta";
            this.THasta.Size = new System.Drawing.Size(95, 22);
            this.THasta.TabIndex = 3;
            this.THasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.THasta_KeyPress);
            // 
            // BGenerarFuncion
            // 
            this.BGenerarFuncion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGenerarFuncion.Location = new System.Drawing.Point(35, 222);
            this.BGenerarFuncion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BGenerarFuncion.Name = "BGenerarFuncion";
            this.BGenerarFuncion.Size = new System.Drawing.Size(208, 28);
            this.BGenerarFuncion.TabIndex = 4;
            this.BGenerarFuncion.Text = "Generar Función";
            this.BGenerarFuncion.UseVisualStyleBackColor = true;
            this.BGenerarFuncion.Click += new System.EventHandler(this.BGenerarFuncion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(377, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lista de Números";
            // 
            // BNumPares
            // 
            this.BNumPares.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNumPares.Location = new System.Drawing.Point(35, 270);
            this.BNumPares.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BNumPares.Name = "BNumPares";
            this.BNumPares.Size = new System.Drawing.Size(208, 28);
            this.BNumPares.TabIndex = 7;
            this.BNumPares.Text = "Números Pares";
            this.BNumPares.UseVisualStyleBackColor = true;
            this.BNumPares.Click += new System.EventHandler(this.BNumPares_Click);
            // 
            // BNumPrimos
            // 
            this.BNumPrimos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNumPrimos.Location = new System.Drawing.Point(35, 367);
            this.BNumPrimos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BNumPrimos.Name = "BNumPrimos";
            this.BNumPrimos.Size = new System.Drawing.Size(208, 28);
            this.BNumPrimos.TabIndex = 8;
            this.BNumPrimos.Text = "Números Primos";
            this.BNumPrimos.UseVisualStyleBackColor = true;
            this.BNumPrimos.Click += new System.EventHandler(this.BNumPrimos_Click);
            // 
            // BNumImpares
            // 
            this.BNumImpares.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNumImpares.Location = new System.Drawing.Point(35, 319);
            this.BNumImpares.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BNumImpares.Name = "BNumImpares";
            this.BNumImpares.Size = new System.Drawing.Size(208, 28);
            this.BNumImpares.TabIndex = 9;
            this.BNumImpares.Text = "Números Impares";
            this.BNumImpares.UseVisualStyleBackColor = true;
            this.BNumImpares.Click += new System.EventHandler(this.BNumImpares_Click);
            // 
            // LBListaNumeros
            // 
            this.LBListaNumeros.FormattingEnabled = true;
            this.LBListaNumeros.ItemHeight = 16;
            this.LBListaNumeros.Location = new System.Drawing.Point(281, 103);
            this.LBListaNumeros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LBListaNumeros.Name = "LBListaNumeros";
            this.LBListaNumeros.Size = new System.Drawing.Size(363, 340);
            this.LBListaNumeros.TabIndex = 10;
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 501);
            this.Controls.Add(this.LBListaNumeros);
            this.Controls.Add(this.BNumImpares);
            this.Controls.Add(this.BNumPrimos);
            this.Controls.Add(this.BNumPares);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BGenerarFuncion);
            this.Controls.Add(this.THasta);
            this.Controls.Add(this.TDesde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ListBox LBListaNumeros;
    }
}

