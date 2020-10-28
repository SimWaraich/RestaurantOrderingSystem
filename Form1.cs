using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SWVerB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<FoodOrder> OrderList = new List<FoodOrder>();
        FoodOrder currOrder = new FoodOrder();
        public void LoadToCurrentOrderListBox()
        {
            listBoxFoodOrders.Items.Clear();
            listBoxFoodOrders.Items.Add("Order Name: " + currOrder.OrderName);
            listBoxFoodOrders.Items.Add("Number of Vegetarian Orders: " + currOrder.VegOrders);
            listBoxFoodOrders.Items.Add("Number of Meat Orders: " + currOrder.MeatOrders);
            listBoxFoodOrders.Items.Add("Total Price: $" + currOrder.TotalPrice.ToString("F2"));
        }

        private void ButtonCreateCurrentOrder_Click(object sender, EventArgs e)
        {
            if(textBoxOrderName.Text=="")
            {
                MessageBox.Show("Order name should not be empty.");
            }
            else
            {
                currOrder.OrderName = textBoxOrderName.Text;
                currOrder.VegOrders = 0;
                currOrder.MeatOrders = 0;
                //OrderList.Add(currOrder);
                LoadToCurrentOrderListBox();
            }
        }

        private void ButtonAddVeg_Click(object sender, EventArgs e)
        {
            if (textBoxOrderName.Text == "")
            {
                MessageBox.Show("Order name should not be empty.");
            }
            else
            {
                currOrder.VegOrders++;
                LoadToCurrentOrderListBox();
            }

        }

        private void ButtonAddMeat_Click(object sender, EventArgs e)
        {
            if (textBoxOrderName.Text == "")
            {
                MessageBox.Show("Order name should not be empty.");
            }
            else
            {
                currOrder.MeatOrders++;
                LoadToCurrentOrderListBox();
            }

        }

        private void ButtonRemoveVeg_Click(object sender, EventArgs e)
        {
            if(currOrder.VegOrders>0)
            {
                currOrder.VegOrders--;
                LoadToCurrentOrderListBox();
            }
            else
            {
                MessageBox.Show("Veg Orders are currently 0");
            }

        }

        private void ButtonRemoveMeat_Click(object sender, EventArgs e)
        {
            if (currOrder.MeatOrders > 0)
            {
                currOrder.MeatOrders--;
                LoadToCurrentOrderListBox();
            }
            else
            {
                MessageBox.Show("Meat Orders are currently 0");
            }
        }

        private void ButtonAddCurrOrderToList_Click(object sender, EventArgs e)
        {
            if (currOrder.TotalPrice == 0)
            {
                MessageBox.Show("Cannot add order, total price is 0");
            }
            else
            {
                OrderList.Add(currOrder);
                textBoxOrderName.Clear();
                listBoxFoodOrders.Items.Clear();
                currOrder = new FoodOrder();
            }
        }

        private void ButtonWriteFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter myOutputFile = new StreamWriter("foodorders.txt"))
                {
                    foreach (FoodOrder foodOrderObj in OrderList)
                    {
                        myOutputFile.WriteLine(foodOrderObj.ToString());
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }           
        }
    }
}
