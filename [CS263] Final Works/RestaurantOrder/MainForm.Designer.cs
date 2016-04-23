namespace RestaurantOrder
{
    partial class MainForm
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
            this.tableComboBox = new System.Windows.Forms.ComboBox();
            this.mealComboBox = new System.Windows.Forms.ComboBox();
            this.tableLabel = new System.Windows.Forms.Label();
            this.mealLabel = new System.Windows.Forms.Label();
            this.mealCountLabel = new System.Windows.Forms.Label();
            this.mealCountTextBox = new System.Windows.Forms.TextBox();
            this.orderButton = new System.Windows.Forms.Button();
            this.resultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tableComboBox
            // 
            this.tableComboBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableComboBox.FormattingEnabled = true;
            this.tableComboBox.Items.AddRange(new object[] {
            "Table 1",
            "Table 2",
            "Table 3"});
            this.tableComboBox.Location = new System.Drawing.Point(30, 62);
            this.tableComboBox.Name = "tableComboBox";
            this.tableComboBox.Size = new System.Drawing.Size(179, 26);
            this.tableComboBox.TabIndex = 0;
            // 
            // mealComboBox
            // 
            this.mealComboBox.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mealComboBox.FormattingEnabled = true;
            this.mealComboBox.Items.AddRange(new object[] {
            "套餐 A",
            "套餐 B",
            "套餐 C"});
            this.mealComboBox.Location = new System.Drawing.Point(259, 60);
            this.mealComboBox.Name = "mealComboBox";
            this.mealComboBox.Size = new System.Drawing.Size(179, 28);
            this.mealComboBox.TabIndex = 1;
            // 
            // tableLabel
            // 
            this.tableLabel.AutoSize = true;
            this.tableLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLabel.Location = new System.Drawing.Point(27, 25);
            this.tableLabel.Name = "tableLabel";
            this.tableLabel.Size = new System.Drawing.Size(92, 18);
            this.tableLabel.TabIndex = 2;
            this.tableLabel.Text = "Table No.";
            // 
            // mealLabel
            // 
            this.mealLabel.AutoSize = true;
            this.mealLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealLabel.Location = new System.Drawing.Point(256, 25);
            this.mealLabel.Name = "mealLabel";
            this.mealLabel.Size = new System.Drawing.Size(42, 18);
            this.mealLabel.TabIndex = 3;
            this.mealLabel.Text = "套餐";
            // 
            // mealCountLabel
            // 
            this.mealCountLabel.AutoSize = true;
            this.mealCountLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealCountLabel.Location = new System.Drawing.Point(500, 25);
            this.mealCountLabel.Name = "mealCountLabel";
            this.mealCountLabel.Size = new System.Drawing.Size(76, 18);
            this.mealCountLabel.TabIndex = 4;
            this.mealCountLabel.Text = "套餐數量";
            // 
            // mealCountTextBox
            // 
            this.mealCountTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealCountTextBox.Location = new System.Drawing.Point(503, 61);
            this.mealCountTextBox.Name = "mealCountTextBox";
            this.mealCountTextBox.Size = new System.Drawing.Size(100, 27);
            this.mealCountTextBox.TabIndex = 5;
            // 
            // orderButton
            // 
            this.orderButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderButton.Location = new System.Drawing.Point(394, 111);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(209, 46);
            this.orderButton.TabIndex = 6;
            this.orderButton.Text = "Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // resultRichTextBox
            // 
            this.resultRichTextBox.Location = new System.Drawing.Point(30, 176);
            this.resultRichTextBox.Name = "resultRichTextBox";
            this.resultRichTextBox.Size = new System.Drawing.Size(573, 306);
            this.resultRichTextBox.TabIndex = 8;
            this.resultRichTextBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 494);
            this.Controls.Add(this.resultRichTextBox);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.mealCountTextBox);
            this.Controls.Add(this.mealCountLabel);
            this.Controls.Add(this.mealLabel);
            this.Controls.Add(this.tableLabel);
            this.Controls.Add(this.mealComboBox);
            this.Controls.Add(this.tableComboBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tableComboBox;
        private System.Windows.Forms.ComboBox mealComboBox;
        private System.Windows.Forms.Label tableLabel;
        private System.Windows.Forms.Label mealLabel;
        private System.Windows.Forms.Label mealCountLabel;
        private System.Windows.Forms.TextBox mealCountTextBox;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.RichTextBox resultRichTextBox;
    }
}