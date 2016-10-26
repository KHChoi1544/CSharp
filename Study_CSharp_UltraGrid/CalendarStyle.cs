using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Study_CSharp_UltraGrid
{
    public partial class CalendarStyle : Form
    {
        public CalendarStyle()
        {
            InitializeComponent();
        }

        private void CalendarStyle_Load(object sender, EventArgs e)
        {
            calendarInfo.EventManager.AllEventsEnabled = false;
            calendarInfo.SelectedDateRanges.Clear();
            calendarInfo.SelectedDateRanges.Add(DateTime.Today, 6);

            calendarInfo.EventManager.AllEventsEnabled = true;  
        }

    }
}
