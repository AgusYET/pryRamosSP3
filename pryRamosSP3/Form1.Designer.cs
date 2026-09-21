namespace pryRamosSP3
{
    partial class Repuestos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Repuestos));
            lblTitulo = new Label();
            txtNumeroRepuesto = new TextBox();
            txtDescripcion = new TextBox();
            txtPrecios = new TextBox();
            lstRepuestos = new ListBox();
            cmbMarca = new ComboBox();
            cmbOrigen = new ComboBox();
            lblMarca = new Label();
            lblOrigen = new Label();
            lblNumero = new Label();
            lblDescripcion = new Label();
            lblPrecio = new Label();
            btnGuardar = new Button();
            lblBusqueda = new Label();
            gbOpciones = new GroupBox();
            cmbMarca2 = new ComboBox();
            rbOrigen2 = new RadioButton();
            rbOrigen = new RadioButton();
            gbOpciones.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Yu Gothic UI", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(53, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(420, 50);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "VENTAS DE REPUESTOS";
            // 
            // txtNumeroRepuesto
            // 
            txtNumeroRepuesto.Location = new Point(220, 183);
            txtNumeroRepuesto.Name = "txtNumeroRepuesto";
            txtNumeroRepuesto.Size = new Size(174, 23);
            txtNumeroRepuesto.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(220, 232);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(174, 23);
            txtDescripcion.TabIndex = 4;
            // 
            // txtPrecios
            // 
            txtPrecios.Location = new Point(220, 283);
            txtPrecios.Name = "txtPrecios";
            txtPrecios.Size = new Size(174, 23);
            txtPrecios.TabIndex = 5;
            // 
            // lstRepuestos
            // 
            lstRepuestos.FormattingEnabled = true;
            lstRepuestos.Location = new Point(53, 379);
            lstRepuestos.Name = "lstRepuestos";
            lstRepuestos.Size = new Size(441, 64);
            lstRepuestos.TabIndex = 7;
            // 
            // cmbMarca
            // 
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Items.AddRange(new object[] { "F", "P", "R" });
            cmbMarca.Location = new Point(239, 83);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(121, 23);
            cmbMarca.TabIndex = 1;
            // 
            // cmbOrigen
            // 
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Items.AddRange(new object[] { "I", "N" });
            cmbOrigen.Location = new Point(239, 130);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(121, 23);
            cmbOrigen.TabIndex = 2;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.BackColor = Color.White;
            lblMarca.Font = new Font("Yu Gothic", 12F, FontStyle.Bold | FontStyle.Italic);
            lblMarca.Location = new Point(96, 83);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(68, 21);
            lblMarca.TabIndex = 10;
            lblMarca.Text = "Marca: ";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.BackColor = Color.White;
            lblOrigen.Font = new Font("Yu Gothic", 12F, FontStyle.Bold | FontStyle.Italic);
            lblOrigen.Location = new Point(96, 132);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(71, 21);
            lblOrigen.TabIndex = 11;
            lblOrigen.Text = "Origen: ";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.BackColor = Color.White;
            lblNumero.Font = new Font("Yu Gothic", 12F, FontStyle.Bold | FontStyle.Italic);
            lblNumero.Location = new Point(96, 183);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(82, 21);
            lblNumero.TabIndex = 12;
            lblNumero.Text = "Numero: ";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = Color.White;
            lblDescripcion.Font = new Font("Yu Gothic", 12F, FontStyle.Bold | FontStyle.Italic);
            lblDescripcion.Location = new Point(96, 235);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(113, 21);
            lblDescripcion.TabIndex = 13;
            lblDescripcion.Text = "Descripcion: ";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.White;
            lblPrecio.Font = new Font("Yu Gothic", 12F, FontStyle.Bold | FontStyle.Italic);
            lblPrecio.Location = new Point(99, 282);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(69, 21);
            lblPrecio.TabIndex = 14;
            lblPrecio.Text = "Precio: ";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(331, 312);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(123, 61);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblBusqueda
            // 
            lblBusqueda.AutoSize = true;
            lblBusqueda.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBusqueda.Location = new Point(2, 446);
            lblBusqueda.Name = "lblBusqueda";
            lblBusqueda.Size = new Size(358, 37);
            lblBusqueda.TabIndex = 16;
            lblBusqueda.Text = "BUSQUEDA DE REPUESTOS";
            // 
            // gbOpciones
            // 
            gbOpciones.Controls.Add(cmbMarca2);
            gbOpciones.Controls.Add(rbOrigen2);
            gbOpciones.Controls.Add(rbOrigen);
            gbOpciones.Location = new Point(21, 486);
            gbOpciones.Name = "gbOpciones";
            gbOpciones.Size = new Size(306, 120);
            gbOpciones.TabIndex = 7;
            gbOpciones.TabStop = false;
            // 
            // cmbMarca2
            // 
            cmbMarca2.FormattingEnabled = true;
            cmbMarca2.Items.AddRange(new object[] { "F", "P", "R" });
            cmbMarca2.Location = new Point(22, 29);
            cmbMarca2.Name = "cmbMarca2";
            cmbMarca2.Size = new Size(121, 23);
            cmbMarca2.TabIndex = 2;
            // 
            // rbOrigen2
            // 
            rbOrigen2.AutoSize = true;
            rbOrigen2.Location = new Point(195, 66);
            rbOrigen2.Name = "rbOrigen2";
            rbOrigen2.Size = new Size(92, 19);
            rbOrigen2.TabIndex = 1;
            rbOrigen2.TabStop = true;
            rbOrigen2.Text = "IMPORTADO";
            rbOrigen2.UseVisualStyleBackColor = true;
            // 
            // rbOrigen
            // 
            rbOrigen.AutoSize = true;
            rbOrigen.Location = new Point(195, 29);
            rbOrigen.Name = "rbOrigen";
            rbOrigen.Size = new Size(85, 19);
            rbOrigen.TabIndex = 0;
            rbOrigen.TabStop = true;
            rbOrigen.Text = "NACIONAL";
            rbOrigen.UseVisualStyleBackColor = true;
            // 
            // Repuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(518, 588);
            Controls.Add(gbOpciones);
            Controls.Add(lblBusqueda);
            Controls.Add(btnGuardar);
            Controls.Add(lblPrecio);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNumero);
            Controls.Add(lblOrigen);
            Controls.Add(lblMarca);
            Controls.Add(cmbOrigen);
            Controls.Add(cmbMarca);
            Controls.Add(lstRepuestos);
            Controls.Add(txtPrecios);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNumeroRepuesto);
            Controls.Add(lblTitulo);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Repuestos";
            Text = "RepuestosSP3";
            gbOpciones.ResumeLayout(false);
            gbOpciones.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtNumeroRepuesto;
        private TextBox txtDescripcion;
        private TextBox txtPrecios;
        private ListBox lstRepuestos;
        private ComboBox cmbMarca;
        private ComboBox cmbOrigen;
        private Label lblMarca;
        private Label lblOrigen;
        private Label lblNumero;
        private Label lblDescripcion;
        private Label lblPrecio;
        private Button btnGuardar;
        private Label lblBusqueda;
        private GroupBox gbOpciones;
        private ComboBox cmbMarca2;
        private RadioButton rbOrigen2;
        private RadioButton rbOrigen;
    }
}
