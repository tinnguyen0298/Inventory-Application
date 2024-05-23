using System;
using System.IO;
using static System.Console;

namespace ProjectClassTemplate
{
    class Program
    {
        static int hottubIndex = 0;
        static int pooltableIndex = 0;
        static void Main(string[] args)
        {
            PoolTable[] PoolTableInventory = new PoolTable[100];
            HotTub[] HotTubInventory = new HotTub[100];
            
            string text = System.IO.File.ReadAllText(@"C:\Users\tinng\OneDrive\Desktop\College\Fall 2021\CSC160175\GroupProject\InventoryDataFile1.csv");
            string[] inventoryFile = text.Split('\n');
            

            foreach (string inventoryRecord in inventoryFile)
            {


                string[] recordFields = inventoryRecord.Split(",");
                
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
            printTheThings(HotTubInventory);
            printTheThings(PoolTableInventory);

            printSerialNumber(HotTubInventory);
            DeleteTheRecord(HotTubInventory, "AM103");
            DeleteTheRecord(HotTubInventory, "LI250");   
            printTheThings(HotTubInventory);

            addRecord(HotTubInventory, "exName", "exSerialNumber", "exModelName", 19.99, 9999, true, 20000);
            printTheThings(HotTubInventory);

            Console.ReadKey();

        }
        static void printTheThings(HotTub[] HotTubInventory)
        {
            for (int i = 0; i < hottubIndex; i++)
            {
                if (HotTubInventory[i] != null)
                {
                    WriteLine("i=" + i + " - " + HotTubInventory[i].PeopleCapacity + " " + HotTubInventory[i].LightKit + " " + HotTubInventory[i].NumberOfJets);
                }
                else
                {
                    WriteLine("null index " + i);
                }
            }
            WriteLine("-----------------------------");
        }
        static void printTheThings(PoolTable[] PoolTableInventory) 
        {
            for (int i = 0; i < pooltableIndex; i++)
            {
                if (PoolTableInventory[i] != null)
                {
                    WriteLine("i=" + i + " - " + PoolTableInventory[i].TableLength + " " + PoolTableInventory[i].PocketsPresent + " " + PoolTableInventory[i].FeltColor);
                }
                else
                {
                    WriteLine("null index " + i);
                }
            }
            WriteLine("-----------------------------");
        }
        static void DeleteTheRecord(HotTub[] HotTubInventory, string Serial)
        {
            int foundIndex = -1;
            for (int i = 0; i < HotTubInventory.Length; i++)
            {
                if (HotTubInventory[i].SerialNumber == Serial)
                {
                    WriteLine(i + " is index for " + HotTubInventory[i].SerialNumber);
                    foundIndex = i;
                    break;
                }
               
            }
            HotTubInventory[foundIndex] = null;
            for (int i = foundIndex; i < HotTubInventory.Length - 1; i++)
            {
                //WriteLine(i + " second loop " + HotTubInventory[i]);
                if (HotTubInventory[i + 1] != null)
                {
                    HotTubInventory[i] = HotTubInventory[i + 1];
                }
                else
                {
                    HotTubInventory[i] = null;
                    hottubIndex = i;
                    break;
                }
            }
        }
        static void printSerialNumber(HotTub[] HotTubInventory) //to see current serial numbers which are available to remove 
        {
            WriteLine("Serial Numbers for HotTub");
            for (int i = 0; i < hottubIndex; i++)
            {
                if (HotTubInventory[i].SerialNumber != null)
                {
                    WriteLine(HotTubInventory[i].SerialNumber);
                }

            }
            WriteLine("-----------------------------");
        }
        static HotTub[] addRecord(HotTub[] HotTubInventory, string mfrNAME, string srlNMBR, string mdlNAME, double whlslPRICE, int pplCAPACITY, bool lghtKIT, int nmbrOfJET)
        {
            HotTubInventory[hottubIndex++] = new HotTub(mfrNAME, srlNMBR, mdlNAME, whlslPRICE, pplCAPACITY, lghtKIT, nmbrOfJET);
            return HotTubInventory;
        }
    }
}
