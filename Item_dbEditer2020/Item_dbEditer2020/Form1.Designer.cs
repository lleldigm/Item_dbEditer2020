namespace Item_dbEditer2020
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
            this.panelItemList = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMainBase = new System.Windows.Forms.Panel();
            this.panelMainCard = new System.Windows.Forms.Panel();
            this.panelMainArrow = new System.Windows.Forms.Panel();
            this.panelMainValue = new System.Windows.Forms.Panel();
            this.panelMainDb2 = new System.Windows.Forms.Panel();
            this.panelMainScript = new System.Windows.Forms.Panel();
            this.panelMainBaseCommon = new System.Windows.Forms.Panel();
            this.panelMainBaseEquip = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.panelMainBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelItemList
            // 
            this.panelItemList.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelItemList.Location = new System.Drawing.Point(0, 0);
            this.panelItemList.Name = "panelItemList";
            this.panelItemList.Size = new System.Drawing.Size(213, 618);
            this.panelItemList.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelMainScript);
            this.panelMain.Controls.Add(this.panelMainDb2);
            this.panelMain.Controls.Add(this.panelMainValue);
            this.panelMain.Controls.Add(this.panelMainArrow);
            this.panelMain.Controls.Add(this.panelMainCard);
            this.panelMain.Controls.Add(this.panelMainBase);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(213, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(817, 618);
            this.panelMain.TabIndex = 1;
            // 
            // panelMainBase
            // 
            this.panelMainBase.Controls.Add(this.panelMainBaseEquip);
            this.panelMainBase.Controls.Add(this.panelMainBaseCommon);
            this.panelMainBase.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMainBase.Location = new System.Drawing.Point(0, 0);
            this.panelMainBase.Name = "panelMainBase";
            this.panelMainBase.Size = new System.Drawing.Size(200, 618);
            this.panelMainBase.TabIndex = 0;
            // 
            // panelMainCard
            // 
            this.panelMainCard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMainCard.Location = new System.Drawing.Point(200, 548);
            this.panelMainCard.Name = "panelMainCard";
            this.panelMainCard.Size = new System.Drawing.Size(617, 70);
            this.panelMainCard.TabIndex = 1;
            // 
            // panelMainArrow
            // 
            this.panelMainArrow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMainArrow.Location = new System.Drawing.Point(200, 475);
            this.panelMainArrow.Name = "panelMainArrow";
            this.panelMainArrow.Size = new System.Drawing.Size(617, 73);
            this.panelMainArrow.TabIndex = 2;
            // 
            // panelMainValue
            // 
            this.panelMainValue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMainValue.Location = new System.Drawing.Point(200, 285);
            this.panelMainValue.Name = "panelMainValue";
            this.panelMainValue.Size = new System.Drawing.Size(617, 190);
            this.panelMainValue.TabIndex = 3;
            // 
            // panelMainDb2
            // 
            this.panelMainDb2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMainDb2.Location = new System.Drawing.Point(200, 67);
            this.panelMainDb2.Name = "panelMainDb2";
            this.panelMainDb2.Size = new System.Drawing.Size(617, 218);
            this.panelMainDb2.TabIndex = 4;
            // 
            // panelMainScript
            // 
            this.panelMainScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainScript.Location = new System.Drawing.Point(200, 0);
            this.panelMainScript.Name = "panelMainScript";
            this.panelMainScript.Size = new System.Drawing.Size(617, 67);
            this.panelMainScript.TabIndex = 5;
            // 
            // panelMainBaseCommon
            // 
            this.panelMainBaseCommon.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainBaseCommon.Location = new System.Drawing.Point(0, 0);
            this.panelMainBaseCommon.Name = "panelMainBaseCommon";
            this.panelMainBaseCommon.Size = new System.Drawing.Size(200, 231);
            this.panelMainBaseCommon.TabIndex = 0;
            // 
            // panelMainBaseEquip
            // 
            this.panelMainBaseEquip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainBaseEquip.Location = new System.Drawing.Point(0, 231);
            this.panelMainBaseEquip.Name = "panelMainBaseEquip";
            this.panelMainBaseEquip.Size = new System.Drawing.Size(200, 387);
            this.panelMainBaseEquip.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 618);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelItemList);
            this.Name = "Form1";
            this.Text = "Item_db Editer 2020 for Auriga";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMainBase.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelItemList;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelMainScript;
        private System.Windows.Forms.Panel panelMainDb2;
        private System.Windows.Forms.Panel panelMainValue;
        private System.Windows.Forms.Panel panelMainArrow;
        private System.Windows.Forms.Panel panelMainCard;
        private System.Windows.Forms.Panel panelMainBase;
        private System.Windows.Forms.Panel panelMainBaseEquip;
        private System.Windows.Forms.Panel panelMainBaseCommon;
    }
}

