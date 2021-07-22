# 1. Winform Basic

<kbd>![Basic](/Winform/capture/Basic.PNG "Basic")</kbd> <br>

## 1. Font 변경

* FontFamily.Families로 컴퓨터 내에 있는 폰트 스타일을 불러와 var FontsList에서 호출
* 반복문으로 Combobox(CboFont)에 리스트 내용 추가

```C#
private void FrmMain_Load(object sender, EventArgs e)
{
    .......
    var FontsList = FontFamily.Families; // font 배열
    foreach (var font in FontsList)
    {
        CboFont.Items.Add(font.Name);
    }
}
```

* ChangeFont()를 모듈화하여 폰트에 변경이 있을 경우 호출
* 조건문으로 콤보박스 및 체크박스가 check 되어있는지 확인하여 폰트 스타일 변경

```C#
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

private void ChangeFont()
{
    if (CboFont.SelectedIndex < 0) return; //콤보박스에 아무것도 선택한했으면(-1) 매서드 탈출
    FontStyle style = FontStyle.Regular;
    if (ChkBold.Checked) style |= FontStyle.Bold; // 00000001
    if (ChkItalic.Checked) style |= FontStyle.Italic; // 00000010
    // 00000001 | 00000010 = 00000011 = Bold + Italic

    TxtResult.Font = new Font((string)CboFont.SelectedItem, 14, style);
}
```

## 2. TracBar = Prograssbar

```C#
private void TrbHandle_Scroll(object sender, EventArgs e)
{
    PrbDisplay.Value = TrbHandle.Value;
}
```

## 3. Modal & Modaless

* Modal 창을 불러오면 modal 창 종료 전까지는 Main 창을 사용할 수 없다. : ShowDialog()
* 반면 Modaless 창은 Main 창과 동시 운영가능 : Show()
* Message창은 Show() / ShowDialog를 활용하여 Modal/Modaless 지정 가능

```C#
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
```

## 4. TreeView_Listview

* 처음 로드 시 ListView에 Column 생성
* 루트 추가 : TrvDummy.Nodes.Add(random.Next().ToString());
* 노드 추가 : TrvDummy.SelectedNode.Nodes.Add(random.Next().ToString());
             TrvDummy.SelectedNode.Expand();
* DisplayTreeToList() / DisplayTreeToList(TreeNode node) 로 overlodding
* 반복문과 List를 활용하여 데이터를 호출

```C#
private void FrmMain_Load(object sender, EventArgs e)
{
    LsvDummy.Columns.Add("Name");
    LsvDummy.Columns.Add("Depth");
    .......
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
```
------------------------------------------------
# 2. File Copy

<kbd>![FileCopy](/Winform/capture/FileCopy.PNG "FileCopy")</kbd>

## 1. File 선택

* OpenFileDialog 와 SaveFileDialog를 활용하여 File 열람 및 저장

```C#
private void BtnSource_Click(object sender, EventArgs e)
{
    OpenFileDialog dialog = new OpenFileDialog();
    if(dialog.ShowDialog() == DialogResult.OK)
    {
        TxtSource.Text = dialog.FileName;
    }
}

private void BtnTarget_Click(object sender, EventArgs e)
{
    SaveFileDialog dialog = new SaveFileDialog();
    if(dialog.ShowDialog() == DialogResult.OK)
    {
        TxtTarget.Text = dialog.FileName;
    }
}
```

## 2. 비동기

* 요청에 대한 응답이 오지 않아도 새로운 요청을 보내고 처리되는 요청대로 응답
* 요청해놓고 딴 일을 하고 있을 수 있다.
* Thread를 사용하는 것과  동일한 역활

```C#
private async void BtnAsyncCopy_Click(object sender, EventArgs e)
{
    long totalCopied = await CopyAsync(TxtSource.Text, TxtTarget.Text);
    MessageBox.Show($"{totalCopied}로 복사햇습니다.", "비동기복사완료");
}
        
// 비동기 처리 Thread와 동일한 역활
private async Task<long> CopyAsync(string sourcePath, string targetPath) 
{
    BtnSyncCopy.Enabled = false; 
    long totalCopied = 0;

    using (FileStream sourceStream = new FileStream(sourcePath, FileMode.Open))
    {
        using (FileStream targetStream = new FileStream(targetPath, FileMode.Create))
        {
            byte[] buffer = new byte[1024 * 1024]; 
            int nRead = 0;
            while ((nRead = await sourceStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
            {
                await targetStream.WriteAsync(buffer, 0, nRead); 
                totalCopied += nRead;

                PrbCopy.Value = (int)((totalCopied / sourceStream.Length) * 100);
            }
        }
    }
    BtnSyncCopy.Enabled = true;
    return totalCopied;
}
```

## 3. 동기

* 요청에 대한 응답이 오면 다음 작업을 요청
* 요청에 대한 응답이 올 때까지 다른 일 못 함

```C#
private void BtnSyncCopy_Click(object sender, EventArgs e)
{
    long totalCopied = CopySync(TxtSource.Text, TxtTarget.Text);
    MessageBox.Show($"{totalCopied}로 복사했습니다.","동기복사완료");
}

private long CopySync(string sourcePath, string targetPath)
{
    BtnAsyncCopy.Enabled = false; // 비동기버튼 비활성화(Enable vs Disable)
    long totalCopied = 0; // 전부 복사했는지

    using (FileStream sourceStream = new FileStream(sourcePath, FileMode.Open))
    {
        using (FileStream targetStream = new FileStream(targetPath, FileMode.Create))
        {
            byte[] buffer = new byte[1024 * 1024]; // 1024(1KB) * 1024 ==> 1MB
            int nRead = 0;
            while ((nRead = sourceStream.Read(buffer, 0, buffer.Length)) != 0 )
            {
                targetStream.Write(buffer, 0, nRead); //복사
                totalCopied += nRead;

                //프로그래스바에 복사 상태 진행표시
                PrbCopy.Value = (int)((totalCopied / sourceStream.Length) * 100);
            }
        }
    }
    BtnAsyncCopy.Enabled = true;
    return totalCopied;
}
```
