using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Right
    {
        private int rightID;
        private string userName;
        private string pageName;
        private int right;

        public int RightID { get { return rightID; } set { rightID = value; } }
        public string UserName { get { return userName; } set { userName = value; } }
        public string PageName { get { return pageName; } set { pageName = value; } }
        public int Rights { get { return right; } set { right = value; } }

    }
}
