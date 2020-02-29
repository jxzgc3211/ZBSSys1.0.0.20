using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZBSSys
{
    public partial class FrmLoginSys : Form
    {
        public FrmLoginSys()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //退出系统
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //用户登录
            string userName = txtUserName.Text.Trim();
            string userPwd = txtPwd.Text.Trim();
            LoginUser user = new LoginUser();
            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(userPwd))
            {
                user.UserName = userName;
                user.UserPwd = userPwd;
            }
            else
            {
                lbMsg.Text = "用户名或密码不能为空！";
                return;
            }

            if (new UserLoginService().IsLoginUser(user))
            {
                //设置当前对话框窗体的结果
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                lbMsg.Text = "用户名或密码输入错误！";
            }
        }

        private void btnUpdatePwd_Click(object sender, EventArgs e)
        {
            FrmUpdateUserPwd uup = new FrmUpdateUserPwd();
            DialogResult dr = uup.ShowDialog();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            lbMsg.Text = "";
        }
    }
}
