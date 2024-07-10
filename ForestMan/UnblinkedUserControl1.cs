using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForestMan
{
    /// <summary>
    /// 自定义用户控件，通过双缓冲技术优化绘制，减少或消除界面刷新时的闪烁现象。
    /// </summary>
    public partial class UnblinkedUserControl1 : UserControl
    {
        /// <summary>
        /// 控件的构造函数，设置控件的样式以支持双缓冲，优化绘制性能。
        /// </summary>
        public UnblinkedUserControl1()
        {
            // 开启双缓冲技术，减少绘制时的闪烁
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            // 允许控件自行绘制，而非通过操作系统的绘制
            SetStyle(ControlStyles.UserPaint, true);

            // 在处理 WM_PAINT 消息时忽略窗口的背景擦除，减少闪烁
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            // 初始化控件的其他组件
            InitializeComponent();
        }
    }
}

