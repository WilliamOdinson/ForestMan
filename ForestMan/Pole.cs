using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ForestMan
{
    /// <summary>
    /// 控制杆类，用于在游戏中控制某些操作的开关。
    /// </summary>
    internal class Pole
    { 
        /// <summary>
        /// 控制状态，用于指示控制杆的当前状态（例如：左或右）。
        /// </summary>
        public bool Ctrl; 

        /// <summary>
        /// 控制杆的矩形表示，包括位置和尺寸。
        /// </summary>
        public Rectangle Rectangle { get; set; }

        /// <summary>
        /// 构造函数，初始化控制杆的默认位置和状态。
        /// </summary>
        public Pole()
        {
            Rectangle = new Rectangle(235, 385, 28, 45);
            Ctrl = false;
        }

        /// <summary>
        /// 在图形界面上根据当前控制状态绘制控制杆。
        /// </summary>
        /// <param name="g">图形绘制上下文。</param>
        public void Draw(Graphics g)
        {
            // 如果控制状态为true，则绘制左向操作杆
            if (Ctrl)
                g.DrawImage(Properties.Resources.操作杆左向, Rectangle);
            // 如果控制状态为false，则绘制右向操作杆
            if (!Ctrl)
                g.DrawImage(Properties.Resources.操作杆右向, Rectangle);
        }

        /// <summary>
        /// 改变控制状态为true，表示激活或向左的操作，并更新控制杆的位置。
        /// </summary>
        public void ChangeCtrl()
        {
            Ctrl = true;
            Rectangle = new Rectangle(210, 385, 28, 43);
        }

        /// <summary>
        /// 改变控制状态为false，表示关闭或向右的操作，并恢复控制杆的位置。
        /// </summary>
        public void ChangeDegreeCtrl()
        {
            Ctrl = false;
            Rectangle = new Rectangle(235, 385, 28, 45);
        }
    }
}
