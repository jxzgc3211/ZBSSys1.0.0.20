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
    public partial class FrmUpdateUserPwd : Form
    {
        public FrmUpdateUserPwd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //封装用户
            string userName = txtUserName.Text.Trim();
            string userOldPwd = txtOldPwd.Text.Trim();
            string userNewPwd = txtNewPwd.Text.Trim();
            LoginUser user = new LoginUser();
            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(userOldPwd))
            {
                user.UserName = userName;
                user.UserPwd = userOldPwd;
            }
            else
            {
                lbMsg.Text = "用户名或密码不能为空！";
                return;
            }
            //判断用户是否存在
            UserLoginService uls = new UserLoginService();
            if (uls.UpdateUserPwd(user, userNewPwd))
            {
                //用户存在
                //修改密码成功
                MessageBox.Show("密码修改成功!");
            }
            else
            {
                lbMsg.Text = "用户名或密码错误！";
                //return;
            }
        }
    }
}
