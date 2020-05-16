using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Globalization;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;
using Item_dbEditer2020.beans;

namespace Item_dbEditer2020.util
{
    public class csvStream
    {
        string dbPath;
        public csvStream(String dbPath)
        {
            this.dbPath = dbPath; 
        }

        public void doing()
        {
            List<Item_dbBeans> item_db = null;
            
            //ファイルを指定
            using (var reader = new StreamReader(dbPath, Encoding.GetEncoding("SHIFT_JIS")))
            using (var csv = new CsvHelper.CsvReader(reader, new CultureInfo("ja-JP", false)))
            {
                //CSVHelperプロパティの指定
                csv.Configuration.HasHeaderRecord = false;  //ヘッダー無し
                csv.Configuration.Delimiter = ",";          //区切り文字
                csv.Configuration.IgnoreBlankLines = true;  //空白行を無視
                item_db = csv.GetRecords<Item_dbBeans>().ToList();
            }

            foreach (var item_dbBeans in item_db)
            {
                //ID,Name,Jname,Type,Price,Sell,Weight,ATK,DEF,Range,Slot,Job,Gender,Loc,wLV,eLV,View,Refine,{UseScript},{EquipScript},{UnEquipScript}
                Console.WriteLine($"ID:{item_dbBeans.ID}  Name:{item_dbBeans.Name} JName:{item_dbBeans.JName}");
            }
        }

















}


    /// <summary>
    /// データ格納用クラス
    /// </summary>
    
    // 【実行結果】
    // Name:鈴木  Address:東京都
    // Name:佐藤  Address:千葉県
}
