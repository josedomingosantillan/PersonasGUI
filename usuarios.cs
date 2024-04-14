using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonaGUI
{
    public partial class usuarios : Form
    {
        private DataTable data;
        public usuarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btngeneral_Click(object sender, EventArgs e)
        {
            try
            {

                ConectDB oracleDBManager = new ConectDB();
                string ordenamiento = "asc";
                if (desc.Checked == true)
                {
                    ordenamiento = "desc";
                }
                string query = $"SELECT ID as Id, NOMBRE as Nombre, CASE WHEN SEXO = 'M' THEN 'Masculino' WHEN SEXO = 'F' THEN 'Femenino' ELSE SEXO END as Sexo, PASATIEMPO as Pasatiempo, EDAD as Edad FROM usuarios order by PASATIEMPO {ordenamiento}";

                data = oracleDBManager.ExecuteQueryUsers(query);

                usersTable.DataSource = data;

                total_users.Text = $"Total de usuarios:";
                prom_edad.Text = $"Promedio de edad:";
                InputIdUser.Text = "";

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine($"Error de Oracle: {ex.Message}");
            }
        }

        private void btnespecifico_Click(object sender, EventArgs e)
        {
            try
            {

                int idSearch = Convert.ToInt32(InputIdUser.Text);

                if (idSearch > 0)
                {
                    ConectDB oracleDBManager = new ConectDB();

                    string query = $"SELECT ID as Id, NOMBRE as Nombre, CASE WHEN SEXO = 'M' THEN 'Masculino' WHEN SEXO = 'F' THEN 'Femenino' ELSE SEXO END as Sexo, PASATIEMPO as Pasatiempo, EDAD as Edad FROM usuarios where id = {idSearch}";

                    data = oracleDBManager.ExecuteQueryUsers(query);

                    if (data.Rows.Count < 1)
                    {
                        MessageBox.Show("No se encontraron resultados para la consulta.");
                        InputIdUser.Text = "";
                        return;
                    }
                    usersTable.DataSource = data;
                    InputIdUser.Text = "";
                    total_users.Text = $"Total de usuarios:";
                    prom_edad.Text = $"Promedio de edad:";
                }
                else
                {
                    MessageBox.Show("Id de Usuario incorrecto.");
                    InputIdUser.Text = "";
                }



            }
            catch (OracleException ex)
            {
                Console.WriteLine($"Error de Oracle: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConectDB conectDB = new ConectDB();
            conectDB.Menu();
            this.Hide();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            try
            {

                if (data == null || data.Rows.Count == 0)
                {

                    ConectDB oracleDBManager = new ConectDB();
                    string ordenamiento = "asc";
                    if (desc.Checked == true)
                    {
                        ordenamiento = "desc";
                    }
                    string query = $"SELECT ID as Id, NOMBRE as Nombre, CASE WHEN SEXO = 'M' THEN 'Masculino' WHEN SEXO = 'F' THEN 'Femenino' ELSE SEXO END as Sexo, PASATIEMPO as Pasatiempo, EDAD as Edad FROM usuarios order by PASATIEMPO {ordenamiento}";

                    data = oracleDBManager.ExecuteQueryUsers(query);


                }
                int total = 0, contador = 0; ;
                foreach (DataRow row in data.Rows)
                {
                    total += Convert.ToInt32(row["Edad"]);
                    contador++;
                }

                prom_edad.Text = $"Promedio de edad: {total / contador}";
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine($"Error de Oracle: {ex.Message}");
            }
        }

        private void Contar_Click(object sender, EventArgs e)
        {
            try
            {

                if (data == null || data.Rows.Count == 0)
                {

                    ConectDB oracleDBManager = new ConectDB();
                    string ordenamiento = "asc";
                    if (desc.Checked == true)
                    {
                        ordenamiento = "desc";
                    }
                    string query = $"SELECT ID as Id, NOMBRE as Nombre, CASE WHEN SEXO = 'M' THEN 'Masculino' WHEN SEXO = 'F' THEN 'Femenino' ELSE SEXO END as Sexo, PASATIEMPO as Pasatiempo, EDAD as Edad FROM usuarios order by PASATIEMPO {ordenamiento}";

                    data = oracleDBManager.ExecuteQueryUsers(query);


                }


                total_users.Text = $"Total de usuarios: {data.Rows.Count}";
            }
            catch (OracleException ex)
            {
                Console.WriteLine($"Error de Oracle: {ex.Message}");
            }
        }
    }
}
