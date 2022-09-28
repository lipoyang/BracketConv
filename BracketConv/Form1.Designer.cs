namespace BracketConv
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.textInputFolder = new System.Windows.Forms.TextBox();
            this.textOutputFolder = new System.Windows.Forms.TextBox();
            this.btnInputFolder = new System.Windows.Forms.Button();
            this.btnOutputFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textFilter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textVarNames = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.checkSubFolder = new System.Windows.Forms.CheckBox();
            this.textStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textInputFolder
            // 
            this.textInputFolder.Location = new System.Drawing.Point(12, 24);
            this.textInputFolder.Name = "textInputFolder";
            this.textInputFolder.Size = new System.Drawing.Size(570, 19);
            this.textInputFolder.TabIndex = 0;
            // 
            // textOutputFolder
            // 
            this.textOutputFolder.Location = new System.Drawing.Point(12, 113);
            this.textOutputFolder.Name = "textOutputFolder";
            this.textOutputFolder.Size = new System.Drawing.Size(570, 19);
            this.textOutputFolder.TabIndex = 1;
            // 
            // btnInputFolder
            // 
            this.btnInputFolder.Location = new System.Drawing.Point(501, 49);
            this.btnInputFolder.Name = "btnInputFolder";
            this.btnInputFolder.Size = new System.Drawing.Size(81, 26);
            this.btnInputFolder.TabIndex = 2;
            this.btnInputFolder.Text = "参照";
            this.btnInputFolder.UseVisualStyleBackColor = true;
            this.btnInputFolder.Click += new System.EventHandler(this.btnInputFolder_Click);
            // 
            // btnOutputFolder
            // 
            this.btnOutputFolder.Location = new System.Drawing.Point(501, 138);
            this.btnOutputFolder.Name = "btnOutputFolder";
            this.btnOutputFolder.Size = new System.Drawing.Size(81, 26);
            this.btnOutputFolder.TabIndex = 3;
            this.btnOutputFolder.Text = "参照";
            this.btnOutputFolder.UseVisualStyleBackColor = true;
            this.btnOutputFolder.Click += new System.EventHandler(this.btnOutputFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "入力フォルダ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "出力フォルダ";
            // 
            // textFilter
            // 
            this.textFilter.Location = new System.Drawing.Point(56, 60);
            this.textFilter.Name = "textFilter";
            this.textFilter.Size = new System.Drawing.Size(115, 19);
            this.textFilter.TabIndex = 6;
            this.textFilter.Text = "*.cs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "フィルタ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "括弧の前の変数名";
            // 
            // textVarNames
            // 
            this.textVarNames.Location = new System.Drawing.Point(115, 183);
            this.textVarNames.Multiline = true;
            this.textVarNames.Name = "textVarNames";
            this.textVarNames.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textVarNames.Size = new System.Drawing.Size(352, 236);
            this.textVarNames.TabIndex = 9;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(501, 393);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(81, 26);
            this.btnConvert.TabIndex = 10;
            this.btnConvert.Text = "置換";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // checkSubFolder
            // 
            this.checkSubFolder.AutoSize = true;
            this.checkSubFolder.Location = new System.Drawing.Point(194, 63);
            this.checkSubFolder.Name = "checkSubFolder";
            this.checkSubFolder.Size = new System.Drawing.Size(111, 16);
            this.checkSubFolder.TabIndex = 11;
            this.checkSubFolder.Text = "サブフォルダも検索";
            this.checkSubFolder.UseVisualStyleBackColor = true;
            // 
            // textStatus
            // 
            this.textStatus.AutoSize = true;
            this.textStatus.Location = new System.Drawing.Point(14, 431);
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(50, 12);
            this.textStatus.TabIndex = 12;
            this.textStatus.Text = "ステータス";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 455);
            this.Controls.Add(this.textStatus);
            this.Controls.Add(this.checkSubFolder);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.textVarNames);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOutputFolder);
            this.Controls.Add(this.btnInputFolder);
            this.Controls.Add(this.textOutputFolder);
            this.Controls.Add(this.textInputFolder);
            this.Name = "FormMain";
            this.Text = "括弧置換ツール ()→[]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textInputFolder;
        private System.Windows.Forms.TextBox textOutputFolder;
        private System.Windows.Forms.Button btnInputFolder;
        private System.Windows.Forms.Button btnOutputFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textVarNames;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.CheckBox checkSubFolder;
        private System.Windows.Forms.Label textStatus;
    }
}

