namespace PersonaGUI
{
    partial class usuarios
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            usersTable = new DataGridView();
            label2 = new Label();
            btngeneral = new Button();
            btnespecifico = new Button();
            InputIdUser = new TextBox();
            label3 = new Label();
            button1 = new Button();
            ordenamiento = new GroupBox();
            desc = new RadioButton();
            asc = new RadioButton();
            Calcular = new Button();
            Contar = new Button();
            prom_edad = new Label();
            total_users = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usersTable).BeginInit();
            ordenamiento.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.png_transparent_user_computer_icons_logo_others_service_logo_computer_wallpaper;
            pictureBox1.Location = new Point(625, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(207, 12);
            label1.Name = "label1";
            label1.Size = new Size(388, 93);
            label1.TabIndex = 1;
            label1.Text = "Usuarios";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // usersTable
            // 
            usersTable.AllowUserToAddRows = false;
            usersTable.AllowUserToDeleteRows = false;
            usersTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            usersTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            usersTable.ColumnHeadersHeight = 29;
            usersTable.Location = new Point(12, 318);
            usersTable.Name = "usersTable";
            usersTable.ReadOnly = true;
            usersTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            usersTable.RowsDefaultCellStyle = dataGridViewCellStyle1;
            usersTable.Size = new Size(776, 193);
            usersTable.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 18F);
            label2.Location = new Point(12, 110);
            label2.Name = "label2";
            label2.Size = new Size(295, 34);
            label2.TabIndex = 3;
            label2.Text = "Consultar Usuarios";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // btngeneral
            // 
            btngeneral.Font = new Font("Arial Rounded MT Bold", 13.8F);
            btngeneral.Location = new Point(27, 69);
            btngeneral.Name = "btngeneral";
            btngeneral.Size = new Size(150, 39);
            btngeneral.TabIndex = 4;
            btngeneral.Text = "General";
            btngeneral.UseVisualStyleBackColor = true;
            btngeneral.Click += btngeneral_Click;
            // 
            // btnespecifico
            // 
            btnespecifico.Font = new Font("Arial Rounded MT Bold", 13.8F);
            btnespecifico.Location = new Point(614, 172);
            btnespecifico.Name = "btnespecifico";
            btnespecifico.Size = new Size(150, 39);
            btnespecifico.TabIndex = 5;
            btnespecifico.Text = "Específica";
            btnespecifico.UseVisualStyleBackColor = true;
            btnespecifico.Click += btnespecifico_Click;
            // 
            // InputIdUser
            // 
            InputIdUser.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InputIdUser.Location = new Point(430, 173);
            InputIdUser.Name = "InputIdUser";
            InputIdUser.Size = new Size(178, 34);
            InputIdUser.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(265, 177);
            label3.Name = "label3";
            label3.Size = new Size(164, 27);
            label3.TabIndex = 7;
            label3.Text = "Id de usuario:";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button1.Location = new Point(253, 521);
            button1.Name = "button1";
            button1.Size = new Size(251, 49);
            button1.TabIndex = 28;
            button1.Text = "Menú Principal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ordenamiento
            // 
            ordenamiento.Controls.Add(desc);
            ordenamiento.Controls.Add(asc);
            ordenamiento.Controls.Add(btngeneral);
            ordenamiento.Font = new Font("Arial Rounded MT Bold", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ordenamiento.Location = new Point(12, 173);
            ordenamiento.Name = "ordenamiento";
            ordenamiento.Size = new Size(244, 120);
            ordenamiento.TabIndex = 29;
            ordenamiento.TabStop = false;
            ordenamiento.Text = "Ordenamiento:";
            // 
            // desc
            // 
            desc.AutoSize = true;
            desc.Location = new Point(97, 32);
            desc.Name = "desc";
            desc.Size = new Size(90, 31);
            desc.TabIndex = 1;
            desc.Text = "Desc";
            desc.UseVisualStyleBackColor = true;
            // 
            // asc
            // 
            asc.AutoSize = true;
            asc.Checked = true;
            asc.Location = new Point(15, 32);
            asc.Name = "asc";
            asc.Size = new Size(76, 31);
            asc.TabIndex = 0;
            asc.TabStop = true;
            asc.Text = "Asc";
            asc.UseVisualStyleBackColor = true;
            // 
            // Calcular
            // 
            Calcular.Font = new Font("Arial Rounded MT Bold", 13.8F);
            Calcular.Location = new Point(262, 254);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(150, 39);
            Calcular.TabIndex = 30;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // Contar
            // 
            Contar.Font = new Font("Arial Rounded MT Bold", 13.8F);
            Contar.Location = new Point(545, 254);
            Contar.Name = "Contar";
            Contar.Size = new Size(150, 39);
            Contar.TabIndex = 31;
            Contar.Text = "Contar";
            Contar.UseVisualStyleBackColor = true;
            Contar.Click += Contar_Click;
            // 
            // prom_edad
            // 
            prom_edad.AutoSize = true;
            prom_edad.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prom_edad.Location = new Point(262, 224);
            prom_edad.Name = "prom_edad";
            prom_edad.Size = new Size(222, 27);
            prom_edad.TabIndex = 32;
            prom_edad.Text = "Promedio de edad:";
            prom_edad.TextAlign = ContentAlignment.TopCenter;
            // 
            // total_users
            // 
            total_users.AutoSize = true;
            total_users.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            total_users.Location = new Point(545, 224);
            total_users.Name = "total_users";
            total_users.Size = new Size(211, 27);
            total_users.TabIndex = 33;
            total_users.Text = "Total de usuarios:";
            total_users.TextAlign = ContentAlignment.TopCenter;
            // 
            // usuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 583);
            Controls.Add(total_users);
            Controls.Add(prom_edad);
            Controls.Add(Contar);
            Controls.Add(Calcular);
            Controls.Add(ordenamiento);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(InputIdUser);
            Controls.Add(btnespecifico);
            Controls.Add(label2);
            Controls.Add(usersTable);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "usuarios";
            Text = "usuarios";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)usersTable).EndInit();
            ordenamiento.ResumeLayout(false);
            ordenamiento.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView usersTable;
        private Label label2;
        private Button btngeneral;
        private Button btnespecifico;
        private TextBox InputIdUser;
        private Label label3;
        private Button button1;
        private GroupBox ordenamiento;
        private RadioButton desc;
        private RadioButton asc;
        private Button Calcular;
        private Button Contar;
        private Label prom_edad;
        private Label total_users;
    }
}