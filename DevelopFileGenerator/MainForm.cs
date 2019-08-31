using System;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace DevelopFileGenerator
{
    public partial class MainForm : Form
    {
        private string fullPath = null;
        private string fullFile = null;

        private string path = null;
        private string folder = null;
        private string file = null;
        private decimal maxCount = 1;

        private int count = 1;

        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        // 프로그램 로딩 시 마지막으로 입력된 값 자동입력
        private void MainForm_Load(object sender, EventArgs e)
        {
            textBoxPath.Text = Properties.Settings.Default.path;
            textBoxFolder.Text = Properties.Settings.Default.folder;
            textBoxFile.Text = Properties.Settings.Default.file;
            numericUpDown.Value = Properties.Settings.Default.maxCount;

            PathFormat();
        }

        // 정보 버튼
        private void ButtonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("설정파일 위치 : " + ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath + "\n\n" + "Icon : " + "https://www.iconfinder.com/korawan_m", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 경로 지정
        private void ButtonPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        // 경로 직접 입력
        private void TextBoxPath_TextChanged(object sender, EventArgs e)
        {
            path = textBoxPath.Text;
            Properties.Settings.Default.path = path;

            PathFormat();
        }

        // 폴더 이름 지정
        private void TextBoxFolder_TextChanged(object sender, EventArgs e)
        {
            folder = textBoxFolder.Text;
            Properties.Settings.Default.folder = folder;

            PathFormat();
        }

        // 파일 이름 지정
        private void TextBoxFile_TextChanged(object sender, EventArgs e)
        {
            file = textBoxFile.Text;
            Properties.Settings.Default.file = file;

            PathFormat();
        }

        // 파일 최대 갯수 지정
        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            maxCount = numericUpDown.Value;
            Properties.Settings.Default.maxCount = maxCount;
        }

        // 동작 버튼
        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            // 폴더 경로가 지정되지 않을 경우
            if (textBoxPath.Text.Equals("") || textBoxPath.Text == null)
            {
                ActiveControl = textBoxPath;
                MessageBox.Show("폴더 경로는 필수로 입력해야합니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // 파일 이름이 업력되지 않을 경우
            else if (textBoxFile.Text.Equals("") || textBoxFile.Text == null)
            {
                ActiveControl = textBoxFile;
                MessageBox.Show("파일 이름은 필수로 입력해야합니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // 모든 필수 항목이 입력될 경우
            else
            {
                backgroundWorker.RunWorkerAsync();
            }
        }

        // 종료 처리
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        // 프로그램 동작
        private void BackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            count = 0;

            progressBar.Maximum = Convert.ToInt32(maxCount) + 3;
            labelCount.Text = "총 " + maxCount + "개";

            // 동작 시도
            try
            {
                buttonSubmit.Enabled = false;

                // 폴더 이름이 지정되지 않을 경우
                if (folder == null)
                {
                    fullPath = path;
                }

                // 폴더 이름이 지정될 경우 전체경로에 폴머 이름 추가
                else
                {
                    fullPath = path + "\\" + folder;
                }

                progressBar.Value = ++count;
                labelProgress.Text = "경로 지정";

                // 생성한 파일 경로 형식 지정
                fullFile = fullPath + "\\" + file;

                progressBar.Value = ++count;
                labelProgress.Text = "파일 이름 형식 지정";

                DirectoryInfo directory = new DirectoryInfo(fullPath);
                StreamWriter writer = null;

                // 전체경로가 존제하지 않을 경우 생성
                if (!directory.Exists)
                {
                    progressBar.Value = ++count;
                    labelProgress.Text = "경로 생성";

                    directory.Create();
                }

                // maxCount만큼 파일 생성
                for (int i = 1; i <= maxCount; i++)
                {
                    progressBar.Value = ++count;
                    labelProgress.Text = i + "번 째 파일 생성";

                    // *을 i로 치환
                    string temp = fullFile.Replace("*", i.ToString());

                    writer = File.CreateText(temp);
                    writer.Close();
                }

                progressBar.Value = progressBar.Maximum;
                labelProgress.Text = "완료";
            }
            
            // 오류 처리
            catch (Exception ex)
            {
                labelProgress.Text = "오류 발생";

                MessageBox.Show("오류 발생\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        // 동작 완료
        private void BackgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            // 오류로 인한 동작 취소가 아닐 경우
            if (!e.Cancelled)
            {
                if (MessageBox.Show("작업 완료\n폴더를 여시겠습니까?", "Done", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Process.Start(fullPath);
                }

                progressBar.Value = 0;
                labelProgress.Text = "";
                labelCount.Text = "";
            }

            buttonSubmit.Enabled = true;
        }

        // 입력값 리셋
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            textBoxPath.Text = "";
            textBoxFolder.Text = "";
            textBoxFile.Text = "";
            numericUpDown.Value = numericUpDown.Minimum;
        }

        // 경로 Formatter
        private void PathFormat()
        {
            if ((path == "" || path == null) && (folder == "" || folder == null) && (file == "" || file == null))
            {
                labelFormat.Text = "Path Formatter";
            }

            else if ((path != "" && path != null) && (folder != "" && folder != null) && (file != "" && file != null))
            {
                labelFormat.Text = path + "\\" + folder + "\\" + file;
            }

            else if ((path != "" && path != null) && (folder == "" || folder == null) && (file != "" && file != null))
            {
                labelFormat.Text = path + "\\" + file;
            }

            else if ((path == "" || path == null) || (file == "" || file == null))
            {
                labelFormat.Text = "구문 오류";
            }
        }
    }
}
