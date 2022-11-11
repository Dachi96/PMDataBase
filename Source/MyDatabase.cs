using System;
using System.Data;
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
        public static List<MyTblRecord> CharacterTbl { get; set; }
        public static List<MyTblRecord> AttireTbl { get; set; }
        public static List<MyTblRecord> EmotionTbl { get; set; }
        public static List<MyTblRecord> EffectTbl { get; set; }
        public static List<MyTblRecord> PositionTbl { get; set; }
        public static List<MyTblRecord> BackgroundTbl { get; set; }


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

            // データベースから読み出し
            DataTable characterDataTbl = getTable("characters");
            DataTable attireDataTbl = getTable("attires");
            DataTable emotionDataTbl = getTable("emotions");
            DataTable effectDataTbl = getTable("effects");
            DataTable positionDataTbl = getTable("positions");
            DataTable backgroundDataTbl = getTable("backgrounds");
            


            // テーブル(ローカル)の初期化
            MyDataBase.CharacterTbl = new List<MyTblRecord>();
            MyDataBase.AttireTbl = new List<MyTblRecord>();
            MyDataBase.EmotionTbl = new List<MyTblRecord>();
            MyDataBase.EffectTbl = new List<MyTblRecord>();
            MyDataBase.PositionTbl = new List<MyTblRecord>();
            MyDataBase.BackgroundTbl = new List<MyTblRecord>();

            // テーブル(ローカル)へコピー
            foreach(DataRow cDTblRow in characterDataTbl.Rows)
            {
                MyTblRecord mtr = new MyTblRecord();
                mtr.name_j = (string)cDTblRow["name_j"];
                mtr.name_e = (string)cDTblRow["name_e"];
                CharacterTbl.Add(mtr);
            }

            foreach (DataRow aDTblRow in attireDataTbl.Rows)
            {
                MyTblRecord mtr = new MyTblRecord();
                mtr.name_j = (string)aDTblRow["name_j"];
                mtr.name_e = (string)aDTblRow["name_e"];
                AttireTbl.Add(mtr);
            }

            foreach (DataRow emDTblRow in emotionDataTbl.Rows)
            {
                MyTblRecord mtr = new MyTblRecord();
                mtr.name_j = (string)emDTblRow["name_j"];
                mtr.name_e = (string)emDTblRow["name_e"];
                EmotionTbl.Add(mtr);
            }

            foreach (DataRow efDTblRow in effectDataTbl.Rows)
            {
                MyTblRecord mtr = new MyTblRecord();
                mtr.name_j = (string)efDTblRow["name_j"];
                mtr.name_e = (string)efDTblRow["name_e"];
                EffectTbl.Add(mtr);
            }

            foreach (DataRow pDTblRow in positionDataTbl.Rows)
            {
                MyTblRecord mtr = new MyTblRecord();
                mtr.name_j = (string)pDTblRow["name_j"];
                mtr.name_e = (string)pDTblRow["name_e"];
                PositionTbl.Add(mtr);
            }

            foreach (DataRow bDTblRow in backgroundDataTbl.Rows)
            {
                MyTblRecord mtr = new MyTblRecord();
                mtr.name_j = (string)bDTblRow["name_j"];
                mtr.name_e = (string)bDTblRow["name_e"];
                BackgroundTbl.Add(mtr);
            }


            // 接続が成功したらフォームを開く
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public static DataTable getTable(string tableName)
        {
            DataTable tbl = new DataTable();
            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                try
                {
                    mySqlConnection.Open();
                    using (var command = mySqlConnection.CreateCommand())
                    {
                        command.CommandText = $"SELECT * FROM {tableName}";
                        using (var reader = command.ExecuteReader())
                        {
                            tbl.Load(reader);
                        }
                    }
                }
                catch (MySqlException mse)
                {
                    // MySqlの接続エラー処理をここに書く
                    Console.WriteLine(mse.Message);
                    MessageBox.Show("MySQLサービスが起動しているか、DB「manutest」がユーザー「test」で試験接続できるか確認してください", "MySQLエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return tbl;
        }
    }
}
