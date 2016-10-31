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
            ((System.ComponentModel.ISupportInitialize)(this.GridCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // GridCustomers
            // 
            this.GridCustomers.AllowUserToAddRows = false;
            this.GridCustomers.AllowUserToDeleteRows = false;
            this.GridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCustomers.Location = new System.Drawing.Point(13, 13);
            this.GridCustomers.MultiSelect = false;
            this.GridCustomers.Name = "GridCustomers";
            this.GridCustomers.ReadOnly = true;
            this.GridCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridCustomers.Size = new System.Drawing.Size(473, 150);
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
            this.BtnLoad.Location = new System.Drawing.Point(13, 191);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(124, 32);
            this.BtnLoad.TabIndex = 2;
            this.BtnLoad.Text = "Load Data";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Clear Orders";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(316, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Fill Orders";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 529);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.GridProducts);
            this.Controls.Add(this.GridCustomers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GridCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridCustomers;
        private System.Windows.Forms.DataGridView GridProducts;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

