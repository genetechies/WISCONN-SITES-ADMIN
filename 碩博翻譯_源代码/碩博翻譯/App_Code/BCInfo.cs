using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Xml;

/// <summary>
/// Summary description for BCInfo
/// </summary>
public class BCInfo
{
    public BCInfo()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public class RssUtil
    {
        /// <summary>
        /// 生成RSS源
        /// </summary>
        /// <param name="channel">频道信息</param>
        /// <param name="items">RSS内容集合</param>
        public static void WriteRSS(RssChannel channel, List<RssItem> items)
        {
            XmlDocument domDoc = new XmlDocument();
            XmlDeclaration nodeDeclar = domDoc.CreateXmlDeclaration("1.0", System.Text.Encoding.UTF8.BodyName, "");
            domDoc.AppendChild(nodeDeclar);
            //如果rss有样式表文件的话，加上这两句
            //XmlProcessingInstruction nodeStylesheet = domDoc.CreateProcessingInstruction("xml-stylesheet", "type=\"text/css\" href=\"rss.css\"");
            //domDoc.AppendChild(nodeStylesheet);
            XmlElement root = domDoc.CreateElement("rss");
            root.SetAttribute("version", "2.0");  //添加属性结点
            domDoc.AppendChild(root);

            //创建Channel信息
            XmlElement chnode = domDoc.CreateElement("channel");
            root.AppendChild(chnode);

            XmlElement element = domDoc.CreateElement("title");
            XmlNode textNode = domDoc.CreateTextNode(channel.Title);    //文本结点
            element.AppendChild(textNode);
            chnode.AppendChild(element);

            element = domDoc.CreateElement("link");
            textNode = domDoc.CreateTextNode(channel.Link);
            element.AppendChild(textNode);
            chnode.AppendChild(element);

            element = domDoc.CreateElement("description"); //引用结点
            XmlNode cDataNode = domDoc.CreateCDataSection(channel.Description);
            element.AppendChild(cDataNode);
            chnode.AppendChild(element);

            //创建项目信息

            foreach (RssItem item in items)
            {
                XmlElement itemNode = domDoc.CreateElement("item");

                element = domDoc.CreateElement("title");
                textNode = domDoc.CreateTextNode(item.Title);    //文本结点
                element.AppendChild(textNode);
                itemNode.AppendChild(element);

                element = domDoc.CreateElement("link");
                textNode = domDoc.CreateTextNode(item.Link);    //文本结点
                element.AppendChild(textNode);
                itemNode.AppendChild(element);

                element = domDoc.CreateElement("description");
                textNode = domDoc.CreateTextNode(item.Description);    //文本结点
                element.AppendChild(textNode);
                itemNode.AppendChild(element);

                element = domDoc.CreateElement("pubDate");
                textNode = domDoc.CreateTextNode(item.PubDate == "" ? "" : Convert.ToDateTime(item.PubDate).ToString("yyyy年MM月dd HH:mm"));    //文本结点
                element.AppendChild(textNode);
                itemNode.AppendChild(element);

                element = domDoc.CreateElement("author");
                textNode = domDoc.CreateTextNode(item.Author);    //文本结点
                element.AppendChild(textNode);
                itemNode.AppendChild(element);

                chnode.AppendChild(itemNode);

            }
            //输出//HttpContext.Current.Response.OutputStream
            XmlTextWriter objTextWrite = new XmlTextWriter(HttpContext.Current.Server.MapPath(".") + "\\rss.xml", System.Text.Encoding.UTF8);
            domDoc.WriteTo(objTextWrite);
            objTextWrite.Flush();
            objTextWrite.Close();
            HttpContext.Current.Response.Redirect("rss.xml");
            HttpContext.Current.Response.End();
        }
    }

    /// <summary>
    /// RSS 项目数据
    /// </summary>
    public class RssItem
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }


        private string link;

        public string Link
        {
            get { return link; }
            set { link = value; }
        }


        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }


        private string pubDate;

        public string PubDate
        {
            get { return pubDate; }
            set { pubDate = value; }
        }


        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
    }

    /// <summary>
    /// RSS 频道数据
    /// </summary>
    public class RssChannel
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }


        private string link;

        public string Link
        {
            get { return link; }
            set { link = value; }
        }


        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
