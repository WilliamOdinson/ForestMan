using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ForestMan.Game;
using System.Media;
using System.Threading;
using System.Runtime.InteropServices;

namespace ForestMan
{
    public partial class frmMain : Form
    {
        private Game game; // 定义一个游戏对象

        /// <summary>
        /// 构造函数，初始化窗体组件。
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 游戏区域加载时的处理程序，创建游戏实例并绑定游戏状态改变事件。
        /// </summary>
        private void gameArea_Load(object sender, EventArgs e)
        {   
            game = new Game();
            game.gameChanged += GameChanged;
        }

        /// <summary>
        /// 游戏状态改变时触发的方法，处理游戏逻辑更新。
        /// </summary>
        private void GameChanged()
        {
            if (game != null)
            {
                JudgeGameOver();
                game.ChangePosition();
                game.ChangeBoxSpeed();
                game.ChangePoleStatus();
                game.EatDiamonds();
                game.ChangeButtonStatus();
                game.ChangeBoxPosition();
                game.SpeedChange();
                gameArea.Invalidate(); // 重新绘制游戏区域
            }
        }

        /// <summary>
        /// 绘制游戏区域，将游戏内容绘制到界面上。
        /// </summary>
        private void gameArea_Paint(object sender, PaintEventArgs e)
        {
            game.Draw(e.Graphics, this.gameArea.Size);
        }

        /// <summary>
        /// 处理按键按下事件，转发到游戏逻辑。
        /// </summary>
        private void gameArea_KeyDown(object sender, KeyEventArgs e)
        {
            game.keyDown(e.KeyCode.ToString());
        }

        /// <summary>
        /// 处理按键释放事件，转发到游戏逻辑。
        /// </summary>
        private void gameArea_KeyUp(object sender, KeyEventArgs e)
        {
            game.keyUp(e.KeyCode.ToString());
        }

        /// <summary>
        /// 判断游戏是否结束，并处理游戏结束后的逻辑。
        /// </summary>
        private void JudgeGameOver()
        {
            if (game != null)
            {  
                if (game.Dead2) // 判断是否失败
                {
                    game.bgm.Stop();
                    game.Timer.Stop();
                    MessageBox.Show("Game Over! You Died!");
                    game = new Game(); // 重新开始游戏
                    game.gameChanged += GameChanged;
                }
                if (game.Win2) // 判断是否胜利
                {
                    game.bgm.Stop();
                    game.Timer.Stop();
                    MessageBox.Show("Game Over! You Win!");
                    game = new Game(); // 重新开始游戏
                    game.gameChanged += GameChanged;
                }
            }
        }

        /// <summary>
        /// 新游戏按钮点击事件，重置游戏状态。
        /// </summary>
        private void newGame_Click(object sender, EventArgs e)
        {
            if (game != null)
            {
                game.Timer.Stop();
                game.gameChanged -= GameChanged;
            }
            Thread.Sleep(1000); // 等待一秒
            game = new Game();
            game.gameChanged += GameChanged;
        }

        /// <summary>
        /// 返回主菜单按钮的点击事件。
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Entry entry = new Entry();
            entry.ShowDialog();
            this.Close();
        }
    }
}
