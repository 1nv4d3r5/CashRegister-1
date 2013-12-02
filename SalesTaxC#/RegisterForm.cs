/*
 * Created By: Zach Dyck 
 * Purpose: Gives an interface for 
 *      users to calculate tax and
 *      final cost of items purchased
 * Date Created: 8/2/2013
 * Last Edit: 8/4/2013
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SalesTaxCSharp
{
    public partial class registerForm : Form
    {
        // Lists that contain all the items (itemList) and the items being
        // purchased (purchaseList)
        List<Item> itemList = new List<Item>();
        List<Item> purchaseList = new List<Item>();

        public registerForm()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Contains what is run upon form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void registerForm_Load(object sender, EventArgs e)
        {
            // Loads items to a list and populates the listBox with the values
            loadItems();
            lstBoxItems.DataSource = itemList;
            lstBoxItems.DisplayMember = "itemName";

        }

        /// <summary>
        /// On the selected index change of the item listBox the details textbox
        /// will show the item details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDetails.Text = "Item: " + ((Item)lstBoxItems.SelectedItem).ItemName + "\n" +
                "Cost: " + ((Item)lstBoxItems.SelectedItem).ItemCost.ToString("C") + "\n" +
                "Description: " + ((Item)lstBoxItems.SelectedItem).ItemDescription;
        }

        /// <summary>
        /// The "Add" button will add the selected item from the Item ListBox
        /// and add it to the Purchase ListBox 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            purchaseList.Add((Item)lstBoxItems.SelectedItem);
            lstBoxPurchase.Items.Add((Item)lstBoxItems.SelectedItem);
            lstBoxPurchase.DisplayMember = "itemName";
            lstBoxPurchase.SelectedIndex = 0;
        }

        /// <summary>
        /// Checks to make sure the Purchase ListBox is not empty
        /// and if it is not empty it will removed the selected
        /// item from the Purchase Listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstBoxPurchase.SelectedIndex != -1)
            {
                purchaseList.Remove((Item)lstBoxPurchase.SelectedItem);
                lstBoxPurchase.Items.Remove((Item)lstBoxPurchase.SelectedItem);
                if (lstBoxPurchase.Items.Count > 0)
                {
                    lstBoxPurchase.SelectedIndex = 0;
                }

            }
            else
            {
                // Error message shown if there is no item to remove
                MessageBox.Show("There is no item to remove!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        /// <summary>
        /// Calculates the item costs, total tax, and
        /// total cost of the items in the Purchase 
        /// ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Variables to store the values needed for the calculation
            double tax;
            double totalTax = 0;
            double itemPrice;
            double totalPrice = 0;
            string output = "";

            // Goes through the Purchase List and displays and calculates
            // the cost and tax of each item
            for (int i = 0; i < purchaseList.Count; i++)
            {
                tax = calculateTax(purchaseList[i]);
                itemPrice = calculateItemTotal(purchaseList[i].ItemCost, tax);
                totalTax += tax;
                totalPrice += itemPrice;
                output += "1 " + purchaseList[i].ItemName + ": " + itemPrice.ToString("C") + "\n";
            }

            // Displays the total tax and total cost of the purchase
            output += "Sales Tax: " + totalTax.ToString("C") + "\n";
            output += "Total: " + totalPrice.ToString("C") + "\n";

            txtPurchaseDetails.Text = output;


            //tax = calculateTax((Item)lstBoxPurchase.SelectedItem);
            //itemPrice = calculateItemTotal(((Item)lstBoxPurchase.SelectedItem).ItemCost, tax);
            //txtPurchaseDetails.Text = itemPrice.ToString();
        }

        /// <summary>
        /// Clears the Purchase List and Purchase ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            purchaseList.Clear();
            lstBoxPurchase.Items.Clear();
            txtPurchaseDetails.Text = "";

            // Confirmation message shown to the user that the Purchase List was cleared
            MessageBox.Show("The register has been cleared!", "Cleared", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// Creates items of the object Item with values and adds them to
        /// a list called itemList
        /// </summary>
        private void loadItems()
        {
            // Creating the items
            Item book = new Item(1, "Book", "Standard paper book", 12.49, 1);
            Item musicCD = new Item(2, "Music CD", "Compact Disc to play music", 14.99, 2);
            Item chocolateBar = new Item(3, "Chocolate Bar", "Chocolate Candy", .85, 1);
            Item frenchChocolate = new Item(4, "French Chocolate", "Chocolate imported from France", 10.00, 3);
            Item germanChocolate = new Item(5, "German Chocolate", "Chocolate imported from Germany", 11.25, 3);
            Item perfume = new Item(6, "Perfume", "Domestic perfume", 18.99, 2);
            Item frenchPerfume = new Item(7, "French Perfume", "Perfume imported from France", 47.5, 4);
            Item indianPerfume = new Item(8, "Indian Perfume", "Perfume imported from India", 27.99, 4);
            Item headachePills = new Item(9, "Headache Pills", "Pill medication for headaches", 9.75, 1);

            // Adding items to the list
            itemList.Add(book);
            itemList.Add(musicCD);
            itemList.Add(chocolateBar);
            itemList.Add(frenchChocolate);
            itemList.Add(germanChocolate);
            itemList.Add(perfume);
            itemList.Add(frenchPerfume);
            itemList.Add(indianPerfume);
            itemList.Add(headachePills);

        }

        /// <summary>
        /// Calculates the tax of the parameter of type Item
        /// The calculation is based on the Item cost and 
        /// tax type
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private double calculateTax(Item item)
        {
            double result = 0;

            switch (item.TaxCategory)
            {
                case 1:
                    result = 0;
                    break;
                case 2:
                    result = Math.Ceiling(item.ItemCost * .1 * 20) / 20;
                    break;
                case 3:
                    result = Math.Ceiling(item.ItemCost * .05 * 20) / 20;
                    break;
                case 4:
                    result = Math.Ceiling(item.ItemCost * .15 * 20) / 20;
                    break;
            }
            return result;
        }

        /// <summary>
        /// Calculates the total cost of an item based on the 
        /// parameters cost and tax.
        /// </summary>
        /// <param name="cost"></param>
        /// <param name="tax"></param>
        /// <returns></returns>
        private double calculateItemTotal(double cost, double tax)
        {
            double result = 0;
            result = cost + tax;
            return result;

        }
      
    }
}
