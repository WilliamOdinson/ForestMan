using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ForestMan
{
    /// <summary>
    /// Entry类，表示应用程序的入口窗体。
    /// </summary>
    public partial class Entry : Form
    {
        /// <summary>
        /// 背景音乐播放器。
        /// </summary>
        public SoundPlayer bgm = new SoundPlayer(Properties.Resources.bgm2);

        /// <summary>
        /// 构造函数，初始化窗体组件。
        /// </summary>
        public Entry()
        {
            InitializeComponent();
        }

        /// <summary>
        /// “开始游戏”按钮的点击事件处理。
        /// 停止背景音乐，隐藏当前窗体，显示主游戏窗体，关闭入口窗体。
        /// </summary>
        /// <param name="sender">事件发送者。</param>
        /// <param name="e">事件数据。</param>
        private void button1_Click(object sender, EventArgs e)
        {
            bgm.Stop(); // 停止播放背景音乐
            this.Hide(); // 隐藏当前窗体
            frmMain frm = new frmMain(); // 创建主游戏窗体的实例
            frm.ShowDialog(); // 显示主游戏窗体
            this.Close(); // 关闭当前窗体
        }

        /// <summary>
        /// 窗体加载时的事件处理。
        /// 自动开始循环播放背景音乐。
        /// </summary>
        /// <param name="sender">事件发送者。</param>
        /// <param name="e">事件数据。</param>
        private void Entry_Load(object sender, EventArgs e)
        {
            bgm.PlayLooping(); // 循环播放背景音乐
        }

        /// <summary>
        /// “关于我”按钮的点击事件处理。
        /// 显示关于窗体。
        /// </summary>
        /// <param name="sender">事件发送者。</param>
        /// <param name="e">事件数据。</param>
        private void aboutMe_Click(object sender, EventArgs e)
        {
            frmAboutMe aboutMe = new frmAboutMe(); // 创建关于窗体的实例
            aboutMe.ShowDialog(); // 显示关于窗体
        }
    }
}
