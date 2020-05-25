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
            foreach (string sex in LIST_SEX) comboBoxGender.Items.Add(sex);






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
                DataRow row = item_DataSet.Tables[0].Rows[index];
                //IDに数字が入っていれば実行
                int i;
                if (int.TryParse(row.ItemArray[0].ToString(), out i))
                { 
                    textBoxId.Text = row.ItemArray[0].ToString();                           //0.ID
                    textBoxName.Text = row.ItemArray[1].ToString();                         //1.Name
                    textBoxJname.Text = row.ItemArray[2].ToString();                        //2.Jname
                    comboBoxType.SelectedIndex = int.Parse(row.ItemArray[3].ToString());    //3.Type
                    textBoxPrice.Text = row.ItemArray[4].ToString();                        //4.Price (defaultt0)
                    textBoxSell.Text = row.ItemArray[5].ToString();                         //5.Sell  (defaultt0)
                    textBoxWeight.Text = row.ItemArray[6].ToString();                       //6.Weight
                    //7.ATK
                    //8.DEF
                    //9.Range
                    //10.Slot
                    textBoxJob.Text = row.ItemArray[11].ToString();                         //11.Job
                    comboBoxGender.SelectedIndex = int.Parse(row.ItemArray[12].ToString()); //12.Gender
                    //13.Loc
                    //14.wLV
                    textBoxELv.Text = row.ItemArray[15].ToString();                         //15.eLV
                    //16.View
                    //17.Refine
                    //18.UseScript
                    //19.EquipScript
                    //20.UnEquipScript



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
