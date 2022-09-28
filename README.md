# BracketConv 括弧置換ツール ( )→[ ]

- ソースファイル中の特定の変数名の後の ( ) を [ ] に置換するツールです。
- Windows用のフォームアプリです。
- テキストエディタの正規表現置換では困難な、括弧の対応を正しく置換します。
- 入力ファイルはフォルダとフィルタで指定します。
- サブフォルダも検索できます。
- 変数名は複数指定できます。(変数名ごとに改行してください。)

## 注意
- 処理は行単位でおこなうので、行をまたぐ括弧の対応は正しく置換できません。
- その場合は「\<ERROR\> 1行の中で閉じない括弧」が出力ファイルに書き加えられます。
- エラーが発生したら置換終了後にエラー個数を表示します。
- コメントは認識しません。 コメント文も置換の対象になります。
- もしも括弧の対応の中にコメントがあったら正しく置換されません。
- 文字コードはUTF-8限定です。
- そこまで作りこんでないです。


