using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PersonaGUI
{
    public partial class editar : Form
    {
        // Declarar resultTable como una variable de clase para que sea accesible en toda la clase
        private DataTable resultTable;

        public editar()
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

        private void pasatiempo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar si hay algún elemento seleccionado en el ComboBox
            if (selectUsuarios.SelectedItem != null)
            {
                // Obtener la cadena que representa al usuario seleccionado
                string usuarioString = selectUsuarios.SelectedItem.ToString();

                // Dividir la cadena para extraer el nombre de usuario
                string[] usuarioData = usuarioString.Split('-');

                // Obtener el nombre de usuario eliminando los espacios en blanco al inicio y al final
                string nombreUsuario = usuarioData[0].Trim();

                try
                {
                    // Recuperar el pasatiempo y la edad del usuario seleccionado del DataTable
                    DataRow[] selectedRows = resultTable.Select($"Nombre = '{nombreUsuario}'");

                    // Verificar si se encontraron resultados
                    if (selectedRows.Length > 0)
                    {
                        // Obtener el pasatiempo del primer resultado (debería haber solo uno)
                        string pasatiempos = selectedRows[0]["Pasatiempo"].ToString();

                        string edad = selectedRows[0]["Edad"].ToString();

                        age.Text = edad;


                        // Buscar el índice del usuario seleccionado en el ComboBox
                        int index = selectUsuarios.FindString(usuarioString);


                        // Verificar si se encontró el índice
                        if (index != -1)
                        {
                            // Establecer el índice seleccionado del ComboBox para que coincida con el índice del usuario
                            pasatiempo.SelectedIndex = index;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"No se encontraron datos para el usuario {nombreUsuario}.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {
            // Este método se generó automáticamente al hacer clic en el label, 
            // pero actualmente no tiene ninguna funcionalidad, así que lo dejaremos vacío.
        }

        private void actualizaruser_Click(object sender, EventArgs e)
        {
            if (selectUsuarios.SelectedItem != null)
            {
                string usuarioString = selectUsuarios.SelectedItem.ToString(), Age = age.Text;


                int item = pasatiempo.SelectedIndex;
                if (item == -1)
                {
                    MessageBox.Show("Debes de llenar todos los datos del formulario");
                    return;
                }

                string Pasatiempos = pasatiempo.Items[item].ToString();

                if (Age != "")
                {
                    try
                    {

                        ConectDB oracleDBManager = new ConectDB();

                        string sqlUpdate = $"update usuarios set EDAD= {Age},PASATIEMPO='{Pasatiempos}' where Nombre = '{usuarioString}'";

                        oracleDBManager.ExecuteNonQuery(sqlUpdate);

                        MessageBox.Show("Usuario actualizado correctamente.");
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
                    MessageBox.Show("Debes de llenar todos los datos del formulario.");
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciona un usuario.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConectDB conectDB = new ConectDB(); 
            conectDB.Menu();
            this.Hide();
        }
    }
}
