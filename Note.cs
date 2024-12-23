﻿using System;
using System.Windows.Forms;

namespace personal_note
{
    public partial class Note : Form
    {
        bool isTitleEmpty = true, isNoteEmpty = true;
        DiaryNode diaryNode;
        public Note(int year, int month, int day)
        {
            InitializeComponent();
            this.diaryNode = new DiaryNode(year, month, day);
        }

        private void rtbTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (isTitleEmpty) rtbTitle.Text = "";
            isTitleEmpty = false;
            if (e.KeyCode == Keys.Back && rtbTitle.Text.Length <= 1)
            {
                isTitleEmpty = true;
                rtbTitle.Text = "Title";
            }
        }

        private void Note_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("是否存儲內容?", "儲存", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Console.WriteLine("要儲存");
                DiaryTree.AddDiary(diaryNode);
                DiaryTree.SaveDiary(diaryNode);
                diaryNode.showDiaryNode();
            }
            else if (result == DialogResult.No) Console.WriteLine("不要儲存");
            else if (result == DialogResult.Cancel)
            {
                Console.WriteLine("取消離開");
                e.Cancel = true;
            }

            //DiaryTree.showTree(DiaryTree.root);
            //Console.WriteLine("結束遍歷");
        }



        private void rtbTitle_TextChanged(object sender, EventArgs e)
        {
            diaryNode.title = rtbTitle.Text;
            //Console.WriteLine(diaryNode.title);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(btnAdd.Text.Equals("Add"))
            {
                rtbAdd.Visible = true;
                rtbTag.Visible = false;
                btnAdd.Text = "Ensure";
            }else if (btnAdd.Text.Equals("Ensure"))
            {
                rtbTag.Text += rtbAdd.Text + ", ";
                rtbTag.Visible = true;
                rtbAdd.Visible = false;
                diaryNode.tag.Add(rtbAdd.Text);
                rtbAdd.Text = "";
                btnAdd.Text = "Add";
            }
        }

        private void rtbNote_TextChanged(object sender, EventArgs e)
        {
            diaryNode.content = rtbNote.Text;
            //Console.WriteLine(diaryNode.content);
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (isNoteEmpty) rtbNote.Text = "";
            isNoteEmpty = false;
            if (e.KeyCode == Keys.Back && rtbNote.Text.Length <= 1)
            {
                isNoteEmpty = true;
                rtbNote.Text = "Let's write note";
            }
        }

    }
}
