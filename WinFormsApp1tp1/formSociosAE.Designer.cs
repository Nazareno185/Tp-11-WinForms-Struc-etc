namespace WinFormsApp1tp1
{
    partial class formSociosAE
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtDni = new TextBox();
            groupBox1 = new GroupBox();
            txtApellido = new TextBox();
            label5 = new Label();
            txtTercerNombre = new TextBox();
            label4 = new Label();
            txtSegundoNombre = new TextBox();
            label3 = new Label();
            txtPrimerNombre = new TextBox();
            label2 = new Label();
            label6 = new Label();
            dtpFechaNc = new DateTimePicker();
            groupBox2 = new GroupBox();
            rbtMasculino = new RadioButton();
            rbtFemenino = new RadioButton();
            label7 = new Label();
            cbxLocalidad = new ComboBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            cbxActivo = new CheckBox();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 180);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "DNI:";
            label1.Click += label1_Click;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(60, 177);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(127, 23);
            txtDni.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTercerNombre);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSegundoNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPrimerNombre);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(16, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(297, 145);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Socio";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(124, 109);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(167, 23);
            txtApellido.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 112);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 0;
            label5.Text = "Apellido:";
            // 
            // txtTercerNombre
            // 
            txtTercerNombre.Location = new Point(124, 80);
            txtTercerNombre.Name = "txtTercerNombre";
            txtTercerNombre.Size = new Size(167, 23);
            txtTercerNombre.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 83);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 0;
            label4.Text = "Tercer Nombre:";
            // 
            // txtSegundoNombre
            // 
            txtSegundoNombre.Location = new Point(124, 51);
            txtSegundoNombre.Name = "txtSegundoNombre";
            txtSegundoNombre.Size = new Size(167, 23);
            txtSegundoNombre.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 54);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 0;
            label3.Text = "Segundo Nombre:";
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.Location = new Point(124, 22);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(167, 23);
            txtPrimerNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 25);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 0;
            label2.Text = "Primer Nombre:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(258, 180);
            label6.Name = "label6";
            label6.Size = new Size(123, 15);
            label6.TabIndex = 3;
            label6.Text = "Fecha De Nacimiento:";
            // 
            // dtpFechaNc
            // 
            dtpFechaNc.Format = DateTimePickerFormat.Short;
            dtpFechaNc.Location = new Point(393, 177);
            dtpFechaNc.Name = "dtpFechaNc";
            dtpFechaNc.Size = new Size(93, 23);
            dtpFechaNc.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbtMasculino);
            groupBox2.Controls.Add(rbtFemenino);
            groupBox2.Location = new Point(335, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(151, 111);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Género";
            // 
            // rbtMasculino
            // 
            rbtMasculino.AutoSize = true;
            rbtMasculino.Location = new Point(15, 66);
            rbtMasculino.Name = "rbtMasculino";
            rbtMasculino.Size = new Size(80, 19);
            rbtMasculino.TabIndex = 0;
            rbtMasculino.TabStop = true;
            rbtMasculino.Text = "Masculino";
            rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtFemenino
            // 
            rbtFemenino.AutoSize = true;
            rbtFemenino.Location = new Point(15, 32);
            rbtFemenino.Name = "rbtFemenino";
            rbtFemenino.Size = new Size(78, 19);
            rbtFemenino.TabIndex = 0;
            rbtFemenino.TabStop = true;
            rbtFemenino.Text = "Femenino";
            rbtFemenino.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 232);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 6;
            label7.Text = "Localidad:";
            // 
            // cbxLocalidad
            // 
            cbxLocalidad.FormattingEnabled = true;
            cbxLocalidad.Location = new Point(91, 229);
            cbxLocalidad.Name = "cbxLocalidad";
            cbxLocalidad.Size = new Size(151, 23);
            cbxLocalidad.TabIndex = 7;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(79, 285);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(108, 37);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(335, 285);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 37);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cbxActivo
            // 
            cbxActivo.AutoSize = true;
            cbxActivo.Location = new Point(298, 231);
            cbxActivo.Name = "cbxActivo";
            cbxActivo.Size = new Size(60, 19);
            cbxActivo.TabIndex = 10;
            cbxActivo.Text = "Activo";
            cbxActivo.UseVisualStyleBackColor = true;
            cbxActivo.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // formSociosAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 360);
            ControlBox = false;
            Controls.Add(cbxActivo);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(cbxLocalidad);
            Controls.Add(label7);
            Controls.Add(groupBox2);
            Controls.Add(dtpFechaNc);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(txtDni);
            Controls.Add(label1);
            MaximumSize = new Size(548, 399);
            MinimumSize = new Size(548, 399);
            Name = "formSociosAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formSociosAE";
            Load += formSociosAE_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDni;
        private GroupBox groupBox1;
        private TextBox txtApellido;
        private Label label5;
        private TextBox txtTercerNombre;
        private Label label4;
        private TextBox txtSegundoNombre;
        private Label label3;
        private TextBox txtPrimerNombre;
        private Label label2;
        private Label label6;
        private DateTimePicker dtpFechaNc;
        private GroupBox groupBox2;
        private RadioButton rbtMasculino;
        private RadioButton rbtFemenino;
        private Label label7;
        private ComboBox cbxLocalidad;
        private Button btnAceptar;
        private Button btnCancelar;
        private CheckBox cbxActivo;
        private ErrorProvider errorProvider1;
    }
}