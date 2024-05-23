namespace HTPT_Inventory_Forms
{
    partial class HotTubView
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
            this.RemoveHTButton = new System.Windows.Forms.Button();
            this.ResetHTButton = new System.Windows.Forms.Button();
            this.FilterHTButton = new System.Windows.Forms.Button();
            this.HotTubDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.HotTubDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RemoveHTButton
            // 
            this.RemoveHTButton.Location = new System.Drawing.Point(492, 21);
            this.RemoveHTButton.Name = "RemoveHTButton";
            this.RemoveHTButton.Size = new System.Drawing.Size(126, 31);
            this.RemoveHTButton.TabIndex = 7;
            this.RemoveHTButton.Text = "Remove Item";
            this.RemoveHTButton.UseVisualStyleBackColor = true;
            this.RemoveHTButton.Click += new System.EventHandler(this.RemoveHTButton_Click);
            // 
            // ResetHTButton
            // 
            this.ResetHTButton.Location = new System.Drawing.Point(356, 21);
            this.ResetHTButton.Name = "ResetHTButton";
            this.ResetHTButton.Size = new System.Drawing.Size(126, 31);
            this.ResetHTButton.TabIndex = 6;
            this.ResetHTButton.Text = "Reset Form";
            this.ResetHTButton.UseVisualStyleBackColor = true;
            this.ResetHTButton.Click += new System.EventHandler(this.ResetHTButton_Click);
            // 
            // FilterHTButton
            // 
            this.FilterHTButton.Location = new System.Drawing.Point(221, 21);
            this.FilterHTButton.Name = "FilterHTButton";
            this.FilterHTButton.Size = new System.Drawing.Size(126, 31);
            this.FilterHTButton.TabIndex = 5;
            this.FilterHTButton.Text = "Filter";
            this.FilterHTButton.UseVisualStyleBackColor = true;
            this.FilterHTButton.Click += new System.EventHandler(this.FilterHTButton_Click);
            // 
            // HotTubDataGridView
            // 
            this.HotTubDataGridView.AllowUserToAddRows = false;
            this.HotTubDataGridView.AllowUserToDeleteRows = false;
            this.HotTubDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HotTubDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HotTubDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.HotTubDataGridView.Location = new System.Drawing.Point(12, 83);
            this.HotTubDataGridView.MultiSelect = false;
            this.HotTubDataGridView.Name = "HotTubDataGridView";
            this.HotTubDataGridView.ReadOnly = true;
            this.HotTubDataGridView.RowHeadersWidth = 51;
            this.HotTubDataGridView.Size = new System.Drawing.Size(776, 346);
            this.HotTubDataGridView.TabIndex = 4;
            this.HotTubDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HotTubDataGridView_CellContentClick);
            // 
            // HotTubView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RemoveHTButton);
            this.Controls.Add(this.ResetHTButton);
            this.Controls.Add(this.FilterHTButton);
            this.Controls.Add(this.HotTubDataGridView);
            this.Name = "HotTubView";
            this.Text = "HotTubForm";
            this.Activated += new System.EventHandler(this.HotTubView_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HotTubView_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.HotTubDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RemoveHTButton;
        private System.Windows.Forms.Button ResetHTButton;
        private System.Windows.Forms.Button FilterHTButton;
        private System.Windows.Forms.DataGridView HotTubDataGridView;
    }
}