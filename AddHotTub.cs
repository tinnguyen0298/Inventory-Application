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
    public partial class AddHotTub : Form
    {
        public AddHotTub()
        {
            InitializeComponent();
        }

        private void AddFormHTButton_Click(object sender, EventArgs e)
        {
            HTHTMainForm.HotTubInventory[HTHTMainForm.hottubIndex++] = new HotTub(ManufacturerAHTBox.Text, SerialNumberAHTBox.Text, ModelAHTBox.Text,
                double.Parse(WholesalePriceAHTBox.Text), int.Parse(NumberPeopleAHTBox.Text), bool.Parse(LightKitAHTBox.Text), int.Parse(NumberJetsAHTBox.Text));          
            this.Close();
        }

        private void AddHotTub_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LightKitAHTBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CancelAddHTButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
