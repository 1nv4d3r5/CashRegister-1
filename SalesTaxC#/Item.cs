/*
 * Created By: Zach Dyck 
 * Purpose: Defines the object "Item" which
 *      is used my the RegisterForm to calculate
 *      the tax and cost of items purchased
 * Date Created: 8/2/2013
 * Last Edit: 8/4/2013
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesTaxCSharp
{
    /// <summary>
    /// The object Item is used to define products to
    /// be purchased
    /// </summary>
    public class Item
    {
        // This region contains the properties for Item
        #region Properties

        private int itemId;
        private string itemName;
        private string itemDescription; 
        private double itemCost;
        private int taxCategory;

        #endregion

        // This region contains the default getters and setters for Item
        #region Getters and Setters

        public int ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        public string ItemDescription
        {
            get { return itemDescription; }
            set { itemDescription = value; }
        }

        public double ItemCost
        {
            get { return itemCost; }
            set { itemCost = value; }
        }

        public int TaxCategory
        {
            get { return taxCategory; }
            set { taxCategory = value; }
        }

        #endregion

        // This region contains the constructors for Item
        #region Constructors

        // Default constructor
        public Item()
        {
            this.itemId = 0;
            this.itemName = "";
            this.itemDescription = "";
            this.itemCost = 0;
            this.taxCategory = 0;
        }

        // Constructor that accepts parameters for to define the Item
        public Item(int itemId, string itemName, string itemDescription, double itemCost, int taxCategory)
        {
            this.itemId = itemId;
            this.itemName = itemName;
            this.itemDescription = itemDescription;
            this.itemCost = itemCost;
            this.taxCategory = taxCategory;
        }

        #endregion
    }
}
