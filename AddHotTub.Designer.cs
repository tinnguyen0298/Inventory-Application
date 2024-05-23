namespace HTPT_Inventory_Forms
{
    partial class AddHotTub
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
            this.ManufacturerAHTBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SerialNumberAHTBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ModelAHTBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WholesalePriceAHTBox = new System.Windows.Forms.TextBox();
            this.LightKitAHTBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NumberPeopleAHTBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NumberJetsAHTBox = new System.Windows.Forms.TextBox();
            this.AddFormHTButton = new System.Windows.Forms.Button();
            this.CancelAddHTButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ManufacturerAHTBox
            // 
            this.ManufacturerAHTBox.Location = new System.Drawing.Point(9, 41);
            this.ManufacturerAHTBox.Margin = new System.Windows.Forms.Padding(4);
            this.ManufacturerAHTBox.Name = "ManufacturerAHTBox";
            this.ManufacturerAHTBox.Size = new System.Drawing.Size(216, 22);
            this.ManufacturerAHTBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manufacturer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Serial Number";
            // 
            // SerialNumberAHTBox
            // 
            this.SerialNumberAHTBox.Location = new System.Drawing.Point(264, 41);
            this.SerialNumberAHTBox.Margin = new System.Windows.Forms.Padding(4);
            this.SerialNumberAHTBox.Name = "SerialNumberAHTBox";
            this.SerialNumberAHTBox.Size = new System.Drawing.Size(216, 22);
            this.SerialNumberAHTBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Model";
            // 
            // ModelAHTBox
            // 
            this.ModelAHTBox.Location = new System.Drawing.Point(511, 41);
            this.ModelAHTBox.Margin = new System.Windows.Forms.Padding(4);
            this.ModelAHTBox.Name = "ModelAHTBox";
            this.ModelAHTBox.Size = new System.Drawing.Size(216, 22);
            this.ModelAHTBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Wholesale Price";
            // 
            // WholesalePriceAHTBox
            // 
            this.WholesalePriceAHTBox.Location = new System.Drawing.Point(9, 102);
            this.WholesalePriceAHTBox.Margin = new System.Windows.Forms.Padding(4);
            this.WholesalePriceAHTBox.Name = "WholesalePriceAHTBox";
            this.WholesalePriceAHTBox.Size = new System.Drawing.Size(216, 22);
            this.WholesalePriceAHTBox.TabIndex = 6;
            // 
            // LightKitAHTBox
            // 
            this.LightKitAHTBox.FormattingEnabled = true;
            this.LightKitAHTBox.Items.AddRange(new object[] {
            "",
            "True",
            "False"});
            this.LightKitAHTBox.Location = new System.Drawing.Point(511, 102);
            this.LightKitAHTBox.Margin = new System.Windows.Forms.Padding(4);
            this.LightKitAHTBox.Name = "LightKitAHTBox";
            this.LightKitAHTBox.Size = new System.Drawing.Size(216, 24);
            this.LightKitAHTBox.TabIndex = 10;
            this.LightKitAHTBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(507, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Light Kit?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 84);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Number of People";
            // 
            // NumberPeopleAHTBox
            // 
            this.NumberPeopleAHTBox.Location = new System.Drawing.Point(264, 104);
            this.NumberPeopleAHTBox.Margin = new System.Windows.Forms.Padding(4);
            this.NumberPeopleAHTBox.Name = "NumberPeopleAHTBox";
            this.NumberPeopleAHTBox.Size = new System.Drawing.Size(216, 22);
            this.NumberPeopleAHTBox.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 146);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Number of Jets";
            // 
            // NumberJetsAHTBox
            // 
            this.NumberJetsAHTBox.Location = new System.Drawing.Point(9, 166);
            this.NumberJetsAHTBox.Margin = new System.Windows.Forms.Padding(4);
            this.NumberJetsAHTBox.Name = "NumberJetsAHTBox";
            this.NumberJetsAHTBox.Size = new System.Drawing.Size(216, 22);
            this.NumberJetsAHTBox.TabIndex = 14;
            // 
            // AddFormHTButton
            // 
            this.AddFormHTButton.Location = new System.Drawing.Point(264, 160);
            this.AddFormHTButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddFormHTButton.Name = "AddFormHTButton";
            this.AddFormHTButton.Size = new System.Drawing.Size(216, 28);
            this.AddFormHTButton.TabIndex = 16;
            this.AddFormHTButton.Text = "Add Hot Tub";
            this.AddFormHTButton.UseVisualStyleBackColor = true;
            this.AddFormHTButton.Click += new System.EventHandler(this.AddFormHTButton_Click);
            // 
            // CancelAddHTButton
            // 
            this.CancelAddHTButton.Location = new System.Drawing.Point(510, 160);
            this.CancelAddHTButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelAddHTButton.Name = "CancelAddHTButton";
            this.CancelAddHTButton.Size = new System.Drawing.Size(216, 28);
            this.CancelAddHTButton.TabIndex = 17;
            this.CancelAddHTButton.Text = "Cancel";
            this.CancelAddHTButton.UseVisualStyleBackColor = true;
            this.CancelAddHTButton.Click += new System.EventHandler(this.CancelAddHTButton_Click);
            // 
            // AddHotTub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 229);
            this.Controls.Add(this.CancelAddHTButton);
            this.Controls.Add(this.AddFormHTButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NumberJetsAHTBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NumberPeopleAHTBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LightKitAHTBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WholesalePriceAHTBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ModelAHTBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SerialNumberAHTBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ManufacturerAHTBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddHotTub";
            this.Text = "AddHotTub";
            this.Load += new System.EventHandler(this.AddHotTub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ManufacturerAHTBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SerialNumberAHTBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ModelAHTBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox WholesalePriceAHTBox;
        private System.Windows.Forms.ComboBox LightKitAHTBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NumberPeopleAHTBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NumberJetsAHTBox;
        private System.Windows.Forms.Button AddFormHTButton;
        private System.Windows.Forms.Button CancelAddHTButton;
    }
}