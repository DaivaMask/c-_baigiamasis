using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Darbeliai
{
    public partial class NaujasIvedimas : Form
    {
        public NaujasIvedimas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DGJ\source\repos\KCS_Csharp_baigiamasis\Darbeliai\Darbai.mdf;Integrated Security=True";
            DataContext db = new DataContext(connectionString);
            Table<Darbininka> darbininkas = db.GetTable<Darbininka>(); //gausim duomenis is lenteles
            
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Darbininkas", sqlConnection))
            //{
            //    sqlConnection.Open();
            //    var reader = sqlCommand.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        object[] jobs =  checkedListBox1.Items.Cast<Darbininka>().ToArray();
            //        int index = checkedListBox1.Items.IndexOf(reader );
            //        //checkedListBox1.SetItemChecked(index, true);


            //    }

                sqlConnection.Close();
            }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void NaujasIvedimas_Load(object sender, EventArgs e)
        {

        }
    }

   
}
