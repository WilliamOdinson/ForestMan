using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ForestMan
{
    /// <summary>
    /// 定义Box类，表示一个具有物理属性（如速度）的盒子，模拟类似于冰火人的物理行为。
    /// </summary>
    internal class Box
    {
        /// <summary>
        /// 盒子的矩形表示，包含位置和尺寸信息。
        /// </summary>
        public Rectangle Rectangle { get; set; }

        /// <summary>
        /// 盒子的水平速度。
        /// </summary>
        public int SpeedX;

        /// <summary>
        /// 盒子的垂直速度。
        /// </summary>
        public int SpeedY;

        /// <summary>
        /// 盒子的高度，默认为30。
        /// </summary>
        public int Height = 30;

        /// <summary>
        /// 盒子的宽度，默认为30。
        /// </summary>
        public int Width = 30;

        /// <summary>
        /// 构造函数，初始化盒子的默认状态。
        /// </summary>
        public Box()
        {
            Rectangle = new Rectangle(520, 160, Width, Height);
            SpeedX = 0;
            SpeedY = 20;
        }

        /// <summary>
        /// 在图形界面上绘制盒子。
        /// </summary>
        /// <param name="g">图形绘制上下文。</param>
        public void Draw(Graphics g)
        {
            g.DrawImage(Properties.Resources.箱子, Rectangle);
        }

        /// <summary>
        /// 计算并获取盒子因重力而下移一个单位后的新位置。
        /// </summary>
        /// <returns>新的矩形位置。</returns>
        public Rectangle NextYRectangle()
        {
            Rectangle rect = new Rectangle(Rectangle.X, Rectangle.Y + 1, Width, Height);
            return rect;
        }

        /// <summary>
        /// 根据水平速度计算盒子的下一个水平位置。
        /// </summary>
        /// <returns>新的矩形位置。</returns>
        public Rectangle NextXRectangle()
        {
            if (SpeedX > 0)
            {
                Rectangle rect = new Rectangle(Rectangle.X + 1, Rectangle.Y, Width, Height);
                return rect;
            }
            if (SpeedX < 0)
            {
                Rectangle rect = new Rectangle(Rectangle.X - 1, Rectangle.Y, Width, Height);
                return rect;
            }
            else
            {
                Rectangle rect = new Rectangle(Rectangle.X, Rectangle.Y, Width, Height);
                return rect;
            }
        }

        /// <summary>
        /// 根据垂直速度改变盒子的Y坐标。
        /// </summary>
        public void MoveY()
        {
            Rectangle = new Rectangle(Rectangle.X, Rectangle.Y + 1, Width, Height);
        }

        /// <summary>
        /// 根据水平速度改变盒子的X坐标。
        /// </summary>
        public void MoveX()
        {
            if (SpeedX > 0)
            {
                Rectangle = new Rectangle(Rectangle.X + 1, Rectangle.Y, Width, Height);
            }
            if (SpeedX < 0)
            {
                Rectangle = new Rectangle(Rectangle.X - 1, Rectangle.Y, Width, Height);
            }
        }

        /// <summary>
        /// 增加盒子的水平速度。
        /// </summary>
        public void ChangeSpeedX()
        {
            SpeedX = 5;
        }

        /// <summary>
        /// 减少盒子的水平速度。
        /// </summary>
        public void ChangeDegreeSpeedX()
        {
            SpeedX = -5;
        }

        /// <summary>
        /// 将盒子的水平速度设为零。
        /// </summary>
        public void ChangeZeroSpeedX()
        {
            SpeedX = 0;
        }
    }
}
