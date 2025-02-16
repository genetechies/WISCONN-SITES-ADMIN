using System;
using System.Collections.Generic;
using System.Text;

namespace CommonFunc
{
    public class ClassCode
    {
        #region 加1并补零函数[补至八位数]
        /// <summary>
        /// 加1并补零函数[补至八位数]
        /// </summary>
        /// <param name="_str">需要补位的数字</param>
        /// <returns></returns>
        public static string Plus1AndFillZero(string _str)
        {
            string ResultStr;
            int str = Convert.ToInt32(_str) + 1;
            if (str < 10)
            {
                ResultStr = "0000000" + str.ToString();
                return ResultStr;
            }
            else if (str < 100)
            {
                ResultStr = "000000" + str.ToString();
                return ResultStr;
            }
            else if (str < 1000)
            {
                ResultStr = "00000" + str.ToString();
                return ResultStr;
            }
            else if (str < 10000)
            {
                ResultStr = "0000" + str.ToString();
                return ResultStr;
            }
            else if (str < 100000)
            {
                ResultStr = "000" + str.ToString();
                return ResultStr;
            }
            else if (str < 1000000)
            {
                ResultStr = "00" + str.ToString();
                return ResultStr;
            }
            else if (str < 10000000)
            {
                ResultStr = "0" + str.ToString();
                return ResultStr;
            }
            else
            {
                ResultStr = str.ToString();
                return ResultStr;
            }
        }
        #endregion


        #region 创建类别的前缀符号
        /// <summary>
        /// 创建类别的前缀符号函数
        /// </summary>
        /// <param name="_ClassLevel">类别级别</param>
        /// <returns></returns>
        public static string CreateClassListItemPreSymbol(string _ClassLevel)
        {
            string Symbol = "|-";

            int n = Convert.ToInt32(_ClassLevel);
            for (int i = 0; i < n; i++)
            {
                Symbol += "----";
            }

            return Symbol;
        }
        #endregion


        #region 创建带前缀符号的类别名称
        /// <summary>
        /// 创建带前缀符号的类别名称
        /// </summary>
        /// <param name="_ItemText">类别名称</param>
        /// <param name="_ClassLevel">类别级别</param>
        /// <returns></returns>
        public static string CreateClassListItemText(string _ItemText, string _ClassLevel)
        {
            string ListItemText = CreateClassListItemPreSymbol(_ClassLevel) + _ItemText;
            return ListItemText;
        }
        #endregion


        #region 获取同级别的下一個类别标识码
        /// <summary>
        /// 获取同级别的下一個类别标识码
        /// </summary>
        /// <param name="_OriginalCode">原始类别标识码</param>
        /// <param name="_CodeLevel">类别级别</param>
        /// <returns></returns>
        public static string CreateNextClassCode(string _OriginalCode, string _CodeLevel)
        {
            string NextClassCode;
            int CodeLevel = Convert.ToInt32(_CodeLevel);

            if ((_OriginalCode.Length / 8) != CodeLevel)
            {
                throw new Exception("类别级别与类别长度不符");
            }
            else
            {
                string Code_Temp1 = _OriginalCode.Substring(0, (CodeLevel - 1) * 8);
                string Code_Temp2 = _OriginalCode.Substring((CodeLevel - 1) * 8);

                NextClassCode = Code_Temp1 + Plus1AndFillZero(Code_Temp2);
            }

            return NextClassCode;
        }
        #endregion


        #region 创建子类别首個类别标识码
        /// <summary>
        /// 创建子类别首個类别标识码
        /// </summary>
        /// <param name="_ParentClassCode">父类类别标识码</param>
        /// <returns></returns>
        public static string CreateChildClassCode(string _ParentClassCode)
        {
            return _ParentClassCode + "00000001";
        }
        #endregion
    }
}
