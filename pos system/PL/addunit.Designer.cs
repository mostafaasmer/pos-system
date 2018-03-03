namespace pos_system.PL
{
    partial class addunit
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
            this.unitno = new System.Windows.Forms.TextBox();
            this.unit_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.smallerRB = new System.Windows.Forms.RadioButton();
            this.largerRB = new System.Windows.Forms.RadioButton();
            this.mainunit_no = new System.Windows.Forms.TextBox();
            this.sell_price_for_each = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.unit_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.main_unit_smaller = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // unitno
            // 
            this.unitno.Location = new System.Drawing.Point(23, 157);
            this.unitno.Name = "unitno";
            this.unitno.Size = new System.Drawing.Size(100, 20);
            this.unitno.TabIndex = 0;
            // 
            // unit_label
            // 
            this.unit_label.AutoSize = true;
            this.unit_label.Location = new System.Drawing.Point(162, 9);
            this.unit_label.Name = "unit_label";
            this.unit_label.Size = new System.Drawing.Size(62, 13);
            this.unit_label.TabIndex = 1;
            this.unit_label.Text = "وحده الصنف";
            this.unit_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "وحده الصنف";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "هل هذه الوحده اكبر منالوحده الرئيسيه؟";
            // 
            // smallerRB
            // 
            this.smallerRB.AutoSize = true;
            this.smallerRB.Location = new System.Drawing.Point(114, 99);
            this.smallerRB.Name = "smallerRB";
            this.smallerRB.Size = new System.Drawing.Size(51, 17);
            this.smallerRB.TabIndex = 4;
            this.smallerRB.TabStop = true;
            this.smallerRB.Text = "اصغر ";
            this.smallerRB.UseVisualStyleBackColor = true;
            this.smallerRB.CheckedChanged += new System.EventHandler(this.smallerRB_CheckedChanged);
            // 
            // largerRB
            // 
            this.largerRB.AutoSize = true;
            this.largerRB.Location = new System.Drawing.Point(23, 99);
            this.largerRB.Name = "largerRB";
            this.largerRB.Size = new System.Drawing.Size(44, 17);
            this.largerRB.TabIndex = 5;
            this.largerRB.TabStop = true;
            this.largerRB.Text = "اكبر";
            this.largerRB.UseVisualStyleBackColor = true;
            this.largerRB.CheckedChanged += new System.EventHandler(this.largerRB_CheckedChanged);
            // 
            // mainunit_no
            // 
            this.mainunit_no.Location = new System.Drawing.Point(165, 157);
            this.mainunit_no.Name = "mainunit_no";
            this.mainunit_no.Size = new System.Drawing.Size(100, 20);
            this.mainunit_no.TabIndex = 6;
            // 
            // sell_price_for_each
            // 
            this.sell_price_for_each.Location = new System.Drawing.Point(23, 222);
            this.sell_price_for_each.Name = "sell_price_for_each";
            this.sell_price_for_each.Size = new System.Drawing.Size(100, 20);
            this.sell_price_for_each.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "كميه الوحده";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "من اصل كم م الوحده الرئيسيه";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "سعر بيع الوحده";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "اضف";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "تراجع";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // unit_name
            // 
            this.unit_name.Location = new System.Drawing.Point(99, 43);
            this.unit_name.Name = "unit_name";
            this.unit_name.Size = new System.Drawing.Size(100, 20);
            this.unit_name.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "وحده الصنف ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "unit_label";
            // 
            // main_unit_smaller
            // 
            this.main_unit_smaller.Location = new System.Drawing.Point(99, 157);
            this.main_unit_smaller.Name = "main_unit_smaller";
            this.main_unit_smaller.Size = new System.Drawing.Size(100, 20);
            this.main_unit_smaller.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "كم تحتوى الوحده الجديده من الوحده الرئيسيه؟";
            // 
            // addunit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 297);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.main_unit_smaller);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unit_name);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sell_price_for_each);
            this.Controls.Add(this.mainunit_no);
            this.Controls.Add(this.largerRB);
            this.Controls.Add(this.smallerRB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.unit_label);
            this.Controls.Add(this.unitno);
            this.Name = "addunit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "addunit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox unitno;
        private System.Windows.Forms.Label unit_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton smallerRB;
        private System.Windows.Forms.RadioButton largerRB;
        private System.Windows.Forms.TextBox mainunit_no;
        private System.Windows.Forms.TextBox sell_price_for_each;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox unit_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox main_unit_smaller;
        private System.Windows.Forms.Label label8;
    }
}