namespace TabControlPlusDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlPlus1 = new TabControlPlusDemo.TabControlPlus();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControlPlus1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPlus1
            // 
            this.tabControlPlus1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlPlus1.CloseButtonImage = null;
            this.tabControlPlus1.Controls.Add(this.tabPage1);
            this.tabControlPlus1.Controls.Add(this.tabPage2);
            this.tabControlPlus1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControlPlus1.ItemSize = new System.Drawing.Size(120, 24);
            this.tabControlPlus1.Location = new System.Drawing.Point(12, 12);
            this.tabControlPlus1.Name = "tabControlPlus1";
            this.tabControlPlus1.SelectedIndex = 0;
            this.tabControlPlus1.Size = new System.Drawing.Size(776, 426);
            this.tabControlPlus1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlPlus1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 394);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 68);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlPlus1);
            this.Name = "Form1";
            this.Text = "带关闭按钮的TabPage";
            this.tabControlPlus1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControlPlus tabControlPlus1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

