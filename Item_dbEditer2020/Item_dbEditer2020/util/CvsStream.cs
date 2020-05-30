using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Globalization;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;
using CsvHelper;
using System.Data;
using System.Text.RegularExpressions;
using static Item_dbEditer2020.util.Constant;

namespace Item_dbEditer2020.util
{
    public class CsvStream
    {
        string dbPath;
        public CsvStream(String dbPath)
        {
            this.dbPath = dbPath;
        }



        public void csvLoad()
        {
            //dbLoad();
            //db2Load();
        }

        public void csvSave()
        {

        }


        public DataSet dbLoad(DataSet dataSet)
        {

            StreamReader sr = new StreamReader(dbPath, System.Text.Encoding.GetEncoding("shift_jis"));

            while (!sr.EndOfStream)
            {

                string sLine = sr.ReadLine();
                if (sLine.StartsWith("//"))
                {
                    DataRow row =  dataSet.Tables[0].NewRow();
                    row[0] = sLine;
                    dataSet.Tables[0].Rows.Add(row);
                    
                }

                else if (string.IsNullOrEmpty(sLine))
                {
                    DataRow row = dataSet.Tables[0].NewRow();
                    dataSet.Tables[0].Rows.Add(row);

                }
                else
                {
                    
                    
                    
                    DataRow row = dataSet.Tables[0].NewRow();
                    var m = Regex.Match(sLine, "^([^,]*,[^,]*,[^,]*,[^,]*,[^,]*[^,]*,[^,]*,[^,]*,[^,]*,[^,]*,[^,]*,[^,]*,[^,]*,[^,]*,[^,]*,[^,]*,[^,]*,[^,]*,[^,]*),(.*)$");


                    
                    string[] sFields = m.Groups[1].Value.Split(',');
                    
                    row[0] = sFields[0];//ID
                    
                    row[1] = sFields[1];//Name
                    row[2] = sFields[2];//Jname
                    
                    row[3] = sFields[3];//Type
                    row[4] = sFields[4];//Price
                    row[5] = sFields[5];//Sell
                    row[6] = sFields[6];//Weight
                    row[7] = sFields[7];//ATK
                    row[8] = sFields[8];//DEF
                    row[9] = sFields[9];//Range
                    row[10] = sFields[10];//Slot
                    row[11] = sFields[11];//Job
                    row[12] = sFields[12];//Gender
                    row[13] = sFields[13];//Loc
                    row[14] = sFields[14];//wLV
                    row[15] = sFields[15];//eLV
                    row[16] = sFields[16];//View
                    row[17] = sFields[17];//Refine
                    
                    //row[18] = sFields[18];//UseScript
                    //row[19] = sFields[19];//EquipScript}
                    //row[20] = sFields[20];//UnEquipScript
                   
                    

                    dataSet.Tables[0].Rows.Add(row);
                    

    

                }
            }

            return dataSet;





        }


        public void db2Load() { }
    }


}





