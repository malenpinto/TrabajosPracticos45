namespace Practico5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TFoto = new System.Windows.Forms.TextBox();
            this.RBMujer = new System.Windows.Forms.RadioButton();
            this.RBHombre = new System.Windows.Forms.RadioButton();
            this.TSaldo = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.BAgregar = new System.Windows.Forms.Button();
            this.BFoto = new System.Windows.Forms.Button();
            this.LSaldo = new System.Windows.Forms.Label();
            this.LSexo = new System.Windows.Forms.Label();
            this.LFechaNac = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.Ruta = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Practico5.Properties.Resources.Avatar1;
            this.pictureBox1.Location = new System.Drawing.Point(494, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 339);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.TFoto);
            this.panel1.Controls.Add(this.RBMujer);
            this.panel1.Controls.Add(this.RBHombre);
            this.panel1.Controls.Add(this.TSaldo);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.TApellido);
            this.panel1.Controls.Add(this.TNombre);
            this.panel1.Controls.Add(this.BAgregar);
            this.panel1.Controls.Add(this.BFoto);
            this.panel1.Controls.Add(this.LSaldo);
            this.panel1.Controls.Add(this.LSexo);
            this.panel1.Controls.Add(this.LFechaNac);
            this.panel1.Controls.Add(this.LApellido);
            this.panel1.Controls.Add(this.LNombre);
            this.panel1.Location = new System.Drawing.Point(64, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 339);
            this.panel1.TabIndex = 1;
            // 
            // TFoto
            // 
            this.TFoto.Location = new System.Drawing.Point(121, 237);
            this.TFoto.Margin = new System.Windows.Forms.Padding(2);
            this.TFoto.Name = "TFoto";
            this.TFoto.Size = new System.Drawing.Size(241, 20);
            this.TFoto.TabIndex = 13;
            // 
            // RBMujer
            // 
            this.RBMujer.AutoSize = true;
            this.RBMujer.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBMujer.ForeColor = System.Drawing.Color.White;
            this.RBMujer.Location = new System.Drawing.Point(206, 153);
            this.RBMujer.Margin = new System.Windows.Forms.Padding(2);
            this.RBMujer.Name = "RBMujer";
            this.RBMujer.Size = new System.Drawing.Size(70, 29);
            this.RBMujer.TabIndex = 12;
            this.RBMujer.Text = "Mujer";
            this.RBMujer.UseVisualStyleBackColor = true;
            // 
            // RBHombre
            // 
            this.RBHombre.AutoSize = true;
            this.RBHombre.Checked = true;
            this.RBHombre.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBHombre.ForeColor = System.Drawing.Color.White;
            this.RBHombre.Location = new System.Drawing.Point(121, 153);
            this.RBHombre.Margin = new System.Windows.Forms.Padding(2);
            this.RBHombre.Name = "RBHombre";
            this.RBHombre.Size = new System.Drawing.Size(89, 29);
            this.RBHombre.TabIndex = 11;
            this.RBHombre.TabStop = true;
            this.RBHombre.Text = "Hombre";
            this.RBHombre.UseVisualStyleBackColor = true;
            // 
            // TSaldo
            // 
            this.TSaldo.Location = new System.Drawing.Point(121, 194);
            this.TSaldo.Margin = new System.Windows.Forms.Padding(2);
            this.TSaldo.Name = "TSaldo";
            this.TSaldo.Size = new System.Drawing.Size(241, 20);
            this.TSaldo.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(206, 114);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(121, 70);
            this.TApellido.Margin = new System.Windows.Forms.Padding(2);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(241, 20);
            this.TApellido.TabIndex = 8;
            this.TApellido.Leave += new System.EventHandler(this.TApellido_Leave);
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(121, 25);
            this.TNombre.Margin = new System.Windows.Forms.Padding(2);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(241, 20);
            this.TNombre.TabIndex = 7;
            this.TNombre.Leave += new System.EventHandler(this.TNombre_Leave);
            // 
            // BAgregar
            // 
            this.BAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BAgregar.Image")));
            this.BAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAgregar.Location = new System.Drawing.Point(133, 268);
            this.BAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.BAgregar.Name = "BAgregar";
            this.BAgregar.Size = new System.Drawing.Size(127, 59);
            this.BAgregar.TabIndex = 6;
            this.BAgregar.Text = "Agregar";
            this.BAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BAgregar.UseVisualStyleBackColor = true;
            this.BAgregar.Click += new System.EventHandler(this.BAgregar_Click);
            // 
            // BFoto
            // 
            this.BFoto.Location = new System.Drawing.Point(22, 232);
            this.BFoto.Margin = new System.Windows.Forms.Padding(2);
            this.BFoto.Name = "BFoto";
            this.BFoto.Size = new System.Drawing.Size(78, 28);
            this.BFoto.TabIndex = 5;
            this.BFoto.Text = "Foto";
            this.BFoto.UseVisualStyleBackColor = true;
            this.BFoto.Click += new System.EventHandler(this.BFoto_Click);
            // 
            // LSaldo
            // 
            this.LSaldo.AutoSize = true;
            this.LSaldo.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSaldo.ForeColor = System.Drawing.Color.White;
            this.LSaldo.Location = new System.Drawing.Point(19, 184);
            this.LSaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LSaldo.Name = "LSaldo";
            this.LSaldo.Size = new System.Drawing.Size(87, 34);
            this.LSaldo.TabIndex = 4;
            this.LSaldo.Text = "Saldo: ";
            // 
            // LSexo
            // 
            this.LSexo.AutoSize = true;
            this.LSexo.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSexo.ForeColor = System.Drawing.Color.White;
            this.LSexo.Location = new System.Drawing.Point(19, 149);
            this.LSexo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LSexo.Name = "LSexo";
            this.LSexo.Size = new System.Drawing.Size(74, 34);
            this.LSexo.TabIndex = 3;
            this.LSexo.Text = "Sexo:";
            // 
            // LFechaNac
            // 
            this.LFechaNac.AutoSize = true;
            this.LFechaNac.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFechaNac.ForeColor = System.Drawing.Color.White;
            this.LFechaNac.Location = new System.Drawing.Point(19, 106);
            this.LFechaNac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LFechaNac.Name = "LFechaNac";
            this.LFechaNac.Size = new System.Drawing.Size(199, 34);
            this.LFechaNac.TabIndex = 2;
            this.LFechaNac.Text = "Fecha Nacimiento: ";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.ForeColor = System.Drawing.Color.White;
            this.LApellido.Location = new System.Drawing.Point(19, 60);
            this.LApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(104, 34);
            this.LApellido.TabIndex = 1;
            this.LApellido.Text = "Apellido:";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.ForeColor = System.Drawing.Color.White;
            this.LNombre.Location = new System.Drawing.Point(19, 15);
            this.LNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(101, 34);
            this.LNombre.TabIndex = 0;
            this.LNombre.Text = "Nombre: ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Apellido,
            this.Nombre,
            this.FechaNacimiento,
            this.Sexo,
            this.Eliminar,
            this.Saldo,
            this.Foto,
            this.Ruta});
            this.dataGridView1.Location = new System.Drawing.Point(9, 353);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 60;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(792, 195);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Apellido
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Pristina", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellido.DefaultCellStyle = dataGridViewCellStyle1;
            this.Apellido.FillWeight = 60F;
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 125;
            // 
            // Nombre
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Pristina", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle2;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.HeaderText = "Fecha Nacimiento";
            this.FechaNacimiento.MinimumWidth = 6;
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.Width = 125;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.MinimumWidth = 6;
            this.Sexo.Name = "Sexo";
            this.Sexo.Width = 125;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            this.Eliminar.Width = 125;
            // 
            // Saldo
            // 
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.MinimumWidth = 6;
            this.Saldo.Name = "Saldo";
            this.Saldo.Width = 125;
            // 
            // Foto
            // 
            this.Foto.HeaderText = "Foto";
            this.Foto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Foto.MinimumWidth = 6;
            this.Foto.Name = "Foto";
            this.Foto.Width = 125;
            // 
            // Ruta
            // 
            this.Ruta.HeaderText = "Ruta";
            this.Ruta.MinimumWidth = 6;
            this.Ruta.Name = "Ruta";
            this.Ruta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ruta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Ruta.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(810, 580);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario con Grid";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LSaldo;
        private System.Windows.Forms.Label LSexo;
        private System.Windows.Forms.Label LFechaNac;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Button BAgregar;
        private System.Windows.Forms.Button BFoto;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.TextBox TSaldo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton RBHombre;
        private System.Windows.Forms.RadioButton RBMujer;
        private System.Windows.Forms.TextBox TFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewImageColumn Foto;
        private System.Windows.Forms.DataGridViewLinkColumn Ruta;
    }
}

