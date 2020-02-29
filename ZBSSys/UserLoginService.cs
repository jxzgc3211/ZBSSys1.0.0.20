using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ZBSSys
{
    public class UserLoginService
    {
        /// <summary>
        /// 判断登录用户是否合法
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public Boolean IsLoginUser(LoginUser user)
        {
            Boolean flag;
            string userName = user.UserName;
            string userPwd = user.UserPwd;
            string sql = "select * from userLogin where userName=@userName and userPwd=@userPwd";
            SqlParameter[] parms =
            {
                new SqlParameter("@userName",userName),
                new SqlParameter("@userPwd",userPwd)
            };
            int tag = Convert.ToInt32(SqlHelper.ExecutScalar(sql, parms));

            if (tag > 0)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }

            return flag;
        }

        public Boolean UpdateUserPwd(LoginUser user, string newPwd)
        {
            Boolean flag;

            if (!IsLoginUser(user))
            {
                return false;
            }

            string sql = "update userLogin set userPwd=@newPwd where userName=@userName";
            SqlParameter[] paras ={
                    new SqlParameter("@newPwd",newPwd),
                    new SqlParameter("@userName",user.UserName)
                };
            int tag = Convert.ToInt32(SqlHelper.ExecuteNonQuery(sql, paras));

            if (tag > 0)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            return flag;
        }
    }
}
