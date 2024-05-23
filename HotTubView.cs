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
    public partial class HotTubView : Form
    {
        public HotTubView()
        {
            InitializeComponent();
            HotTubDataGridView.ColumnCount = 7;
            HotTubDataGridView.Columns[0].Name = "Manufacturer";
            HotTubDataGridView.Columns[1].Name = "Serial Number";
            HotTubDataGridView.Columns[2].Name = "Model";
            HotTubDataGridView.Columns[3].Name = "Price";
            HotTubDataGridView.Columns[4].Name = "# People";
            HotTubDataGridView.Columns[5].Name = "Lights?";
            HotTubDataGridView.Columns[6].Name = "# of Jets";
        }

        private void FilterHTButton_Click(object sender, EventArgs e)
        {
            HotTubFilter htFilter = new HotTubFilter();
            htFilter.ShowDialog();
        }
        //string[] row = new string[] { "1", "Product 1", "1000" };
        //dataGridView1.Rows.Add(row);


        private void HotTubDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void LoadHotTubGrid()
        {
            HotTubDataGridView.Rows.Clear();
            for (int idx = 0; idx < HTHTMainForm.hottubIndex; idx++)
            {
                if (HTHTMainForm.peopleHTFilter == "" || 
                    HTHTMainForm.peopleHTFilter == HTHTMainForm.HotTubInventory[idx].PeopleCapacity.ToString())
                {
                    if (HTHTMainForm.jetsHTFilter == "" || 
                        HTHTMainForm.jetsHTFilter == HTHTMainForm.HotTubInventory[idx].NumberOfJets.ToString())
                    {
                        if (HTHTMainForm.lightkitHTFilter == "" || 
                            HTHTMainForm.lightkitHTFilter == HTHTMainForm.HotTubInventory[idx].LightKit.ToString())
                        {
                            HotTubDataGridView.Rows.Add(HTHTMainForm.HotTubInventory[idx].HotTubRecordArray());
                        }
                    }
                }
            }
        }

        private void HotTubView_Activated(object sender, EventArgs e)
        {
            LoadHotTubGrid();
        }

        private void ResetHTButton_Click(object sender, EventArgs e)
        {
            HotTubDataGridView.Rows.Clear();
            HTHTMainForm.peopleHTFilter = "";
            HTHTMainForm.jetsHTFilter = "";
            HTHTMainForm.lightkitHTFilter = "";
            LoadHotTubGrid();
        }

        private void RemoveHTButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in HotTubDataGridView.SelectedCells)
            {
                if (oneCell.Selected)
                {
                    DeleteTheRecord(HTHTMainForm.HotTubInventory, HotTubDataGridView.CurrentRow.Cells[1].Value.ToString());
                    LoadHotTubGrid();
                    break;
                }
            }
        }

        private void HotTubView_FormClosing(object sender, FormClosingEventArgs e)
        {
            HotTubDataGridView.Rows.Clear();
            HTHTMainForm.peopleHTFilter = "";
            HTHTMainForm.jetsHTFilter = "";
            HTHTMainForm.lightkitHTFilter = "";
            this.Hide();
            e.Cancel = true;
        }

        private void DeleteTheRecord(HotTub[] HotTubArray, string serialNmbr)
        {

            int foundIndex = -1;
            for (int i = 0; i < HotTubArray.Length; i++)
            {
                if (HotTubArray[i].SerialNumber == serialNmbr)
                {
                    foundIndex = i;
                    break;
                }
            }
            HotTubArray[foundIndex] = null;
            for (int i = foundIndex; i < HotTubArray.Length - 1; i++)
            {
                // move the next object "down" in the array, then if that next one was null, break out
                HotTubArray[i] = HotTubArray[i + 1];

                if (HotTubArray[i + 1] == null)
                {
                    break;
                }
            }
            // make the last item in the array null - since deleting one always leaves the array less than full, 
            // this addresses the case of the deleted record being last or next to last. Also adjust index for next writeable index.
            HotTubArray[(HotTubArray.Length) - 1] = null;

            HTHTMainForm.hottubIndex -= 1;
        }

    }
}
