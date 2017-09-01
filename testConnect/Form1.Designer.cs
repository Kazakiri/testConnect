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
            ((System.ComponentModel.ISupportInitialize)(this.mysqlGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MDBGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // mysqlButton
            // 
            this.mysqlButton.Location = new System.Drawing.Point(22, 51);
            this.mysqlButton.Name = "mysqlButton";
            this.mysqlButton.Size = new System.Drawing.Size(75, 23);
            this.mysqlButton.TabIndex = 0;
            this.mysqlButton.Text = "mysql";
            this.mysqlButton.UseVisualStyleBackColor = true;
            this.mysqlButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // mysqlGridView1
            // 
            this.mysqlGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mysqlGridView1.Location = new System.Drawing.Point(22, 80);
            this.mysqlGridView1.Name = "mysqlGridView1";
            this.mysqlGridView1.RowTemplate.Height = 24;
            this.mysqlGridView1.Size = new System.Drawing.Size(450, 337);
            this.mysqlGridView1.TabIndex = 1;
            // 
            // MDBButton
            // 
            this.MDBButton.Location = new System.Drawing.Point(486, 51);
            this.MDBButton.Name = "MDBButton";
            this.MDBButton.Size = new System.Drawing.Size(75, 23);
            this.MDBButton.TabIndex = 2;
            this.MDBButton.Text = "MDB";
            this.MDBButton.UseVisualStyleBackColor = true;
            this.MDBButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // MDBGridView2
            // 
            this.MDBGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MDBGridView2.Location = new System.Drawing.Point(486, 80);
            this.MDBGridView2.Name = "MDBGridView2";
            this.MDBGridView2.RowTemplate.Height = 24;
            this.MDBGridView2.Size = new System.Drawing.Size(477, 337);
            this.MDBGridView2.TabIndex = 3;
            this.MDBGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MDBGridView2_CellContentClick);
            // 
            // compareGrid
            // 
            this.compareGrid.Location = new System.Drawing.Point(22, 424);
            this.compareGrid.Name = "compareGrid";
            this.compareGrid.Size = new System.Drawing.Size(75, 23);
            this.compareGrid.TabIndex = 4;
            this.compareGrid.Text = "compareGrid";
            this.compareGrid.UseVisualStyleBackColor = true;
            this.compareGrid.Click += new System.EventHandler(this.compareGrid_Click);
            // 
            // compareResult
            // 
            this.compareResult.Location = new System.Drawing.Point(22, 453);
            this.compareResult.Name = "compareResult";
            this.compareResult.Size = new System.Drawing.Size(941, 151);
            this.compareResult.TabIndex = 5;
            this.compareResult.Text = "";
            this.compareResult.TextChanged += new System.EventHandler(this.compareResult_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 616);
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

        }

        #endregion

        private System.Windows.Forms.Button mysqlButton;
        private System.Windows.Forms.DataGridView mysqlGridView1;
        private System.Windows.Forms.Button MDBButton;
        private System.Windows.Forms.DataGridView MDBGridView2;
        private System.Windows.Forms.Button compareGrid;
        private System.Windows.Forms.RichTextBox compareResult;
    }
}

