using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // FileInfo
using System.Text.RegularExpressions; // 正規表現
using IniFileSharp; // INIファイル

namespace BracketConv
{
    public partial class FormMain : Form
    {
        private int ErrorNum = 0; // エラーの数
        private IniFile iniFile = new IniFile(); // INIファイル

        public FormMain()
        {
            InitializeComponent();
            
            textStatus.Text = "";

            // INIファイルの設定読み込み
            textInputFolder.Text   = iniFile.ReadString( "PATH",   "INPUT", "");
            textOutputFolder.Text  = iniFile.ReadString( "PATH",   "OUTPUT", "");
            textFilter.Text        = iniFile.ReadString( "OPTION", "FILTER", "*.cs");
            checkSubFolder.Checked = iniFile.ReadBoolean("OPTION", "SUBFOLDER", false);
        }

        // 終了時にINIファイルに設定保存
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            iniFile.WriteString ("PATH",   "INPUT",     textInputFolder.Text);
            iniFile.WriteString ("PATH",   "OUTPUT",    textOutputFolder.Text);
            iniFile.WriteString ("OPTION", "FILTER",    textFilter.Text);
            iniFile.WriteBoolean("OPTION", "SUBFOLDER", checkSubFolder.Checked);
        }

        // 入力フォルダの選択
        private void btnInputFolder_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            fbd.Description = "入力フォルダを指定してください。";
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            fbd.ShowNewFolderButton = false;
            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                textInputFolder.Text = fbd.SelectedPath;
            }
        }

        // 出力フォルダの選択
        private void btnOutputFolder_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            fbd.Description = "出力フォルダを指定してください。";
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            fbd.ShowNewFolderButton = true;
            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                textOutputFolder.Text = fbd.SelectedPath;
            }
        }
        
        // 変換処理
        private void btnConvert_Click(object sender, EventArgs e)
        {
            textStatus.Text = "処理を開始します。";
            ErrorNum = 0;

            // ファイル一覧を取得
            var di = new System.IO.DirectoryInfo(textInputFolder.Text);
            var option = checkSubFolder.Checked ? // サブフォルダも？
                SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            FileInfo[] files = di.GetFiles(textFilter.Text, option);

            // 変数名一覧を取得
            string[] varNames = textVarNames.Text.Split(
                new[] { Environment.NewLine }, StringSplitOptions.None);
            
            // 各々のファイルについて
            foreach(var file in files)
            {
                textStatus.Text = "処理中: " + file.Name;

                // 入力ファイル
                var sr = new StreamReader(
                    file.FullName,
                    Encoding.GetEncoding("UTF-8"));
                // 出力ファイル
                var sw = new StreamWriter(
                    textOutputFolder.Text + @"\" + file.Name,
                    false, // 新規作成 or 上書き
                    Encoding.GetEncoding("UTF-8"));

                // 1行ずつ読み込んで処理
                while (sr.Peek() > -1)
                {
                    string line = sr.ReadLine();

                    // 各々の変数名について
                    foreach (var varName in varNames)
                    {
                        // 括弧の置換 (1行の文字列, 括弧の前の変数名)
                        line = ConvertLine(line, varName);
                    }
                    sw.WriteLine(line);
                }
                //ファイルを閉じる
                sw.Close();
                sr.Close();
            }
            textStatus.Text = "";
            MessageBox.Show(
                files.Length.ToString() + "個のファイルを処理しました。\n" + 
                "エラー件数: " + ErrorNum.ToString());
        }

        // 括弧の置換 (1行の文字列, 括弧の前の変数名)
        private string ConvertLine(string line, string varName)
        {
            var sbLine = new StringBuilder(line);
            bool changed = false;

            // 単語検索(正規表現)で変数名を検索
            MatchCollection mc = Regex.Matches(line, String.Format(@"\b{0}\b", varName));

            // 検索結果すべてについて
            foreach (Match m in mc)
            {
                // 変数の直後の位置
                int pos = m.Index + varName.Length;

                // 変数の直後に ( があるか探して置換。
                int bracketPos = findOpeningBracket(sbLine, pos);
                if (bracketPos > 0)
                {
                    // 対応する ) を探して置換。
                    findClosingBracket(sbLine, pos);
                    changed = true;
                }
            }

            if (changed) {
                line = sbLine.ToString();
            }
            return line;
        }

        // 変数の直後に ( があるか探して置換 
        // sbLine: 1行の文字列
        // pos: 変数の直後の位置
        // return: ( の直後の位置　(見つからなかったら 0 を返す)
        private int findOpeningBracket(StringBuilder sbLine, int pos)
        {
            for (int i = pos; i < sbLine.Length; i++)
            {
                char c = sbLine[i];
                if (c == ' ' || c == '\t')
                {
                    // 空白は飛ばして次の文字へ
                }
                else if (c == '(')
                {
                    // ( があれば [ に置換して次の処理へ。位置は ( の直後から
                    sbLine[i] = '[';
                    return i + 1;
                }
                else
                {
                    // 変数名の次に ( が無い場合
                    return 0;
                }
            }
            // 行末まで空白しか無い場合
            return 0;
        }

        // 対応する ) を探して置換
        // sbLine: 1行の文字列
        // pos: ( の直後の位置
        private void findClosingBracket(StringBuilder sbLine, int pos)
        {
            int nest = 1;
            for (int i = pos; i < sbLine.Length; i++)
            {
                char c = sbLine[i];
                if (c == '(')
                {
                    // ( があればネスト段数をカウントアップ
                    nest++;
                }
                else if (c == ')')
                {
                    // ) があればネスト段数をカウントダウン
                    nest--;
                    if (nest == 0)
                    {
                        // 対応する ) があれば ] に置換して
                        // 変数の検索を再開
                        sbLine[i] = ']';
                        return;
                    }
                }
            }
            // 対応する ) が無い場合 (エラー)
            ErrorNum++;
            sbLine.Append(" <ERROR> 1行の中で閉じない括弧");
            return;
        }
    }
}
