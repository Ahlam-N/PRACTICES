using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ADO_NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionString["dbcs"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs)) 
            {

                SqlCommand cm = new SqlCommand("select * from personsss", con);
                con.Open();

                int numberoflineaffected = (int)cm.ExecuteScalar;
                if(numberoflineaffected > 0)
                {
                    MessageBox.Show("Successfull");
                }
              SqlDataReader sqlDataReader = cm.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Console.WriteLine(sqlDataReader["name"])
                }
            }

            }

          
        
        }
    }
}
