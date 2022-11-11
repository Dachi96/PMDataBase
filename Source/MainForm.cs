﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PromptManager
{
    public partial class MainForm : Form
    {
        // フォーム呼び出し状態
        private bool called = false;

        // 追加したコンポーネント数
        private int addCompornents = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button_ReadSQL_Click(object sender, EventArgs e)
        {
            if (this.called == true)
            {
                MessageBox.Show("すでに表示されています");
                return;
            }

            // コントロール生成
            // Charcterテーブル
            foreach (var cTbl in MyDataBase.CharacterTbl)
            {
                CheckBox cbx = new CheckBox();
                cbx.Name = cTbl.name_e;
                cbx.Text = cTbl.name_j;

                // サイズと配置
                cbx.Size = new Size(100, 20);
                cbx.Location = new Point(10, 32 + addCompornents * 22);

                // フォームへの追加
                this.Controls.Add(cbx);

                addCompornents++;
            }
            addCompornents = 0;

            // Backgrondテーブル
            foreach (var bTbl in MyDataBase.BackgroundTbl)
            {
                CheckBox cbx = new CheckBox();
                cbx.Name = bTbl.name_e;
                cbx.Text = bTbl.name_j;

                // サイズと配置
                cbx.Size = new Size(100, 20);
                cbx.Location = new Point(110, 32 + addCompornents * 22);

                // フォームへの追加
                this.Controls.Add(cbx);

                addCompornents++;
            }
            addCompornents = 0;

            // ※テーブル追加した場合は、ここに処理を追加

            // フォームが呼び出された状態
            this.called = true;
        }

        private void generatePrompt_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            // 動的に生成したフォーム上のコントロールを、識別名で探す
            // Characterテーブル
            foreach (var cTbl in MyDataBase.CharacterTbl)
            {
                Control[] cmpnntCtls = this.Controls.Find(cTbl.name_e, false);

                CheckBox cbx = (CheckBox)cmpnntCtls[0];
                if (cbx.Checked)
                {
                    sb.Append(cTbl.name_e);
                    sb.Append(",");
                }
            }
            // Backgrondテーブル
            foreach (var bTbl in MyDataBase.BackgroundTbl)
            {
                Control[] cmpnntCtls = this.Controls.Find(bTbl.name_e, false);

                CheckBox cbx = (CheckBox)cmpnntCtls[0];
                if (cbx.Checked)
                {
                    sb.Append(bTbl.name_e);
                    sb.Append(",");
                }
            }

            // ※テーブル追加した場合は、ここに処理を追加

            // メッセージを表示する
            textBox_PromptAll.Text = sb.ToString();
        }
    }
}
