namespace HTPT_Inventory_Forms
{
    partial class PoolTableView
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
            this.PoolTableDataGridView = new System.Windows.Forms.DataGridView();
            this.FilterPTButton = new System.Windows.Forms.Button();
            this.ResetPTButton = new System.Windows.Forms.Button();
            this.RemovePTButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PoolTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PoolTableDataGridView
            // 
            this.PoolTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PoolTableDataGridView.Location = new System.Drawing.Point(12, 92);
            this.PoolTableDataGridView.Name = "PoolTableDataGridView";
            this.PoolTableDataGridView.RowHeadersWidth = 51;
            this.PoolTableDataGridView.Size = new System.Drawing.Size(776, 346);
            this.PoolTableDataGridView.TabIndex = 0;
            this.PoolTableDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PoolTableDataGridView_CellContentClick);
            // 
            // FilterPTButton
            // 
            this.FilterPTButton.Location = new System.Drawing.Point(221, 29);
            this.FilterPTButton.Name = "FilterPTButton";
            this.FilterPTButton.Size = new System.Drawing.Size(126, 32);
            this.FilterPTButton.TabIndex = 1;
            this.FilterPTButton.Text = "Filter";
            this.FilterPTButton.UseVisualStyleBackColor = true;
            this.FilterPTButton.Click += new System.EventHandler(this.FilterPTButton_Click);
            // 
            // ResetPTButton
            // 
            this.ResetPTButton.Location = new System.Drawing.Point(356, 29);
            this.ResetPTButton.Name = "ResetPTButton";
            this.ResetPTButton.Size = new System.Drawing.Size(126, 32);
            this.ResetPTButton.TabIndex = 2;
            this.ResetPTButton.Text = "Reset Form";
            this.ResetPTButton.UseVisualStyleBackColor = true;
            this.ResetPTButton.Click += new System.EventHandler(this.ResetPTButton_Click);
            // 
            // RemovePTButton
            // 
            this.RemovePTButton.Location = new System.Drawing.Point(492, 29);
            this.RemovePTButton.Name = "RemovePTButton";
            this.RemovePTButton.Size = new System.Drawing.Size(126, 32);
            this.RemovePTButton.TabIndex = 3;
            this.RemovePTButton.Text = "Remove Item";
            this.RemovePTButton.UseVisualStyleBackColor = true;
            this.RemovePTButton.Click += new System.EventHandler(this.RemovePTButton_Click);
            // 
            // PoolTableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RemovePTButton);
            this.Controls.Add(this.ResetPTButton);
            this.Controls.Add(this.FilterPTButton);
            this.Controls.Add(this.PoolTableDataGridView);
            this.Name = "PoolTableView";
            this.Text = "PoolTableForm";
            this.Activated += new System.EventHandler(this.PoolTableView_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PoolTableView_FormClosing);
            this.Load += new System.EventHandler(this.PoolTableInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PoolTableDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PoolTableDataGridView;
        private System.Windows.Forms.Button FilterPTButton;
        private System.Windows.Forms.Button ResetPTButton;
        private System.Windows.Forms.Button RemovePTButton;
    }
}