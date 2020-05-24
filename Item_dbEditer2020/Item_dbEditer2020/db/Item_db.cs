using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Item_dbEditer2020.beans;

namespace Item_dbEditer2020.db
{
    public class Item_db
    {
        public Item_db(){

            this.item_db = new List<Item_dbBeans>();
        }


        public List<Item_dbBeans> item_db { get; set; }

    }
}
