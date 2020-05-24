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
                    row[0] = " ";
                    dataSet.Tables[0].Rows.Add(row);
                }
                else
                {
                    DataRow row = dataSet.Tables[0].NewRow();
                    string[] sFields = sLine.Split(',');
                    row[0] = sFields[0];
                    row[1] = sFields[1];
                    row[2] = sFields[2];
                    dataSet.Tables[0].Rows.Add(row);

                }
            }

            return dataSet;





        }


        public void db2Load() { }
    }


}





