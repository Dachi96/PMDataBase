# PMDataBase

* MySQL(5.7)
* .NET Framework 4.7.2

## プロジェクトのインポート手順
1. Windows Form Application(.NET Framework)の新規プロジェクトを作成する。
2. Source以下のファイルを、プロジェクトにインポートし、初期ファイルを削除する(Form1,Program)
3. MySQLをリンクさせる
4. ビルド⇒実行

### VisualStudioの環境でMySQLを使用するための方法

* プロパティ->参照で、"MySql.Data"を追加する
    - C:\Program Files (x86)\MySQL\Connector NET 8.0\Assemblies\v4.8\MySql.Data.dll

* NuGetでMySqlのパッケージをソリューションにインストールする。
    - MySql.Dataのパッケージ
    - これだけでいいかも?(未検証)
