namespace BestellApp
{
    partial class TableSelect
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.butOrder = new System.Windows.Forms.Button();
            this.butBill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstProducts
            // 
            this.lstProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstProducts.ItemHeight = 38;
            this.lstProducts.Items.AddRange(new object[] {
            "T1",
            "T2",
            "T3",
            "T4",
            "T5"});
            this.lstProducts.Location = new System.Drawing.Point(3, 3);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(253, 384);
            this.lstProducts.TabIndex = 1;
            // 
            // butOrder
            // 
            this.butOrder.BackColor = System.Drawing.Color.Green;
            this.butOrder.Enabled = false;
            this.butOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butOrder.ForeColor = System.Drawing.Color.White;
            this.butOrder.Location = new System.Drawing.Point(262, 3);
            this.butOrder.Name = "butOrder";
            this.butOrder.Size = new System.Drawing.Size(135, 216);
            this.butOrder.TabIndex = 3;
            this.butOrder.Text = "Order";
            this.butOrder.UseVisualStyleBackColor = false;
            // 
            // butBill
            // 
            this.butBill.BackColor = System.Drawing.Color.Red;
            this.butBill.Enabled = false;
            this.butBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBill.ForeColor = System.Drawing.Color.White;
            this.butBill.Location = new System.Drawing.Point(262, 225);
            this.butBill.Name = "butBill";
            this.butBill.Size = new System.Drawing.Size(135, 172);
            this.butBill.TabIndex = 4;
            this.butBill.Text = "Bill";
            this.butBill.UseVisualStyleBackColor = false;
            // 
            // TableSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.butBill);
            this.Controls.Add(this.butOrder);
            this.Controls.Add(this.lstProducts);
            this.Name = "TableSelect";
            this.Size = new System.Drawing.Size(400, 400);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Button butOrder;
        private System.Windows.Forms.Button butBill;
    }
}
