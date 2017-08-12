using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateNameRenamer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileGridView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                //ファイル情報のコピー
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
                MessageBox.Show("ファイルではありません",
                "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

        }

        private void fileGridView_DragDrop(object sender, DragEventArgs e)
        {
            fileGridView.Rows.Clear(); //GridViewの初期化

            string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            //行の配列にデータを追加していく
            DataGridViewRow[] rows = new DataGridViewRow[paths.Length];
            for (int i = 0; i < paths.Length; i++)
            {
                DateTime createdTime = System.IO.File.GetCreationTime(@paths[i]);
                DateTime updatedTime = System.IO.File.GetLastWriteTime(@paths[i]);

                rows[i] = new DataGridViewRow();
                rows[i].CreateCells(fileGridView);
                rows[i].SetValues(new object[] { 
                    paths[i], 
                    createdTime.ToString("yyyy/MM/dd/HH:mm:ss:fff"),
                    updatedTime.ToString("yyyy/MM/dd/HH:mm:ss:fff")}); 
            }

            fileGridView.Rows.AddRange(rows);

        }

        private void renameStartButton_Click(object sender, EventArgs e)
        {
            //選択された行だけ対象に，文字を置換していく
            for (int i = 0; i < fileGridView.Rows.Count; i++)
            {
                int useCol = createdRadioButton.Checked ? 1 : 2; 

                string beforePath = @fileGridView[0, i].Value.ToString();
                string dirname = System.IO.Path.GetDirectoryName(beforePath) + "\\";
                string ext = System.IO.Path.GetExtension(beforePath);
                string afterFileName = addedFileText.Text + fileGridView[useCol, i].Value.ToString() + ext;

                //文字削除
                char[] removeChars = new char[] { ':', '/', ' '};
                afterFileName = removeChars.Aggregate(afterFileName, (s, c) => s.Replace(c.ToString(), ""));

                try
                {
                    //実際にファイル名を変更する
                    System.IO.File.Move(beforePath, dirname + afterFileName);

                }
                catch (IOException ex)
                {
                    MessageBox.Show(beforePath + " >>> "  + dirname + afterFileName + " --- " + ex.Message,
                    "ファイル名変更時エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button2);
                }
            }
        }


    }
}
