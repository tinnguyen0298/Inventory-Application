namespace HTPT_Inventory_Forms
{
    partial class HotTubFilter
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
            this.button1 = new System.Windows.Forms.Button();
            this.JetsFilterBox = new System.Windows.Forms.ComboBox();
            this.PeopleFilterBox = new System.Windows.Forms.ComboBox();
            this.LightKitFilterBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 140);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 52);
            this.button1.TabIndex = 7;
            this.button1.Text = "Apply Filters";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ApplyHTFilterButton_Click);
            // 
            // JetsFilterBox
            // 
            this.JetsFilterBox.FormattingEnabled = true;
            this.JetsFilterBox.Location = new System.Drawing.Point(565, 72);
            this.JetsFilterBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.JetsFilterBox.Name = "JetsFilterBox";
            this.JetsFilterBox.Size = new System.Drawing.Size(219, 32);
            this.JetsFilterBox.TabIndex = 6;
            // 
            // PeopleFilterBox
            // 
            this.PeopleFilterBox.FormattingEnabled = true;
            this.PeopleFilterBox.Items.AddRange(new object[] {
            "",
            "4",
            "5",
            "6"});
            this.PeopleFilterBox.Location = new System.Drawing.Point(293, 72);
            this.PeopleFilterBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PeopleFilterBox.Name = "PeopleFilterBox";
            this.PeopleFilterBox.Size = new System.Drawing.Size(219, 32);
            this.PeopleFilterBox.TabIndex = 5;
            // 
            // LightKitFilterBox
            // 
            this.LightKitFilterBox.FormattingEnabled = true;
            this.LightKitFilterBox.Items.AddRange(new object[] {
            "",
            "True",
            "False"});
            this.LightKitFilterBox.Location = new System.Drawing.Point(26, 72);
            this.LightKitFilterBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LightKitFilterBox.Name = "LightKitFilterBox";
            this.LightKitFilterBox.Size = new System.Drawing.Size(219, 32);
            this.LightKitFilterBox.TabIndex = 4;
            this.LightKitFilterBox.SelectedIndexChanged += new System.EventHandler(this.LightKitFilterBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Light Kit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Number of People";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(561, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Number of Jets";
            // 
            // HotTubFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 325);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.JetsFilterBox);
            this.Controls.Add(this.PeopleFilterBox);
            this.Controls.Add(this.LightKitFilterBox);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "HotTubFilter";
            this.Text = "HotTubFilter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox JetsFilterBox;
        private System.Windows.Forms.ComboBox PeopleFilterBox;
        private System.Windows.Forms.ComboBox LightKitFilterBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}