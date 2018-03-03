namespace pos_system.PL
{
    partial class edite_category
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
            this.category_dgv = new System.Windows.Forms.DataGridView();
            this.refresh = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.excel = new System.Windows.Forms.Button();
            this.cate_mov_report = new System.Windows.Forms.Button();
            this.warehouse_goods_report = new System.Windows.Forms.Button();
            this.warehous_mov_report = new System.Windows.Forms.Button();
            this.edite_price_list = new System.Windows.Forms.Button();
            this.printall = new System.Windows.Forms.Button();
            this.search_about = new System.Windows.Forms.Button();
            this.transaction_report = new System.Windows.Forms.Button();
            this.search_tx = new System.Windows.Forms.TextBox();
            this.class_cb = new System.Windows.Forms.ComboBox();
            this.unused_categories = new System.Windows.Forms.CheckBox();
            this.under_limit_categories = new System.Windows.Forms.CheckBox();
            this.date_tx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.category_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // category_dgv
            // 
            this.category_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.category_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.category_dgv.Location = new System.Drawing.Point(190, 167);
            this.category_dgv.Name = "category_dgv";
            this.category_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.category_dgv.Size = new System.Drawing.Size(744, 367);
            this.category_dgv.TabIndex = 0;
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(222, 79);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 1;
            this.refresh.Text = "تحديث";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(339, 79);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 2;
            this.search_btn.Text = "بحث متقدم";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(71, 210);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(45, 23);
            this.update.TabIndex = 4;
            this.update.Text = "تعديل ";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(9, 210);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(56, 23);
            this.delete.TabIndex = 3;
            this.delete.Text = "حذف";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(122, 210);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(60, 23);
            this.add.TabIndex = 5;
            this.add.Text = "اضافه";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button5_Click);
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(71, 258);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(111, 23);
            this.print.TabIndex = 7;
            this.print.Text = "طباعه قائمه الاصناف";
            this.print.UseVisualStyleBackColor = true;
            // 
            // excel
            // 
            this.excel.Location = new System.Drawing.Point(9, 258);
            this.excel.Name = "excel";
            this.excel.Size = new System.Drawing.Size(56, 23);
            this.excel.TabIndex = 6;
            this.excel.Text = "اكسيل";
            this.excel.UseVisualStyleBackColor = true;
            // 
            // cate_mov_report
            // 
            this.cate_mov_report.Location = new System.Drawing.Point(9, 303);
            this.cate_mov_report.Name = "cate_mov_report";
            this.cate_mov_report.Size = new System.Drawing.Size(173, 23);
            this.cate_mov_report.TabIndex = 8;
            this.cate_mov_report.Text = "تقرير حركه الصنف";
            this.cate_mov_report.UseVisualStyleBackColor = true;
            // 
            // warehouse_goods_report
            // 
            this.warehouse_goods_report.Location = new System.Drawing.Point(9, 332);
            this.warehouse_goods_report.Name = "warehouse_goods_report";
            this.warehouse_goods_report.Size = new System.Drawing.Size(173, 23);
            this.warehouse_goods_report.TabIndex = 9;
            this.warehouse_goods_report.Text = "تقرير بضاعه المخزن";
            this.warehouse_goods_report.UseVisualStyleBackColor = true;
            // 
            // warehous_mov_report
            // 
            this.warehous_mov_report.Location = new System.Drawing.Point(9, 361);
            this.warehous_mov_report.Name = "warehous_mov_report";
            this.warehous_mov_report.Size = new System.Drawing.Size(173, 23);
            this.warehous_mov_report.TabIndex = 10;
            this.warehous_mov_report.Text = "تقرير حركه المخزن";
            this.warehous_mov_report.UseVisualStyleBackColor = true;
            // 
            // edite_price_list
            // 
            this.edite_price_list.Location = new System.Drawing.Point(71, 422);
            this.edite_price_list.Name = "edite_price_list";
            this.edite_price_list.Size = new System.Drawing.Size(111, 23);
            this.edite_price_list.TabIndex = 12;
            this.edite_price_list.Text = "تعديل قائمه الاسعار";
            this.edite_price_list.UseVisualStyleBackColor = true;
            // 
            // printall
            // 
            this.printall.Location = new System.Drawing.Point(9, 422);
            this.printall.Name = "printall";
            this.printall.Size = new System.Drawing.Size(56, 23);
            this.printall.TabIndex = 11;
            this.printall.Text = "طباعه ملصقات الباركود";
            this.printall.UseVisualStyleBackColor = true;
            // 
            // search_about
            // 
            this.search_about.Location = new System.Drawing.Point(107, 449);
            this.search_about.Name = "search_about";
            this.search_about.Size = new System.Drawing.Size(75, 23);
            this.search_about.TabIndex = 14;
            this.search_about.Text = "بحث عن سيريال كود";
            this.search_about.UseVisualStyleBackColor = true;
            // 
            // transaction_report
            // 
            this.transaction_report.Location = new System.Drawing.Point(9, 449);
            this.transaction_report.Name = "transaction_report";
            this.transaction_report.Size = new System.Drawing.Size(75, 23);
            this.transaction_report.TabIndex = 13;
            this.transaction_report.Text = "تقرير شحنه";
            this.transaction_report.UseVisualStyleBackColor = true;
            // 
            // search_tx
            // 
            this.search_tx.Location = new System.Drawing.Point(736, 79);
            this.search_tx.Name = "search_tx";
            this.search_tx.Size = new System.Drawing.Size(176, 20);
            this.search_tx.TabIndex = 15;
            this.search_tx.TextChanged += new System.EventHandler(this.search_tx_TextChanged);
            // 
            // class_cb
            // 
            this.class_cb.FormattingEnabled = true;
            this.class_cb.Location = new System.Drawing.Point(600, 79);
            this.class_cb.Name = "class_cb";
            this.class_cb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.class_cb.Size = new System.Drawing.Size(121, 21);
            this.class_cb.TabIndex = 16;
            // 
            // unused_categories
            // 
            this.unused_categories.AutoSize = true;
            this.unused_categories.Location = new System.Drawing.Point(754, 118);
            this.unused_categories.Name = "unused_categories";
            this.unused_categories.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.unused_categories.Size = new System.Drawing.Size(154, 17);
            this.unused_categories.TabIndex = 17;
            this.unused_categories.Text = "عرض الاصناف الغير مستخدمه";
            this.unused_categories.UseVisualStyleBackColor = true;
            // 
            // under_limit_categories
            // 
            this.under_limit_categories.AutoSize = true;
            this.under_limit_categories.Location = new System.Drawing.Point(525, 118);
            this.under_limit_categories.Name = "under_limit_categories";
            this.under_limit_categories.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.under_limit_categories.Size = new System.Drawing.Size(196, 17);
            this.under_limit_categories.TabIndex = 18;
            this.under_limit_categories.Text = "عرض الاصناف 1التى تجاوزت اقل كميه";
            this.under_limit_categories.UseVisualStyleBackColor = true;
            // 
            // date_tx
            // 
            this.date_tx.Location = new System.Drawing.Point(570, 141);
            this.date_tx.Name = "date_tx";
            this.date_tx.Size = new System.Drawing.Size(176, 20);
            this.date_tx.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(870, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "الاصناف";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(679, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "التصنيف";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(879, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "البحث";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(751, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "الاصناف التى تم شرائها بعد تاريخ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(364, 141);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 24;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // edite_category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 536);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date_tx);
            this.Controls.Add(this.under_limit_categories);
            this.Controls.Add(this.unused_categories);
            this.Controls.Add(this.class_cb);
            this.Controls.Add(this.search_tx);
            this.Controls.Add(this.search_about);
            this.Controls.Add(this.transaction_report);
            this.Controls.Add(this.edite_price_list);
            this.Controls.Add(this.printall);
            this.Controls.Add(this.warehous_mov_report);
            this.Controls.Add(this.warehouse_goods_report);
            this.Controls.Add(this.cate_mov_report);
            this.Controls.Add(this.print);
            this.Controls.Add(this.excel);
            this.Controls.Add(this.add);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.category_dgv);
            this.Name = "edite_category";
            this.Text = "edite_category";
            ((System.ComponentModel.ISupportInitialize)(this.category_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView category_dgv;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Button excel;
        private System.Windows.Forms.Button cate_mov_report;
        private System.Windows.Forms.Button warehouse_goods_report;
        private System.Windows.Forms.Button warehous_mov_report;
        private System.Windows.Forms.Button edite_price_list;
        private System.Windows.Forms.Button printall;
        private System.Windows.Forms.Button search_about;
        private System.Windows.Forms.Button transaction_report;
        private System.Windows.Forms.TextBox search_tx;
        private System.Windows.Forms.ComboBox class_cb;
        private System.Windows.Forms.CheckBox unused_categories;
        private System.Windows.Forms.CheckBox under_limit_categories;
        private System.Windows.Forms.TextBox date_tx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}