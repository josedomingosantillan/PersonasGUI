using Oracle.ManagedDataAccess.Client;

namespace PersonaGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void send_Click(object sender, EventArgs e)
        {
            string Name = name.Text, Age = age.Text;

            int item = pasatiempo.SelectedIndex;

            if (item == -1)
            {
                MessageBox.Show("Debes de llenar todos los datos del formulario");
                return;
            }

            string Pasatiempos = pasatiempo.Items[item].ToString();

            bool masculino = Masculino.Checked, femenino = Femenino.Checked;

            if ((masculino || femenino) && Name != "" && Age != "")
            {
                try
                {
                    string connectionString = "User Id=SYSTEM;Password=chivasDE1;Data Source=localhost:1521/FREE;";

                    ConectDB oracleDBManager = new ConectDB();

                    string sexo = "";
                    if (masculino == true)
                    {
                        sexo = "M";
                    }
                    else
                    {
                        sexo = "F";
                    }

                    string sqlInsert = $"INSERT INTO usuarios VALUES (null, '{Name}', '{sexo}', '{Pasatiempos}','{Age}')";

                    oracleDBManager.ExecuteNonQuery(sqlInsert);

                    MessageBox.Show("Se insertó registro correctamente.");
                }
                catch (OracleException ex)
                {
                    Console.WriteLine($"Error de Oracle: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Debes de llenar todos los datos del formulario");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu= new Menu();
            menu.Show();
            this.Hide();
        }
    }
}