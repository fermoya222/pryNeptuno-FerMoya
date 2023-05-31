using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;


namespace pryNeptuno_FerMoya
{
    internal class ClaseBD
    {
        OleDbCommand command = new OleDbCommand();
        OleDbConnection connection = new OleDbConnection();
        OleDbDataReader reader;

        string CadenaDeConexion;

        public void ConectarBD()
        {
            CadenaDeConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NEPTUNO.accdb;";

            try
            {
                connection.ConnectionString = CadenaDeConexion;
                connection.Open();

                //MessageBox.Show("exito");
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }

        public void CargarCmb(ComboBox cmb)
        {
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.TableDirect;
            command.CommandText = "Proveedores";

            reader = command.ExecuteReader();

            cmb.Items.Clear();

            while (reader.Read())
            {
                cmb.Items.Add(reader.GetString(8));
            }

            reader.Close();

        }
        public void CargarCmb(ComboBox cmb,string NombrePais)
        {
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.TableDirect;
            command.CommandText = "Proveedores";

            reader = command.ExecuteReader();

            //Limpio para que o se acumule 
            cmb.Items.Clear();

            while (reader.Read())
            {
                if (reader.GetString(8) == NombrePais)
                {
                    cmb.Items.Add(reader.GetString(5));
                }
                
            }
            reader.Close();
        }

    }
}
