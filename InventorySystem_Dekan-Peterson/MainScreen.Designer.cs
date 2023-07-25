namespace InventorySystem_Dekan_Peterson
{
    partial class MainScreen
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
            this.InventoryManagementSystem = new System.Windows.Forms.Label();
            this.mainPartSearchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mainProductSearchButton = new System.Windows.Forms.Button();
            this.mainPartAddButton = new System.Windows.Forms.Button();
            this.mainPartModifyButton = new System.Windows.Forms.Button();
            this.mainPartDeleteButton = new System.Windows.Forms.Button();
            this.mainProductDeleteButton = new System.Windows.Forms.Button();
            this.mainProductModifyButton = new System.Windows.Forms.Button();
            this.mainProductAddButton = new System.Windows.Forms.Button();
            this.mainDataGridParts = new System.Windows.Forms.DataGridView();
            this.mainDataGridProducts = new System.Windows.Forms.DataGridView();
            this.mainPartSearchTextBox = new System.Windows.Forms.TextBox();
            this.mainProductSearchTextBox = new System.Windows.Forms.TextBox();
            this.mainExitbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // InventoryManagementSystem
            // 
            this.InventoryManagementSystem.AutoSize = true;
            this.InventoryManagementSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryManagementSystem.Location = new System.Drawing.Point(12, 9);
            this.InventoryManagementSystem.Name = "InventoryManagementSystem";
            this.InventoryManagementSystem.Size = new System.Drawing.Size(283, 25);
            this.InventoryManagementSystem.TabIndex = 0;
            this.InventoryManagementSystem.Text = "Inventory Management System";
            // 
            // mainPartSearchButton
            // 
            this.mainPartSearchButton.Location = new System.Drawing.Point(291, 70);
            this.mainPartSearchButton.Name = "mainPartSearchButton";
            this.mainPartSearchButton.Size = new System.Drawing.Size(75, 23);
            this.mainPartSearchButton.TabIndex = 3;
            this.mainPartSearchButton.Text = "Search";
            this.mainPartSearchButton.UseVisualStyleBackColor = true;
            this.mainPartSearchButton.Click += new System.EventHandler(this.mainPartsSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Parts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(712, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Products";
            // 
            // mainProductSearchButton
            // 
            this.mainProductSearchButton.Location = new System.Drawing.Point(996, 70);
            this.mainProductSearchButton.Name = "mainProductSearchButton";
            this.mainProductSearchButton.Size = new System.Drawing.Size(75, 23);
            this.mainProductSearchButton.TabIndex = 6;
            this.mainProductSearchButton.Text = "Search";
            this.mainProductSearchButton.UseVisualStyleBackColor = true;
            this.mainProductSearchButton.Click += new System.EventHandler(this.mainProductSearch_Click);
            // 
            // mainPartAddButton
            // 
            this.mainPartAddButton.Location = new System.Drawing.Point(377, 401);
            this.mainPartAddButton.Name = "mainPartAddButton";
            this.mainPartAddButton.Size = new System.Drawing.Size(75, 23);
            this.mainPartAddButton.TabIndex = 7;
            this.mainPartAddButton.Text = "Add";
            this.mainPartAddButton.UseVisualStyleBackColor = true;
            this.mainPartAddButton.Click += new System.EventHandler(this.mainPartsAdd_Click);
            // 
            // mainPartModifyButton
            // 
            this.mainPartModifyButton.Location = new System.Drawing.Point(472, 401);
            this.mainPartModifyButton.Name = "mainPartModifyButton";
            this.mainPartModifyButton.Size = new System.Drawing.Size(75, 23);
            this.mainPartModifyButton.TabIndex = 8;
            this.mainPartModifyButton.Text = "Modify";
            this.mainPartModifyButton.UseVisualStyleBackColor = true;
            this.mainPartModifyButton.Click += new System.EventHandler(this.mainPartsModify_Click);
            // 
            // mainPartDeleteButton
            // 
            this.mainPartDeleteButton.Location = new System.Drawing.Point(566, 401);
            this.mainPartDeleteButton.Name = "mainPartDeleteButton";
            this.mainPartDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.mainPartDeleteButton.TabIndex = 9;
            this.mainPartDeleteButton.Text = "Delete";
            this.mainPartDeleteButton.UseVisualStyleBackColor = true;
            this.mainPartDeleteButton.Click += new System.EventHandler(this.mainPartsDelete_Click);
            // 
            // mainProductDeleteButton
            // 
            this.mainProductDeleteButton.Location = new System.Drawing.Point(1266, 401);
            this.mainProductDeleteButton.Name = "mainProductDeleteButton";
            this.mainProductDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.mainProductDeleteButton.TabIndex = 10;
            this.mainProductDeleteButton.Text = "Delete";
            this.mainProductDeleteButton.UseVisualStyleBackColor = true;
            this.mainProductDeleteButton.Click += new System.EventHandler(this.mainProductDeleteButton_Click);
            // 
            // mainProductModifyButton
            // 
            this.mainProductModifyButton.Location = new System.Drawing.Point(1176, 401);
            this.mainProductModifyButton.Name = "mainProductModifyButton";
            this.mainProductModifyButton.Size = new System.Drawing.Size(75, 23);
            this.mainProductModifyButton.TabIndex = 11;
            this.mainProductModifyButton.Text = "Modify";
            this.mainProductModifyButton.UseVisualStyleBackColor = true;
            this.mainProductModifyButton.Click += new System.EventHandler(this.mainProductModifyButton_Click);
            // 
            // mainProductAddButton
            // 
            this.mainProductAddButton.Location = new System.Drawing.Point(1079, 401);
            this.mainProductAddButton.Name = "mainProductAddButton";
            this.mainProductAddButton.Size = new System.Drawing.Size(75, 23);
            this.mainProductAddButton.TabIndex = 12;
            this.mainProductAddButton.Text = "Add";
            this.mainProductAddButton.UseVisualStyleBackColor = true;
            this.mainProductAddButton.Click += new System.EventHandler(this.mainProductAddButton_Click);
            // 
            // mainDataGridParts
            // 
            this.mainDataGridParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainDataGridParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGridParts.Location = new System.Drawing.Point(17, 110);
            this.mainDataGridParts.Name = "mainDataGridParts";
            this.mainDataGridParts.RowHeadersVisible = false;
            this.mainDataGridParts.RowHeadersWidth = 51;
            this.mainDataGridParts.RowTemplate.Height = 24;
            this.mainDataGridParts.Size = new System.Drawing.Size(624, 285);
            this.mainDataGridParts.TabIndex = 13;
            // 
            // mainDataGridProducts
            // 
            this.mainDataGridProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainDataGridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGridProducts.Location = new System.Drawing.Point(717, 110);
            this.mainDataGridProducts.Name = "mainDataGridProducts";
            this.mainDataGridProducts.RowHeadersVisible = false;
            this.mainDataGridProducts.RowHeadersWidth = 51;
            this.mainDataGridProducts.RowTemplate.Height = 24;
            this.mainDataGridProducts.Size = new System.Drawing.Size(624, 285);
            this.mainDataGridProducts.TabIndex = 14;
            // 
            // mainPartSearchTextBox
            // 
            this.mainPartSearchTextBox.Location = new System.Drawing.Point(377, 71);
            this.mainPartSearchTextBox.Name = "mainPartSearchTextBox";
            this.mainPartSearchTextBox.Size = new System.Drawing.Size(264, 22);
            this.mainPartSearchTextBox.TabIndex = 15;
            // 
            // mainProductSearchTextBox
            // 
            this.mainProductSearchTextBox.Location = new System.Drawing.Point(1077, 70);
            this.mainProductSearchTextBox.Name = "mainProductSearchTextBox";
            this.mainProductSearchTextBox.Size = new System.Drawing.Size(264, 22);
            this.mainProductSearchTextBox.TabIndex = 16;
            // 
            // mainExitbutton
            // 
            this.mainExitbutton.Location = new System.Drawing.Point(1266, 484);
            this.mainExitbutton.Name = "mainExitbutton";
            this.mainExitbutton.Size = new System.Drawing.Size(75, 23);
            this.mainExitbutton.TabIndex = 17;
            this.mainExitbutton.Text = "Exit";
            this.mainExitbutton.UseVisualStyleBackColor = true;
            this.mainExitbutton.Click += new System.EventHandler(this.mainExitbutton_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 519);
            this.Controls.Add(this.mainExitbutton);
            this.Controls.Add(this.mainProductSearchTextBox);
            this.Controls.Add(this.mainPartSearchTextBox);
            this.Controls.Add(this.mainDataGridProducts);
            this.Controls.Add(this.mainDataGridParts);
            this.Controls.Add(this.mainProductAddButton);
            this.Controls.Add(this.mainProductModifyButton);
            this.Controls.Add(this.mainProductDeleteButton);
            this.Controls.Add(this.mainPartDeleteButton);
            this.Controls.Add(this.mainPartModifyButton);
            this.Controls.Add(this.mainPartAddButton);
            this.Controls.Add(this.mainProductSearchButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainPartSearchButton);
            this.Controls.Add(this.InventoryManagementSystem);
            this.Name = "MainScreen";
            this.Text = "Inventory Management System";
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InventoryManagementSystem;
        private System.Windows.Forms.Button mainPartSearchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button mainProductSearchButton;
        private System.Windows.Forms.Button mainPartAddButton;
        private System.Windows.Forms.Button mainPartModifyButton;
        private System.Windows.Forms.Button mainPartDeleteButton;
        private System.Windows.Forms.Button mainProductDeleteButton;
        private System.Windows.Forms.Button mainProductModifyButton;
        private System.Windows.Forms.Button mainProductAddButton;
        private System.Windows.Forms.DataGridView mainDataGridParts;
        private System.Windows.Forms.DataGridView mainDataGridProducts;
        private System.Windows.Forms.TextBox mainPartSearchTextBox;
        private System.Windows.Forms.TextBox mainProductSearchTextBox;
        private System.Windows.Forms.Button mainExitbutton;
    }
}

