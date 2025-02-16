using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 黑名单
    /// </summary>
    [Serializable]
    public class Model_DisableIP
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int D_Id { get; set; }

        /// <summary>
        /// IP地址
        /// </summary>
        public string IPAddress { get; set; }

        /// <summary>
        /// 禁用时间
        /// </summary>
        public DateTime AddDate { get; set; }
    }
}
