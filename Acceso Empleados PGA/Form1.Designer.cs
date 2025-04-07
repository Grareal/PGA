namespace Acceso_Empleados_PGA
{
    partial class frmChecada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChecada));
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtDescuento = new TextBox();
            label7 = new Label();
            txtDepartamento = new TextBox();
            txtColor = new TextBox();
            txtNivel = new TextBox();
            txtEmpresa = new TextBox();
            txtNombre = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblTarjeta = new TextBox();
            lblEmp = new Label();
            gpoAsistentes = new GroupBox();
            pictureBox2 = new PictureBox();
            btnCancel = new Button();
            btnConfirmar = new Button();
            btnMenminus = new Button();
            btnMenplus = new Button();
            txtMenores = new MaskedTextBox();
            label9 = new Label();
            btnAdminus = new Button();
            btnAdplus = new Button();
            txtAdultos = new MaskedTextBox();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            groupBox1.SuspendLayout();
            gpoAsistentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(213, 54);
            label1.Name = "label1";
            label1.Size = new Size(557, 72);
            label1.TabIndex = 2;
            label1.Text = "Favor de leer el gafete";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDescuento);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtDepartamento);
            groupBox1.Controls.Add(txtColor);
            groupBox1.Controls.Add(txtNivel);
            groupBox1.Controls.Add(txtEmpresa);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(51, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(871, 436);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del colaborador";
            // 
            // txtDescuento
            // 
            txtDescuento.BackColor = Color.White;
            txtDescuento.Enabled = false;
            txtDescuento.Font = new Font("Segoe UI", 45F, FontStyle.Bold, GraphicsUnit.Point);
            txtDescuento.Location = new Point(239, 323);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(610, 87);
            txtDescuento.TabIndex = 11;
            txtDescuento.TabStop = false;
            txtDescuento.TextAlign = HorizontalAlignment.Center;
            txtDescuento.TextChanged += txtDescuento_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(67, 345);
            label7.Name = "label7";
            label7.Size = new Size(148, 37);
            label7.TabIndex = 10;
            label7.Text = "Descuento:";
            // 
            // txtDepartamento
            // 
            txtDepartamento.BackColor = Color.White;
            txtDepartamento.Enabled = false;
            txtDepartamento.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtDepartamento.Location = new Point(239, 271);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(610, 34);
            txtDepartamento.TabIndex = 9;
            txtDepartamento.TabStop = false;
            // 
            // txtColor
            // 
            txtColor.Enabled = false;
            txtColor.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtColor.Location = new Point(239, 219);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(610, 34);
            txtColor.TabIndex = 8;
            txtColor.TabStop = false;
            // 
            // txtNivel
            // 
            txtNivel.BackColor = Color.White;
            txtNivel.Enabled = false;
            txtNivel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtNivel.Location = new Point(239, 168);
            txtNivel.Name = "txtNivel";
            txtNivel.Size = new Size(610, 34);
            txtNivel.TabIndex = 7;
            txtNivel.TabStop = false;
            // 
            // txtEmpresa
            // 
            txtEmpresa.BackColor = Color.White;
            txtEmpresa.Enabled = false;
            txtEmpresa.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmpresa.Location = new Point(239, 119);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(610, 34);
            txtEmpresa.TabIndex = 6;
            txtEmpresa.TabStop = false;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.Enabled = false;
            txtNombre.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(239, 64);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(610, 34);
            txtNombre.TabIndex = 5;
            txtNombre.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(20, 268);
            label6.Name = "label6";
            label6.Size = new Size(195, 37);
            label6.TabIndex = 4;
            label6.Text = "Departamento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(42, 215);
            label5.Name = "label5";
            label5.Size = new Size(173, 37);
            label5.TabIndex = 3;
            label5.Text = "Color Gafete:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(79, 164);
            label4.Name = "label4";
            label4.Size = new Size(136, 37);
            label4.TabIndex = 2;
            label4.Text = "Nivel Org:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(91, 115);
            label3.Name = "label3";
            label3.Size = new Size(124, 37);
            label3.TabIndex = 1;
            label3.Text = "Empresa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(91, 60);
            label2.Name = "label2";
            label2.Size = new Size(121, 37);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // lblTarjeta
            // 
            lblTarjeta.BorderStyle = BorderStyle.None;
            lblTarjeta.ForeColor = SystemColors.Control;
            lblTarjeta.Location = new Point(2, 3);
            lblTarjeta.Name = "lblTarjeta";
            lblTarjeta.Size = new Size(62, 16);
            lblTarjeta.TabIndex = 9;
            lblTarjeta.UseSystemPasswordChar = true;
            lblTarjeta.KeyPress += lblTarjeta_KeyPress;
            // 
            // lblEmp
            // 
            lblEmp.AutoSize = true;
            lblEmp.BackColor = Color.White;
            lblEmp.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmp.ForeColor = SystemColors.ControlText;
            lblEmp.Location = new Point(103, 441);
            lblEmp.Name = "lblEmp";
            lblEmp.Size = new Size(0, 37);
            lblEmp.TabIndex = 4;
            // 
            // gpoAsistentes
            // 
            gpoAsistentes.Controls.Add(pictureBox2);
            gpoAsistentes.Controls.Add(btnCancel);
            gpoAsistentes.Controls.Add(btnConfirmar);
            gpoAsistentes.Controls.Add(btnMenminus);
            gpoAsistentes.Controls.Add(btnMenplus);
            gpoAsistentes.Controls.Add(txtMenores);
            gpoAsistentes.Controls.Add(label9);
            gpoAsistentes.Controls.Add(btnAdminus);
            gpoAsistentes.Controls.Add(btnAdplus);
            gpoAsistentes.Controls.Add(txtAdultos);
            gpoAsistentes.Controls.Add(label8);
            gpoAsistentes.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            gpoAsistentes.Location = new Point(928, 54);
            gpoAsistentes.Name = "gpoAsistentes";
            gpoAsistentes.Size = new Size(205, 436);
            gpoAsistentes.TabIndex = 6;
            gpoAsistentes.TabStop = false;
            gpoAsistentes.Text = "Asistentes";
            gpoAsistentes.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(153, 145);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 42);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.System;
            btnCancel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(6, 392);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(193, 38);
            btnCancel.TabIndex = 9;
            btnCancel.TabStop = false;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.FlatStyle = FlatStyle.System;
            btnConfirmar.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmar.Location = new Point(6, 332);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(193, 54);
            btnConfirmar.TabIndex = 8;
            btnConfirmar.TabStop = false;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += button5_Click;
            // 
            // btnMenminus
            // 
            btnMenminus.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenminus.Location = new Point(94, 283);
            btnMenminus.Name = "btnMenminus";
            btnMenminus.Size = new Size(48, 43);
            btnMenminus.TabIndex = 7;
            btnMenminus.TabStop = false;
            btnMenminus.Text = "-";
            btnMenminus.UseVisualStyleBackColor = true;
            btnMenminus.Click += btnMenminus_Click;
            // 
            // btnMenplus
            // 
            btnMenplus.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenplus.Location = new Point(94, 243);
            btnMenplus.Name = "btnMenplus";
            btnMenplus.Size = new Size(48, 43);
            btnMenplus.TabIndex = 6;
            btnMenplus.TabStop = false;
            btnMenplus.Text = "+";
            btnMenplus.UseVisualStyleBackColor = true;
            btnMenplus.Click += btnMenplus_Click;
            // 
            // txtMenores
            // 
            txtMenores.BorderStyle = BorderStyle.None;
            txtMenores.Font = new Font("Segoe UI", 46F, FontStyle.Regular, GraphicsUnit.Point);
            txtMenores.Location = new Point(15, 244);
            txtMenores.Name = "txtMenores";
            txtMenores.Size = new Size(80, 82);
            txtMenores.TabIndex = 5;
            txtMenores.TabStop = false;
            txtMenores.Text = "1";
            txtMenores.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(11, 198);
            label9.Name = "label9";
            label9.Size = new Size(92, 28);
            label9.TabIndex = 4;
            label9.Text = "Menores:";
            label9.Click += label9_Click;
            // 
            // btnAdminus
            // 
            btnAdminus.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdminus.Location = new Point(94, 134);
            btnAdminus.Name = "btnAdminus";
            btnAdminus.Size = new Size(48, 43);
            btnAdminus.TabIndex = 3;
            btnAdminus.TabStop = false;
            btnAdminus.Text = "-";
            btnAdminus.UseVisualStyleBackColor = true;
            btnAdminus.Click += btnAdminus_Click;
            // 
            // btnAdplus
            // 
            btnAdplus.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdplus.Location = new Point(94, 94);
            btnAdplus.Name = "btnAdplus";
            btnAdplus.Size = new Size(48, 43);
            btnAdplus.TabIndex = 2;
            btnAdplus.TabStop = false;
            btnAdplus.Text = "+";
            btnAdplus.UseVisualStyleBackColor = true;
            btnAdplus.Click += btnAdplus_Click;
            // 
            // txtAdultos
            // 
            txtAdultos.BorderStyle = BorderStyle.None;
            txtAdultos.Font = new Font("Segoe UI", 46F, FontStyle.Regular, GraphicsUnit.Point);
            txtAdultos.Location = new Point(15, 95);
            txtAdultos.Name = "txtAdultos";
            txtAdultos.Size = new Size(80, 82);
            txtAdultos.TabIndex = 1;
            txtAdultos.TabStop = false;
            txtAdultos.Text = "1";
            txtAdultos.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(11, 49);
            label8.Name = "label8";
            label8.Size = new Size(84, 28);
            label8.TabIndex = 0;
            label8.Text = "Adultos:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 36);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(3, 529);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1159, 32);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // frmChecada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(1162, 564);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(gpoAsistentes);
            Controls.Add(lblEmp);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(lblTarjeta);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmChecada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta Colaboradores PGA";
            WindowState = FormWindowState.Maximized;
            Activated += frmChecada_Activated;
            Deactivate += frmChecada_Deactivate;
            Load += frmChecada_Load;
            KeyPress += frmChecada_KeyPress;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gpoAsistentes.ResumeLayout(false);
            gpoAsistentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtDepartamento;
        private TextBox txtColor;
        private TextBox txtNivel;
        private TextBox txtEmpresa;
        private TextBox txtNombre;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblEmp;
        private TextBox txtDescuento;
        private Label label7;
        private GroupBox gpoAsistentes;
        private Label label8;
        private Button btnAdminus;
        private Button btnAdplus;
        private MaskedTextBox txtAdultos;
        private Button btnMenminus;
        private Button btnMenplus;
        private MaskedTextBox txtMenores;
        private Label label9;
        private Button btnConfirmar;
        private TextBox lblTarjeta;
        private PictureBox pictureBox1;
        private Button btnCancel;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}