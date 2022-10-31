namespace WinFormPract
{
    partial class FormRestaurante
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
            this.gbRestaurante = new System.Windows.Forms.GroupBox();
            this.txtOpiniones = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaApertura = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAnyadir = new System.Windows.Forms.Button();
            this.dgvRestaurantes = new System.Windows.Forms.DataGridView();
            this.gbRestaurante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestaurantes)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRestaurante
            // 
            this.gbRestaurante.Controls.Add(this.txtOpiniones);
            this.gbRestaurante.Controls.Add(this.label5);
            this.gbRestaurante.Controls.Add(this.txtNumero);
            this.gbRestaurante.Controls.Add(this.label4);
            this.gbRestaurante.Controls.Add(this.txtCalle);
            this.gbRestaurante.Controls.Add(this.label3);
            this.gbRestaurante.Controls.Add(this.dtpFechaApertura);
            this.gbRestaurante.Controls.Add(this.label2);
            this.gbRestaurante.Controls.Add(this.lblId);
            this.gbRestaurante.Controls.Add(this.txtId);
            this.gbRestaurante.Controls.Add(this.txtNombre);
            this.gbRestaurante.Controls.Add(this.label1);
            this.gbRestaurante.Location = new System.Drawing.Point(12, 12);
            this.gbRestaurante.Name = "gbRestaurante";
            this.gbRestaurante.Size = new System.Drawing.Size(886, 210);
            this.gbRestaurante.TabIndex = 0;
            this.gbRestaurante.TabStop = false;
            this.gbRestaurante.Text = "Formulario:";
            // 
            // txtOpiniones
            // 
            this.txtOpiniones.Location = new System.Drawing.Point(442, 134);
            this.txtOpiniones.Multiline = true;
            this.txtOpiniones.Name = "txtOpiniones";
            this.txtOpiniones.Size = new System.Drawing.Size(426, 70);
            this.txtOpiniones.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Opinion:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(433, 81);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(42, 27);
            this.txtNumero.TabIndex = 24;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Número: ";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(434, 33);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(164, 27);
            this.txtCalle.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Calle: ";
            // 
            // dtpFechaApertura
            // 
            this.dtpFechaApertura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaApertura.Location = new System.Drawing.Point(124, 136);
            this.dtpFechaApertura.Name = "dtpFechaApertura";
            this.dtpFechaApertura.Size = new System.Drawing.Size(121, 27);
            this.dtpFechaApertura.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Fecha Apertura:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(9, 32);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 20);
            this.lblId.TabIndex = 18;
            this.lblId.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(86, 29);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(60, 27);
            this.txtId.TabIndex = 17;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(86, 81);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(164, 27);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(634, 228);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 30);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(498, 228);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(94, 30);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(280, 228);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(94, 30);
            this.btnModificar.TabIndex = 25;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(153, 228);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 30);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAnyadir
            // 
            this.btnAnyadir.Location = new System.Drawing.Point(35, 228);
            this.btnAnyadir.Name = "btnAnyadir";
            this.btnAnyadir.Size = new System.Drawing.Size(94, 30);
            this.btnAnyadir.TabIndex = 2;
            this.btnAnyadir.Text = "Añadir";
            this.btnAnyadir.UseVisualStyleBackColor = true;
            this.btnAnyadir.Click += new System.EventHandler(this.btnAnyadir_Click);
            // 
            // dgvRestaurantes
            // 
            this.dgvRestaurantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRestaurantes.Location = new System.Drawing.Point(12, 274);
            this.dgvRestaurantes.Name = "dgvRestaurantes";
            this.dgvRestaurantes.RowHeadersWidth = 51;
            this.dgvRestaurantes.RowTemplate.Height = 29;
            this.dgvRestaurantes.Size = new System.Drawing.Size(886, 295);
            this.dgvRestaurantes.TabIndex = 1;
            this.dgvRestaurantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRestaurantes_CellClick);
            this.dgvRestaurantes.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvRestaurantes_RowStateChanged);
            // 
            // FormRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 581);
            this.Controls.Add(this.dgvRestaurantes);
            this.Controls.Add(this.gbRestaurante);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAnyadir);
            this.Controls.Add(this.btnEliminar);
            this.Name = "FormRestaurante";
            this.Text = "Restaurantes en Málaga";
            this.Load += new System.EventHandler(this.FormRestaurante_Load);
            this.gbRestaurante.ResumeLayout(false);
            this.gbRestaurante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestaurantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbRestaurante;
        private DataGridView dgvRestaurantes;
        private Label lblId;
        private TextBox txtId;
        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpFechaApertura;
        private TextBox txtCalle;
        private Label label3;
        private TextBox txtNumero;
        private Label label4;
        private Button btnAnyadir;
        private Button btnEliminar;
        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnModificar;
        private TextBox txtOpiniones;
        private Label label5;
    }
}