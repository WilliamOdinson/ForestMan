using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestMan
{
    /// <summary>
    /// 砖块类：用于表示游戏中的基础砖块。
    /// </summary>
    internal class Block
    {
        // 矩形属性，定义砖块的位置和大小。
        public Rectangle Rectangle { get; set; }

        // 构造函数，初始化砖块的矩形。
        public Block(Rectangle rec)
        {
            Rectangle = rec;
        }

        // 绘制方法，使用黑色笔触绘制矩形。
        public void Draw(Graphics g)
        {
            g.DrawRectangle(new Pen(Color.Black), Rectangle);
        }
    }

    /// <summary>
    /// 建立火池的类：用于游戏中表示火元素的区域。
    /// </summary>
    internal class FireBlock
    {
        // 矩形属性，定义火池的位置和大小。
        public Rectangle Rectangle { get; set; }

        // 构造函数，指定火池的位置和大小。
        public FireBlock()
        {
            Rectangle = new Rectangle(463, 581, 115, 12);
        }
    }

    /// <summary>
    /// 建立水池的类：用于游戏中表示水元素的区域。
    /// </summary>
    internal class IceBlock
    {
        // 矩形属性，定义水池的位置和大小。
        public Rectangle Rectangle { get; set; }

        // 构造函数，指定水池的位置和大小。
        public IceBlock()
        {
            Rectangle = new Rectangle(664, 581, 115, 12);
        }
    }

    /// <summary>
    /// 建立毒池的类：用于游戏中表示毒素区域。
    /// </summary>
    internal class PoisionBlock
    {
        // 矩形属性，定义毒池的位置和大小。
        public Rectangle Rectangle { get; set; }

        // 构造函数，指定毒池的位置和大小。
        public PoisionBlock()
        {
            Rectangle = new Rectangle(612, 455, 115, 12);
        }
    }

    /// <summary>
    /// 建立胜利之门类：用于游戏中表示玩家可以通过以赢得游戏的门。
    /// </summary>
    internal class BulandDarwaza
    {
        // 矩形属性1，定义一个门的位置和大小。
        public Rectangle Rectangle1 { get; set; }

        // 矩形属性2，定义另一个门的位置和大小。
        public Rectangle Rectangle2 { get; set; }

        // 构造函数，指定两个门的位置和大小。
        public BulandDarwaza()
        {
            Rectangle1 = new Rectangle(810, 60, 70, 60);
            Rectangle2 = new Rectangle(900, 60, 70, 60);
        }
    }
}
