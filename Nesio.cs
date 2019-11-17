using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktinis2._2
{
    public partial class Nesio : UserControl
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Nesio.mdb;";
        private OleDbConnection myConnection;
        public static string connectString3 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Krepselis.mdb;";
        private OleDbConnection myConnection3;
        public Nesio()
        {
            InitializeComponent();
            myConnection3 = new OleDbConnection(connectString3);
            myConnection3.Open();
        }

        private void Nesio_Load(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            string isvedimas = "SELECT Pavadinimas, Kiekis, Kaina FROM Nesio ORDER BY ID";
            OleDbCommand command = new OleDbCommand(isvedimas, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            listBox2.Items.Clear();
            while (reader.Read())
            {
                listBox2.Items.Add(reader[0].ToString() + "/" + reader[1].ToString() + "/" + reader[2].ToString() + "/");

            }
            reader.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            string isvedimas = "SELECT Pavadinimas, Kiekis, Kaina FROM Nesio ORDER BY ID;";
            OleDbCommand command = new OleDbCommand(isvedimas, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (listBox2.GetItemText(listBox2.SelectedItem).ToString() == reader[0].ToString() + "/" + reader[1].ToString() + "/" + reader[2].ToString() + "/")
                {
                    string query = "INSERT INTO Krepselis (Pavadinimas, Kaina, Apmokejimo_busena) VALUES ('" + reader[0].ToString() + "', '" + reader[2].ToString() + "', 'Neapmoketa')";
                    OleDbCommand command2 = new OleDbCommand(query, myConnection3);
                    command2.ExecuteNonQuery();
                    MessageBox.Show("Preke sekmingai itraukta i kripseli", "Prekes", MessageBoxButtons.OK);
                }


            }
            reader.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            string isvedimas = "SELECT Pavadinimas, Kiekis, Kaina, CPU, Videocard, Memory FROM Nesio ORDER BY ID;";
            OleDbCommand command = new OleDbCommand(isvedimas, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (listBox2.GetItemText(listBox2.SelectedItem).ToString() == reader[0].ToString() + "/" + reader[1].ToString() + "/" + reader[2].ToString() + "/")
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add(reader[3].ToString() + "/" + reader[4].ToString() + "/" + reader[5] + "/");
                }


            }
            reader.Close();
        }
    }
}
