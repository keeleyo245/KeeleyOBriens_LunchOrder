namespace LunchOrder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbxMainCourse = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox2 = new GroupBox();
            txtOrderTotal = new TextBox();
            label3 = new Label();
            txtSalesTax = new TextBox();
            label2 = new Label();
            txtSubtotal = new TextBox();
            label1 = new Label();
            btnPlaceOrder = new Button();
            btnExit = new Button();
            groupBox1 = new GroupBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            gbxMainCourse.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gbxMainCourse
            // 
            gbxMainCourse.Controls.Add(radioButton3);
            gbxMainCourse.Controls.Add(radioButton1);
            gbxMainCourse.Controls.Add(radioButton2);
            gbxMainCourse.Location = new Point(39, 22);
            gbxMainCourse.Margin = new Padding(2);
            gbxMainCourse.Name = "gbxMainCourse";
            gbxMainCourse.Padding = new Padding(2);
            gbxMainCourse.Size = new Size(182, 130);
            gbxMainCourse.TabIndex = 0;
            gbxMainCourse.TabStop = false;
            gbxMainCourse.Text = "Main Course";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(5, 85);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(116, 24);
            radioButton3.TabIndex = 6;
            radioButton3.Text = "Salad - $4.95";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(5, 25);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(155, 24);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Hamburger - $6.95";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(5, 55);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(113, 24);
            radioButton2.TabIndex = 5;
            radioButton2.Text = "Pizza - $5.95";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtOrderTotal);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtSalesTax);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtSubtotal);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(39, 178);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(297, 154);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Order Total";
            // 
            // txtOrderTotal
            // 
            txtOrderTotal.Location = new Point(128, 102);
            txtOrderTotal.Margin = new Padding(2);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.ReadOnly = true;
            txtOrderTotal.Size = new Size(121, 27);
            txtOrderTotal.TabIndex = 5;
            txtOrderTotal.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 106);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 4;
            label3.Text = "Order Total:";
            // 
            // txtSalesTax
            // 
            txtSalesTax.Location = new Point(128, 66);
            txtSalesTax.Margin = new Padding(2);
            txtSalesTax.Name = "txtSalesTax";
            txtSalesTax.ReadOnly = true;
            txtSalesTax.Size = new Size(121, 27);
            txtSalesTax.TabIndex = 3;
            txtSalesTax.TabStop = false;
            txtSalesTax.TextChanged += txtSalesTax_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 70);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 2;
            label2.Text = "Tax (7.75%):";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(128, 30);
            txtSubtotal.Margin = new Padding(2);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new Size(121, 27);
            txtSubtotal.TabIndex = 1;
            txtSubtotal.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 34);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Subtotal:";
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(366, 190);
            btnPlaceOrder.Margin = new Padding(2);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(89, 34);
            btnPlaceOrder.TabIndex = 2;
            btnPlaceOrder.Text = "Place &Order";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(366, 296);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(89, 34);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(263, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(220, 125);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add-on Items ($.75/each)";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 86);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(101, 24);
            checkBox3.TabIndex = 5;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 56);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(101, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 26);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AcceptButton = btnPlaceOrder;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(495, 366);
            Controls.Add(groupBox1);
            Controls.Add(btnExit);
            Controls.Add(btnPlaceOrder);
            Controls.Add(groupBox2);
            Controls.Add(gbxMainCourse);
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Keeley OBrien's Lunch Order Application";
            gbxMainCourse.ResumeLayout(false);
            gbxMainCourse.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox gbxMainCourse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalesTax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnExit;
        private RadioButton radioButton3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}
