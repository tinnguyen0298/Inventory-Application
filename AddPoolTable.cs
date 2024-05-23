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
    public partial class AddPoolTable : Form
    {
        public AddPoolTable()
        {
            InitializeComponent();
        }

        private void AddFormPTButton_Click(object sender, EventArgs e)
        {
            HTHTMainForm.PoolTableInventory[HTHTMainForm.pooltableIndex++] = new PoolTable(ManufacturerAPTBox.Text, SerialNumberAPTBox.Text, ModelAPTBox.Text,
                double.Parse(WholesalePriceAPTBox.Text), int.Parse(LengthAPTBox.Text), bool.Parse(PocketsAPTBox.Text), ColorAPTBox.Text);
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PocketsAPTBox.DropDownStyle = ComboBoxStyle.DropDownList;            
        }

        private void AddPoolTable_Load(object sender, EventArgs e)
        {
            
        }

        private void CancelAddPTButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
