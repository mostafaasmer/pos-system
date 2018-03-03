namespace pos_system.PL
{
    partial class Add_cat
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
            this.label1 = new System.Windows.Forms.Label();
            this.cate_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sell_price = new System.Windows.Forms.TextBox();
            this.discount = new System.Windows.Forms.TextBox();
            this.less_price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.classification = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cate_code = new System.Windows.Forms.TextBox();
            this.another_code = new System.Windows.Forms.TextBox();
            this.less_quantity = new System.Windows.Forms.TextBox();
            this.barcode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cat_image = new System.Windows.Forms.PictureBox();
            this.cate_warehouses = new System.Windows.Forms.DataGridView();
            this.cate_unite = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.save = new System.Windows.Forms.Button();
            this.save_new = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.add_image = new System.Windows.Forms.Button();
            this.unit = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.main_unit_smaller = new System.Windows.Forms.TextBox();
            this.unit_name = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.sell_price_for_each = new System.Windows.Forms.TextBox();
            this.mainunit_no = new System.Windows.Forms.TextBox();
            this.largerRB = new System.Windows.Forms.RadioButton();
            this.smallerRB = new System.Windows.Forms.RadioButton();
            this.label22 = new System.Windows.Forms.Label();
            this.unit_label = new System.Windows.Forms.Label();
            this.unitno = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cat_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cate_warehouses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cate_unite)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(804, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم الصنف";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cate_name
            // 
            this.cate_name.Location = new System.Drawing.Point(617, 39);
            this.cate_name.Name = "cate_name";
            this.cate_name.Size = new System.Drawing.Size(254, 20);
            this.cate_name.TabIndex = 1;
            this.cate_name.TextChanged += new System.EventHandler(this.cate_name_TextChanged);
            this.cate_name.Validated += new System.EventHandler(this.cate_name_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(808, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "سعر البيع";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(723, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "الخصم";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(631, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "اقل سعر";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // sell_price
            // 
            this.sell_price.Location = new System.Drawing.Point(795, 93);
            this.sell_price.Name = "sell_price";
            this.sell_price.Size = new System.Drawing.Size(76, 20);
            this.sell_price.TabIndex = 5;
            this.sell_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sell_price_KeyPress);
            // 
            // discount
            // 
            this.discount.Location = new System.Drawing.Point(703, 93);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(76, 20);
            this.discount.TabIndex = 6;
            this.discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.discount_KeyPress);
            // 
            // less_price
            // 
            this.less_price.Location = new System.Drawing.Point(617, 93);
            this.less_price.Name = "less_price";
            this.less_price.Size = new System.Drawing.Size(76, 20);
            this.less_price.TabIndex = 7;
            this.less_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.less_price_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(542, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "بيانات اضافيه";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(828, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "التصنيف";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // classification
            // 
            this.classification.Location = new System.Drawing.Point(629, 181);
            this.classification.Name = "classification";
            this.classification.Size = new System.Drawing.Size(242, 20);
            this.classification.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(601, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "كود الصنف";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(516, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "كود اخر للصنف";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(412, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "اقل كميه للصنف";
            // 
            // cate_code
            // 
            this.cate_code.Location = new System.Drawing.Point(588, 221);
            this.cate_code.Name = "cate_code";
            this.cate_code.Size = new System.Drawing.Size(76, 20);
            this.cate_code.TabIndex = 14;
            // 
            // another_code
            // 
            this.another_code.Location = new System.Drawing.Point(496, 221);
            this.another_code.Name = "another_code";
            this.another_code.Size = new System.Drawing.Size(76, 20);
            this.another_code.TabIndex = 15;
            // 
            // less_quantity
            // 
            this.less_quantity.Location = new System.Drawing.Point(410, 221);
            this.less_quantity.Name = "less_quantity";
            this.less_quantity.Size = new System.Drawing.Size(76, 20);
            this.less_quantity.TabIndex = 16;
            this.less_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.less_quantity_KeyPress);
            // 
            // barcode
            // 
            this.barcode.Location = new System.Drawing.Point(795, 220);
            this.barcode.Name = "barcode";
            this.barcode.Size = new System.Drawing.Size(76, 20);
            this.barcode.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(808, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "بار  كود";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(690, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "توليد";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(741, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(12, 188);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.description.Size = new System.Drawing.Size(193, 86);
            this.description.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "وصف الصنف";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "اختيارات اخرى";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(389, 261);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "وحدات الصنف";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(735, 384);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "الكميه الافتتاحيه فى المخازن";
            // 
            // cat_image
            // 
            this.cat_image.Location = new System.Drawing.Point(12, 12);
            this.cat_image.Name = "cat_image";
            this.cat_image.Size = new System.Drawing.Size(193, 101);
            this.cat_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cat_image.TabIndex = 26;
            this.cat_image.TabStop = false;
            this.cat_image.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cate_warehouses
            // 
            this.cate_warehouses.AllowUserToAddRows = false;
            this.cate_warehouses.AllowUserToDeleteRows = false;
            this.cate_warehouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cate_warehouses.Location = new System.Drawing.Point(631, 410);
            this.cate_warehouses.Name = "cate_warehouses";
            this.cate_warehouses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cate_warehouses.Size = new System.Drawing.Size(247, 125);
            this.cate_warehouses.TabIndex = 27;
            this.cate_warehouses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cate_warehouses_CellContentClick);
            // 
            // cate_unite
            // 
            this.cate_unite.AllowUserToAddRows = false;
            this.cate_unite.AllowUserToDeleteRows = false;
            this.cate_unite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cate_unite.Location = new System.Drawing.Point(332, 410);
            this.cate_unite.Name = "cate_unite";
            this.cate_unite.Size = new System.Drawing.Size(240, 126);
            this.cate_unite.TabIndex = 28;
            this.cate_unite.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(274, 458);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "اضافه";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(274, 487);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 23);
            this.button5.TabIndex = 31;
            this.button5.Text = "حذف";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox1.Location = new System.Drawing.Point(11, 351);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox1.Size = new System.Drawing.Size(130, 17);
            this.checkBox1.TabIndex = 32;
            this.checkBox1.Text = "اضافه للاصناف السريعه";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox2.Location = new System.Drawing.Point(36, 374);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox2.Size = new System.Drawing.Size(105, 17);
            this.checkBox2.TabIndex = 33;
            this.checkBox2.Text = "صنف غير مستخدم";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox3.Location = new System.Drawing.Point(44, 327);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox3.Size = new System.Drawing.Size(97, 17);
            this.checkBox3.TabIndex = 34;
            this.checkBox3.Text = "صنف بدون كميه";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(795, 552);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(48, 23);
            this.save.TabIndex = 36;
            this.save.Text = "حفظ";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.button6_Click);
            // 
            // save_new
            // 
            this.save_new.Location = new System.Drawing.Point(426, 552);
            this.save_new.Name = "save_new";
            this.save_new.Size = new System.Drawing.Size(90, 23);
            this.save_new.TabIndex = 35;
            this.save_new.Text = "حفظ | جديد";
            this.save_new.UseVisualStyleBackColor = true;
            this.save_new.Click += new System.EventHandler(this.save_new_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(112, 552);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(90, 23);
            this.back.TabIndex = 37;
            this.back.Text = "تراجع";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // add_image
            // 
            this.add_image.Location = new System.Drawing.Point(157, 133);
            this.add_image.Name = "add_image";
            this.add_image.Size = new System.Drawing.Size(48, 23);
            this.add_image.TabIndex = 38;
            this.add_image.Text = "اضافه";
            this.add_image.UseVisualStyleBackColor = true;
            this.add_image.Click += new System.EventHandler(this.add_image_Click);
            // 
            // unit
            // 
            this.unit.Location = new System.Drawing.Point(389, 297);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(100, 20);
            this.unit.TabIndex = 39;
            this.unit.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(501, 300);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "الوحده الرئيسيه للصنف";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(220, 366);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(217, 13);
            this.label16.TabIndex = 58;
            this.label16.Text = "كم تحتوى الوحده الجديده من الوحده الرئيسيه؟";
            // 
            // main_unit_smaller
            // 
            this.main_unit_smaller.Location = new System.Drawing.Point(253, 384);
            this.main_unit_smaller.Name = "main_unit_smaller";
            this.main_unit_smaller.Size = new System.Drawing.Size(100, 20);
            this.main_unit_smaller.TabIndex = 57;
            this.main_unit_smaller.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.main_unit_smaller_KeyPress);
            // 
            // unit_name
            // 
            this.unit_name.Location = new System.Drawing.Point(389, 323);
            this.unit_name.Name = "unit_name";
            this.unit_name.Size = new System.Drawing.Size(100, 20);
            this.unit_name.TabIndex = 54;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(265, 303);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(78, 13);
            this.label19.TabIndex = 51;
            this.label19.Text = "سعر بيع الوحده";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(426, 384);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(144, 13);
            this.label20.TabIndex = 50;
            this.label20.Text = "من اصل كم من الوحده الرئيسيه";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(389, 368);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 13);
            this.label21.TabIndex = 49;
            this.label21.Text = "كميه الوحده";
            // 
            // sell_price_for_each
            // 
            this.sell_price_for_each.Location = new System.Drawing.Point(256, 319);
            this.sell_price_for_each.Name = "sell_price_for_each";
            this.sell_price_for_each.Size = new System.Drawing.Size(100, 20);
            this.sell_price_for_each.TabIndex = 48;
            this.sell_price_for_each.TextChanged += new System.EventHandler(this.sell_price_for_each_TextChanged);
            this.sell_price_for_each.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sell_price_for_each_KeyPress);
            // 
            // mainunit_no
            // 
            this.mainunit_no.Location = new System.Drawing.Point(319, 384);
            this.mainunit_no.Name = "mainunit_no";
            this.mainunit_no.Size = new System.Drawing.Size(100, 20);
            this.mainunit_no.TabIndex = 47;
            this.mainunit_no.TextChanged += new System.EventHandler(this.mainunit_no_TextChanged);
            this.mainunit_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainunit_no_KeyPress);
            // 
            // largerRB
            // 
            this.largerRB.AutoSize = true;
            this.largerRB.Location = new System.Drawing.Point(351, 346);
            this.largerRB.Name = "largerRB";
            this.largerRB.Size = new System.Drawing.Size(44, 17);
            this.largerRB.TabIndex = 46;
            this.largerRB.TabStop = true;
            this.largerRB.Text = "اكبر";
            this.largerRB.UseVisualStyleBackColor = true;
            this.largerRB.CheckedChanged += new System.EventHandler(this.largerRB_CheckedChanged);
            // 
            // smallerRB
            // 
            this.smallerRB.AutoSize = true;
            this.smallerRB.Location = new System.Drawing.Point(274, 345);
            this.smallerRB.Name = "smallerRB";
            this.smallerRB.Size = new System.Drawing.Size(51, 17);
            this.smallerRB.TabIndex = 45;
            this.smallerRB.TabStop = true;
            this.smallerRB.Text = "اصغر ";
            this.smallerRB.UseVisualStyleBackColor = true;
            this.smallerRB.CheckedChanged += new System.EventHandler(this.smallerRB_CheckedChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(417, 349);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(187, 13);
            this.label22.TabIndex = 44;
            this.label22.Text = "هل هذه الوحده اكبر منالوحده الرئيسيه؟";
            // 
            // unit_label
            // 
            this.unit_label.AutoSize = true;
            this.unit_label.Location = new System.Drawing.Point(511, 327);
            this.unit_label.Name = "unit_label";
            this.unit_label.Size = new System.Drawing.Size(93, 13);
            this.unit_label.TabIndex = 42;
            this.unit_label.Text = "اسم الوحده الجديده";
            // 
            // unitno
            // 
            this.unitno.Location = new System.Drawing.Point(177, 384);
            this.unitno.Name = "unitno";
            this.unitno.Size = new System.Drawing.Size(100, 20);
            this.unitno.TabIndex = 41;
            this.unitno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.unitno_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(220, 368);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 59;
            this.label17.Text = "من اصل كم";
            // 
            // Add_cat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 587);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.main_unit_smaller);
            this.Controls.Add(this.unit_name);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.sell_price_for_each);
            this.Controls.Add(this.mainunit_no);
            this.Controls.Add(this.largerRB);
            this.Controls.Add(this.smallerRB);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.unit_label);
            this.Controls.Add(this.unitno);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.unit);
            this.Controls.Add(this.add_image);
            this.Controls.Add(this.back);
            this.Controls.Add(this.save);
            this.Controls.Add(this.save_new);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cate_unite);
            this.Controls.Add(this.cate_warehouses);
            this.Controls.Add(this.cat_image);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.description);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.barcode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.less_quantity);
            this.Controls.Add(this.another_code);
            this.Controls.Add(this.cate_code);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.classification);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.less_price);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.sell_price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cate_name);
            this.Controls.Add(this.label1);
            this.Name = "Add_cat";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Add_cat";
            this.Load += new System.EventHandler(this.Add_cat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cat_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cate_warehouses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cate_unite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox cate_name;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox sell_price;
        public System.Windows.Forms.TextBox discount;
        public System.Windows.Forms.TextBox less_price;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox classification;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox cate_code;
        public System.Windows.Forms.TextBox another_code;
        public System.Windows.Forms.TextBox less_quantity;
        public System.Windows.Forms.TextBox barcode;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox description;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.PictureBox cat_image;
        public System.Windows.Forms.DataGridView cate_warehouses;
        public System.Windows.Forms.DataGridView cate_unite;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.CheckBox checkBox2;
        public System.Windows.Forms.CheckBox checkBox3;
        public System.Windows.Forms.Button save;
        public System.Windows.Forms.Button save_new;
        public System.Windows.Forms.Button back;
        public System.Windows.Forms.Button add_image;
        public System.Windows.Forms.TextBox unit;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox main_unit_smaller;
        public System.Windows.Forms.TextBox unit_name;
        public System.Windows.Forms.Label label19;
        public System.Windows.Forms.Label label20;
        public System.Windows.Forms.Label label21;
        public System.Windows.Forms.TextBox sell_price_for_each;
        public System.Windows.Forms.TextBox mainunit_no;
        public System.Windows.Forms.RadioButton largerRB;
        public System.Windows.Forms.RadioButton smallerRB;
        public System.Windows.Forms.Label label22;
        public System.Windows.Forms.Label unit_label;
        public System.Windows.Forms.TextBox unitno;
        public System.Windows.Forms.Label label17;
    }
}