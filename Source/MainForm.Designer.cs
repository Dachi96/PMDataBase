
namespace PromptManager
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_ReadSQL = new System.Windows.Forms.Button();
            this.Label_Character = new System.Windows.Forms.Label();
            this.button_GeneratePrompt = new System.Windows.Forms.Button();
            this.textBox_PromptAll = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_ReadSQL
            // 
            this.button_ReadSQL.Location = new System.Drawing.Point(640, 415);
            this.button_ReadSQL.Name = "button_ReadSQL";
            this.button_ReadSQL.Size = new System.Drawing.Size(75, 23);
            this.button_ReadSQL.TabIndex = 1;
            this.button_ReadSQL.Text = "読込み(R)";
            this.button_ReadSQL.UseVisualStyleBackColor = true;
            this.button_ReadSQL.Click += new System.EventHandler(this.button_ReadSQL_Click);
            // 
            // Label_Character
            // 
            this.Label_Character.AutoSize = true;
            this.Label_Character.Location = new System.Drawing.Point(10, 10);
            this.Label_Character.Name = "Label_Character";
            this.Label_Character.Size = new System.Drawing.Size(29, 12);
            this.Label_Character.TabIndex = 2;
            this.Label_Character.Text = "人物";
            // 
            // button_GeneratePrompt
            // 
            this.button_GeneratePrompt.Location = new System.Drawing.Point(721, 415);
            this.button_GeneratePrompt.Name = "button_GeneratePrompt";
            this.button_GeneratePrompt.Size = new System.Drawing.Size(75, 23);
            this.button_GeneratePrompt.TabIndex = 3;
            this.button_GeneratePrompt.Text = "生成";
            this.button_GeneratePrompt.UseVisualStyleBackColor = true;
            this.button_GeneratePrompt.Click += new System.EventHandler(this.generatePrompt_Click);
            // 
            // textBox_PromptAll
            // 
            this.textBox_PromptAll.Location = new System.Drawing.Point(12, 415);
            this.textBox_PromptAll.Name = "textBox_PromptAll";
            this.textBox_PromptAll.Size = new System.Drawing.Size(622, 19);
            this.textBox_PromptAll.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "服装";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "表情";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "効果";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "構図";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(510, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "背景";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_PromptAll);
            this.Controls.Add(this.button_GeneratePrompt);
            this.Controls.Add(this.Label_Character);
            this.Controls.Add(this.button_ReadSQL);
            this.Name = "MainForm";
            this.Text = "PromptManger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_ReadSQL;
        private System.Windows.Forms.Label Label_Character;
        private System.Windows.Forms.Button button_GeneratePrompt;
        private System.Windows.Forms.TextBox textBox_PromptAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

