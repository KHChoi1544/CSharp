namespace Study_Database
{
    partial class How_to_connect_SQL_Database
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
            this.user2Pc = new System.Windows.Forms.Button();
            this.user3Pc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user2Pc
            // 
            this.user2Pc.Location = new System.Drawing.Point(12, 12);
            this.user2Pc.Name = "user2Pc";
            this.user2Pc.Size = new System.Drawing.Size(277, 23);
            this.user2Pc.TabIndex = 0;
            this.user2Pc.Text = "USER2-PC_AdventureWorks2012";
            this.user2Pc.UseVisualStyleBackColor = true;
            // 
            // user3Pc
            // 
            this.user3Pc.Location = new System.Drawing.Point(304, 12);
            this.user3Pc.Name = "user3Pc";
            this.user3Pc.Size = new System.Drawing.Size(277, 23);
            this.user3Pc.TabIndex = 1;
            this.user3Pc.Text = "USER3-PC_AdventureWorks2012";
            this.user3Pc.UseVisualStyleBackColor = true;
            this.user3Pc.Click += new System.EventHandler(this.user3Pc_Click);
            // 
            // How_to_connect_SQL_Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 261);
            this.Controls.Add(this.user3Pc);
            this.Controls.Add(this.user2Pc);
            this.Name = "How_to_connect_SQL_Database";
            this.Text = "How_to_connect_SQL_Database";
            this.Load += new System.EventHandler(this.How_to_connect_SQL_Database_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button user2Pc;
        private System.Windows.Forms.Button user3Pc;
    }
}

