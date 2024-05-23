using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTPT_Inventory_Forms
{
    public partial class PoolTableView : Form
    {
        public PoolTableView()
        {
            InitializeComponent();
            PoolTableDataGridView.ColumnCount = 7;
            PoolTableDataGridView.Columns[0].Name = "Manufacturer";
            PoolTableDataGridView.Columns[1].Name = "Serial Number";
            PoolTableDataGridView.Columns[2].Name = "Model";
            PoolTableDataGridView.Columns[3].Name = "Price";
            PoolTableDataGridView.Columns[4].Name = "Length";
            PoolTableDataGridView.Columns[5].Name = "Pockets?";
            PoolTableDataGridView.Columns[6].Name = "Color";
        }

        private void PoolTableInventory_Load(object sender, EventArgs e)
        {

        }

        private void FilterPTButton_Click(object sender, EventArgs e)
        {
            PoolTableFilter ptFilter = new PoolTableFilter();
            ptFilter.ShowDialog();
        }

        private void ResetPTButton_Click(object sender, EventArgs e)
        {
            PoolTableDataGridView.Rows.Clear();
            HTHTMainForm.colorPTFilter = "";
            HTHTMainForm.pocketsPTFilter = "";
            HTHTMainForm.lengthPTFilter = "";
            LoadPoolTableGrid();
        }

        private void PoolTableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LoadPoolTableGrid()
        {
            PoolTableDataGridView.Rows.Clear();
            for (int idx = 0; idx < HTHTMainForm.pooltableIndex; idx++)
            {
                if (HTHTMainForm.colorPTFilter == "" ||
                    HTHTMainForm.colorPTFilter == HTHTMainForm.PoolTableInventory[idx].FeltColor.ToString())
                {
                    if (HTHTMainForm.pocketsPTFilter == "" ||
                        HTHTMainForm.pocketsPTFilter == HTHTMainForm.PoolTableInventory[idx].PocketsPresent.ToString())
                    {
                        if (HTHTMainForm.lengthPTFilter == "" ||
                            HTHTMainForm.lengthPTFilter == HTHTMainForm.PoolTableInventory[idx].TableLength.ToString())
                        {
                            PoolTableDataGridView.Rows.Add(HTHTMainForm.PoolTableInventory[idx].PoolTableRecordArray());
                        }
                    }
                }
            }
        }

        private void PoolTableView_Activated(object sender, EventArgs e)
        {
            LoadPoolTableGrid();
        }

        private void RemovePTButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in PoolTableDataGridView.SelectedCells)
            {
                if (oneCell.Selected)
                {
                    DeleteTheRecord(HTHTMainForm.PoolTableInventory, PoolTableDataGridView.CurrentRow.Cells[1].Value.ToString());
                    LoadPoolTableGrid();
                    break;
                }
            }
        }

        private void PoolTableView_FormClosing(object sender, FormClosingEventArgs e)
        {
            PoolTableDataGridView.Rows.Clear();
            HTHTMainForm.colorPTFilter = "";
            HTHTMainForm.pocketsPTFilter = "";
            HTHTMainForm.lengthPTFilter = "";
            this.Hide();
            e.Cancel = true;
        }

        private void DeleteTheRecord(PoolTable[] PoolTableArray, string serialNmbr)
        {
            int foundIndex = -1;
            for (int i = 0; i < PoolTableArray.Length; i++)
            {
                if (PoolTableArray[i].SerialNumber == serialNmbr)
                {
                    foundIndex = i;
                    break;
                }
            }
            PoolTableArray[foundIndex] = null;
            for (int i = foundIndex; i < PoolTableArray.Length - 1; i++)
            {
                // move the next object "down" in the array, then if that next one was null, break out
                PoolTableArray[i] = PoolTableArray[i + 1];

                if (PoolTableArray[i + 1] == null)
                {
                    break;
                }
            }
            // make the last item in the array null - since deleting one always leaves the array less than full, 
            // this addresses the case of the deleted record being last or next to last. Also adjust index for next writeable index.
            PoolTableArray[(PoolTableArray.Length) - 1] = null;

            HTHTMainForm.pooltableIndex -= 1;
        }
    }
}
