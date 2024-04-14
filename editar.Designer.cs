using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace PersonaGUI
{
    partial class editar
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            selectUsuarios = new ComboBox();
            label5 = new Label();
            actualizaruser = new Button();
            pasatiempo = new ComboBox();
            age = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.png_transparent_user_computer_icons_logo_others_service_logo_computer_wallpaper;
            pictureBox1.Location = new Point(625, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 12);
            label1.Name = "label1";
            label1.Size = new Size(775, 93);
            label1.TabIndex = 18;
            label1.Text = "Modificar Usuarios";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // selectUsuarios
            // 
            selectUsuarios.FormattingEnabled = true;
            selectUsuarios.Location = new Point(168, 142);
            selectUsuarios.Name = "selectUsuarios";
            selectUsuarios.Size = new Size(397, 28);
            selectUsuarios.TabIndex = 21;
            selectUsuarios.Text = "Selecciona un Usuario.";
            selectUsuarios.SelectedIndexChanged += pasatiempo_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 18F);
            label5.Location = new Point(13, 136);
            label5.Name = "label5";
            label5.Size = new Size(138, 34);
            label5.TabIndex = 20;
            label5.Text = "Usuario:";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // actualizaruser
            // 
            actualizaruser.Font = new Font("Arial Rounded MT Bold", 16.2F);
            actualizaruser.Location = new Point(377, 352);
            actualizaruser.Name = "actualizaruser";
            actualizaruser.Size = new Size(177, 49);
            actualizaruser.TabIndex = 22;
            actualizaruser.Text = "Actualizar";
            actualizaruser.UseVisualStyleBackColor = true;
            actualizaruser.Click += actualizaruser_Click;
            // 
            // pasatiempo
            // 
            pasatiempo.FormattingEnabled = true;
            pasatiempo.Items.AddRange(new object[] { "Fútbol", "Cantar", "Bailar", "Ejercicio" });
            pasatiempo.Location = new Point(216, 274);
            pasatiempo.Name = "pasatiempo";
            pasatiempo.Size = new Size(397, 28);
            pasatiempo.TabIndex = 26;
            pasatiempo.Text = "Selecciona una opción";
            // 
            // age
            // 
            age.Font = new Font("Arial", 12F);
            age.Location = new Point(161, 204);
            age.MaxLength = 3;
            age.Name = "age";
            age.Size = new Size(138, 30);
            age.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 18F);
            label2.Location = new Point(13, 268);
            label2.Name = "label2";
            label2.Size = new Size(197, 34);
            label2.TabIndex = 24;
            label2.Text = "Pasatiempo:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 18F);
            label3.Location = new Point(13, 202);
            label3.Name = "label3";
            label3.Size = new Size(100, 34);
            label3.TabIndex = 23;
            label3.Text = "Edad:";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button1.Location = new Point(94, 352);
            button1.Name = "button1";
            button1.Size = new Size(251, 49);
            button1.TabIndex = 27;
            button1.Text = "Menú Principal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // editar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(pasatiempo);
            Controls.Add(age);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(actualizaruser);
            Controls.Add(selectUsuarios);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "editar";
            Text = "editar";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox selectUsuarios;
        private Label label5;
        private Button actualizaruser;
        private ComboBox pasatiempo;
        private TextBox age;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}