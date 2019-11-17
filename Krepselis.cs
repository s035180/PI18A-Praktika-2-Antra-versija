using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktinis2._2
{
    public partial class Krepselis : UserControl
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Krepselis.mdb;";
        private OleDbConnection myConnection;
        public Krepselis()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Krepselis_Load(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            string isvedimas = "SELECT Pavadinimas, Kaina, Apmokejimo_busena FROM Krepselis ORDER BY ID;";
            OleDbCommand command = new OleDbCommand(isvedimas, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            listBox3.Items.Clear();
            while (reader.Read())
            {
                listBox3.Items.Add(reader[0].ToString() + "/" + reader[1].ToString() + "/" + reader[2].ToString() + "/");

            }
            reader.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
