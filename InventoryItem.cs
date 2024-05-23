using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTPT_Inventory_Forms
{
    public abstract class InventoryItem
    {
        string manufacturerName;
        string serialNumber;
        string modelName;
        double wholesalePrice;
        const double MARKUP_PERCENT = .25;


        public InventoryItem (string mfrName, string srlNmbr, string mdlName, double whlslPrice)
        {
            this.manufacturerName = mfrName;
            this.serialNumber = srlNmbr;
            this.modelName = mdlName;
            this.wholesalePrice = whlslPrice;
        }

        public string ManufacturerName
        {
            get
            {
                return manufacturerName;
            }
        }
        public string SerialNumber
        {
            get
            {
                return serialNumber;
            }
        }
        public string ModelName
        {
            get
            {
                return modelName;
            }
        }
        public double WholesalePrice
        {
            get
            {
                return wholesalePrice;
            }
        }
        public double RetailPrice()
        {
            // return a retail price based on wholesale price
            return WholesalePrice + WholesalePrice * MARKUP_PERCENT;
        }
    }

    public class HotTub : InventoryItem
    {
        int peopleCapacity;
        bool lightKit;
        int numberOfJets;

        public HotTub(string mfrName, string srlNmbr, string mdlName, double whlslPrice, int pplCapacity, bool lghtKit, int nmbrOfJets)
            : base (mfrName, srlNmbr, mdlName, whlslPrice)
        {
            this.peopleCapacity = pplCapacity;
            this.lightKit = lghtKit;
            this.numberOfJets = nmbrOfJets;
        }
        public string[] HotTubRecordArray()
        {
            string[] returnArray = new string[7];
            returnArray[0] = ManufacturerName;
            returnArray[1] = SerialNumber;
            returnArray[2] = ModelName;
            returnArray[3] = RetailPrice().ToString("C2");
            returnArray[4] = PeopleCapacity.ToString();
            returnArray[5] = LightKit.ToString();
            returnArray[6] = NumberOfJets.ToString();
            return returnArray;
        }

        public int PeopleCapacity
        {
            get
            {
                return peopleCapacity;
            }
        }
        public bool LightKit
        {
            get
            {
                return lightKit;
            }
        }
        public int NumberOfJets
        {
            get
            {
                return numberOfJets;
            }
        }
    }
    public class PoolTable : InventoryItem
    {
        int tableLength;
        bool pocketsPresent;
        string feltColor;

        public PoolTable(string mfrName, string srlNmbr, string mdlName, double whlslPrice, int tblLength, bool pcktsPresent, string fltColor)
            : base(mfrName, srlNmbr, mdlName, whlslPrice)
        {
            this.tableLength = tblLength;
            this.pocketsPresent = pcktsPresent;
            this.feltColor = fltColor;
        }
        public string[] PoolTableRecordArray()
        {
            string[] returnArray = new string[7];
            returnArray[0] = ManufacturerName;
            returnArray[1] = SerialNumber;
            returnArray[2] = ModelName;
            returnArray[3] = RetailPrice().ToString("C2");
            returnArray[4] = TableLength.ToString();
            returnArray[5] = PocketsPresent.ToString();
            returnArray[6] = FeltColor;
            return returnArray;
        }


        public int TableLength
        {
            get
            {
                return tableLength;
            }
        }
        public bool PocketsPresent
        {
            get
            {
                return pocketsPresent;
            }
        }
        public string FeltColor
        {
            get
            {
                return feltColor;
            }
        }
    }
}
