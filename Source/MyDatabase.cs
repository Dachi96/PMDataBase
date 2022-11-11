using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PromptManager
{
    public class MyTblRecord
    {
        public string name_j { get; set; }
        public string name_e { get; set; }
    }


    static class MyDataBase
    {
        private static string connectionString {get; set;}
        // テーブルの定義
        // Characterテーブル
        public static List<MyTblRecord> CharacterTbl { get; set; }

        public static int CharacterRecordNum { get; set; }

        // Backgroundテーブル
        public static List<MyTblRecord> BackgroundTbl { get; set; }

        public static int BackgroundRecordNum { get; set; }

        // ※テーブル追加はここへ


        /// <summary>
        /// アプリケーションのメイン エントリ ポイント
        /// </summary>

        [STAThread]
        static void Main()
        {
            // MySqlConnectionの設定(※パスワードはハードコーディングすること)
            string server = "127.0.0.1";
            string user = "root";
            string pass = "S8GM1U9u";
            string database = "test1";
            connectionString = string.Format("server={0};user id={1};password={2};database={3}", server, user, pass, database);

            // テーブルの初期化
            // Characterテーブル
            MyDataBase.CharacterTbl = new List<MyTblRecord>();
            // Backgroundテーブル
            MyDataBase.BackgroundTbl = new List<MyTblRecord>();

            // ※テーブル追加した場合は、ここに初期化処理を追加

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    // MySQLサーバーとの接続
                    conn.Open();

                    // SQLを実行
                    // Characterテーブル
                    MySqlCommand mstrCmd_ch = new MySqlCommand("SELECT name_j, name_e FROM characters", conn);
                    MySqlDataReader mstrData_ch = mstrCmd_ch.ExecuteReader();

                    while (mstrData_ch.Read())
                    {
                        // フィールドの読出し
                        MyTblRecord mtr = new MyTblRecord();
                        mtr.name_j = mstrData_ch.GetString(0);
                        mtr.name_e = mstrData_ch.GetString(1);

                        // レコードの追加
                        MyDataBase.CharacterTbl.Add(mtr);
                    }
                }

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    // MySQLサーバーとの接続
                    conn.Open();

                    // Backgroundテーブル
                    MySqlCommand mstrCmd_bg = new MySqlCommand("SELECT name_j, name_e FROM backgrounds", conn);
                    MySqlDataReader mstrData_bg = mstrCmd_bg.ExecuteReader();

                    while (mstrData_bg.Read())
                    {
                        // フィールドの読出し
                        MyTblRecord mtr = new MyTblRecord();
                        mtr.name_j = mstrData_bg.GetString(0);
                        mtr.name_e = mstrData_bg.GetString(1);

                        // レコードの追加
                        MyDataBase.BackgroundTbl.Add(mtr);
                    }
                }
            }
            catch (MySqlException mse)
            {
                // MySqlの接続エラー処理をここに書く
                Console.WriteLine(mse.Message);
                MessageBox.Show("MySQLサービスが起動しているか、DB「manutest」がユーザー「test」で試験接続できるか確認してください", "MySQLエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 接続が成功したらフォームを開く
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
