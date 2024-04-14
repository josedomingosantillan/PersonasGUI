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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PersonaGUI
{
    public partial class eliminar : Form
    {
        private DataTable resultTable;
        public eliminar()
        {
            InitializeComponent();
            try
            {
                ConectDB oracleDBManager = new ConectDB();
                string query = "SELECT ID as Id, NOMBRE as Nombre, CASE WHEN SEXO = 'M' THEN 'Masculino' WHEN SEXO = 'F' THEN 'Femenino' ELSE SEXO END as Sexo, EDAD as Edad, PASATIEMPO as Pasatiempo FROM usuarios";
                // Asignar el resultado de la consulta al DataTable resultTable
                resultTable = oracleDBManager.ExecuteQueryUsers(query);

                // Llenar el ComboBox con los nombres de usuario
                selectUsuarios.Items.Clear();
                foreach (DataRow row in resultTable.Rows)
                {
                    string usuarioString = $"{row["Nombre"]}";
                    selectUsuarios.Items.Add(usuarioString);
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

        private void actualizaruser_Click(object sender, EventArgs e)
        {
            if (selectUsuarios.SelectedItem != null)
            {
                string usuarioString = selectUsuarios.SelectedItem.ToString();
                try
                {
                    ConectDB oracleDBManager = new ConectDB();

                    string sqlUpdate = $"delete from usuarios where Nombre = '{usuarioString}'";

                    MessageBox.Show(sqlUpdate);
                    oracleDBManager.ExecuteNonQuery(sqlUpdate);

                    MessageBox.Show("Usuario eliminado correctamente.");
                    oracleDBManager.Menu();
                    this.Hide();
                }
                catch (OracleException ex)
                {
                    Console.WriteLine($"Error de Oracle: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciona un usuario.");
            }
            }
    }
}
