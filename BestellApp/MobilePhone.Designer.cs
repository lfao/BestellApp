namespace BestellApp
{
    partial class MobilePhone
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
            this.butAdd = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAvail = new System.Windows.Forms.TextBox();
            this.txtOrdered = new System.Windows.Forms.MaskedTextBox();
            this.lblbestellt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstProducts
            // 
            this.lstProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstProducts.ItemHeight = 38;
            this.lstProducts.Items.AddRange(new object[] {
            "Leberkäse",
            "Senf",
            "Semmel"});
            this.lstProducts.Location = new System.Drawing.Point(3, 2);
            this.lstProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(253, 308);
            this.lstProducts.TabIndex = 0;
            this.lstProducts.SelectedIndexChanged += new System.EventHandler(this.lstProducts_SelectedIndexChanged);
            // 
            // butAdd
            // 
            this.butAdd.BackColor = System.Drawing.Color.Green;
            this.butAdd.Enabled = false;
            this.butAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAdd.ForeColor = System.Drawing.Color.White;
            this.butAdd.Location = new System.Drawing.Point(261, 2);
            this.butAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(135, 97);
            this.butAdd.TabIndex = 2;
            this.butAdd.Text = "+";
            this.butAdd.UseVisualStyleBackColor = false;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butDelete
            // 
            this.butDelete.BackColor = System.Drawing.Color.Red;
            this.butDelete.Enabled = false;
            this.butDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDelete.ForeColor = System.Drawing.Color.White;
            this.butDelete.Location = new System.Drawing.Point(262, 212);
            this.butDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(135, 108);
            this.butDelete.TabIndex = 3;
            this.butDelete.Text = "-";
            this.butDelete.UseVisualStyleBackColor = false;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Verf.:";
            // 
            // txtAvail
            // 
            this.txtAvail.Location = new System.Drawing.Point(327, 110);
            this.txtAvail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAvail.Name = "txtAvail";
            this.txtAvail.Size = new System.Drawing.Size(63, 22);
            this.txtAvail.TabIndex = 5;
            // 
            // txtOrdered
            // 
            this.txtOrdered.Location = new System.Drawing.Point(327, 153);
            this.txtOrdered.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrdered.Name = "txtOrdered";
            this.txtOrdered.Size = new System.Drawing.Size(63, 22);
            this.txtOrdered.TabIndex = 6;
            // 
            // lblbestellt
            // 
            this.lblbestellt.AutoSize = true;
            this.lblbestellt.Location = new System.Drawing.Point(263, 155);
            this.lblbestellt.Name = "lblbestellt";
            this.lblbestellt.Size = new System.Drawing.Size(58, 17);
            this.lblbestellt.TabIndex = 7;
            this.lblbestellt.Text = "Bestellt:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(4, 334);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(396, 58);
            this.button1.TabIndex = 8;
            this.button1.Text = "Leave Table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MobilePhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblbestellt);
            this.Controls.Add(this.txtOrdered);
            this.Controls.Add(this.txtAvail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.lstProducts);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MobilePhone";
            this.Size = new System.Drawing.Size(400, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAvail;
        private System.Windows.Forms.MaskedTextBox txtOrdered;
        private System.Windows.Forms.Label lblbestellt;
        private System.Windows.Forms.Button button1;
    }
}
