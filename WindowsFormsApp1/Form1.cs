using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tradeDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tradeDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.tradeDataSet.Product);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            idTextBox.Clear();
            productArticleNumberTextBox.Clear();
            productNameTextBox.Clear();
            productDescriptionTextBox.Clear();
            productCategoryTextBox.Clear();
            productPhotoTextBox.Clear();
            productManufacturerTextBox.Clear();
            productCostTextBox.Clear();
            productDescriptionTextBox.Clear();
            productQuantityInStockTextBox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            productBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            productBindingSource.RemoveCurrent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tradeDataSet);
        }
    }
}
