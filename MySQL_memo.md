# MySQL (for Visual Studio)操作方法について

## 概要
&emsp;個人用メモ。Visual StudioでMySQLを使用する際に、基本的なデータベースの作成方法や、注意事項等をメモとして記録する。

* MySQL(v5.7)
* VisualStudio(2019)

## インストール方法
&emsp;下記を参照のこと。
[インストーラー](https://dev.mysql.com/downloads/windows/installer/5.7.html)
[インスト―ル手順](https://prog-8.com/docs/mysql-env-win)

## MySQLの基本的な使用方法(by コマンドプロンプト)

* 立ちあげと接続
    1.コマンドプロンプトを"管理者権限"で実行する。
    2.<b>"net start mysql57"</b>を実行し、MySQLを起動する。
    3.<b>"mysql --user=root --password"</b>を実行する。
    4.MySQLサーバーで設定したパスワードを入力し、管理者としてログインする。
    5.MySQLの接続に成功。おめでとう。

(ここから先は、MySQLにクエリを送信することでMySQLの操作を行う)
[MYSQLクエリの参考情報](https://26gram.com/mysql)
[Progate_MySQL(Mac)](https://prog-8.com/docs/mysql-database-setup)

* データベースの作成
    - <b>"CREATE DATBASE データベース名;"</b>を実行することで、データべ０スを作成することが可能

* データベースの参照
    - <b>"SHOW DATABASES;"</b>で、登録されているデータベースを確認可能。

* テーブルの作成
    - <b>"USE データベース名;"</b>で、テーブルを作成したいデータベースを選択する。
    - <b>"CREATE TABLE テーブル名(カラム名1 データタイプ1, カラム名2 データタイプ2, (...略), プライマリーキー ) DEFAULT CHARSET=utf8;"</b>で、テーブルの形式を決め、テーブルを作成する。
    - <em>(ex.) CREATE TABLE users (id INT AUTO_INCREMENT, name TEXT, PRIMARY KEY (id)) DEFAULT CHARSET=utf8;</em>
    - <b>"SHOW tables;"</b>で、選択しているデータベースに存在するテーブルを確認可能。
    - <b>"DESCRIBE テーブル名;"</b> でテーブルの中身(構造)を確認可能。
    - <b>"SELECT * FROM テーブル名;"</b> でテーブルの中身(全て)を確認可能。

* テーブルの削除
    - <b>"DROP TABLE テーブル名;"</b>で、テーブルを削除する。

* レコードの追加
    - <b>"INSERT INTO テーブル名 (フィールド名1, フィールド名2 ...(略)) VALUES ('データ1', 'データ2' ...(略));"</b>で、レコードを追加する。
    - 全てのフィールドが対象の場合は、フィールド名の指定を省略可能。
    - 複数レコードを追加する場合は、<b>"VALUES (1レコード目),(2レコード目),(3レコード目);"</b>の様な形で追加することが可能。

* レコードの削除
    - <b>"DELET FROM テーブル名 WHERE id = 数字;"</b>で、指定したidのレコードを削除する。
    - <b>"DELETE FROM テーブル名;"</b>で、全てのレコードを削除する。

* 切断と終了
    - <b>"EXIT;"で、MySQLからログアウトします。
    - <b>"net stop mysql57"で終了します。(※管理者権限でコマンドプロンプトを開いていないとアクセス拒否されるっぽい)
