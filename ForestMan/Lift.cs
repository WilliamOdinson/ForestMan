using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestMan
{
    /// <summary>
    /// 电梯类，用于表示和控制电梯的运动。
    /// </summary>
    internal class Lift
    {
        /// <summary>
        /// 计数器，用于控制电梯的运动次数。
        /// </summary>
        int count = 25;

        /// <summary>
        /// 电梯的矩形表示，包含位置和尺寸信息。
        /// </summary>
        public Rectangle Rectangle { get; set; }

        /// <summary>
        /// 构造函数，初始化电梯的位置。
        /// </summary>
        /// <param name="rec">表示电梯的矩形区域。</param>
        public Lift(Rectangle rec)
        {
            Rectangle = rec;
        }

        /// <summary>
        /// 在图形界面上绘制电梯。
        /// </summary>
        /// <param name="g">图形绘制上下文。</param>
        /// <param name="bitmap">用于绘制的位图资源。</param>
        public void Draw(Graphics g, Bitmap bitmap)
        {
            g.DrawImage(bitmap, Rectangle);
        }

        /// <summary>
        /// 控制电梯上升。每次上升减少矩形的Y坐标。
        /// </summary>
        public void Up()
        {
            if (count < 25)
            {
                Rectangle = new Rectangle(Rectangle.X, Rectangle.Y - 2, Rectangle.Width, Rectangle.Height);
                count++;
            }
        }

        /// <summary>
        /// 控制电梯下降。每次下降增加矩形的Y坐标。
        /// </summary>
        public void Down()
        {
            if (count > 0)
            {
                Rectangle = new Rectangle(Rectangle.X, Rectangle.Y + 2, Rectangle.Width, Rectangle.Height);
                count--;
            }
        }
    }
}
