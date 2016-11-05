namespace MicroOrm
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnFillOrders = new System.Windows.Forms.Button();
            this.btnClearOrders = new System.Windows.Forms.Button();
            this.richText = new System.Windows.Forms.RichTextBox();
            this.btnGetOrders = new System.Windows.Forms.Button();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Dapper";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(13, 37);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(82, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Simple.Data";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btnFillOrders
            // 
            this.btnFillOrders.Location = new System.Drawing.Point(13, 115);
            this.btnFillOrders.Name = "btnFillOrders";
            this.btnFillOrders.Size = new System.Drawing.Size(75, 23);
            this.btnFillOrders.TabIndex = 2;
            this.btnFillOrders.Text = "Fill Orders";
            this.btnFillOrders.UseVisualStyleBackColor = true;
            this.btnFillOrders.Click += new System.EventHandler(this.btnFillOrders_Click);
            // 
            // btnClearOrders
            // 
            this.btnClearOrders.Location = new System.Drawing.Point(13, 145);
            this.btnClearOrders.Name = "btnClearOrders";
            this.btnClearOrders.Size = new System.Drawing.Size(75, 23);
            this.btnClearOrders.TabIndex = 3;
            this.btnClearOrders.Text = "Clear Orders";
            this.btnClearOrders.UseVisualStyleBackColor = true;
            this.btnClearOrders.Click += new System.EventHandler(this.btnClearOrders_Click);
            // 
            // richText
            // 
            this.richText.Location = new System.Drawing.Point(101, 13);
            this.richText.Name = "richText";
            this.richText.Size = new System.Drawing.Size(820, 335);
            this.richText.TabIndex = 4;
            this.richText.Text = "";
            // 
            // btnGetOrders
            // 
            this.btnGetOrders.Location = new System.Drawing.Point(13, 175);
            this.btnGetOrders.Name = "btnGetOrders";
            this.btnGetOrders.Size = new System.Drawing.Size(75, 23);
            this.btnGetOrders.TabIndex = 5;
            this.btnGetOrders.Text = "Get Orders";
            this.btnGetOrders.UseVisualStyleBackColor = true;
            this.btnGetOrders.Click += new System.EventHandler(this.btnGetOrders_Click);
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Location = new System.Drawing.Point(13, 205);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateOrder.TabIndex = 6;
            this.btnUpdateOrder.Text = "Update Order";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 360);
            this.Controls.Add(this.btnUpdateOrder);
            this.Controls.Add(this.btnGetOrders);
            this.Controls.Add(this.richText);
            this.Controls.Add(this.btnClearOrders);
            this.Controls.Add(this.btnFillOrders);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button btnFillOrders;
        private System.Windows.Forms.Button btnClearOrders;
        private System.Windows.Forms.RichTextBox richText;
        private System.Windows.Forms.Button btnGetOrders;
        private System.Windows.Forms.Button btnUpdateOrder;
    }
}

