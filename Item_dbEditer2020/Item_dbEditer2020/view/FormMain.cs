using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Item_dbEditer2020.util;
using Item_dbEditer2020.beans;
using Item_dbEditer2020.db;
namespace Item_dbEditer2020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            



        }

        private void testToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var fileName = openFileDialog1.ShowDialog();
            string item_dbPath = openFileDialog1.FileName;
            Item_db db = new CsvStream(item_dbPath).doTest();


            for (int i=0;i<db.item_db.Count();i++)
            {
                if(db.item_db[i].comment != null)
                {
                    
                    ListViewItem item = new ListViewItem(db.item_db[i].comment);
                    listView1.Items.Add(item);
                }
                else
                {
                    
                    ListViewItem item = new ListViewItem(db.item_db[i].ID);
                    item.SubItems.Add(db.item_db[i].Name);
                    item.SubItems.Add(db.item_db[i].JName);
                    listView1.Items.Add(item);
                }

            }


          
        }
    }
}
