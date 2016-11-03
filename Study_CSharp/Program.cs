using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Study_CSharp_Database;
using Study_CSharp_UltraGrid;


namespace Study_CSharp_Main
{
    static class Program
    {
        //Study_CSharp_Database.How_to_connect_SQL_Database how_to_connect_sql_database = new How_to_connect_SQL_Database(); 
        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            //Application.Run(new How_to_connect_SQL_Database());
            Application.Run(new Study_CSharp_UltraGrid.Form1());
        }
    }
}
