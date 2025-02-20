﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Helper
{
    /// <summary>   

    /// MessageBox 的摘要说明   

    /// </summary>   

    public class MessageBox
    {

        public MessageBox()
        {

            //   

            // TODO: 在此处添加构造函数逻辑   

            //   

        }

        /// <summary>   

        /// 显示消息提示对话框   

        /// </summary>   

        /// <param name="page">当前页面指针，一般为this</param>   

        /// <param name="msg">提示信息</param>   

        public static void Show(System.Web.UI.Page page, string msg)
        {

            page.RegisterStartupScript("message", "<script language='javascript' defer>alert('" + msg.ToString() + "');</script>");

        }



        /// <summary>   

        /// 控件点击 消息确认提示框   

        /// </summary>   

        /// <param name="page">当前页面指针，一般为this</param>   

        /// <param name="msg">提示信息</param>   

        public static void ShowConfirm(System.Web.UI.WebControls.WebControl Control, string msg)
        {

            //Control.Attributes.Add("onClick","if (!window.confirm('"+msg+"')){return false;}");   

            Control.Attributes.Add("onclick", "return confirm('" + msg + "');");

        }



        /// <summary>   

        /// 显示消息提示对话框，并进行页面跳转   

        /// </summary>   

        /// <param name="page">当前页面指针，一般为this</param>   

        /// <param name="msg">提示信息</param>   

        /// <param name="url">跳转的目标URL</param>   

        public static void ShowAndRedirect(System.Web.UI.Page page, string msg, string url)
        {

            StringBuilder Builder = new StringBuilder();

            Builder.Append("<script language='javascript' defer>");

            Builder.AppendFormat("alert('{0}');", msg);

            Builder.AppendFormat("top.location.href='{0}'", url);

            Builder.Append("</script>");

            page.RegisterStartupScript("message", Builder.ToString());




        }

        /// <summary>   

        /// 输出自定义脚本信息   

        /// </summary>   

        /// <param name="page">当前页面指针，一般为this</param>   

        /// <param name="script">输出脚本</param>   

        public static void ResponseScript(System.Web.UI.Page page, string script)
        {

            page.RegisterStartupScript("message", "<script language='javascript' defer>" + script + "</script>");

        }

    }   
}
