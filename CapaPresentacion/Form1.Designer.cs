namespace CapaPresentacion
{
    partial class Form1
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
            moverFormulario = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnClose = new PictureBox();
            txtBoxbuscar = new TextBox();
            pictureBox2 = new PictureBox();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDireccion = new Label();
            lblDestino = new Label();
            lblFecha = new Label();
            lblTelefono = new Label();
            txtboxNombre = new TextBox();
            txtboxApellido = new TextBox();
            txtboxDireccion = new TextBox();
            txtboxTelefono = new TextBox();
            txtboxDestino = new TextBox();
            boxFecha = new DateTimePicker();
            tablaAgenda = new DataGridView();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnGo = new Button();
            btnNuevo = new Button();
            moverFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tablaAgenda).BeginInit();
            SuspendLayout();
            // 
            // moverFormulario
            // 
            moverFormulario.BackColor = Color.FromArgb(52, 81, 120);
            moverFormulario.Controls.Add(label1);
            moverFormulario.Controls.Add(pictureBox1);
            moverFormulario.Controls.Add(btnClose);
            moverFormulario.Dock = DockStyle.Top;
            moverFormulario.Location = new Point(0, 0);
            moverFormulario.Name = "moverFormulario";
            moverFormulario.Size = new Size(1404, 48);
            moverFormulario.TabIndex = 0;
            moverFormulario.MouseDown += moverFormulario_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(89, 10);
            label1.Name = "label1";
            label1.Size = new Size(327, 25);
            label1.TabIndex = 3;
            label1.Text = "AGENDA ITLA - ELECTRONICA";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_planificador_94;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources.icons8_xbox_x_80;
            btnClose.Location = new Point(1360, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(43, 48);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 1;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // txtBoxbuscar
            // 
            txtBoxbuscar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxbuscar.Location = new Point(55, 93);
            txtBoxbuscar.Multiline = true;
            txtBoxbuscar.Name = "txtBoxbuscar";
            txtBoxbuscar.Size = new Size(205, 33);
            txtBoxbuscar.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_búsqueda_120;
            pictureBox2.Location = new Point(12, 93);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(32, 207);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(81, 25);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(259, 207);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(82, 25);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDireccion.Location = new Point(475, 207);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(92, 25);
            lblDireccion.TabIndex = 5;
            lblDireccion.Text = "Direccion";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDestino.Location = new Point(918, 207);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(76, 25);
            lblDestino.TabIndex = 6;
            lblDestino.Text = "Destino";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(1151, 207);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(61, 25);
            lblFecha.TabIndex = 7;
            lblFecha.Text = "Fecha";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(699, 207);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(86, 25);
            lblTelefono.TabIndex = 8;
            lblTelefono.Text = "Telefono";
            // 
            // txtboxNombre
            // 
            txtboxNombre.Location = new Point(32, 235);
            txtboxNombre.Multiline = true;
            txtboxNombre.Name = "txtboxNombre";
            txtboxNombre.Size = new Size(198, 33);
            txtboxNombre.TabIndex = 9;
            // 
            // txtboxApellido
            // 
            txtboxApellido.Location = new Point(259, 235);
            txtboxApellido.Multiline = true;
            txtboxApellido.Name = "txtboxApellido";
            txtboxApellido.Size = new Size(198, 33);
            txtboxApellido.TabIndex = 10;
            // 
            // txtboxDireccion
            // 
            txtboxDireccion.Location = new Point(475, 235);
            txtboxDireccion.Multiline = true;
            txtboxDireccion.Name = "txtboxDireccion";
            txtboxDireccion.Size = new Size(198, 33);
            txtboxDireccion.TabIndex = 11;
            // 
            // txtboxTelefono
            // 
            txtboxTelefono.Location = new Point(699, 235);
            txtboxTelefono.Multiline = true;
            txtboxTelefono.Name = "txtboxTelefono";
            txtboxTelefono.Size = new Size(198, 33);
            txtboxTelefono.TabIndex = 12;
            // 
            // txtboxDestino
            // 
            txtboxDestino.Location = new Point(920, 235);
            txtboxDestino.Multiline = true;
            txtboxDestino.Name = "txtboxDestino";
            txtboxDestino.Size = new Size(198, 33);
            txtboxDestino.TabIndex = 13;
            // 
            // boxFecha
            // 
            boxFecha.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxFecha.Location = new Point(1151, 235);
            boxFecha.Name = "boxFecha";
            boxFecha.Size = new Size(226, 30);
            boxFecha.TabIndex = 15;
            // 
            // tablaAgenda
            // 
            tablaAgenda.AllowUserToAddRows = false;
            tablaAgenda.AllowUserToDeleteRows = false;
            tablaAgenda.BackgroundColor = Color.Gainsboro;
            tablaAgenda.BorderStyle = BorderStyle.None;
            tablaAgenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaAgenda.Location = new Point(34, 286);
            tablaAgenda.Name = "tablaAgenda";
            tablaAgenda.ReadOnly = true;
            tablaAgenda.Size = new Size(1345, 412);
            tablaAgenda.TabIndex = 16;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(78, 122, 181);
            btnEliminar.FlatAppearance.BorderSize = 2;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 64);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Image = Properties.Resources.icons8_trash_24;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(1003, 107);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(178, 64);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += button4_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(78, 122, 181);
            btnGuardar.FlatAppearance.BorderSize = 2;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 64);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Image = Properties.Resources.icons8_plus_24;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(1199, 107);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(178, 64);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnGo
            // 
            btnGo.BackColor = Color.FromArgb(78, 122, 181);
            btnGo.FlatAppearance.BorderSize = 2;
            btnGo.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 64);
            btnGo.FlatStyle = FlatStyle.Flat;
            btnGo.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGo.ForeColor = Color.White;
            btnGo.ImageAlign = ContentAlignment.MiddleLeft;
            btnGo.Location = new Point(266, 93);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(51, 34);
            btnGo.TabIndex = 22;
            btnGo.Text = "GO";
            btnGo.UseVisualStyleBackColor = false;
            btnGo.Click += btnGo_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(78, 122, 181);
            btnNuevo.FlatAppearance.BorderSize = 2;
            btnNuevo.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 64);
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Image = Properties.Resources.icons8_user_26;
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(816, 107);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(178, 64);
            btnNuevo.TabIndex = 23;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1404, 733);
            Controls.Add(btnNuevo);
            Controls.Add(btnGo);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(tablaAgenda);
            Controls.Add(boxFecha);
            Controls.Add(txtboxDestino);
            Controls.Add(txtboxTelefono);
            Controls.Add(txtboxDireccion);
            Controls.Add(txtboxApellido);
            Controls.Add(txtboxNombre);
            Controls.Add(lblTelefono);
            Controls.Add(lblFecha);
            Controls.Add(lblDestino);
            Controls.Add(lblDireccion);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(pictureBox2);
            Controls.Add(txtBoxbuscar);
            Controls.Add(moverFormulario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            moverFormulario.ResumeLayout(false);
            moverFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)tablaAgenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel moverFormulario;
        private PictureBox btnClose;
        private PictureBox pictureBox1;
        private Label label1;
        public TextBox txtBoxbuscar;
        private PictureBox pictureBox2;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDireccion;
        private Label lblDestino;
        private Label lblFecha;
        private Label lblTelefono;
        public TextBox txtboxNombre;
        public TextBox txtboxApellido;
        public TextBox txtboxDireccion;
        public TextBox txtboxTelefono;
        public TextBox txtboxDestino;
        private DateTimePicker boxFecha;
        private DataGridView tablaAgenda;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnGo;
        private Button btnNuevo;
    }
}
