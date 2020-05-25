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
using static Item_dbEditer2020.util.Constant;
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

            //Comboboxの生成
            foreach(string type in LIST_TYPE) comboBoxType.Items.Add(type);
            foreach (string filter in LIST_FILTER) comboBoxFilter.Items.Add(filter);
            foreach (string sex in LIST_SEX) comboBoxSex.Items.Add(sex);






        }

        private void testToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var fileName = openFileDialog1.ShowDialog();
            string item_dbPath = openFileDialog1.FileName;
            csvs = new CsvStream(item_dbPath);
            csvs.dbLoad(item_DataSet);
            




          
        }

        
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //選択列番号取得
            int index = dataGridView1.CurrentCell.RowIndex;

            try
            {
                //IDに数字が入っていれば実行
                int i;
                if (int.TryParse(item_DataSet.Tables[0].Rows[index].ItemArray[0].ToString(), out i))
                { 
                    textBoxId.Text = item_DataSet.Tables[0].Rows[index].ItemArray[0].ToString();
                    textBoxName.Text = item_DataSet.Tables[0].Rows[index].ItemArray[1].ToString();
                    textBoxJname.Text = item_DataSet.Tables[0].Rows[index].ItemArray[2].ToString();
                    comboBoxType.SelectedIndex = int.Parse(item_DataSet.Tables[0].Rows[index].ItemArray[3].ToString());

                }
                else
                {
                    textBoxId.Text = item_DataSet.Tables[0].Rows[index].ItemArray[0].ToString();
                }
            }
            catch (FormatException exception)
            
            {
                MessageBox.Show(exception.StackTrace);
                Console.WriteLine(exception.StackTrace);
            }
            



        }
    }
}
