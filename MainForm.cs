using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HTPT_Inventory_Forms
{
    public partial class HTHTMainForm : Form
    {
        static public int hottubIndex = 0;
        static public int pooltableIndex = 0;
        static public PoolTable[] PoolTableInventory = new PoolTable[100];
        static public HotTub[] HotTubInventory = new HotTub[100];

        // Filter Variables - all strings since will be comparing to text box contents (strings)

        static public string colorPTFilter = "";
        static public string pocketsPTFilter = "";
        static public string lengthPTFilter = "";

        static public string peopleHTFilter = "";
        static public string jetsHTFilter = "";
        static public string lightkitHTFilter = "";

        static public HotTubView HotTubViewForm = new HotTubView();


        public HTHTMainForm()
        {
            InitializeComponent();
        }

        private void ViewHotTubButton_Click(object sender, EventArgs e)
        {
            // HotTubView HotTubViewForm = new HotTubView(); Moved this up to make static public
            HotTubViewForm.Show();
        }

        private void ViewPoolTableButton_Click(object sender, EventArgs e)
        {
            PoolTableView poolTable = new PoolTableView();
            poolTable.ShowDialog();
        }

        private void AddHotTubButton_Click(object sender, EventArgs e)
        {
            AddHotTub addHt = new AddHotTub();
            addHt.ShowDialog();
        }

        private void AddPoolTableButton_Click(object sender, EventArgs e)
        {
            AddPoolTable addPt = new AddPoolTable();
            addPt.ShowDialog();
        }

        private void ImportDataButton_Click(object sender, EventArgs e)
        {
            ReadDataFromFile();
            // Activate all the buttons for action and deactivate the Load File button
            this.AddHotTubButton.Enabled = true;
            this.ViewHotTubButton.Enabled = true;
            this.AddPoolTableButton.Enabled = true;
            this.ViewPoolTableButton.Enabled = true;
            this.ImportDataButton.Enabled = false;

        }
        public void ReadDataFromFile()
        {

            string text = System.IO.File.ReadAllText(@"..\Debug\InventoryDataFile1.csv");
            string[] inventoryFile = text.Split('\n');

            foreach (string inventoryRecord in inventoryFile)
            {
                string[] recordFields = inventoryRecord.Split(',');

                if (recordFields[0] == "H")
                {
                    //HotTubInventory[hottubIndex++] = new HotTub(string mfrName, string srlNmbr, string mdlName, double whlslPrice, int pplCapacity, bool lghtKit, int nmbrOfJet);
                    HotTubInventory[hottubIndex++] = new HotTub(recordFields[1], recordFields[2], recordFields[3],
                        double.Parse(recordFields[4]), int.Parse(recordFields[5]), bool.Parse(recordFields[6]), int.Parse(recordFields[7]));
                }
                else if (recordFields[0] == "P")
                {
                    //PoolTable(string mfrName, string srlNmbr, string mdlName, double whlslPrice, int tblLength, bool pcktsPresent, string fltColor)
                    PoolTableInventory[pooltableIndex++] = new PoolTable(recordFields[1], recordFields[2], recordFields[3],
                        double.Parse(recordFields[4]), int.Parse(recordFields[5]), bool.Parse(recordFields[6]), recordFields[7]);
                }
            }

        }
    }
}
