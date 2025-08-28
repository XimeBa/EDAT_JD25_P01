namespace UI.NumerosAleatorios
{
    partial class frmDatosAleatorios
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
            btnMostrarMensaje = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            btnGrupo = new ComboBox();
            btnSeguroMedico = new CheckBox();
            btnFemenino = new RadioButton();
            btnMasculino = new RadioButton();
            btnSueldo = new TextBox();
            btnNombre = new TextBox();
            btnNumero = new TextBox();
            btnFechaNacimiento = new DateTimePicker();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnMostrarMensaje
            // 
            btnMostrarMensaje.BackColor = SystemColors.Window;
            btnMostrarMensaje.ForeColor = SystemColors.ActiveCaptionText;
            btnMostrarMensaje.Location = new Point(171, 458);
            btnMostrarMensaje.Name = "btnMostrarMensaje";
            btnMostrarMensaje.Size = new Size(350, 33);
            btnMostrarMensaje.TabIndex = 0;
            btnMostrarMensaje.Text = "Generar datos aleatorios";
            btnMostrarMensaje.UseVisualStyleBackColor = false;
            btnMostrarMensaje.Click += btnMostrarMensaje_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 36);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 1;
            label1.Text = "Número";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 96);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 154);
            label3.Name = "label3";
            label3.Size = new Size(146, 20);
            label3.TabIndex = 3;
            label3.Text = "Fecha de nacimiento";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 278);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 4;
            label4.Text = "Grupo";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnGrupo);
            panel1.Controls.Add(btnSeguroMedico);
            panel1.Controls.Add(btnFemenino);
            panel1.Controls.Add(btnMasculino);
            panel1.Controls.Add(btnSueldo);
            panel1.Controls.Add(btnNombre);
            panel1.Controls.Add(btnNumero);
            panel1.Controls.Add(btnFechaNacimiento);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(28, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(663, 409);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // btnGrupo
            // 
            btnGrupo.FormattingEnabled = true;
            btnGrupo.Location = new Point(160, 270);
            btnGrupo.Name = "btnGrupo";
            btnGrupo.Size = new Size(96, 28);
            btnGrupo.TabIndex = 13;
            btnGrupo.SelectedIndexChanged += btnGrupo_SelectedIndexChanged;
            // 
            // btnSeguroMedico
            // 
            btnSeguroMedico.AutoSize = true;
            btnSeguroMedico.Location = new Point(161, 364);
            btnSeguroMedico.Name = "btnSeguroMedico";
            btnSeguroMedico.Size = new Size(132, 24);
            btnSeguroMedico.TabIndex = 12;
            btnSeguroMedico.Text = "Seguro médico";
            btnSeguroMedico.UseVisualStyleBackColor = true;
            // 
            // btnFemenino
            // 
            btnFemenino.AutoSize = true;
            btnFemenino.Location = new Point(161, 227);
            btnFemenino.Name = "btnFemenino";
            btnFemenino.Size = new Size(95, 24);
            btnFemenino.TabIndex = 11;
            btnFemenino.TabStop = true;
            btnFemenino.Text = "Femenino";
            btnFemenino.UseVisualStyleBackColor = true;
            btnFemenino.CheckedChanged += btnFemenino_CheckedChanged;
            // 
            // btnMasculino
            // 
            btnMasculino.AutoSize = true;
            btnMasculino.Location = new Point(161, 197);
            btnMasculino.Name = "btnMasculino";
            btnMasculino.Size = new Size(97, 24);
            btnMasculino.TabIndex = 10;
            btnMasculino.TabStop = true;
            btnMasculino.Text = "Masculino";
            btnMasculino.UseVisualStyleBackColor = true;
            btnMasculino.CheckedChanged += btnMasculino_CheckedChanged;
            // 
            // btnSueldo
            // 
            btnSueldo.Location = new Point(161, 313);
            btnSueldo.Name = "btnSueldo";
            btnSueldo.Size = new Size(125, 27);
            btnSueldo.TabIndex = 9;
            btnSueldo.TextChanged += btnSueldo_TextChanged;
            // 
            // btnNombre
            // 
            btnNombre.Location = new Point(161, 93);
            btnNombre.Name = "btnNombre";
            btnNombre.Size = new Size(372, 27);
            btnNombre.TabIndex = 8;
            btnNombre.TextChanged += textBox2_TextChanged;
            // 
            // btnNumero
            // 
            btnNumero.Location = new Point(161, 36);
            btnNumero.Name = "btnNumero";
            btnNumero.Size = new Size(104, 27);
            btnNumero.TabIndex = 7;
            btnNumero.TextChanged += textBox1_TextChanged;
            // 
            // btnFechaNacimiento
            // 
            btnFechaNacimiento.Location = new Point(241, 154);
            btnFechaNacimiento.Name = "btnFechaNacimiento";
            btnFechaNacimiento.Size = new Size(292, 27);
            btnFechaNacimiento.TabIndex = 6;
            btnFechaNacimiento.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(74, 316);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 5;
            label5.Text = "Sueldo";
            // 
            // frmDatosAleatorios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 515);
            Controls.Add(panel1);
            Controls.Add(btnMostrarMensaje);
            Name = "frmDatosAleatorios";
            Text = "Empleado con datos aleatorios";
            Load += frmDatosAleatorios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMostrarMensaje;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Label label5;
        private DateTimePicker btnFechaNacimiento;
        private TextBox btnSueldo;
        private TextBox btnNombre;
        private TextBox btnNumero;
        private CheckBox btnSeguroMedico;
        private RadioButton btnFemenino;
        private RadioButton btnMasculino;
        private ComboBox btnGrupo;
        private CheckBox Masculino;
    }
}
