using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Globalization;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;
using Item_dbEditer2020.beans;
using Item_dbEditer2020.db;
using CsvHelper;

namespace Item_dbEditer2020.util
{
    public class CsvStream
    {
        string dbPath;
        public CsvStream(String dbPath)
        {
            this.dbPath = dbPath;
        }

        public Item_db doTest()
        {
           return dbLoad();
            
        }

  
        public void csvLoad()
        {
            dbLoad();
            //db2Load();
        }

        public void csvSave()
        {

        }


        public Item_db dbLoad() {
            Item_db item_db = new Item_db();
            

            //読み込むCSVファイルを開く
            StreamReader sr = new StreamReader(dbPath,System.Text.Encoding.GetEncoding("shift_jis"));

            //CSVから1行分の文字を読み取り、文字列として返す
           
           
            while (!sr.EndOfStream)
            {
                
                Item_dbBeans item_dbBeans = new Item_dbBeans();
                string sLine = sr.ReadLine();
                if (sLine.StartsWith("//"))
                {
           
                    item_dbBeans.comment = sLine;
                    item_db.item_db.Add(item_dbBeans);
                }

                else if (string.IsNullOrEmpty(sLine))
                {
                    
                    item_dbBeans.comment = "改行";
                    item_db.item_db.Add(item_dbBeans);
                }
                else
                {
                    
                    string[] sFields = sLine.Split(',');
                    item_dbBeans.ID = sFields[0];
                    item_dbBeans.Name = sFields[1];
                    item_dbBeans.JName = sFields[2];
                    item_db.item_db.Add(item_dbBeans);


                }
                




                /*
        static IEnumerable<string> Split(string source)
        {
            //ソースがnullならcatch
            if (source == null) throw new ArgumentNullException(nameof(source));

            //フラグを立てる
            int flag = 0;

            //リストを作る
            var list = new List<char>();
            
            foreach (var c in source.Append(','))
            {
                if (flag == 0 && c == ',')
                {
                    yield return string.Concat(list);
                    list.Clear();
                }
                else
                {
                    list.Add(c);
                }

                
                flag += c switch
                {
                    '{' => 1,
                    '}' => -1,
                    _ => 0
                };
                
            }
        }
    */


            }


            /*
            using (var reader = new StreamReader(dbPath, System.Text.Encoding.GetEncoding("shift_jis")))
            using (var csv = new CsvHelper.CsvReader(reader, new CultureInfo("ja-JP", false)))
            {
                csv.Configuration.HasHeaderRecord = false;
                csv.Configuration.Delimiter = ",";
                csv.Configuration.IgnoreBlankLines = true;
                csv.Configuration.MissingFieldFound = null;
                Console.WriteLine(csv.GetRecords<Item_dbBeans>().ToList()[0].ID);



            }
            */



            //CSVHelperでindex17行まで読み込む

            //フラグ管理して読み込む
            /*
             * boolean flag;
            String[] text1Array = str.split("");
            for (int i = 0; text1Array < i i++)
            {
                //ここでフラグ管理
            }
            */
            //18行目
            //19行目
            //20行目(無い場合あり)

            return item_db;





        }


        public void db2Load() { }
    }


}





