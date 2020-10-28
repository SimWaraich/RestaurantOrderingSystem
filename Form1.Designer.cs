namespace SWVerB
{
    partial class Form1
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
            this.labelOrderName = new System.Windows.Forms.Label();
            this.textBoxOrderName = new System.Windows.Forms.TextBox();
            this.buttonCreateCurrentOrder = new System.Windows.Forms.Button();
            this.listBoxFoodOrders = new System.Windows.Forms.ListBox();
            this.buttonAddCurrOrderToList = new System.Windows.Forms.Button();
            this.buttonAddVeg = new System.Windows.Forms.Button();
            this.buttonAddMeat = new System.Windows.Forms.Button();
            this.buttonRemoveMeat = new System.Windows.Forms.Button();
            this.buttonRemoveVeg = new System.Windows.Forms.Button();
            this.buttonWriteFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelOrderName
            // 
            this.labelOrderName.AutoSize = true;
            this.labelOrderName.Location = new System.Drawing.Point(317, 9);
            this.labelOrderName.Name = "labelOrderName";
            this.labelOrderName.Size = new System.Drawing.Size(70, 13);
            this.labelOrderName.TabIndex = 0;
            this.labelOrderName.Text = "Order Name: ";
            // 
            // textBoxOrderName
            // 
            this.textBoxOrderName.Location = new System.Drawing.Point(394, 9);
            this.textBoxOrderName.Name = "textBoxOrderName";
            this.textBoxOrderName.Size = new System.Drawing.Size(100, 20);
            this.textBoxOrderName.TabIndex = 1;
            // 
            // buttonCreateCurrentOrder
            // 
            this.buttonCreateCurrentOrder.Location = new System.Drawing.Point(320, 40);
            this.buttonCreateCurrentOrder.Name = "buttonCreateCurrentOrder";
            this.buttonCreateCurrentOrder.Size = new System.Drawing.Size(174, 23);
            this.buttonCreateCurrentOrder.TabIndex = 2;
            this.buttonCreateCurrentOrder.Text = "Create Current Order";
            this.buttonCreateCurrentOrder.UseVisualStyleBackColor = true;
            this.buttonCreateCurrentOrder.Click += new System.EventHandler(this.ButtonCreateCurrentOrder_Click);
            // 
            // listBoxFoodOrders
            // 
            this.listBoxFoodOrders.FormattingEnabled = true;
            this.listBoxFoodOrders.Location = new System.Drawing.Point(54, 94);
            this.listBoxFoodOrders.Name = "listBoxFoodOrders";
            this.listBoxFoodOrders.Size = new System.Drawing.Size(333, 134);
            this.listBoxFoodOrders.TabIndex = 3;
            // 
            // buttonAddCurrOrderToList
            // 
            this.buttonAddCurrOrderToList.Location = new System.Drawing.Point(91, 244);
            this.buttonAddCurrOrderToList.Name = "buttonAddCurrOrderToList";
            this.buttonAddCurrOrderToList.Size = new System.Drawing.Size(208, 23);
            this.buttonAddCurrOrderToList.TabIndex = 4;
            this.buttonAddCurrOrderToList.Text = "Add Current Order To List";
            this.buttonAddCurrOrderToList.UseVisualStyleBackColor = true;
            this.buttonAddCurrOrderToList.Click += new System.EventHandler(this.ButtonAddCurrOrderToList_Click);
            // 
            // buttonAddVeg
            // 
            this.buttonAddVeg.Location = new System.Drawing.Point(418, 94);
            this.buttonAddVeg.Name = "buttonAddVeg";
            this.buttonAddVeg.Size = new System.Drawing.Size(351, 23);
            this.buttonAddVeg.TabIndex = 5;
            this.buttonAddVeg.Text = "Add One Vegetarian Order To Current Order";
            this.buttonAddVeg.UseVisualStyleBackColor = true;
            this.buttonAddVeg.Click += new System.EventHandler(this.ButtonAddVeg_Click);
            // 
            // buttonAddMeat
            // 
            this.buttonAddMeat.Location = new System.Drawing.Point(418, 123);
            this.buttonAddMeat.Name = "buttonAddMeat";
            this.buttonAddMeat.Size = new System.Drawing.Size(351, 23);
            this.buttonAddMeat.TabIndex = 6;
            this.buttonAddMeat.Text = "Add One Meat Order To Current Order";
            this.buttonAddMeat.UseVisualStyleBackColor = true;
            this.buttonAddMeat.Click += new System.EventHandler(this.ButtonAddMeat_Click);
            // 
            // buttonRemoveMeat
            // 
            this.buttonRemoveMeat.Location = new System.Drawing.Point(418, 234);
            this.buttonRemoveMeat.Name = "buttonRemoveMeat";
            this.buttonRemoveMeat.Size = new System.Drawing.Size(351, 23);
            this.buttonRemoveMeat.TabIndex = 8;
            this.buttonRemoveMeat.Text = "Remove One Meat Order From Current Order";
            this.buttonRemoveMeat.UseVisualStyleBackColor = true;
            this.buttonRemoveMeat.Click += new System.EventHandler(this.ButtonRemoveMeat_Click);
            // 
            // buttonRemoveVeg
            // 
            this.buttonRemoveVeg.Location = new System.Drawing.Point(418, 205);
            this.buttonRemoveVeg.Name = "buttonRemoveVeg";
            this.buttonRemoveVeg.Size = new System.Drawing.Size(351, 23);
            this.buttonRemoveVeg.TabIndex = 7;
            this.buttonRemoveVeg.Text = "Remove One Vegetarian Order From Current Order";
            this.buttonRemoveVeg.UseVisualStyleBackColor = true;
            this.buttonRemoveVeg.Click += new System.EventHandler(this.ButtonRemoveVeg_Click);
            // 
            // buttonWriteFile
            // 
            this.buttonWriteFile.Location = new System.Drawing.Point(320, 287);
            this.buttonWriteFile.Name = "buttonWriteFile";
            this.buttonWriteFile.Size = new System.Drawing.Size(174, 23);
            this.buttonWriteFile.TabIndex = 9;
            this.buttonWriteFile.Text = "Save All Orders to Output File";
            this.buttonWriteFile.UseVisualStyleBackColor = true;
            this.buttonWriteFile.Click += new System.EventHandler(this.ButtonWriteFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 348);
            this.Controls.Add(this.buttonWriteFile);
            this.Controls.Add(this.buttonRemoveMeat);
            this.Controls.Add(this.buttonRemoveVeg);
            this.Controls.Add(this.buttonAddMeat);
            this.Controls.Add(this.buttonAddVeg);
            this.Controls.Add(this.buttonAddCurrOrderToList);
            this.Controls.Add(this.listBoxFoodOrders);
            this.Controls.Add(this.buttonCreateCurrentOrder);
            this.Controls.Add(this.textBoxOrderName);
            this.Controls.Add(this.labelOrderName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOrderName;
        private System.Windows.Forms.TextBox textBoxOrderName;
        private System.Windows.Forms.Button buttonCreateCurrentOrder;
        private System.Windows.Forms.ListBox listBoxFoodOrders;
        private System.Windows.Forms.Button buttonAddCurrOrderToList;
        private System.Windows.Forms.Button buttonAddVeg;
        private System.Windows.Forms.Button buttonAddMeat;
        private System.Windows.Forms.Button buttonRemoveMeat;
        private System.Windows.Forms.Button buttonRemoveVeg;
        private System.Windows.Forms.Button buttonWriteFile;
    }
}

