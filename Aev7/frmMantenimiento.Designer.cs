
namespace Aev7
{
    partial class frmMantenimiento
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
            this.components = new System.ComponentModel.Container();
            this.grpGestion = new System.Windows.Forms.GroupBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.lblNif = new System.Windows.Forms.Label();
            this.lblGestion = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrarm = new System.Windows.Forms.Button();
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.lblFichaje = new System.Windows.Forms.Label();
            this.dgvFichajes = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.ErrorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpGestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProv)).BeginInit();
            this.SuspendLayout();
            // 
            // grpGestion
            // 
            this.grpGestion.Controls.Add(this.txtClave);
            this.grpGestion.Controls.Add(this.lblClave);
            this.grpGestion.Controls.Add(this.chkAdmin);
            this.grpGestion.Controls.Add(this.lblApellidos);
            this.grpGestion.Controls.Add(this.txtApellidos);
            this.grpGestion.Controls.Add(this.txtNombre);
            this.grpGestion.Controls.Add(this.lblNombre);
            this.grpGestion.Controls.Add(this.txtNif);
            this.grpGestion.Controls.Add(this.lblNif);
            this.grpGestion.Controls.Add(this.lblGestion);
            this.grpGestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGestion.Location = new System.Drawing.Point(574, 12);
            this.grpGestion.Name = "grpGestion";
            this.grpGestion.Size = new System.Drawing.Size(299, 247);
            this.grpGestion.TabIndex = 8;
            this.grpGestion.TabStop = false;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(131, 192);
            this.txtClave.MaxLength = 12;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(141, 29);
            this.txtClave.TabIndex = 15;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(54, 195);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(57, 24);
            this.lblClave.TabIndex = 14;
            this.lblClave.Text = "Clave";
            // 
            // chkAdmin
            // 
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.Location = new System.Drawing.Point(65, 165);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(84, 28);
            this.chkAdmin.TabIndex = 14;
            this.chkAdmin.Text = "Admin";
            this.chkAdmin.UseVisualStyleBackColor = true;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(33, 130);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(88, 24);
            this.lblApellidos.TabIndex = 9;
            this.lblApellidos.Text = "Apellidos";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(131, 130);
            this.txtApellidos.MaxLength = 50;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(141, 29);
            this.txtApellidos.TabIndex = 13;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(131, 95);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(141, 29);
            this.txtNombre.TabIndex = 12;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(40, 98);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 24);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNif
            // 
            this.txtNif.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNif.Location = new System.Drawing.Point(131, 60);
            this.txtNif.MaxLength = 9;
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(141, 29);
            this.txtNif.TabIndex = 11;
            // 
            // lblNif
            // 
            this.lblNif.AutoSize = true;
            this.lblNif.Location = new System.Drawing.Point(79, 69);
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(32, 24);
            this.lblNif.TabIndex = 10;
            this.lblNif.Text = "Nif";
            // 
            // lblGestion
            // 
            this.lblGestion.AutoSize = true;
            this.lblGestion.Location = new System.Drawing.Point(25, 25);
            this.lblGestion.Name = "lblGestion";
            this.lblGestion.Size = new System.Drawing.Size(202, 24);
            this.lblGestion.TabIndex = 9;
            this.lblGestion.Text = "Gestion de Empleados";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(599, 291);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(88, 44);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(717, 291);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 44);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCerrarm
            // 
            this.btnCerrarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarm.Location = new System.Drawing.Point(599, 407);
            this.btnCerrarm.Name = "btnCerrarm";
            this.btnCerrarm.Size = new System.Drawing.Size(86, 48);
            this.btnCerrarm.TabIndex = 18;
            this.btnCerrarm.Text = "Cerrar";
            this.btnCerrarm.UseVisualStyleBackColor = true;
            this.btnCerrarm.Click += new System.EventHandler(this.btnCerrarm_Click);
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleados.Location = new System.Drawing.Point(23, 14);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(229, 25);
            this.lblEmpleados.TabIndex = 12;
            this.lblEmpleados.Text = "Gestion de Empleados";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(27, 42);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.Size = new System.Drawing.Size(531, 196);
            this.dgvEmpleados.TabIndex = 99;
            this.dgvEmpleados.TabStop = false;
            // 
            // lblFichaje
            // 
            this.lblFichaje.AutoSize = true;
            this.lblFichaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichaje.Location = new System.Drawing.Point(23, 241);
            this.lblFichaje.Name = "lblFichaje";
            this.lblFichaje.Size = new System.Drawing.Size(203, 25);
            this.lblFichaje.TabIndex = 14;
            this.lblFichaje.Text = "Gestion de Fichajes";
            // 
            // dgvFichajes
            // 
            this.dgvFichajes.AllowUserToAddRows = false;
            this.dgvFichajes.AllowUserToDeleteRows = false;
            this.dgvFichajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFichajes.Location = new System.Drawing.Point(28, 265);
            this.dgvFichajes.Name = "dgvFichajes";
            this.dgvFichajes.ReadOnly = true;
            this.dgvFichajes.Size = new System.Drawing.Size(530, 189);
            this.dgvFichajes.TabIndex = 15;
            this.dgvFichajes.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(717, 407);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 48);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ErrorProv
            // 
            this.ErrorProv.ContainerControl = this;
            // 
            // frmMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 477);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvFichajes);
            this.Controls.Add(this.lblFichaje);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.lblEmpleados);
            this.Controls.Add(this.btnCerrarm);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grpGestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento";
            this.Load += new System.EventHandler(this.frmMantenimiento_Load);
            this.grpGestion.ResumeLayout(false);
            this.grpGestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGestion;
        private System.Windows.Forms.Label lblNif;
        private System.Windows.Forms.Label lblGestion;
        private System.Windows.Forms.CheckBox chkAdmin;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrarm;
        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Label lblFichaje;
        private System.Windows.Forms.DataGridView dgvFichajes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider ErrorProv;
    }
}