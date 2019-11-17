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
    public partial class Admin : UserControl
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Stacio.mdb;";
        private OleDbConnection myConnection;
        public static string connectString2 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Nesio.mdb;";
        private OleDbConnection myConnection2;
        public Admin()
        {
            InitializeComponent();
            myConnection2 = new OleDbConnection(connectString2);
            myConnection2.Open();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            string isvedimas = "SELECT Pavadinimas, Kiekis, Kaina FROM Stacio ORDER BY ID";
            OleDbCommand command = new OleDbCommand(isvedimas, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            listBox1.Items.Clear();
            while (reader.Read())
            {
                listBox1.Items.Add(reader[0].ToString() + "/" + reader[1].ToString() + "/" + reader[2].ToString() + "/");

            }
            reader.Close();
            myConnection2 = new OleDbConnection(connectString2);
            myConnection2.Open();
            string isvedimas2 = "SELECT Pavadinimas, Kiekis, Kaina FROM Nesio ORDER BY ID";
            OleDbCommand command2 = new OleDbCommand(isvedimas2, myConnection2);
            OleDbDataReader reader2 = command2.ExecuteReader();
            listBox2.Items.Clear();
            while (reader2.Read())
            {
                listBox2.Items.Add(reader2[0].ToString() + "/" + reader2[1].ToString() + "/" + reader2[2].ToString() + "/");

            }
            reader.Close();
        }
    }
}
