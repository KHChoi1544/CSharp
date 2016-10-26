namespace Study_CSharp_UltraGrid
{
    partial class CalendarStyle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.calendarInfo = new Infragistics.Win.UltraWinSchedule.UltraCalendarInfo(this.components);
            this.ultraMonthViewMulti1 = new Infragistics.Win.UltraWinSchedule.UltraMonthViewMulti();
            this.calendarLook = new Infragistics.Win.UltraWinSchedule.UltraCalendarLook(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ultraMonthViewMulti1)).BeginInit();
            this.SuspendLayout();
            // 
            // calendarInfo
            // 
            this.calendarInfo.DataBindingsForAppointments.BindingContextControl = this;
            this.calendarInfo.DataBindingsForOwners.BindingContextControl = this;
            // 
            // ultraMonthViewMulti1
            // 
            this.ultraMonthViewMulti1.BackColor = System.Drawing.SystemColors.Window;
            this.ultraMonthViewMulti1.CalendarInfo = this.calendarInfo;
            this.ultraMonthViewMulti1.CalendarLook = this.calendarLook;
            this.ultraMonthViewMulti1.Location = new System.Drawing.Point(12, 12);
            this.ultraMonthViewMulti1.MonthDimensions = new System.Drawing.Size(1, 2);
            this.ultraMonthViewMulti1.Name = "ultraMonthViewMulti1";
            this.ultraMonthViewMulti1.Size = new System.Drawing.Size(153, 256);
            this.ultraMonthViewMulti1.TabIndex = 1;
            // 
            // CalendarStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 663);
            this.Controls.Add(this.ultraMonthViewMulti1);
            this.Name = "CalendarStyle";
            this.Text = "CalendarStyle";
            this.Load += new System.EventHandler(this.CalendarStyle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraMonthViewMulti1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraWinSchedule.UltraCalendarInfo calendarInfo;
        private Infragistics.Win.UltraWinSchedule.UltraMonthViewMulti ultraMonthViewMulti1;
        private Infragistics.Win.UltraWinSchedule.UltraCalendarLook calendarLook;
    }
}