namespace DateNameRenamer
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.fileGridView = new System.Windows.Forms.DataGridView();
            this.renameStartButton = new System.Windows.Forms.Button();
            this.addedFileText = new System.Windows.Forms.TextBox();
            this.text1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.createdRadioButton = new System.Windows.Forms.RadioButton();
            this.updatedRadioButton = new System.Windows.Forms.RadioButton();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fileGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fileGridView
            // 
            this.fileGridView.AllowDrop = true;
            this.fileGridView.AllowUserToAddRows = false;
            this.fileGridView.AllowUserToDeleteRows = false;
            this.fileGridView.AllowUserToResizeColumns = false;
            this.fileGridView.AllowUserToResizeRows = false;
            this.fileGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fileGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fileGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Path,
            this.CreatedDate,
            this.UpdatedTime});
            this.fileGridView.Location = new System.Drawing.Point(12, 24);
            this.fileGridView.Name = "fileGridView";
            this.fileGridView.RowHeadersVisible = false;
            this.fileGridView.RowTemplate.Height = 21;
            this.fileGridView.Size = new System.Drawing.Size(731, 489);
            this.fileGridView.TabIndex = 0;
            this.fileGridView.DragDrop += new System.Windows.Forms.DragEventHandler(this.fileGridView_DragDrop);
            this.fileGridView.DragEnter += new System.Windows.Forms.DragEventHandler(this.fileGridView_DragEnter);
            // 
            // renameStartButton
            // 
            this.renameStartButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.renameStartButton.Location = new System.Drawing.Point(587, 519);
            this.renameStartButton.Name = "renameStartButton";
            this.renameStartButton.Size = new System.Drawing.Size(156, 23);
            this.renameStartButton.TabIndex = 1;
            this.renameStartButton.Text = "Rename Start";
            this.renameStartButton.UseVisualStyleBackColor = true;
            this.renameStartButton.Click += new System.EventHandler(this.renameStartButton_Click);
            // 
            // addedFileText
            // 
            this.addedFileText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addedFileText.Location = new System.Drawing.Point(179, 521);
            this.addedFileText.Name = "addedFileText";
            this.addedFileText.Size = new System.Drawing.Size(248, 19);
            this.addedFileText.TabIndex = 2;
            // 
            // text1
            // 
            this.text1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.text1.AutoSize = true;
            this.text1.Location = new System.Drawing.Point(12, 524);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(161, 12);
            this.text1.TabIndex = 3;
            this.text1.Text = "ファイル名の先頭に追加する文字";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "ファイルをドラッグ&ドロップしてください";
            // 
            // createdRadioButton
            // 
            this.createdRadioButton.AutoSize = true;
            this.createdRadioButton.Checked = true;
            this.createdRadioButton.Location = new System.Drawing.Point(433, 522);
            this.createdRadioButton.Name = "createdRadioButton";
            this.createdRadioButton.Size = new System.Drawing.Size(71, 16);
            this.createdRadioButton.TabIndex = 5;
            this.createdRadioButton.TabStop = true;
            this.createdRadioButton.Text = "作成日時";
            this.createdRadioButton.UseVisualStyleBackColor = true;
            // 
            // updatedRadioButton
            // 
            this.updatedRadioButton.AutoSize = true;
            this.updatedRadioButton.Location = new System.Drawing.Point(510, 522);
            this.updatedRadioButton.Name = "updatedRadioButton";
            this.updatedRadioButton.Size = new System.Drawing.Size(71, 16);
            this.updatedRadioButton.TabIndex = 6;
            this.updatedRadioButton.TabStop = true;
            this.updatedRadioButton.Text = "更新日時";
            this.updatedRadioButton.UseVisualStyleBackColor = true;
            // 
            // Path
            // 
            this.Path.FillWeight = 33F;
            this.Path.HeaderText = "Path";
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            // 
            // CreatedDate
            // 
            this.CreatedDate.FillWeight = 33F;
            this.CreatedDate.HeaderText = "Created Date";
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.ReadOnly = true;
            // 
            // UpdatedTime
            // 
            this.UpdatedTime.FillWeight = 33F;
            this.UpdatedTime.HeaderText = "Updated Time";
            this.UpdatedTime.Name = "UpdatedTime";
            this.UpdatedTime.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 554);
            this.Controls.Add(this.updatedRadioButton);
            this.Controls.Add(this.createdRadioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.addedFileText);
            this.Controls.Add(this.renameStartButton);
            this.Controls.Add(this.fileGridView);
            this.Name = "Form1";
            this.Text = "Date File Rename - ファイル名を作成日時or更新日時に変換します";
            ((System.ComponentModel.ISupportInitialize)(this.fileGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView fileGridView;
        private System.Windows.Forms.Button renameStartButton;
        private System.Windows.Forms.TextBox addedFileText;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton createdRadioButton;
        private System.Windows.Forms.RadioButton updatedRadioButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedTime;
    }
}

