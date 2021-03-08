using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingControlApp
{
    public partial class FrmMain : Form
    {
        Random random = new Random(37);

        public FrmMain()
        {
            InitializeComponent();
        }

        #region 이벤트핸들러 영역
        private void FrmMain_Load(object sender, EventArgs e)
        {
            LsvDummy.Columns.Add("Name");
            LsvDummy.Columns.Add("Depth");

            var FontsList = FontFamily.Families; // font 배열
            foreach (var font in FontsList)
            {
                CboFont.Items.Add(font.Name);
            }
        }

        private void CboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void TrbHandle_Scroll(object sender, EventArgs e)
        {
            PrbDisplay.Value = TrbHandle.Value;
        }

        private void BtnModal_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Modal Form";
            frm.Width = 300;
            frm.Height = 100;
            frm.BackColor = Color.Coral;
            frm.ShowDialog(); //모달창 띄우기. -> 모달창이 떠있는 동안은 메인창 사용불가
        }

        private void BrnModaless_Click(object sender, EventArgs e)
        {
            Form frm = new Form
            {
                Text = "Modaless Form",
                Width = 300,
                Height = 100,
                BackColor = Color.GreenYellow
            };
            frm.Show(); //모달리스창 띄우기. -> 메인창 사용가능
        }

        private void BtnMsgBox_Click(object sender, EventArgs e)
        {
            // 모달창 메시지 박스
            MessageBox.Show(TxtResult.Text, "타이틀", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        private void BtnAddRoot_Click(object sender, EventArgs e)
        {
            TrvDummy.Nodes.Add(random.Next().ToString());

            DisplayTreeToList();
        }

        private void BtnAddChild_Click(object sender, EventArgs e)
        {
            if (TrvDummy.SelectedNode == null)
            {
                MessageBox.Show("선택된 노드가 없습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TrvDummy.SelectedNode.Nodes.Add(random.Next().ToString());
            TrvDummy.SelectedNode.Expand();
            DisplayTreeToList();
        }
        #endregion

        #region 사용자메서드 영역
        /// <summary>
        /// 콤보박스, 체크박스 값변경으로 글자체 변경 메서드
        /// </summary>
        private void ChangeFont()
        {
            if (CboFont.SelectedIndex < 0) return; //콤보박스에 아무것도 선택한했으면(-1) 매서드 탈출
            FontStyle style = FontStyle.Regular;
            if (ChkBold.Checked) style |= FontStyle.Bold; // 00000001
            if (ChkItalic.Checked) style |= FontStyle.Italic; // 00000010
            // 00000001 | 00000010 = 00000011 = Bold + Italic

            TxtResult.Font = new Font((string)CboFont.SelectedItem, 14, style);
        }

        // 트리뷰 내용 리스트뷰에 표시
        private void DisplayTreeToList()
        {
            LsvDummy.Items.Clear();
            foreach (TreeNode node in TrvDummy.Nodes)
            {
                DisplayTreeToList(node);
            }
        }

        private void DisplayTreeToList(TreeNode node)
        {
            LsvDummy.Items.Add(new ListViewItem(new string[] { node.Text, node.FullPath } ));

            foreach (TreeNode item in node.Nodes)
            {
                DisplayTreeToList(item);
            }
        }

        #endregion
    }
}
