using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.SqlClient;            


//kazka prisimaigiau ir BindingNavigator rodo neaktyvu paleidus.. Paspaudus SAVE neissaugo iraso naujo, nors dar paskaitos
//video ziurejau kad nieko daryt nereikia ir issaugot turi
//ir gerai butu nauja irasa vedant (per mygtuka ar pliusa) kad issaugotu.. galvojau kad atskira klase kurtis reiktu, 
//bet prie to sql uzsisedejau



namespace Darbeliai
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void baigtiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var ivesti = new NaujasIvedimas())
            {
                ivesti.ShowDialog();

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'darbaiDataSet11.Darbas' table. You can move, or remove it, as needed.
            this.darbasTableAdapter.Fill(this.darbaiDataSet11.Darbas);
            // TODO: This line of code loads data into the 'darbaiDataSet.Darbininkas' table. You can move, or remove it, as needed.
            this.darbininkasTableAdapter1.Fill(this.darbaiDataSet.Darbininkas);
            // TODO: This line of code loads data into the 'darbaiDataSet.Darbininkas' table. You can move, or remove it, as needed.
            this.darbininkasTableAdapter1.Fill(this.darbaiDataSet.Darbininkas);

            this.darbasTableAdapter1.Fill(this.darbaiDataSet.Darbas);
            this.darbininkasTableAdapter1.Fill(this.darbaiDataSet.Darbininkas);


            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DGJ\source\repos\KCS_Csharp_baigiamasis\Darbeliai\Darbai.mdf;Integrated Security=True";
            DataContext db = new DataContext(connectionString);
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            Table<Darbininka> darbininkas = db.GetTable<Darbininka>();
            Table<Darba> darb = db.GetTable<Darba>();

            //var vardas = darb.Name.ToString();

            using (SqlCommand sqlCommand = new SqlCommand("SELECT Darbas.Id, Darbininkas.Name AS Vardas, Darbas.WorkDesc, Darbas.WorkStart FROM Darbas INNER JOIN Darbininkas ON Darbas.Worker_ID = Darbininkas.WorkerID", sqlConnection))
            {
                sqlConnection.Open();
                var reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    //    //dataGridView1.Columns.Equals(reader["ID"].ToString());
                    //    //dataGridView1.Columns.Equals(reader["Name"].ToString());
                    //    //dataGridView1.Rows(reader["Name"]).ToString();
                    //}


                    //cia turetu rodyti dataGridView is sql SELECT Darbas.Id, Darbininkas.Name AS Vardas, Darbas.WorkDesc, Darbas.WorkStart
                    //kad butu visos uzduotys bet vietoj darbuotojo id rodytu jo varda
                    foreach (var item in darbininkas)
                    {
                        dataGridView1.Rows.Add(item.Name );
                       // dataGridView1.Rows.Add(item. );
                     
                    }
                    //foreach (var item in darb)
                    //{
                    //    dataGridView1.Rows.Add( item.WorkDesc );
                    //}

                }
                sqlConnection.Close();


            }




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.Rows.Clear(); //isvalo pries tai buvusius duomenis
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DGJ\source\repos\KCS_Csharp_baigiamasis\Darbeliai\Darbai.mdf;Integrated Security=True";
            //DataContext db = new DataContext(connectionString);



        }

        private void darbaiDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // this.
            }
            catch (System.Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorSeparator_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            using (var ivesti = new NaujasIvedimas())
            {
                ivesti.ShowDialog();

            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.darbasTableAdapter1.FillBy(this.darbaiDataSet.Darbas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.darbininkasTableAdapter1.FillBy(this.darbaiDataSet.Darbininkas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void darbininkasBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.darbasTableAdapter1.FillBy1(this.darbaiDataSet.Darbas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.darbasTableAdapter1.FillBy2(this.darbaiDataSet.Darbas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.darbininkasTableAdapter1.Fill(this.darbaiDataSet.Darbininkas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.darbininkasTableAdapter1.Fill(this.darbaiDataSet.Darbininkas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy3ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.darbasTableAdapter1.FillBy3(this.darbaiDataSet.Darbas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.darbasTableAdapter.Fill(this.darbaiDataSet11.Darbas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.darbasTableAdapter.FillBy(this.darbaiDataSet11.Darbas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.darbasTableAdapter.FillBy(this.darbaiDataSet11.Darbas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void atliktiToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.darbasTableAdapter.Atlikti(this.darbaiDataSet11.Darbas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void visiDarbaiToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.darbasTableAdapter.VisiDarbai(this.darbaiDataSet11.Darbas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void daromiToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.darbasTableAdapter.Daromi(this.darbaiDataSet11.Darbas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            using (var ivesti = new NaujasIvedimas())
            {
                ivesti.ShowDialog();

            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
