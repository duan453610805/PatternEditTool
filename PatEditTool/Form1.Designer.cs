namespace PatEditTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Btn_OpenFile = new System.Windows.Forms.Button();
            this.Failpath = new System.Windows.Forms.TextBox();
            this.filecontext = new System.Windows.Forms.RichTextBox();
            this.PinName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_run = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.cB_PatDataMode = new System.Windows.Forms.ComboBox();
            this.cb_TSB_Enable = new System.Windows.Forms.CheckBox();
            this.cb_TSB_Array = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_OpenFile
            // 
            this.Btn_OpenFile.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OpenFile.Location = new System.Drawing.Point(14, 37);
            this.Btn_OpenFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_OpenFile.Name = "Btn_OpenFile";
            this.Btn_OpenFile.Size = new System.Drawing.Size(120, 30);
            this.Btn_OpenFile.TabIndex = 0;
            this.Btn_OpenFile.Text = "OpenFolder";
            this.Btn_OpenFile.UseVisualStyleBackColor = true;
            this.Btn_OpenFile.Click += new System.EventHandler(this.Btn_OpenFile_Click);
            // 
            // Failpath
            // 
            this.Failpath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Failpath.Location = new System.Drawing.Point(140, 43);
            this.Failpath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Failpath.Name = "Failpath";
            this.Failpath.Size = new System.Drawing.Size(1275, 23);
            this.Failpath.TabIndex = 1;
            // 
            // filecontext
            // 
            this.filecontext.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.filecontext.Location = new System.Drawing.Point(14, 170);
            this.filecontext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filecontext.Name = "filecontext";
            this.filecontext.ReadOnly = true;
            this.filecontext.Size = new System.Drawing.Size(1402, 683);
            this.filecontext.TabIndex = 2;
            this.filecontext.Text = "";
            this.filecontext.WordWrap = false;
            // 
            // PinName
            // 
            this.PinName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PinName.Location = new System.Drawing.Point(140, 85);
            this.PinName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PinName.Name = "PinName";
            this.PinName.Size = new System.Drawing.Size(96, 23);
            this.PinName.TabIndex = 3;
            this.PinName.Text = "SPI1_CLK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(22, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Edit Pin Name:";
            // 
            // Btn_run
            // 
            this.Btn_run.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_run.Location = new System.Drawing.Point(1232, 74);
            this.Btn_run.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_run.Name = "Btn_run";
            this.Btn_run.Size = new System.Drawing.Size(184, 88);
            this.Btn_run.TabIndex = 5;
            this.Btn_run.Text = "Run";
            this.Btn_run.UseVisualStyleBackColor = true;
            this.Btn_run.Click += new System.EventHandler(this.Btn_run_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1430, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(22, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Edit Pat Data:";
            // 
            // cB_PatDataMode
            // 
            this.cB_PatDataMode.FormattingEnabled = true;
            this.cB_PatDataMode.Items.AddRange(new object[] {
            "0-0-1-1",
            "0-1-0-1",
            "0-0-0-0",
            "1-1-1-1"});
            this.cB_PatDataMode.Location = new System.Drawing.Point(140, 122);
            this.cB_PatDataMode.Name = "cB_PatDataMode";
            this.cB_PatDataMode.Size = new System.Drawing.Size(96, 25);
            this.cB_PatDataMode.TabIndex = 8;
            this.cB_PatDataMode.Text = "0-0-1-1";
            this.cB_PatDataMode.TextChanged += new System.EventHandler(this.cB_PatDataMode_TextChanged);
            // 
            // cb_TSB_Enable
            // 
            this.cb_TSB_Enable.AutoSize = true;
            this.cb_TSB_Enable.Location = new System.Drawing.Point(282, 87);
            this.cb_TSB_Enable.Name = "cb_TSB_Enable";
            this.cb_TSB_Enable.Size = new System.Drawing.Size(92, 21);
            this.cb_TSB_Enable.TabIndex = 9;
            this.cb_TSB_Enable.Text = "TSB Enable";
            this.cb_TSB_Enable.UseVisualStyleBackColor = true;
            this.cb_TSB_Enable.CheckedChanged += new System.EventHandler(this.cb_TSB_Enable_CheckedChanged);
            // 
            // cb_TSB_Array
            // 
            this.cb_TSB_Array.Enabled = false;
            this.cb_TSB_Array.FormattingEnabled = true;
            this.cb_TSB_Array.Items.AddRange(new object[] {
            "gen_tp1",
            "gen_tp2",
            "gen_tp3",
            "clk_wave"});
            this.cb_TSB_Array.Location = new System.Drawing.Point(380, 83);
            this.cb_TSB_Array.Name = "cb_TSB_Array";
            this.cb_TSB_Array.Size = new System.Drawing.Size(96, 25);
            this.cb_TSB_Array.TabIndex = 10;
            this.cb_TSB_Array.Text = "gen_tp1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 871);
            this.Controls.Add(this.cb_TSB_Array);
            this.Controls.Add(this.cb_TSB_Enable);
            this.Controls.Add(this.cB_PatDataMode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_run);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PinName);
            this.Controls.Add(this.filecontext);
            this.Controls.Add(this.Failpath);
            this.Controls.Add(this.Btn_OpenFile);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "PatternEdit";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_OpenFile;
        private System.Windows.Forms.TextBox Failpath;
        private System.Windows.Forms.RichTextBox filecontext;
        private System.Windows.Forms.TextBox PinName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_run;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cB_PatDataMode;
        private System.Windows.Forms.CheckBox cb_TSB_Enable;
        private System.Windows.Forms.ComboBox cb_TSB_Array;
    }
}

