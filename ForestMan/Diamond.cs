using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestMan
{   
    /// <summary>
    /// 钻石类，用于表示游戏中的钻石对象。
    /// </summary>
    internal class Diamond
    {
        /// <summary>
        /// 钻石的类型：true表示火钻石，false表示冰钻石。
        /// </summary>
        public bool Type;

        /// <summary>
        /// 钻石是否已被吃掉。
        /// </summary>
        public bool Eat;

        /// <summary>
        /// 钻石的矩形位置和尺寸。
        /// </summary>
        public Rectangle Rectangle { get; set; }

        /// <summary>
        /// 钻石类的构造函数。
        /// </summary>
        /// <param name="rec">定义钻石位置和尺寸的矩形。</param>
        /// <param name="type">钻石的类型，true为火钻石，false为冰钻石。</param>
        public Diamond(Rectangle rec, bool type)
        {
            Rectangle = rec;
            Eat = false;
            Type = type;
        }

        /// <summary>
        /// 在图形界面上绘制钻石，根据类型选择不同的图像，并且只在未被吃掉时绘制。
        /// </summary>
        /// <param name="g">图形绘制上下文。</param>
        public void Draw(Graphics g)
        {
            if (!Eat)
            {
                if (Type)
                {
                    g.DrawImage(Properties.Resources.火钻, Rectangle);
                }
                else
                {
                    g.DrawImage(Properties.Resources.冰钻, Rectangle);
                }
            }
        }
    }
}
