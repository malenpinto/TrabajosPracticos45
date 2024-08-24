namespace Practico4
{
    partial class Formulario2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button BLimpiar;
            System.Windows.Forms.Button BSalir;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LBListaNumeros = new System.Windows.Forms.ListBox();
            this.BNumImpares = new System.Windows.Forms.Button();
            this.BNumPrimos = new System.Windows.Forms.Button();
            this.BNumPares = new System.Windows.Forms.Button();
            this.BGenerarFuncion = new System.Windows.Forms.Button();
            this.THasta = new System.Windows.Forms.TextBox();
            this.TDesde = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            BLimpiar = new System.Windows.Forms.Button();
            BSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // BLimpiar
            // 
            BLimpiar.BackColor = System.Drawing.Color.Gainsboro;
            BLimpiar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BLimpiar.ForeColor = System.Drawing.SystemColors.Desktop;
            BLimpiar.Location = new System.Drawing.Point(153, 488);
            BLimpiar.Name = "BLimpiar";
            BLimpiar.Size = new System.Drawing.Size(186, 56);
            BLimpiar.TabIndex = 1;
            BLimpiar.Text = "Limpiar";
            BLimpiar.UseVisualStyleBackColor = false;
            BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click);
            // 
            // BSalir
            // 
            BSalir.BackColor = System.Drawing.Color.Gainsboro;
            BSalir.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BSalir.ForeColor = System.Drawing.SystemColors.Desktop;
            BSalir.Location = new System.Drawing.Point(390, 488);
            BSalir.Name = "BSalir";
            BSalir.Size = new System.Drawing.Size(186, 56);
            BSalir.TabIndex = 2;
            BSalir.Text = "Salir";
            BSalir.UseVisualStyleBackColor = false;
            BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.LBListaNumeros);
            this.panel1.Controls.Add(this.BNumImpares);
            this.panel1.Controls.Add(this.BNumPrimos);
            this.panel1.Controls.Add(this.BNumPares);
            this.panel1.Controls.Add(this.BGenerarFuncion);
            this.panel1.Controls.Add(this.THasta);
            this.panel1.Controls.Add(this.TDesde);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 457);
            this.panel1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(289, 260);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(357, 173);
            this.chart1.TabIndex = 21;
            this.chart1.Text = "chart1";
            // 
            // LBListaNumeros
            // 
            this.LBListaNumeros.FormattingEnabled = true;
            this.LBListaNumeros.ItemHeight = 16;
            this.LBListaNumeros.Location = new System.Drawing.Point(289, 77);
            this.LBListaNumeros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LBListaNumeros.Name = "LBListaNumeros";
            this.LBListaNumeros.Size = new System.Drawing.Size(357, 164);
            this.LBListaNumeros.TabIndex = 20;
            // 
            // BNumImpares
            // 
            this.BNumImpares.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNumImpares.Location = new System.Drawing.Point(43, 293);
            this.BNumImpares.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BNumImpares.Name = "BNumImpares";
            this.BNumImpares.Size = new System.Drawing.Size(208, 28);
            this.BNumImpares.TabIndex = 19;
            this.BNumImpares.Text = "Números Impares";
            this.BNumImpares.UseVisualStyleBackColor = true;
            this.BNumImpares.Click += new System.EventHandler(this.BNumImpares_Click);
            // 
            // BNumPrimos
            // 
            this.BNumPrimos.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNumPrimos.Location = new System.Drawing.Point(43, 341);
            this.BNumPrimos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BNumPrimos.Name = "BNumPrimos";
            this.BNumPrimos.Size = new System.Drawing.Size(208, 28);
            this.BNumPrimos.TabIndex = 18;
            this.BNumPrimos.Text = "Números Primos";
            this.BNumPrimos.UseVisualStyleBackColor = true;
            this.BNumPrimos.Click += new System.EventHandler(this.BNumPrimos_Click);
            // 
            // BNumPares
            // 
            this.BNumPares.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNumPares.Location = new System.Drawing.Point(43, 244);
            this.BNumPares.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BNumPares.Name = "BNumPares";
            this.BNumPares.Size = new System.Drawing.Size(208, 28);
            this.BNumPares.TabIndex = 17;
            this.BNumPares.Text = "Números Pares";
            this.BNumPares.UseVisualStyleBackColor = true;
            this.BNumPares.Click += new System.EventHandler(this.BNumPares_Click);
            // 
            // BGenerarFuncion
            // 
            this.BGenerarFuncion.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGenerarFuncion.Location = new System.Drawing.Point(43, 196);
            this.BGenerarFuncion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BGenerarFuncion.Name = "BGenerarFuncion";
            this.BGenerarFuncion.Size = new System.Drawing.Size(208, 28);
            this.BGenerarFuncion.TabIndex = 15;
            this.BGenerarFuncion.Text = "Generar Función";
            this.BGenerarFuncion.UseVisualStyleBackColor = true;
            this.BGenerarFuncion.Click += new System.EventHandler(this.BGenerarFuncion_Click);
            // 
            // THasta
            // 
            this.THasta.Location = new System.Drawing.Point(141, 128);
            this.THasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.THasta.Name = "THasta";
            this.THasta.Size = new System.Drawing.Size(95, 22);
            this.THasta.TabIndex = 14;
            this.THasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.THasta_KeyPress);
            // 
            // TDesde
            // 
            this.TDesde.Location = new System.Drawing.Point(141, 75);
            this.TDesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TDesde.Name = "TDesde";
            this.TDesde.Size = new System.Drawing.Size(95, 22);
            this.TDesde.TabIndex = 13;
            this.TDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDesde_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hasta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Desde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(193, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Números";
            // 
            // Formulario2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 574);
            this.Controls.Add(BSalir);
            this.Controls.Add(BLimpiar);
            this.Controls.Add(this.panel1);
            this.Name = "Formulario2";
            this.Text = "Formulario Modificado";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LBListaNumeros;
        private System.Windows.Forms.Button BNumImpares;
        private System.Windows.Forms.Button BNumPrimos;
        private System.Windows.Forms.Button BNumPares;
        private System.Windows.Forms.Button BGenerarFuncion;
        private System.Windows.Forms.TextBox THasta;
        private System.Windows.Forms.TextBox TDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}