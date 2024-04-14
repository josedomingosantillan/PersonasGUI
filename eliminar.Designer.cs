namespace PersonaGUI
{
    partial class eliminar
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
            actualizaruser = new Button();
            selectUsuarios = new ComboBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // actualizaruser
            // 
            actualizaruser.Font = new Font("Arial Rounded MT Bold", 16.2F);
            actualizaruser.Location = new Point(388, 261);
            actualizaruser.Name = "actualizaruser";
            actualizaruser.Size = new Size(177, 49);
            actualizaruser.TabIndex = 27;
            actualizaruser.Text = "Eliminar";
            actualizaruser.UseVisualStyleBackColor = true;
            actualizaruser.Click += actualizaruser_Click;
            // 
            // selectUsuarios
            // 
            selectUsuarios.FormattingEnabled = true;
            selectUsuarios.Location = new Point(168, 139);
            selectUsuarios.Name = "selectUsuarios";
            selectUsuarios.Size = new Size(397, 28);
            selectUsuarios.TabIndex = 26;
            selectUsuarios.Text = "Selecciona un Usuario.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 18F);
            label5.Location = new Point(13, 133);
            label5.Name = "label5";
            label5.Size = new Size(138, 34);
            label5.TabIndex = 25;
            label5.Text = "Usuario:";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.png_transparent_user_computer_icons_logo_others_service_logo_computer_wallpaper;
            pictureBox1.Location = new Point(625, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 9);
            label1.Name = "label1";
            label1.Size = new Size(729, 93);
            label1.TabIndex = 23;
            label1.Text = "Eliminar Usuarios";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button1.Location = new Point(107, 261);
            button1.Name = "button1";
            button1.Size = new Size(251, 49);
            button1.TabIndex = 28;
            button1.Text = "Menú Principal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // eliminar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(actualizaruser);
            Controls.Add(selectUsuarios);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "eliminar";
            Text = "eliminar";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button actualizaruser;
        private ComboBox selectUsuarios;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
    }
}