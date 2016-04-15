namespace AutoSaveMan
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.components = new System.ComponentModel.Container();
            this.reloadButton = new System.Windows.Forms.Button();
            this.processComboBox = new System.Windows.Forms.ComboBox();
            this.onOffButton = new System.Windows.Forms.Button();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.countDownFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.minLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.secLabel = new System.Windows.Forms.Label();
            this.CountDownTimer = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.countDownCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.countDownFlowLayoutPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reloadButton
            // 
            this.reloadButton.Location = new System.Drawing.Point(12, 12);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(75, 23);
            this.reloadButton.TabIndex = 0;
            this.reloadButton.Text = "更新";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // processComboBox
            // 
            this.processComboBox.FormattingEnabled = true;
            this.processComboBox.Location = new System.Drawing.Point(12, 41);
            this.processComboBox.Name = "processComboBox";
            this.processComboBox.Size = new System.Drawing.Size(506, 23);
            this.processComboBox.TabIndex = 1;
            // 
            // onOffButton
            // 
            this.onOffButton.Location = new System.Drawing.Point(12, 111);
            this.onOffButton.Name = "onOffButton";
            this.onOffButton.Size = new System.Drawing.Size(75, 23);
            this.onOffButton.TabIndex = 2;
            this.onOffButton.Text = "開始";
            this.onOffButton.UseVisualStyleBackColor = true;
            this.onOffButton.Click += new System.EventHandler(this.onOffButton_Click);
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(12, 83);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(100, 22);
            this.timeTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "分";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // countDownFlowLayoutPanel
            // 
            this.countDownFlowLayoutPanel.Controls.Add(this.minLabel);
            this.countDownFlowLayoutPanel.Controls.Add(this.label2);
            this.countDownFlowLayoutPanel.Controls.Add(this.secLabel);
            this.countDownFlowLayoutPanel.Location = new System.Drawing.Point(12, 140);
            this.countDownFlowLayoutPanel.Name = "countDownFlowLayoutPanel";
            this.countDownFlowLayoutPanel.Size = new System.Drawing.Size(200, 100);
            this.countDownFlowLayoutPanel.TabIndex = 5;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("游ゴシック", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.minLabel.Location = new System.Drawing.Point(3, 0);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(55, 43);
            this.minLabel.TabIndex = 6;
            this.minLabel.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("游ゴシック", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(64, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 43);
            this.label2.TabIndex = 8;
            this.label2.Text = ":";
            // 
            // secLabel
            // 
            this.secLabel.AutoSize = true;
            this.secLabel.Font = new System.Drawing.Font("游ゴシック", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.secLabel.Location = new System.Drawing.Point(98, 0);
            this.secLabel.Name = "secLabel";
            this.secLabel.Size = new System.Drawing.Size(55, 43);
            this.secLabel.TabIndex = 7;
            this.secLabel.Text = "00";
            // 
            // CountDownTimer
            // 
            this.CountDownTimer.Interval = 1000;
            this.CountDownTimer.Tick += new System.EventHandler(this.CountDownTimer_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.countDownCheckBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(218, 140);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // countDownCheckBox
            // 
            this.countDownCheckBox.AutoSize = true;
            this.countDownCheckBox.Location = new System.Drawing.Point(3, 3);
            this.countDownCheckBox.Name = "countDownCheckBox";
            this.countDownCheckBox.Size = new System.Drawing.Size(171, 34);
            this.countDownCheckBox.TabIndex = 8;
            this.countDownCheckBox.Text = "保存までの\r\nカウントダウンを表示する";
            this.countDownCheckBox.UseVisualStyleBackColor = true;
            this.countDownCheckBox.CheckedChanged += new System.EventHandler(this.countDownCheckBox_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 280);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.countDownFlowLayoutPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.onOffButton);
            this.Controls.Add(this.processComboBox);
            this.Controls.Add(this.reloadButton);
            this.Name = "Form1";
            this.Text = "自動でCtrl+S押す奴";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.countDownFlowLayoutPanel.ResumeLayout(false);
            this.countDownFlowLayoutPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.ComboBox processComboBox;
        private System.Windows.Forms.Button onOffButton;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel countDownFlowLayoutPanel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label secLabel;
        private System.Windows.Forms.Timer CountDownTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox countDownCheckBox;
        private System.Windows.Forms.Button button1;
    }
}

