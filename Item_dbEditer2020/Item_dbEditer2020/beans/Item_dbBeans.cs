using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;

namespace Item_dbEditer2020.beans
{
    public class Item_dbBeans
    {
        //ID,Name,Jname,Type,Price,Sell,Weight,ATK,DEF,Range,Slot,Job,Gender,Loc,wLV,eLV,View,Refine,{UseScript},{EquipScript},{UnEquipScript}
        [Index(0)] public string ID { get; set; }
        [Index(1)] public string Name { get; set; }
        [Index(2)] public string JName { get; set; }
        [Index(3)] public string Type { get; set; }
        [Index(4)] public string Price { get; set; }
        [Index(5)] public string Sell { get; set; }
        [Index(6)] public string Weight { get; set; }
        [Index(7)] public string ATK { get; set; }
        [Index(8)] public string DEF { get; set; }
        [Index(9)] public string Range { get; set; }
        [Index(10)] public string Slot { get; set; }
        [Index(11)] public string Job { get; set; }
        [Index(12)] public string Gender { get; set; }
        [Index(13)] public string Loc { get; set; }
        [Index(14)] public string wLV { get; set; }
        [Index(15)] public string eLV { get; set; }
        [Index(16)] public string View { get; set; }
        [Index(17)] public string Refine { get; set; }
        [Index(18)] public string UseScript { get; set; }
        [Index(19)] public string EquipScript { get; set; }
        [Index(20)] public string UnEquipScript { get; set; }
    }
}
