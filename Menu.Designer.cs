namespace PersonaGUI
{
    partial class Menu
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button1.Location = new Point(242, 158);
            button1.Name = "button1";
            button1.Size = new Size(290, 49);
            button1.TabIndex = 14;
            button1.Text = "Consultar Usuarios";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button2.Location = new Point(242, 249);
            button2.Name = "button2";
            button2.Size = new Size(294, 49);
            button2.TabIndex = 15;
            button2.Text = "Editar Usuarios";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(281, 9);
            label1.Name = "label1";
            label1.Size = new Size(251, 93);
            label1.TabIndex = 16;
            label1.Text = "Menú";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.png_transparent_user_computer_icons_logo_others_service_logo_computer_wallpaper;
            pictureBox1.Location = new Point(625, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button3.Location = new Point(242, 343);
            button3.Name = "button3";
            button3.Size = new Size(294, 49);
            button3.TabIndex = 18;
            button3.Text = "Eliminar Usuarios";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Menu";
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button3;
    }
}