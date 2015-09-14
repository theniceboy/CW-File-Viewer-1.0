namespace CW_File_Viewer_1._0
{
    partial class ffile
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ffile));
            this.viewfile = new System.Windows.Forms.Button();
            this.filev = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lrcv = new System.Windows.Forms.TextBox();
            this.folderbroser = new System.Windows.Forms.FolderBrowserDialog();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.sfpath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // viewfile
            // 
            resources.ApplyResources(this.viewfile, "viewfile");
            this.viewfile.Name = "viewfile";
            this.viewfile.UseVisualStyleBackColor = true;
            this.viewfile.Click += new System.EventHandler(this.button1_Click);
            // 
            // filev
            // 
            resources.ApplyResources(this.filev, "filev");
            this.filev.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.filev.Name = "filev";
            this.filev.UseCompatibleStateImageBehavior = false;
            this.filev.View = System.Windows.Forms.View.Details;
            this.filev.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // lrcv
            // 
            resources.ApplyResources(this.lrcv, "lrcv");
            this.lrcv.Name = "lrcv";
            // 
            // folderbroser
            // 
            resources.ApplyResources(this.folderbroser, "folderbroser");
            // 
            // player
            // 
            resources.ApplyResources(this.player, "player");
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.UseWaitCursor = true;
            this.player.Enter += new System.EventHandler(this.player_Enter);
            // 
            // sfpath
            // 
            resources.ApplyResources(this.sfpath, "sfpath");
            this.sfpath.Name = "sfpath";
            // 
            // ffile
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sfpath);
            this.Controls.Add(this.player);
            this.Controls.Add(this.lrcv);
            this.Controls.Add(this.filev);
            this.Controls.Add(this.viewfile);
            this.Name = "ffile";
            this.Load += new System.EventHandler(this.ffile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewfile;
        private System.Windows.Forms.ListView filev;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox lrcv;
        private System.Windows.Forms.FolderBrowserDialog folderbroser;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Label sfpath;
    }
}

