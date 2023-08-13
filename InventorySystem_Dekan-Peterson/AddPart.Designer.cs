namespace InventorySystem_Dekan_Peterson
{
    partial class AddPart
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
            this.outsourcedPartButton = new System.Windows.Forms.RadioButton();
            this.inHousePartButton = new System.Windows.Forms.RadioButton();
            this.addPartMachineIDTextBox = new System.Windows.Forms.TextBox();
            this.addPartNameTextBox = new System.Windows.Forms.TextBox();
            this.addPartInvTextBox = new System.Windows.Forms.TextBox();
            this.addPartPriceCostTextBox = new System.Windows.Forms.TextBox();
            this.addPartMaxTextBox = new System.Windows.Forms.TextBox();
            this.addPartMinTextBox = new System.Windows.Forms.TextBox();
            this.addPartIDTextBox = new System.Windows.Forms.TextBox();
            this.addPartCancelButton = new System.Windows.Forms.Button();
            this.addPartSaveButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.addPartMachComp = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outsourcedPartButton
            // 
            this.outsourcedPartButton.AutoSize = true;
            this.outsourcedPartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outsourcedPartButton.Location = new System.Drawing.Point(307, 9);
            this.outsourcedPartButton.Name = "outsourcedPartButton";
            this.outsourcedPartButton.Size = new System.Drawing.Size(117, 24);
            this.outsourcedPartButton.TabIndex = 2;
            this.outsourcedPartButton.Text = "Outsourced";
            this.outsourcedPartButton.UseVisualStyleBackColor = true;
            this.outsourcedPartButton.CheckedChanged += new System.EventHandler(this.addPartOutsourcedRadio_CheckChanged);
            // 
            // inHousePartButton
            // 
            this.inHousePartButton.AutoSize = true;
            this.inHousePartButton.Checked = true;
            this.inHousePartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inHousePartButton.Location = new System.Drawing.Point(183, 9);
            this.inHousePartButton.Name = "inHousePartButton";
            this.inHousePartButton.Size = new System.Drawing.Size(98, 24);
            this.inHousePartButton.TabIndex = 1;
            this.inHousePartButton.TabStop = true;
            this.inHousePartButton.Text = "In-House";
            this.inHousePartButton.UseVisualStyleBackColor = true;
            this.inHousePartButton.CheckedChanged += new System.EventHandler(this.addPartInHouseRadio_CheckChanged);
            // 
            // addPartMachineIDTextBox
            // 
            this.addPartMachineIDTextBox.Location = new System.Drawing.Point(228, 323);
            this.addPartMachineIDTextBox.Name = "addPartMachineIDTextBox";
            this.addPartMachineIDTextBox.Size = new System.Drawing.Size(166, 22);
            this.addPartMachineIDTextBox.TabIndex = 9;
            // 
            // addPartNameTextBox
            // 
            this.addPartNameTextBox.Location = new System.Drawing.Point(228, 117);
            this.addPartNameTextBox.Name = "addPartNameTextBox";
            this.addPartNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.addPartNameTextBox.TabIndex = 4;
            // 
            // addPartInvTextBox
            // 
            this.addPartInvTextBox.Location = new System.Drawing.Point(228, 168);
            this.addPartInvTextBox.Name = "addPartInvTextBox";
            this.addPartInvTextBox.Size = new System.Drawing.Size(100, 22);
            this.addPartInvTextBox.TabIndex = 5;
            // 
            // addPartPriceCostTextBox
            // 
            this.addPartPriceCostTextBox.Location = new System.Drawing.Point(228, 222);
            this.addPartPriceCostTextBox.Name = "addPartPriceCostTextBox";
            this.addPartPriceCostTextBox.Size = new System.Drawing.Size(100, 22);
            this.addPartPriceCostTextBox.TabIndex = 6;
            // 
            // addPartMaxTextBox
            // 
            this.addPartMaxTextBox.Location = new System.Drawing.Point(228, 273);
            this.addPartMaxTextBox.Name = "addPartMaxTextBox";
            this.addPartMaxTextBox.Size = new System.Drawing.Size(100, 22);
            this.addPartMaxTextBox.TabIndex = 7;
            // 
            // addPartMinTextBox
            // 
            this.addPartMinTextBox.Location = new System.Drawing.Point(411, 273);
            this.addPartMinTextBox.Name = "addPartMinTextBox";
            this.addPartMinTextBox.Size = new System.Drawing.Size(100, 22);
            this.addPartMinTextBox.TabIndex = 8;
            // 
            // addPartIDTextBox
            // 
            this.addPartIDTextBox.Location = new System.Drawing.Point(228, 67);
            this.addPartIDTextBox.Name = "addPartIDTextBox";
            this.addPartIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.addPartIDTextBox.TabIndex = 3;
            // 
            // addPartCancelButton
            // 
            this.addPartCancelButton.Location = new System.Drawing.Point(464, 386);
            this.addPartCancelButton.Name = "addPartCancelButton";
            this.addPartCancelButton.Size = new System.Drawing.Size(75, 23);
            this.addPartCancelButton.TabIndex = 11;
            this.addPartCancelButton.Text = "Cancel";
            this.addPartCancelButton.UseVisualStyleBackColor = true;
            this.addPartCancelButton.Click += new System.EventHandler(this.addPartCancel_Click);
            // 
            // addPartSaveButton
            // 
            this.addPartSaveButton.Location = new System.Drawing.Point(362, 386);
            this.addPartSaveButton.Name = "addPartSaveButton";
            this.addPartSaveButton.Size = new System.Drawing.Size(75, 23);
            this.addPartSaveButton.TabIndex = 10;
            this.addPartSaveButton.Text = "Save";
            this.addPartSaveButton.UseVisualStyleBackColor = true;
            this.addPartSaveButton.Click += new System.EventHandler(this.addPartSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(358, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Min";
            // 
            // addPartMachComp
            // 
            this.addPartMachComp.AutoSize = true;
            this.addPartMachComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartMachComp.Location = new System.Drawing.Point(80, 325);
            this.addPartMachComp.Name = "addPartMachComp";
            this.addPartMachComp.Size = new System.Drawing.Size(94, 20);
            this.addPartMachComp.TabIndex = 26;
            this.addPartMachComp.Text = "Machine ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(165, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(107, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Price / Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Inventory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 69);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Add Part";
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 447);
            this.Controls.Add(this.outsourcedPartButton);
            this.Controls.Add(this.inHousePartButton);
            this.Controls.Add(this.addPartMachineIDTextBox);
            this.Controls.Add(this.addPartNameTextBox);
            this.Controls.Add(this.addPartInvTextBox);
            this.Controls.Add(this.addPartPriceCostTextBox);
            this.Controls.Add(this.addPartMaxTextBox);
            this.Controls.Add(this.addPartMinTextBox);
            this.Controls.Add(this.addPartIDTextBox);
            this.Controls.Add(this.addPartCancelButton);
            this.Controls.Add(this.addPartSaveButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.addPartMachComp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPart";
            this.Text = "Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton outsourcedPartButton;
        private System.Windows.Forms.RadioButton inHousePartButton;
        private System.Windows.Forms.TextBox addPartMachineIDTextBox;
        private System.Windows.Forms.TextBox addPartNameTextBox;
        private System.Windows.Forms.TextBox addPartInvTextBox;
        private System.Windows.Forms.TextBox addPartPriceCostTextBox;
        private System.Windows.Forms.TextBox addPartMaxTextBox;
        private System.Windows.Forms.TextBox addPartMinTextBox;
        private System.Windows.Forms.TextBox addPartIDTextBox;
        private System.Windows.Forms.Button addPartCancelButton;
        private System.Windows.Forms.Button addPartSaveButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label addPartMachComp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}