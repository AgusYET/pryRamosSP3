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
            tbp = new TabControl();
            tbpCarga = new TabPage();
            rbImportado = new RadioButton();
            rbNacional = new RadioButton();
            lstRepuestos = new ListBox();
            btnGuardar = new Button();
            lblPrecio = new Label();
            lblDescripcion = new Label();
            lblNumero = new Label();
            lblMarca = new Label();
            cmbMarca = new ComboBox();
            txtPrecios = new TextBox();
            txtDescripcion = new TextBox();
            txtNumeroRepuesto = new TextBox();
            tbpBusqueda = new TabPage();
            gbOpciones = new GroupBox();
            rdbImportado = new RadioButton();
            rdbNacional = new RadioButton();
            cmbMarca2 = new ComboBox();
            lblBusqueda = new Label();
            gbOrigen = new GroupBox();
            tbp.SuspendLayout();
            tbpCarga.SuspendLayout();
            tbpBusqueda.SuspendLayout();
            gbOpciones.SuspendLayout();
            gbOrigen.SuspendLayout();
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
            // tbp
            // 
            tbp.Controls.Add(tbpCarga);
            tbp.Controls.Add(tbpBusqueda);
            tbp.Location = new Point(2, 102);
            tbp.Name = "tbp";
            tbp.SelectedIndex = 0;
            tbp.Size = new Size(537, 419);
            tbp.TabIndex = 17;
            // 
            // tbpCarga
            // 
            tbpCarga.BackColor = SystemColors.ActiveCaption;
            tbpCarga.Controls.Add(gbOrigen);
            tbpCarga.Controls.Add(lstRepuestos);
            tbpCarga.Controls.Add(btnGuardar);
            tbpCarga.Controls.Add(lblPrecio);
            tbpCarga.Controls.Add(lblDescripcion);
            tbpCarga.Controls.Add(lblNumero);
            tbpCarga.Controls.Add(lblMarca);
            tbpCarga.Controls.Add(cmbMarca);
            tbpCarga.Controls.Add(txtPrecios);
            tbpCarga.Controls.Add(txtDescripcion);
            tbpCarga.Controls.Add(txtNumeroRepuesto);
            tbpCarga.Location = new Point(4, 24);
            tbpCarga.Name = "tbpCarga";
            tbpCarga.Padding = new Padding(3);
            tbpCarga.Size = new Size(529, 391);
            tbpCarga.TabIndex = 0;
            tbpCarga.Text = "Carga De Repuestos";
            // 
            // rbImportado
            // 
            rbImportado.AutoSize = true;
            rbImportado.Location = new Point(210, 10);
            rbImportado.Name = "rbImportado";
            rbImportado.Size = new Size(92, 19);
            rbImportado.TabIndex = 28;
            rbImportado.TabStop = true;
            rbImportado.Text = "IMPORTADO";
            rbImportado.UseVisualStyleBackColor = true;
            // 
            // rbNacional
            // 
            rbNacional.AutoSize = true;
            rbNacional.Location = new Point(119, 10);
            rbNacional.Name = "rbNacional";
            rbNacional.Size = new Size(85, 19);
            rbNacional.TabIndex = 27;
            rbNacional.TabStop = true;
            rbNacional.Text = "NACIONAL";
            rbNacional.UseVisualStyleBackColor = true;
            // 
            // lstRepuestos
            // 
            lstRepuestos.FormattingEnabled = true;
            lstRepuestos.Location = new Point(6, 306);
            lstRepuestos.Name = "lstRepuestos";
            lstRepuestos.Size = new Size(502, 79);
            lstRepuestos.TabIndex = 26;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(313, 241);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(123, 61);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.White;
            lblPrecio.Font = new Font("Yu Gothic", 12F, FontStyle.Bold | FontStyle.Italic);
            lblPrecio.Location = new Point(122, 253);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(69, 21);
            lblPrecio.TabIndex = 25;
            lblPrecio.Text = "Precio: ";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = Color.White;
            lblDescripcion.Font = new Font("Yu Gothic", 12F, FontStyle.Bold | FontStyle.Italic);
            lblDescripcion.Location = new Point(78, 164);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(113, 21);
            lblDescripcion.TabIndex = 24;
            lblDescripcion.Text = "Descripcion: ";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.BackColor = Color.White;
            lblNumero.Font = new Font("Yu Gothic", 12F, FontStyle.Bold | FontStyle.Italic);
            lblNumero.Location = new Point(109, 114);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(82, 21);
            lblNumero.TabIndex = 23;
            lblNumero.Text = "Numero: ";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.BackColor = Color.White;
            lblMarca.Font = new Font("Yu Gothic", 12F, FontStyle.Bold | FontStyle.Italic);
            lblMarca.Location = new Point(123, 14);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(68, 21);
            lblMarca.TabIndex = 21;
            lblMarca.Text = "Marca: ";
            // 
            // cmbMarca
            // 
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Items.AddRange(new object[] { "F", "P", "R" });
            cmbMarca.Location = new Point(202, 15);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(121, 23);
            cmbMarca.TabIndex = 15;
            // 
            // txtPrecios
            // 
            txtPrecios.Location = new Point(202, 254);
            txtPrecios.Name = "txtPrecios";
            txtPrecios.Size = new Size(103, 23);
            txtPrecios.TabIndex = 19;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(202, 161);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(223, 74);
            txtDescripcion.TabIndex = 18;
            // 
            // txtNumeroRepuesto
            // 
            txtNumeroRepuesto.Location = new Point(202, 112);
            txtNumeroRepuesto.Name = "txtNumeroRepuesto";
            txtNumeroRepuesto.Size = new Size(121, 23);
            txtNumeroRepuesto.TabIndex = 17;
            // 
            // tbpBusqueda
            // 
            tbpBusqueda.BackColor = SystemColors.ActiveCaption;
            tbpBusqueda.Controls.Add(gbOpciones);
            tbpBusqueda.Controls.Add(lblBusqueda);
            tbpBusqueda.Location = new Point(4, 24);
            tbpBusqueda.Name = "tbpBusqueda";
            tbpBusqueda.Padding = new Padding(3);
            tbpBusqueda.Size = new Size(529, 391);
            tbpBusqueda.TabIndex = 1;
            tbpBusqueda.Text = "Busqueda de repuestos";
            // 
            // gbOpciones
            // 
            gbOpciones.Controls.Add(rdbImportado);
            gbOpciones.Controls.Add(rdbNacional);
            gbOpciones.Controls.Add(cmbMarca2);
            gbOpciones.Location = new Point(27, 154);
            gbOpciones.Name = "gbOpciones";
            gbOpciones.Size = new Size(306, 120);
            gbOpciones.TabIndex = 18;
            gbOpciones.TabStop = false;
            // 
            // rdbImportado
            // 
            rdbImportado.AutoSize = true;
            rdbImportado.Location = new Point(181, 72);
            rdbImportado.Name = "rdbImportado";
            rdbImportado.Size = new Size(92, 19);
            rdbImportado.TabIndex = 30;
            rdbImportado.TabStop = true;
            rdbImportado.Text = "IMPORTADO";
            rdbImportado.UseVisualStyleBackColor = true;
            // 
            // rdbNacional
            // 
            rdbNacional.AutoSize = true;
            rdbNacional.Location = new Point(90, 72);
            rdbNacional.Name = "rdbNacional";
            rdbNacional.Size = new Size(85, 19);
            rdbNacional.TabIndex = 29;
            rdbNacional.TabStop = true;
            rdbNacional.Text = "NACIONAL";
            rdbNacional.UseVisualStyleBackColor = true;
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
            // lblBusqueda
            // 
            lblBusqueda.AutoSize = true;
            lblBusqueda.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBusqueda.Location = new Point(8, 114);
            lblBusqueda.Name = "lblBusqueda";
            lblBusqueda.Size = new Size(358, 37);
            lblBusqueda.TabIndex = 20;
            lblBusqueda.Text = "BUSQUEDA DE REPUESTOS";
            // 
            // gbOrigen
            // 
            gbOrigen.Controls.Add(rbImportado);
            gbOrigen.Controls.Add(rbNacional);
            gbOrigen.Location = new Point(83, 44);
            gbOrigen.Name = "gbOrigen";
            gbOrigen.Size = new Size(353, 58);
            gbOrigen.TabIndex = 29;
            gbOrigen.TabStop = false;
            gbOrigen.Text = "Origen";
            // 
            // Repuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(518, 588);
            Controls.Add(tbp);
            Controls.Add(lblTitulo);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Repuestos";
            Text = "Ventas De Reouestos";
            tbp.ResumeLayout(false);
            tbpCarga.ResumeLayout(false);
            tbpCarga.PerformLayout();
            tbpBusqueda.ResumeLayout(false);
            tbpBusqueda.PerformLayout();
            gbOpciones.ResumeLayout(false);
            gbOpciones.PerformLayout();
            gbOrigen.ResumeLayout(false);
            gbOrigen.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TabControl tbp;
        private TabPage tbpCarga;
        private TabPage tbpBusqueda;
        private ListBox lstRepuestos;
        private Button btnGuardar;
        private Label lblPrecio;
        private Label lblDescripcion;
        private Label lblNumero;
        private Label lblMarca;
        private ComboBox cmbMarca;
        private TextBox txtPrecios;
        private TextBox txtDescripcion;
        private TextBox txtNumeroRepuesto;
        private GroupBox gbOpciones;
        private ComboBox cmbMarca2;
        private Label lblBusqueda;
        private RadioButton rbImportado;
        private RadioButton rbNacional;
        private RadioButton rdbImportado;
        private RadioButton rdbNacional;
        private GroupBox gbOrigen;
    }
}
