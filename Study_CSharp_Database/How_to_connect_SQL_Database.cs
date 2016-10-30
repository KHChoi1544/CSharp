using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Study_CSharp_Database
{
    public partial class How_to_connect_SQL_Database : Form
    {
        //ConfigurationManager ConnectionStrings = new System.Configuration.ConfigurationManager();

        // test
        public How_to_connect_SQL_Database()
        {
            InitializeComponent();
        }
        //ZZ// 

        private void user3Pc_Click(object sender, EventArgs e)
        {

        }

        private void How_to_connect_SQL_Database_Load(object sender, EventArgs e)
        {
            //var connection_string = System.Configuration.ConfigurationManager.connectionStrings["USER3-PC_AdventureWorks2012"].connectionString;
            var connection_string = System.Configuration.ConfigurationManager.ConnectionStrings["USER3-PC_AdventureWorks2012"].ConnectionString;
            
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connection_string;
                    conn.Open();

                    //SqlCommand command = new SqlCommand("SELECT * FROM [Purchasing].[Vendor]", conn);

                    // Create the command
                    SqlCommand command = new SqlCommand("SELECT * FROM [Purchasing].[Vendor] WHERE NAME = @name", conn);

                    // Add the parameters.
                    command.Parameters.Add(new SqlParameter("name", "Australia Bike Retailer"));





                    // Create new SqlDataReader object and read data from the command.
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // while there is another record present
                        while (reader.Read())
                        {
                            // write the data on to the screen
                            /*
                            Console.WriteLine(string.Format("{0} \t | {1} \t | {2} \t | {3}",
                                // call the objects from their index
                                reader[0], reader[1], reader[2], reader[3]));
                            */
                            textBox1.Text = string.Format("{0} \t | {1} \t | {2} \t | {3}",
                                // call the objects from their index
                                reader[0], reader[1], reader[2], reader[3]);
                        }
                    }

                    // 머지는 머지?
                    //SqlCommand insertCommand = new SqlCommand("INSERT INTO [Purchasing].[Vendor] (BusinessEntityID, Name) VALUES (@0, @1)", conn);
                    //insertCommand.Parameters.Add(new SqlParameter("0", 9999));
                    //insertCommand.Parameters.Add(new SqlParameter("1", "testUser"));

                    //SqlCommand errorCommand = new SqlCommand("INSERT INTO [Purchasing].[Vendor] (BusinessEntityID, Name) VALUES (@0, @1)", conn);
                    //errorCommand.Parameters.Add(new SqlParameter("0", 9999));
                    //errorCommand.Parameters.Add(new SqlParameter("1", "testUser"));

                    //errorCommand.ExecuteNonQuery();
                }
            }
            catch (SqlException er)
            {
                MessageBox.Show("There was an error reported by SQL Server, " + er.Message);
                //throw;
            }

            finally
            {

            }
        }

    }
}