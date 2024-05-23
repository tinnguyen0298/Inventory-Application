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
    public partial class PoolTableFilter : Form
    {
        public PoolTableFilter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HTHTMainForm.colorPTFilter = comboBox3.Text;
            HTHTMainForm.lengthPTFilter = comboBox2.Text;
            HTHTMainForm.pocketsPTFilter = comboBox1.Text;
            this.Close();
        }
    }
}
