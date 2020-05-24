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
namespace Item_dbEditer2020
{
    public partial class Form1 : Form
    {
        CsvStream csvs;
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
            csvs = new CsvStream(item_dbPath);
            csvs.dbLoad(item_DataSet);
            




          
        }
    }
}
