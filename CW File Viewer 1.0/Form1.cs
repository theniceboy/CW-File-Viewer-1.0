using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CW_File_Viewer_1._0
{
    public partial class ffile : Form
    {
        string fname;
        string fpath;
        string path;
        string last;
        public ffile()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.filev.SelectedItems.Count > 0)
            {
                fname = this.filev.SelectedItems[0].Text;
                path = fpath + '/' + fname;
                this.sfpath.Text = path;
                //last;
                last = Path.GetExtension(path);
                if(last==".lrc" || last==".txt" || last==".ini" || last==".dat")
                    lrcv.Text = System.IO.File.ReadAllText(path);
                if(last==".mp3")
                {
                    this.player.URL = path;
                }
                
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            filev.Items.Clear();
            if (folderbroser.ShowDialog() == DialogResult.OK)
            {
                folderbroser.SelectedPath = folderbroser.SelectedPath;
                fpath = folderbroser.SelectedPath;
                //实例化DirectoryInfo对象
                DirectoryInfo dinfo = new DirectoryInfo(fpath);
                //获取指定目录下的所有子目录及文件类型
                FileSystemInfo[] fsinfos = dinfo.GetFileSystemInfos();
                foreach (FileSystemInfo fsinfo in fsinfos)
                {
                    
                    if (fsinfo is DirectoryInfo)    //判断是否文件夹
                    {
                        //使用获取的文件夹名称实例化DirectoryInfo对象
                        DirectoryInfo dirinfo = new DirectoryInfo(fsinfo.FullName);
                        //为ListView控件添加文件夹信息
                        filev.Items.Add(dirinfo.Name);
                        filev.Items[filev.Items.Count - 1].SubItems.Add(dirinfo.FullName);
                        filev.Items[filev.Items.Count - 1].SubItems.Add("");
                        filev.Items[filev.Items.Count - 1].SubItems.Add(dirinfo.CreationTime.ToShortDateString());
                    }
                    else
                    {
                        //使用获取的文件名称实例化FileInfo对象
                        FileInfo finfo = new FileInfo(fsinfo.FullName);
                        //为ListView控件添加文件信息
                        filev.Items.Add(finfo.Name);
                        filev.Items[filev.Items.Count - 1].SubItems.Add(finfo.FullName);
                        filev.Items[filev.Items.Count - 1].SubItems.Add(finfo.Length.ToString());
                        filev.Items[filev.Items.Count - 1].SubItems.Add(finfo.CreationTime.ToShortDateString());
                    }
                }
            }
        }

        private void ffile_Load(object sender, EventArgs e)
        {
            filev.GridLines = true;
            //filev.FullRowSelect = true;
        }

        private void player_Enter(object sender, EventArgs e)
        {
            this.player.URL = path;
        }
    }
}
