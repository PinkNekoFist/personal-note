using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personal_note
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            if (rtbDay.Text == "" || rtbYear.Text == "" || rtbMonth.Text == "")
            {
                ErrorDay();
                return;
            }
            try
            {
                List<DiaryNode> list = DiaryTree.SearchDiary(int.Parse(rtbYear.Text), int.Parse(rtbMonth.Text), int.Parse(rtbDay.Text));
                Form1.mainForm.turnToDate(int.Parse(rtbYear.Text), int.Parse(rtbMonth.Text));

                if (list == null) return;

                foreach (DiaryNode node in list)
                {
                    node.showDiaryNode();
                }

                Form1.showSearchedDiary(list);
            }
            catch (Exception ex)
            {
                ErrorDay();
                return;
            }
        }

        private void ErrorDay()
        {
            lblAlarm.Text = "請輸入正確格式";
            rtbYear.Text = "";
            rtbMonth.Text = "";
            rtbDay.Text = "";
        }

        private void btnStar_Click(object sender, EventArgs e)
        {
            if (rtbStar.Text == "")
            {
                ErrorStar();
                return;
            }
            try
            {
                List<DiaryNode> list = DiaryTree.SearchMonthStar(int.Parse(rtbStar.Text),Form1.mainForm.GetYear(),Form1.mainForm.GetMonth());

                foreach (DiaryNode node in list)
                {
                    node.showDiaryNode();
                }

                Form1.showSearchedDiary(list);
            }
            catch (Exception ex)
            {
                ErrorStar();
                return;
            }
        }

        private void ErrorStar()
        {
            lblStar.Text = "請輸入正確格式";
            rtbStar.Text = "";
        }

        private void btnTag_Click(object sender, EventArgs e)
        {
            if (rtbTag.Text == "")
            {
                ErrorTag();
                return;
            }

            List<DiaryNode> list = DiaryTree.SearchDiaryTag(rtbTag.Text, Form1.mainForm.GetYear(), Form1.mainForm.GetMonth());

            foreach (DiaryNode node in list)
            {
                node.showDiaryNode();
            }

            Form1.showSearchedDiary(list);
        }

        private void ErrorTag()
        {
            lblTag.Text = "請輸入正確格式";
            rtbTag.Text = "";
        }

        private void rtbYear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // 禁止 Enter 键的输入
                e.Handled = true;          // 防止其他事件触发
            }
        }
    }
}
