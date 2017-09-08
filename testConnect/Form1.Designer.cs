namespace testConnect
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.mysqlButton = new System.Windows.Forms.Button();
            this.mysqlGridView1 = new System.Windows.Forms.DataGridView();
            this.MDBButton = new System.Windows.Forms.Button();
            this.MDBGridView2 = new System.Windows.Forms.DataGridView();
            this.compareGrid = new System.Windows.Forms.Button();
            this.compareResult = new System.Windows.Forms.RichTextBox();
            this.mysqlTdate = new System.Windows.Forms.TextBox();
            this.MDBTdate = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.getMysql = new System.Windows.Forms.Button();
            this.textUser = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.textIP = new System.Windows.Forms.TextBox();
            this.textDB = new System.Windows.Forms.TextBox();
            this.chooseMDB = new System.Windows.Forms.Button();
            this.remarkButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.remarkText = new System.Windows.Forms.TextBox();
            this.selectRemarkButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MDBLable = new System.Windows.Forms.Label();
            this.mysqlCountLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mysqlGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MDBGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // mysqlButton
            // 
            this.mysqlButton.Location = new System.Drawing.Point(22, 12);
            this.mysqlButton.Name = "mysqlButton";
            this.mysqlButton.Size = new System.Drawing.Size(75, 23);
            this.mysqlButton.TabIndex = 0;
            this.mysqlButton.Text = "選擇資料庫";
            this.mysqlButton.UseVisualStyleBackColor = true;
            this.mysqlButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // mysqlGridView1
            // 
            this.mysqlGridView1.AllowUserToAddRows = false;
            this.mysqlGridView1.AllowUserToDeleteRows = false;
            this.mysqlGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mysqlGridView1.Location = new System.Drawing.Point(142, 80);
            this.mysqlGridView1.Name = "mysqlGridView1";
            this.mysqlGridView1.RowTemplate.Height = 24;
            this.mysqlGridView1.Size = new System.Drawing.Size(542, 489);
            this.mysqlGridView1.TabIndex = 1;
            // 
            // MDBButton
            // 
            this.MDBButton.Location = new System.Drawing.Point(782, 52);
            this.MDBButton.Name = "MDBButton";
            this.MDBButton.Size = new System.Drawing.Size(75, 23);
            this.MDBButton.TabIndex = 2;
            this.MDBButton.Text = "MDB";
            this.MDBButton.UseVisualStyleBackColor = true;
            this.MDBButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // MDBGridView2
            // 
            this.MDBGridView2.AllowUserToAddRows = false;
            this.MDBGridView2.AllowUserToDeleteRows = false;
            this.MDBGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MDBGridView2.Location = new System.Drawing.Point(811, 80);
            this.MDBGridView2.Name = "MDBGridView2";
            this.MDBGridView2.RowTemplate.Height = 24;
            this.MDBGridView2.Size = new System.Drawing.Size(152, 337);
            this.MDBGridView2.TabIndex = 3;
            this.MDBGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MDBGridView2_CellContentClick);
            // 
            // compareGrid
            // 
            this.compareGrid.Location = new System.Drawing.Point(708, 568);
            this.compareGrid.Name = "compareGrid";
            this.compareGrid.Size = new System.Drawing.Size(75, 23);
            this.compareGrid.TabIndex = 4;
            this.compareGrid.Text = "compareGrid";
            this.compareGrid.UseVisualStyleBackColor = true;
            this.compareGrid.Click += new System.EventHandler(this.compareGrid_Click);
            // 
            // compareResult
            // 
            this.compareResult.Location = new System.Drawing.Point(789, 440);
            this.compareResult.Name = "compareResult";
            this.compareResult.Size = new System.Drawing.Size(174, 151);
            this.compareResult.TabIndex = 5;
            this.compareResult.Text = "";
            this.compareResult.TextChanged += new System.EventHandler(this.compareResult_TextChanged_1);
            // 
            // mysqlTdate
            // 
            this.mysqlTdate.Location = new System.Drawing.Point(38, 282);
            this.mysqlTdate.Name = "mysqlTdate";
            this.mysqlTdate.Size = new System.Drawing.Size(92, 22);
            this.mysqlTdate.TabIndex = 6;
            // 
            // MDBTdate
            // 
            this.MDBTdate.Location = new System.Drawing.Point(863, 52);
            this.MDBTdate.Name = "MDBTdate";
            this.MDBTdate.Size = new System.Drawing.Size(100, 22);
            this.MDBTdate.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(22, 80);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(92, 196);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // getMysql
            // 
            this.getMysql.Enabled = false;
            this.getMysql.Location = new System.Drawing.Point(22, 42);
            this.getMysql.Name = "getMysql";
            this.getMysql.Size = new System.Drawing.Size(75, 23);
            this.getMysql.TabIndex = 10;
            this.getMysql.Text = "抓取mysql";
            this.getMysql.UseVisualStyleBackColor = true;
            this.getMysql.Click += new System.EventHandler(this.getMysql_Click);
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(142, 12);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(100, 22);
            this.textUser.TabIndex = 11;
            this.textUser.Text = "root";
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(260, 12);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '*';
            this.textPass.Size = new System.Drawing.Size(100, 22);
            this.textPass.TabIndex = 12;
            this.textPass.Text = "ganto1184";
            // 
            // textIP
            // 
            this.textIP.Location = new System.Drawing.Point(142, 41);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(100, 22);
            this.textIP.TabIndex = 13;
            this.textIP.Text = "127.0.0.1";
            // 
            // textDB
            // 
            this.textDB.Location = new System.Drawing.Point(260, 40);
            this.textDB.Name = "textDB";
            this.textDB.Size = new System.Drawing.Size(100, 22);
            this.textDB.TabIndex = 14;
            this.textDB.Text = "stocker";
            // 
            // chooseMDB
            // 
            this.chooseMDB.Location = new System.Drawing.Point(873, 12);
            this.chooseMDB.Name = "chooseMDB";
            this.chooseMDB.Size = new System.Drawing.Size(75, 23);
            this.chooseMDB.TabIndex = 15;
            this.chooseMDB.Text = "選擇檔案";
            this.chooseMDB.UseVisualStyleBackColor = true;
            this.chooseMDB.Click += new System.EventHandler(this.chooseMDB_Click);
            // 
            // remarkButton
            // 
            this.remarkButton.Location = new System.Drawing.Point(377, 38);
            this.remarkButton.Name = "remarkButton";
            this.remarkButton.Size = new System.Drawing.Size(75, 23);
            this.remarkButton.TabIndex = 16;
            this.remarkButton.Text = "remark";
            this.remarkButton.UseVisualStyleBackColor = true;
            this.remarkButton.Click += new System.EventHandler(this.remarkButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(12, 408);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(118, 23);
            this.printButton.TabIndex = 17;
            this.printButton.Text = "印(搭配上面)";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // remarkText
            // 
            this.remarkText.Location = new System.Drawing.Point(50, 351);
            this.remarkText.Name = "remarkText";
            this.remarkText.Size = new System.Drawing.Size(86, 22);
            this.remarkText.TabIndex = 18;
            // 
            // selectRemarkButton
            // 
            this.selectRemarkButton.Location = new System.Drawing.Point(12, 379);
            this.selectRemarkButton.Name = "selectRemarkButton";
            this.selectRemarkButton.Size = new System.Drawing.Size(118, 23);
            this.selectRemarkButton.TabIndex = 19;
            this.selectRemarkButton.Text = "獲取表格";
            this.selectRemarkButton.UseVisualStyleBackColor = true;
            this.selectRemarkButton.Click += new System.EventHandler(this.selectRemarkButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "板號";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "日期";
            // 
            // MDBLable
            // 
            this.MDBLable.AutoSize = true;
            this.MDBLable.Location = new System.Drawing.Point(809, 425);
            this.MDBLable.Name = "MDBLable";
            this.MDBLable.Size = new System.Drawing.Size(32, 12);
            this.MDBLable.TabIndex = 22;
            this.MDBLable.Text = "總計:";
            // 
            // mysqlCountLable
            // 
            this.mysqlCountLable.AutoSize = true;
            this.mysqlCountLable.Location = new System.Drawing.Point(142, 576);
            this.mysqlCountLable.Name = "mysqlCountLable";
            this.mysqlCountLable.Size = new System.Drawing.Size(32, 12);
            this.mysqlCountLable.TabIndex = 23;
            this.mysqlCountLable.Text = "總計:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 616);
            this.Controls.Add(this.mysqlCountLable);
            this.Controls.Add(this.MDBLable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectRemarkButton);
            this.Controls.Add(this.remarkText);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.remarkButton);
            this.Controls.Add(this.chooseMDB);
            this.Controls.Add(this.textDB);
            this.Controls.Add(this.textIP);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.getMysql);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.MDBTdate);
            this.Controls.Add(this.mysqlTdate);
            this.Controls.Add(this.compareResult);
            this.Controls.Add(this.compareGrid);
            this.Controls.Add(this.MDBGridView2);
            this.Controls.Add(this.MDBButton);
            this.Controls.Add(this.mysqlGridView1);
            this.Controls.Add(this.mysqlButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mysqlGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MDBGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mysqlButton;
        private System.Windows.Forms.DataGridView mysqlGridView1;
        private System.Windows.Forms.Button MDBButton;
        private System.Windows.Forms.DataGridView MDBGridView2;
        private System.Windows.Forms.Button compareGrid;
        private System.Windows.Forms.RichTextBox compareResult;
        private System.Windows.Forms.TextBox mysqlTdate;
        private System.Windows.Forms.TextBox MDBTdate;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button getMysql;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.TextBox textIP;
        private System.Windows.Forms.TextBox textDB;
        private System.Windows.Forms.Button chooseMDB;
        private System.Windows.Forms.Button remarkButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.TextBox remarkText;
        private System.Windows.Forms.Button selectRemarkButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MDBLable;
        private System.Windows.Forms.Label mysqlCountLable;
    }
}

