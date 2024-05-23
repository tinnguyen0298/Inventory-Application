namespace HTPT_Inventory_Forms
{
    partial class HTHTMainForm
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
            this.AddHotTubButton = new System.Windows.Forms.Button();
            this.ViewHotTubButton = new System.Windows.Forms.Button();
            this.AddPoolTableButton = new System.Windows.Forms.Button();
            this.ViewPoolTableButton = new System.Windows.Forms.Button();
            this.ImportDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddHotTubButton
            // 
            this.AddHotTubButton.Enabled = false;
            this.AddHotTubButton.Location = new System.Drawing.Point(178, 9);
            this.AddHotTubButton.Name = "AddHotTubButton";
            this.AddHotTubButton.Size = new System.Drawing.Size(130, 33);
            this.AddHotTubButton.TabIndex = 0;
            this.AddHotTubButton.Text = "Add Hot Tub";
            this.AddHotTubButton.UseVisualStyleBackColor = true;
            this.AddHotTubButton.Click += new System.EventHandler(this.AddHotTubButton_Click);
            // 
            // ViewHotTubButton
            // 
            this.ViewHotTubButton.Enabled = false;
            this.ViewHotTubButton.Location = new System.Drawing.Point(178, 62);
            this.ViewHotTubButton.Name = "ViewHotTubButton";
            this.ViewHotTubButton.Size = new System.Drawing.Size(130, 33);
            this.ViewHotTubButton.TabIndex = 1;
            this.ViewHotTubButton.Text = "View Hot Tub";
            this.ViewHotTubButton.UseVisualStyleBackColor = true;
            this.ViewHotTubButton.Click += new System.EventHandler(this.ViewHotTubButton_Click);
            // 
            // AddPoolTableButton
            // 
            this.AddPoolTableButton.Enabled = false;
            this.AddPoolTableButton.Location = new System.Drawing.Point(178, 119);
            this.AddPoolTableButton.Name = "AddPoolTableButton";
            this.AddPoolTableButton.Size = new System.Drawing.Size(130, 33);
            this.AddPoolTableButton.TabIndex = 2;
            this.AddPoolTableButton.Text = "Add Pool Table";
            this.AddPoolTableButton.UseVisualStyleBackColor = true;
            this.AddPoolTableButton.Click += new System.EventHandler(this.AddPoolTableButton_Click);
            // 
            // ViewPoolTableButton
            // 
            this.ViewPoolTableButton.Enabled = false;
            this.ViewPoolTableButton.Location = new System.Drawing.Point(178, 172);
            this.ViewPoolTableButton.Name = "ViewPoolTableButton";
            this.ViewPoolTableButton.Size = new System.Drawing.Size(130, 33);
            this.ViewPoolTableButton.TabIndex = 3;
            this.ViewPoolTableButton.Text = "View Pool Table";
            this.ViewPoolTableButton.UseVisualStyleBackColor = true;
            this.ViewPoolTableButton.Click += new System.EventHandler(this.ViewPoolTableButton_Click);
            // 
            // ImportDataButton
            // 
            this.ImportDataButton.Location = new System.Drawing.Point(26, 92);
            this.ImportDataButton.Name = "ImportDataButton";
            this.ImportDataButton.Size = new System.Drawing.Size(130, 33);
            this.ImportDataButton.TabIndex = 4;
            this.ImportDataButton.Text = "Import Data";
            this.ImportDataButton.UseVisualStyleBackColor = true;
            this.ImportDataButton.Click += new System.EventHandler(this.ImportDataButton_Click);
            // 
            // HTHTMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 215);
            this.Controls.Add(this.ImportDataButton);
            this.Controls.Add(this.ViewPoolTableButton);
            this.Controls.Add(this.AddPoolTableButton);
            this.Controls.Add(this.ViewHotTubButton);
            this.Controls.Add(this.AddHotTubButton);
            this.Name = "HTHTMainForm";
            this.Text = "HotTubs and Hot Tables Inventory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddHotTubButton;
        private System.Windows.Forms.Button ViewHotTubButton;
        private System.Windows.Forms.Button AddPoolTableButton;
        private System.Windows.Forms.Button ViewPoolTableButton;
        private System.Windows.Forms.Button ImportDataButton;
    }
}

