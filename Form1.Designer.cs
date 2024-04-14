namespace PersonaGUI
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            send = new Button();
            cancel = new Button();
            name = new TextBox();
            age = new TextBox();
            pasatiempo = new ComboBox();
            Masculino = new RadioButton();
            Femenino = new RadioButton();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(186, 9);
            label1.Name = "label1";
            label1.Size = new Size(372, 93);
            label1.TabIndex = 0;
            label1.Text = "Registro";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 18F);
            label2.Location = new Point(26, 117);
            label2.Name = "label2";
            label2.Size = new Size(142, 34);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 18F);
            label3.Location = new Point(26, 167);
            label3.Name = "label3";
            label3.Size = new Size(100, 34);
            label3.TabIndex = 2;
            label3.Text = "Edad:";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 18F);
            label4.Location = new Point(26, 213);
            label4.Name = "label4";
            label4.Size = new Size(96, 34);
            label4.TabIndex = 3;
            label4.Text = "Sexo:";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 18F);
            label5.Location = new Point(26, 263);
            label5.Name = "label5";
            label5.Size = new Size(197, 34);
            label5.TabIndex = 4;
            label5.Text = "Pasatiempo:";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // send
            // 
            send.Font = new Font("Arial Rounded MT Bold", 16.2F);
            send.Location = new Point(214, 368);
            send.Name = "send";
            send.Size = new Size(177, 49);
            send.TabIndex = 5;
            send.Text = "Enviar";
            send.UseVisualStyleBackColor = true;
            send.Click += send_Click;
            // 
            // cancel
            // 
            cancel.Font = new Font("Arial Rounded MT Bold", 16.2F);
            cancel.Location = new Point(410, 368);
            cancel.Name = "cancel";
            cancel.Size = new Size(177, 49);
            cancel.TabIndex = 6;
            cancel.Text = "Cancelar";
            cancel.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            name.Font = new Font("Arial", 12F);
            name.Location = new Point(174, 112);
            name.MaxLength = 100;
            name.Name = "name";
            name.Size = new Size(452, 30);
            name.TabIndex = 7;
            // 
            // age
            // 
            age.Font = new Font("Arial", 12F);
            age.Location = new Point(174, 169);
            age.MaxLength = 3;
            age.Name = "age";
            age.Size = new Size(138, 30);
            age.TabIndex = 8;
            // 
            // pasatiempo
            // 
            pasatiempo.FormattingEnabled = true;
            pasatiempo.Items.AddRange(new object[] { "Fútbol", "Cantar", "Bailar", "Ejercicio" });
            pasatiempo.Location = new Point(229, 269);
            pasatiempo.Name = "pasatiempo";
            pasatiempo.Size = new Size(397, 28);
            pasatiempo.TabIndex = 9;
            pasatiempo.Text = "Selecciona una opción";
            // 
            // Masculino
            // 
            Masculino.AutoSize = true;
            Masculino.Location = new Point(174, 223);
            Masculino.Name = "Masculino";
            Masculino.Size = new Size(97, 24);
            Masculino.TabIndex = 10;
            Masculino.TabStop = true;
            Masculino.Text = "Masculino";
            Masculino.UseVisualStyleBackColor = true;
            // 
            // Femenino
            // 
            Femenino.AutoSize = true;
            Femenino.Location = new Point(306, 223);
            Femenino.Name = "Femenino";
            Femenino.Size = new Size(95, 24);
            Femenino.TabIndex = 11;
            Femenino.TabStop = true;
            Femenino.Text = "Femenino";
            Femenino.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.png_transparent_computer_icons_registered_user_login_user_profile_others_blue_logo_registered_user_thumbnail;
            pictureBox1.Location = new Point(663, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button1.Location = new Point(26, 368);
            button1.Name = "button1";
            button1.Size = new Size(177, 49);
            button1.TabIndex = 13;
            button1.Text = "Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(Femenino);
            Controls.Add(Masculino);
            Controls.Add(pasatiempo);
            Controls.Add(age);
            Controls.Add(name);
            Controls.Add(cancel);
            Controls.Add(send);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button send;
        private Button cancel;
        private TextBox name;
        private TextBox age;
        private ComboBox pasatiempo;
        private RadioButton Masculino;
        private RadioButton Femenino;
        private PictureBox pictureBox1;
        private Button button1;
    }
}
