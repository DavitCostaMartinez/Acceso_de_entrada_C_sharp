
namespace Aev7
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.btnPresencia = new System.Windows.Forms.Button();
            this.btnPermanencia = new System.Windows.Forms.Button();
            this.btnMantenimiento = new System.Windows.Forms.Button();
            this.lblReloj = new System.Windows.Forms.Label();
            this.tmrReloj = new System.Windows.Forms.Timer(this.components);
            this.lblFecha = new System.Windows.Forms.Label();
            this.pcbFondo_Hora = new System.Windows.Forms.PictureBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.ErrorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnClave = new System.Windows.Forms.Button();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.lblFecha_Final = new System.Windows.Forms.Label();
            this.lblFecha_Inicial = new System.Windows.Forms.Label();
            this.btnFechas = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pcbfondo_per = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFondo_Hora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbfondo_per)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNif
            // 
            this.txtNif.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNif.Location = new System.Drawing.Point(16, 26);
            this.txtNif.MaxLength = 9;
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(468, 53);
            this.txtNif.TabIndex = 0;
            this.txtNif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEntrar.Location = new System.Drawing.Point(514, 139);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(260, 49);
            this.btnEntrar.TabIndex = 1;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.BackColor = System.Drawing.Color.Maroon;
            this.btnSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalida.Location = new System.Drawing.Point(514, 194);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(260, 50);
            this.btnSalida.TabIndex = 2;
            this.btnSalida.Text = "Salida";
            this.btnSalida.UseVisualStyleBackColor = false;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // btnPresencia
            // 
            this.btnPresencia.BackColor = System.Drawing.Color.Coral;
            this.btnPresencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresencia.Location = new System.Drawing.Point(514, 250);
            this.btnPresencia.Name = "btnPresencia";
            this.btnPresencia.Size = new System.Drawing.Size(260, 50);
            this.btnPresencia.TabIndex = 3;
            this.btnPresencia.Text = "Presencia";
            this.btnPresencia.UseVisualStyleBackColor = false;
            this.btnPresencia.Click += new System.EventHandler(this.btnPresencia_Click);
            // 
            // btnPermanencia
            // 
            this.btnPermanencia.BackColor = System.Drawing.Color.YellowGreen;
            this.btnPermanencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPermanencia.Location = new System.Drawing.Point(514, 306);
            this.btnPermanencia.Name = "btnPermanencia";
            this.btnPermanencia.Size = new System.Drawing.Size(260, 50);
            this.btnPermanencia.TabIndex = 4;
            this.btnPermanencia.Text = "Permanencia";
            this.btnPermanencia.UseVisualStyleBackColor = false;
            this.btnPermanencia.Click += new System.EventHandler(this.btnPermanencia_Click);
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.BackColor = System.Drawing.Color.HotPink;
            this.btnMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimiento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMantenimiento.Location = new System.Drawing.Point(514, 362);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Size = new System.Drawing.Size(260, 50);
            this.btnMantenimiento.TabIndex = 5;
            this.btnMantenimiento.Text = "Mantenimiento";
            this.btnMantenimiento.UseVisualStyleBackColor = false;
            this.btnMantenimiento.Click += new System.EventHandler(this.btnMantenimiento_Click);
            // 
            // lblReloj
            // 
            this.lblReloj.AutoSize = true;
            this.lblReloj.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblReloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReloj.Location = new System.Drawing.Point(624, 77);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(73, 31);
            this.lblReloj.TabIndex = 6;
            this.lblReloj.Text = "Hora";
            // 
            // tmrReloj
            // 
            this.tmrReloj.Enabled = true;
            this.tmrReloj.Tick += new System.EventHandler(this.tmrReloj_Tick);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(594, 26);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(90, 31);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "Fecha";
            // 
            // pcbFondo_Hora
            // 
            this.pcbFondo_Hora.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pcbFondo_Hora.Enabled = false;
            this.pcbFondo_Hora.Location = new System.Drawing.Point(514, 12);
            this.pcbFondo_Hora.Name = "pcbFondo_Hora";
            this.pcbFondo_Hora.Size = new System.Drawing.Size(260, 112);
            this.pcbFondo_Hora.TabIndex = 8;
            this.pcbFondo_Hora.TabStop = false;
            // 
            // txtInfo
            // 
            this.txtInfo.Enabled = false;
            this.txtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.Location = new System.Drawing.Point(16, 149);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(492, 262);
            this.txtInfo.TabIndex = 9;
            this.txtInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ErrorProv
            // 
            this.ErrorProv.ContainerControl = this;
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(16, 98);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(305, 45);
            this.txtClave.TabIndex = 10;
            this.txtClave.UseSystemPasswordChar = true;
            this.txtClave.Visible = false;
            // 
            // btnClave
            // 
            this.btnClave.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClave.Location = new System.Drawing.Point(327, 98);
            this.btnClave.Name = "btnClave";
            this.btnClave.Size = new System.Drawing.Size(181, 45);
            this.btnClave.TabIndex = 11;
            this.btnClave.Text = "Acceder";
            this.btnClave.UseVisualStyleBackColor = false;
            this.btnClave.Visible = false;
            this.btnClave.Click += new System.EventHandler(this.btnClave_Click);
            // 
            // dtpInicial
            // 
            this.dtpInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicial.Location = new System.Drawing.Point(116, 444);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(97, 23);
            this.dtpInicial.TabIndex = 13;
            this.dtpInicial.Visible = false;
            // 
            // dtpFinal
            // 
            this.dtpFinal.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dtpFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(317, 445);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(97, 23);
            this.dtpFinal.TabIndex = 14;
            this.dtpFinal.Visible = false;
            // 
            // lblFecha_Final
            // 
            this.lblFecha_Final.AutoSize = true;
            this.lblFecha_Final.BackColor = System.Drawing.Color.Firebrick;
            this.lblFecha_Final.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha_Final.Location = new System.Drawing.Point(219, 447);
            this.lblFecha_Final.Name = "lblFecha_Final";
            this.lblFecha_Final.Size = new System.Drawing.Size(92, 20);
            this.lblFecha_Final.TabIndex = 15;
            this.lblFecha_Final.Text = "Fecha Final";
            this.lblFecha_Final.Visible = false;
            // 
            // lblFecha_Inicial
            // 
            this.lblFecha_Inicial.AutoSize = true;
            this.lblFecha_Inicial.BackColor = System.Drawing.Color.Firebrick;
            this.lblFecha_Inicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha_Inicial.Location = new System.Drawing.Point(12, 446);
            this.lblFecha_Inicial.Name = "lblFecha_Inicial";
            this.lblFecha_Inicial.Size = new System.Drawing.Size(98, 20);
            this.lblFecha_Inicial.TabIndex = 16;
            this.lblFecha_Inicial.Text = "Fecha Inicial";
            this.lblFecha_Inicial.Visible = false;
            // 
            // btnFechas
            // 
            this.btnFechas.BackColor = System.Drawing.Color.SlateGray;
            this.btnFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechas.Location = new System.Drawing.Point(420, 435);
            this.btnFechas.Name = "btnFechas";
            this.btnFechas.Size = new System.Drawing.Size(125, 37);
            this.btnFechas.TabIndex = 17;
            this.btnFechas.Text = "Comprobar";
            this.btnFechas.UseVisualStyleBackColor = false;
            this.btnFechas.Visible = false;
            this.btnFechas.Click += new System.EventHandler(this.btnFechas_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(563, 418);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(211, 67);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Volver";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pcbfondo_per
            // 
            this.pcbfondo_per.BackColor = System.Drawing.Color.Maroon;
            this.pcbfondo_per.Enabled = false;
            this.pcbfondo_per.Location = new System.Drawing.Point(10, 427);
            this.pcbfondo_per.Name = "pcbfondo_per";
            this.pcbfondo_per.Size = new System.Drawing.Size(547, 58);
            this.pcbfondo_per.TabIndex = 19;
            this.pcbfondo_per.TabStop = false;
            this.pcbfondo_per.Visible = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnFechas);
            this.Controls.Add(this.lblFecha_Inicial);
            this.Controls.Add(this.lblFecha_Final);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.dtpInicial);
            this.Controls.Add(this.btnClave);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblReloj);
            this.Controls.Add(this.btnMantenimiento);
            this.Controls.Add(this.btnPermanencia);
            this.Controls.Add(this.btnPresencia);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtNif);
            this.Controls.Add(this.pcbFondo_Hora);
            this.Controls.Add(this.pcbfondo_per);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcbFondo_Hora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbfondo_per)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Button btnPresencia;
        private System.Windows.Forms.Button btnPermanencia;
        private System.Windows.Forms.Button btnMantenimiento;
        private System.Windows.Forms.Label lblReloj;
        private System.Windows.Forms.Timer tmrReloj;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.PictureBox pcbFondo_Hora;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.ErrorProvider ErrorProv;
        private System.Windows.Forms.Button btnClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblFecha_Inicial;
        private System.Windows.Forms.Label lblFecha_Final;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.Button btnFechas;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pcbfondo_per;
    }
}