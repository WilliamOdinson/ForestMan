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
    /// frmAboutMe 表单类，用于展示关于我的信息。
    /// </summary>
    public partial class frmAboutMe : Form
    {
        /// <summary>
        /// 构造函数，初始化表单组件。
        /// </summary>
        public frmAboutMe()
        {
            // 初始化表单内的组件，这个方法通常是设计器自动生成的。
            InitializeComponent();
        }

        /// <summary>
        /// 表单加载时执行的事件处理程序。
        /// </summary>
        /// <param name="sender">事件的发送者。</param>
        /// <param name="e">事件的参数。</param>
        private void frmAboutMe_Load(object sender, EventArgs e)
        {
            // 这里可以添加在表单加载时需要执行的代码。
        }

        /// <summary>
        /// 关闭按钮点击事件处理程序。
        /// </summary>
        /// <param name="sender">事件的发送者，即关闭按钮。</param>
        /// <param name="e">事件的参数。</param>
        private void button1_Click(object sender, EventArgs e)
        {
            // 关闭当前表单。
            this.Close();
        }
    }
}
