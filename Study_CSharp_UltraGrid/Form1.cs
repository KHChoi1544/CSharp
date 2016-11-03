using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using System.Diagnostics;

namespace Study_CSharp_UltraGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UltraGridBand band = this.ultraGrid1.DisplayLayout.Bands[0];

            // Set a column's and group's headers' captions to a multi-line text.
            band.Columns[0].Header.Caption = "Line 1\nLine 2";

            // Assuming you have added groups to the band, set first group's header's Caption 
            // to a multiline text.
            band.Groups[0].Header.Caption = "Multiline\nGroup Header";

            // To accomodate the multiline captions, set the ColHeaderLines and 
            // GroupHeaderLines to 2.
            band.ColHeaderLines = 2;
            band.GroupHeaderLines = 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
