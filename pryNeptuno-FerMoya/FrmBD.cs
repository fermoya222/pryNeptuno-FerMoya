using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Common;
using System.Windows.Input;

namespace pryNeptuno_FerMoya
{
    public partial class FrmBD : Form
    {
        OleDbCommand Command;
        OleDbConnection Connection;
        OleDbDataReader Reader;


        public FrmBD()
        {
            InitializeComponent();
        }

        private void FrmBD_Load(object sender, EventArgs e)
        {
            try
            {
                Connection = new OleDbConnection();

                Connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NEPTUNO.accdb";

                Connection.Open();


                btnConect.BackColor = Color.Green;

            }
            catch (Exception ex)
            {
                btnConect.Text = "Error";
                btnConect.Text = ex.Message;
                btnConect.BackColor = Color.Red;
            }
        }

        private void clientes_Click(object sender, EventArgs e)
        {
            try
            {
                Command = new OleDbCommand();

                Command.Connection = Connection;
                Command.CommandType = CommandType.TableDirect;
                Command.CommandText = "Clientes";

                btnCargar.BackColor = Color.Green;

                Reader = Command.ExecuteReader();

                while (Reader.Read())
                {

                    dgv.Rows.Add(Reader[0], Reader[1], Reader[2], Reader[3], Reader[4], Reader[5], Reader[6], Reader[7], Reader[8], Reader[9]);

                }


            }
            catch (Exception)
            {
                btnCargar.Text = "Error";
                btnCargar.BackColor = Color.Red;


            }
        }

}
