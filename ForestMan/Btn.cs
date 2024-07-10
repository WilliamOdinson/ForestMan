using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ForestMan
{
    /// <summary>
    /// 定义冰火娃踩的机关类，控制机关按钮的状态和显示。
    /// </summary>
    internal class Btn
    {
        /// <summary>
        /// 标识按钮是否被占用。
        /// </summary>
        public bool occupy;

        /// <summary>
        /// 按钮的矩形区域，定义其在游戏界面中的位置和尺寸。
        /// </summary>
        public Rectangle Rectangle { get; set; }

        /// <summary>
        /// 构造函数，初始化按钮的位置和占用状态。
        /// </summary>
        /// <param name="rec">按钮的初始矩形区域。</param>
        public Btn(Rectangle rec)
        {
            Rectangle = rec;
            occupy = false; // 初始状态为未被占用
        }

        /// <summary>
        /// 在图形界面上绘制按钮。如果按钮未被占用，则显示按钮图像。
        /// </summary>
        /// <param name="g">图形绘制上下文，用于在界面上绘图。</param>
        public void Draw(Graphics g)
        {
            if (!occupy)
            {
                g.DrawImage(Properties.Resources.按钮, Rectangle);
            }
        }
    }
}
