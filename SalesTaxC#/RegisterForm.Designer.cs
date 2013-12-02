namespace SalesTaxCSharp
{
    partial class registerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstBoxItems = new System.Windows.Forms.ListBox();
            this.lstBoxPurchase = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtDetails = new System.Windows.Forms.RichTextBox();
            this.lblItemDetails = new System.Windows.Forms.Label();
            this.lblPurchase = new System.Windows.Forms.Label();
            this.txtPurchaseDetails = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstBoxItems
            // 
            this.lstBoxItems.FormattingEnabled = true;
            this.lstBoxItems.Location = new System.Drawing.Point(39, 28);
            this.lstBoxItems.Name = "lstBoxItems";
            this.lstBoxItems.Size = new System.Drawing.Size(179, 173);
            this.lstBoxItems.TabIndex = 0;
            this.lstBoxItems.SelectedIndexChanged += new System.EventHandler(this.lstBoxItems_SelectedIndexChanged);
            // 
            // lstBoxPurchase
            // 
            this.lstBoxPurchase.FormattingEnabled = true;
            this.lstBoxPurchase.Location = new System.Drawing.Point(350, 28);
            this.lstBoxPurchase.Name = "lstBoxPurchase";
            this.lstBoxPurchase.Size = new System.Drawing.Size(179, 173);
            this.lstBoxPurchase.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(243, 42);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(243, 81);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(243, 120);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calcuate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(39, 240);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(179, 103);
            this.txtDetails.TabIndex = 5;
            this.txtDetails.Text = "";
            // 
            // lblItemDetails
            // 
            this.lblItemDetails.AutoSize = true;
            this.lblItemDetails.Location = new System.Drawing.Point(93, 224);
            this.lblItemDetails.Name = "lblItemDetails";
            this.lblItemDetails.Size = new System.Drawing.Size(62, 13);
            this.lblItemDetails.TabIndex = 6;
            this.lblItemDetails.Text = "Item Details";
            // 
            // lblPurchase
            // 
            this.lblPurchase.AutoSize = true;
            this.lblPurchase.Location = new System.Drawing.Point(393, 224);
            this.lblPurchase.Name = "lblPurchase";
            this.lblPurchase.Size = new System.Drawing.Size(87, 13);
            this.lblPurchase.TabIndex = 8;
            this.lblPurchase.Text = "Purchase Details";
            // 
            // txtPurchaseDetails
            // 
            this.txtPurchaseDetails.Location = new System.Drawing.Point(350, 240);
            this.txtPurchaseDetails.Name = "txtPurchaseDetails";
            this.txtPurchaseDetails.Size = new System.Drawing.Size(179, 103);
            this.txtPurchaseDetails.TabIndex = 7;
            this.txtPurchaseDetails.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(243, 161);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Inventory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Items Selected";
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 355);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblPurchase);
            this.Controls.Add(this.txtPurchaseDetails);
            this.Controls.Add(this.lblItemDetails);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstBoxPurchase);
            this.Controls.Add(this.lstBoxItems);
            this.MaximumSize = new System.Drawing.Size(593, 393);
            this.MinimumSize = new System.Drawing.Size(593, 393);
            this.Name = "registerForm";
            this.Text = "Cash Register";
            this.Load += new System.EventHandler(this.registerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxItems;
        private System.Windows.Forms.ListBox lstBoxPurchase;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.RichTextBox txtDetails;
        private System.Windows.Forms.Label lblItemDetails;
        private System.Windows.Forms.Label lblPurchase;
        private System.Windows.Forms.RichTextBox txtPurchaseDetails;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

