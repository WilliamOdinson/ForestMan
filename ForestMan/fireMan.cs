using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
namespace ForestMan
{
    /// <summary>
    /// 人类基类，定义了人物的基本属性和行为。
    /// </summary>
    internal class Man
    {
        // 定义人物的各种图片资源
        public Bitmap leftPicture;
        public Bitmap rightPicture;
        public Bitmap standPicture;
        public Bitmap leftPicture2;
        public Bitmap rightPicture2;
        public Bitmap jumpPicture;
        public Bitmap fallPicture;
        public Bitmap leftJumpPicture;
        public Bitmap rightJumpPicture;
        public Bitmap leftFallPicture;
        public Bitmap rightFallPicture;

        // 定义控制人物移动的按键
        public string leftKey;
        public string rightKey;
        public string upKey;

        // 定义人物的宽度和高度
        public int manWidth = 40;
        public int manHeight = 50;
        public bool picture; // 用于切换行走图像以实现动画效果
        public int SpeedX;   // 水平速度
        public int SpeedY;   // 垂直速度（用于模拟跳跃和下落）
        public Rectangle Rectangle { get; set; } // 人物在屏幕上的位置和大小

        public Man()
        {
            SpeedX = 0;
            SpeedY = 20;
            picture = false;
        }

        /// <summary>
        /// 绘制人物，根据人物的运动状态选择不同的图像。
        /// </summary>
        /// <param name="g">绘图图形上下文。</param>
        public void Draw(Graphics g)
        {
            // 根据速度和状态选择对应的图像进行绘制
            if (SpeedX == 0 && SpeedY == 20)
                g.DrawImage(standPicture, Rectangle);
            else if (SpeedX == 0 && SpeedY >= 0 && SpeedY < 20)
                g.DrawImage(fallPicture, Rectangle);
            else if (SpeedX == 0 && SpeedY < 0)
                g.DrawImage(jumpPicture, Rectangle);
            else if (SpeedX < 0 && SpeedY == 20 && picture == false)
            {
                picture = !picture;
                g.DrawImage(leftPicture, Rectangle);
            }
            else if (SpeedX < 0 && SpeedY == 20 && picture == true)
            {
                picture = !picture;
                g.DrawImage(leftPicture2, Rectangle);
            }
            else if (SpeedX > 0 && SpeedY == 20 && picture == false)
            {
                picture = !picture;
                g.DrawImage(rightPicture, Rectangle);
            }
            else if (SpeedX > 0 && SpeedY == 20 && picture == true)
            {
                picture = !picture;
                g.DrawImage(rightPicture2, Rectangle);
            }
            else if (SpeedX < 0 && SpeedY >= 0 && SpeedY < 20)
                g.DrawImage(leftFallPicture, Rectangle);
            else if (SpeedX > 0 && SpeedY >= 0 && SpeedY < 20)
                g.DrawImage(rightFallPicture, Rectangle);
            else if (SpeedX > 0 && SpeedY < 0)
                g.DrawImage(rightJumpPicture, Rectangle);
            else if (SpeedX < 0 && SpeedY < 0)
                g.DrawImage(leftJumpPicture, Rectangle);
        }

        /// <summary>
        /// 计算并返回人物下一帧在Y轴的位置。
        /// </summary>
        /// <returns>新的位置矩形。</returns>
        public Rectangle NextYRectangle()
        {
            if (SpeedY > 0)
            {
                return new Rectangle(Rectangle.X, Rectangle.Y + 1, manWidth, manHeight);
            }
            else
            {
                return new Rectangle(Rectangle.X, Rectangle.Y - 1, manWidth, manHeight);
            }
        }

        /// <summary>
        /// 计算并返回人物在X轴的下一个位置。
        /// </summary>
        /// <returns>新的位置矩形。</returns>
        public Rectangle NextXRectangle()
        {
            if (SpeedX > 0)
            {
                return new Rectangle(Rectangle.X + 1, Rectangle.Y, manWidth, manHeight);
            }
            else if (SpeedX < 0)
            {
                return new Rectangle(Rectangle.X - 1, Rectangle.Y, manWidth, manHeight);
            }
            else
            {
                return Rectangle;
            }
        }

        /// <summary>
        /// 根据按键输入改变人物的速度。
        /// </summary>
        /// <param name="key">按下的键。</param>
        public void keyDown(string key)
        {
            if (key == leftKey)
                SpeedX = -10;
            if (key == rightKey)
                SpeedX = 10;
            if (key == upKey && SpeedY == 20)
                SpeedY = -20;
        }

        /// <summary>
        /// 当按键释放时，如果是水平移动键，则水平速度归零。
        /// </summary>
        /// <param name="key">释放的键。</param>
        public void keyUp(string key)
        {
            if (key == leftKey || key == rightKey)
                SpeedX = 0;
        }

        /// <summary>
        /// 更新人物在Y轴上的位置，模拟重力效果。
        /// </summary>
        public void MoveY()
        {
            if (SpeedY > 0)
                Rectangle = new Rectangle(Rectangle.X, Rectangle.Y + 1, manWidth, manHeight);
            else
                Rectangle = new Rectangle(Rectangle.X, Rectangle.Y - 1, manWidth, manHeight);
        }

        /// <summary>
        /// 更新人物在X轴上的位置。
        /// </summary>
        public void MoveX()
        {
            if (SpeedX > 0)
                Rectangle = new Rectangle(Rectangle.X + 1, Rectangle.Y, manWidth, manHeight);
            else if (SpeedX < 0)
                Rectangle = new Rectangle(Rectangle.X - 1, Rectangle.Y, manWidth, manHeight);
        }

        /// <summary>
        /// 如果Y轴速度改变，逐渐恢复到初始速度。
        /// </summary>
        public void SpeedYChanged()
        {
            if (SpeedY < 20)
                SpeedY += 2;
        }
    }

    /// <summary>
    /// 火人类，继承自人类，具有特定的图像资源。
    /// </summary>
    internal class fireMan : Man
    {
        public fireMan()
        {
            // 初始化火人的位置和图像资源
            Rectangle = new Rectangle(100, 530, manWidth, manHeight);
            // 火人特有的图像资源，包括各种运动状态下的图像
            leftPicture = new Bitmap(Properties.Resources.火娃左跑);
            rightPicture = new Bitmap(Properties.Resources.火娃右跑);
            leftPicture2 = new Bitmap(Properties.Resources.火娃左跑2);
            rightPicture2 = new Bitmap(Properties.Resources.火娃右跑2);
            standPicture = new Bitmap(Properties.Resources.火娃站立);
            jumpPicture = new Bitmap(Properties.Resources.火娃上升);
            fallPicture = new Bitmap(Properties.Resources.火娃下落);
            leftJumpPicture = new Bitmap(Properties.Resources.火娃左上升);
            leftFallPicture = new Bitmap(Properties.Resources.火娃左下降);
            rightJumpPicture = new Bitmap(Properties.Resources.火娃右上升);
            rightFallPicture = new Bitmap(Properties.Resources.火娃右下降);
            // 定义火人的控制键
            leftKey = "Left";
            rightKey = "Right";
            upKey = "Up";
        }
    }

    /// <summary>
    /// 冰人类，继承自人类，具有特定的图像资源。
    /// </summary>
    internal class iceMan : Man
    {
        public iceMan()
        {
            // 初始化冰人的位置和图像资源
            Rectangle = new Rectangle(50, 530, manWidth, manHeight);
            // 冰人特有的图像资源，包括各种运动状态下的图像
            leftPicture = new Bitmap(Properties.Resources.冰娃左跑1);
            rightPicture = new Bitmap(Properties.Resources.冰娃右跑1);
            leftPicture2 = new Bitmap(Properties.Resources.冰娃左跑2);
            rightPicture2 = new Bitmap(Properties.Resources.冰娃右跑2);
            standPicture = new Bitmap(Properties.Resources.冰娃站立);
            jumpPicture = new Bitmap(Properties.Resources.冰娃上升);
            fallPicture = new Bitmap(Properties.Resources.冰娃下降);
            leftJumpPicture = new Bitmap(Properties.Resources.冰娃左上升);
            leftFallPicture = new Bitmap(Properties.Resources.冰娃左下降);
            rightJumpPicture = new Bitmap(Properties.Resources.冰娃右上升);
            rightFallPicture = new Bitmap(Properties.Resources.冰娃右下降);
            // 定义冰人的控制键
            leftKey = "A";
            rightKey = "D";
            upKey = "W";
        }
    }
}
