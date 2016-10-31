namespace Orders
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
            this.GridCustomers = new System.Windows.Forms.DataGridView();
            this.GridProducts = new System.Windows.Forms.DataGridView();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.GridDsCustomers = new System.Windows.Forms.DataGridView();
            this.GridDsOrders = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.GridTransientProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridDsCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridDsOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTransientProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // GridCustomers
            // 
            this.GridCustomers.AllowUserToAddRows = false;
            this.GridCustomers.AllowUserToDeleteRows = false;
            this.GridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCustomers.Location = new System.Drawing.Point(171, 12);
            this.GridCustomers.MultiSelect = false;
            this.GridCustomers.Name = "GridCustomers";
            this.GridCustomers.ReadOnly = true;
            this.GridCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridCustomers.Size = new System.Drawing.Size(426, 150);
            this.GridCustomers.TabIndex = 0;
            // 
            // GridProducts
            // 
            this.GridProducts.AllowUserToAddRows = false;
            this.GridProducts.AllowUserToDeleteRows = false;
            this.GridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProducts.Location = new System.Drawing.Point(617, 13);
            this.GridProducts.MultiSelect = false;
            this.GridProducts.Name = "GridProducts";
            this.GridProducts.ReadOnly = true;
            this.GridProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridProducts.Size = new System.Drawing.Size(554, 150);
            this.GridProducts.TabIndex = 1;
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(41, 54);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(124, 32);
            this.BtnLoad.TabIndex = 2;
            this.BtnLoad.Text = "Load Data";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Clear Orders";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(41, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Fill Orders";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 263);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Load Data To DataSet";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // GridDsCustomers
            // 
            this.GridDsCustomers.AllowUserToAddRows = false;
            this.GridDsCustomers.AllowUserToDeleteRows = false;
            this.GridDsCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDsCustomers.Location = new System.Drawing.Point(171, 215);
            this.GridDsCustomers.MultiSelect = false;
            this.GridDsCustomers.Name = "GridDsCustomers";
            this.GridDsCustomers.ReadOnly = true;
            this.GridDsCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridDsCustomers.Size = new System.Drawing.Size(426, 161);
            this.GridDsCustomers.TabIndex = 6;
            // 
            // GridDsOrders
            // 
            this.GridDsOrders.AllowUserToAddRows = false;
            this.GridDsOrders.AllowUserToDeleteRows = false;
            this.GridDsOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDsOrders.Location = new System.Drawing.Point(617, 215);
            this.GridDsOrders.Name = "GridDsOrders";
            this.GridDsOrders.ReadOnly = true;
            this.GridDsOrders.Size = new System.Drawing.Size(554, 161);
            this.GridDsOrders.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 293);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Make some changes";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 323);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(153, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Insert Order to Current";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 353);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(153, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "Save changes";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 428);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(153, 23);
            this.button7.TabIndex = 11;
            this.button7.Text = "Run Transien Fault Demo";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(171, 421);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(426, 96);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // GridTransientProducts
            // 
            this.GridTransientProducts.AllowUserToAddRows = false;
            this.GridTransientProducts.AllowUserToDeleteRows = false;
            this.GridTransientProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTransientProducts.Location = new System.Drawing.Point(617, 421);
            this.GridTransientProducts.Name = "GridTransientProducts";
            this.GridTransientProducts.ReadOnly = true;
            this.GridTransientProducts.Size = new System.Drawing.Size(554, 96);
            this.GridTransientProducts.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 529);
            this.Controls.Add(this.GridTransientProducts);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.GridDsOrders);
            this.Controls.Add(this.GridDsCustomers);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.GridProducts);
            this.Controls.Add(this.GridCustomers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GridCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridDsCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridDsOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTransientProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridCustomers;
        private System.Windows.Forms.DataGridView GridProducts;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView GridDsCustomers;
        private System.Windows.Forms.DataGridView GridDsOrders;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView GridTransientProducts;
    }
}

