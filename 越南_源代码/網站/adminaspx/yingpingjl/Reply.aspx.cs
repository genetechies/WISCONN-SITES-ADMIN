using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Helper;

namespace Web.Admin.GuestBook {
    public partial class Reply : System.Web.UI.Page {
        BLL.TranslatorList b = new BLL.TranslatorList();
        public Model.TranslatorList book = null;

        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                Helper.CommonFunction.IsAdmin();
                if (!Utils.IsRight(Session["Admin"].ToString(), "yingpin", RightStatus.Select))
                {
                //    ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');history.go(-1);", true);
                //    return;
                    MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
                }
                if (!string.IsNullOrEmpty(Request.QueryString["G_Id"])) {
                    book =b.GetModel(Convert.ToInt32(Request.QueryString["G_Id"]));
                    if (book != null)
                    {
                        //lblTitle.Text = book.G_Title;
                        //lblUserName.Text = book.G_Username;
                        //lblCompanyName.Text = book.G_CompanyName;
                        //lblTelphone.Text = book.G_Telphone;
                        //lblEmail.Text = book.G_Email;
                        //lblWebsite.Text = book.G_Website;
                        //lblAddress.Text = book.G_Address;
                        //lblCharge.Text = book.G_Charge;
                        //lblRuntime.Text = book.G_Runtime;
                        //lblIsFinish.Text = book.G_IsFinish == 0 ? "未處理" : "已處理";
                        //lblTime.Text = book.G_Datetime.ToString("yyyy-MM-dd HH:mm:ss");
                        //string sql = "select G_IpAddress from GuestBook where G_Id=" + Request.QueryString["G_Id"];
                        ///*
                        //State1 = 1,//Seo網站專用空間
                        //State2 = 1 << 1,//Seo專業網頁設計
                        //State3 = 1 << 2,//全球搜尋引擎登錄
                        //State4 = 1 << 3,//網站排名
                        //State5 = 1 << 4, //社群行銷
                        //State6 = 1 << 5,//論壇行銷
                        //State7 = 1 << 6, //部落格行銷
                        //State8 = 1 << 7,//專業行銷分析系統
                        // */
                        //string result =string.Empty;
                        //if (book.G_Items.IndexOf("1")>0) {
                        //    result = result + "Seo網站專用空間;";
                        //}
                        //if (book.G_Items.IndexOf("2")>0) {
                        //    result = result + "Seo專業網頁設計;";
                        //}
                        //if (book.G_Items.IndexOf("3") > 0)
                        //{
                        //    result = result + "全球搜尋引擎登錄;";
                        //}
                        //if (book.G_Items.IndexOf("4") > 0)
                        //{
                        //    result = result + "網站排名;";
                        //}
                        //if (book.G_Items.IndexOf("5") > 0)
                        //{
                        //    result = result + "社群行銷;";
                        //}
                        //if (book.G_Items.IndexOf("6") > 0)
                        //{
                        //    result = result + "論壇行銷;";
                        //}
                        //if (book.G_Items.IndexOf("7") > 0)
                        //{
                        //    result = result + "部落格行銷;";
                        //}
                        //if (book.G_Items.IndexOf("8") > 0)
                        //{
                        //    result = result + "專業行銷分析系統;";
                        //}
                        //lblItems.Text = result;
                        //ltlContent.Text = book.G_Content;
                        //lblIPAddress.Text = book.G_IpAddress;
                    }
                    else
                    {
                        MyTool.alertback("參數錯誤");
                    }

                }
            }
        }

        public string worktype(string str)
        {
            string[] arr = str.Split('|');
            string temp="";

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Trim() == "1")
                {
                    temp = temp + "筆譯,";
                }
                if (arr[i].Trim() == "2")
                {
                    temp = temp + "口譯,";
                }
                if (arr[i].Trim() == "3")
                {
                    temp = temp + "專有名詞,";
                }
                if (arr[i].Trim() == "4")
                {
                    temp = temp + "潤稿,";
                }
                if (arr[i].Trim() == "5")
                {
                    temp = temp + "排版,";
                }
            }

            return temp;
        }

        public string language(string str)
        {
            string[] arr = str.Split('|');
            string temp = "";

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Trim() == "1")
                {
                    temp = temp + "英文,";
                }
                if (arr[i].Trim() == "2")
                {
                    temp = temp + "日文,";
                }
                if (arr[i].Trim() == "3")
                {
                    temp = temp + "繁中,";
                }
                if (arr[i].Trim() == "4")
                {
                    temp = temp + "簡中,";
                }
                if (arr[i].Trim() == "5")
                {
                    temp = temp + "韓文,";
                }
                if (arr[i].Trim() == "6")
                {
                    temp = temp + "德文,";
                }
                if (arr[i].Trim() == "7")
                {
                    temp = temp + "西文,";
                }
                if (arr[i].Trim() == "8")
                {
                    temp = temp + "法文,";
                }
                if (arr[i].Trim() == "9")
                {
                    temp = temp + "俄文,";
                }
                if (arr[i].Trim() == "10")
                {
                    temp = temp + "義文,";
                }
                if (arr[i].Trim() == "11")
                {
                    temp = temp + "葡文,";
                }
                if (arr[i].Trim() == "12")
                {
                    temp = temp + "荷文,";
                }
                if (arr[i].Trim() == "13")
                {
                    temp = temp + "波蘭,";
                }
                if (arr[i].Trim() == "14")
                {
                    temp = temp + "阿文,";
                }
                if (arr[i].Trim() == "15")
                {
                    temp = temp + "越文,";
                }
                if (arr[i].Trim() == "16")
                {
                    temp = temp + "泰文,";
                }
                if (arr[i].Trim() == "17")
                {
                    temp = temp + "馬來文,";
                }
                if (arr[i].Trim() == "18")
                {
                    temp = temp + "印尼文,";
                }
                if (arr[i].Trim() == "19")
                {
                    temp = temp + "其它,";
                }

            }

            return temp;
        }


        public string translationskill(string str)
        {
            string[] arr = str.Split('|');
            string temp = "";

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Trim() == "1")
                {
                    temp = temp + "醫學,";
                }
                if (arr[i].Trim() == "2")
                {
                    temp = temp + "醫療器材,";
                }
                if (arr[i].Trim() == "3")
                {
                    temp = temp + "中醫,";
                }
                if (arr[i].Trim() == "4")
                {
                    temp = temp + "藥學,";
                }
                if (arr[i].Trim() == "5")
                {
                    temp = temp + "生物化學,";
                }
                if (arr[i].Trim() == "6")
                {
                    temp = temp + "物理/光學,";
                }
                if (arr[i].Trim() == "7")
                {
                    temp = temp + "理工,";
                }
                if (arr[i].Trim() == "8")
                {
                    temp = temp + "化學/化工,";
                }
                if (arr[i].Trim() == "9")
                {
                    temp = temp + "數學,";
                }
                if (arr[i].Trim() == "10")
                {
                    temp = temp + "電機,";
                }
                if (arr[i].Trim() == "11")
                {
                    temp = temp + "電子,";
                }
                if (arr[i].Trim() == "12")
                {
                    temp = temp + "電信通訊,";
                }
                if (arr[i].Trim() == "13")
                {
                    temp = temp + "電腦硬體,";
                }
                if (arr[i].Trim() == "14")
                {
                    temp = temp + "地球科學,";
                }
                if (arr[i].Trim() == "15")
                {
                    temp = temp + "電腦軟體,";
                }
                if (arr[i].Trim() == "16")
                {
                    temp = temp + "電玩遊戲,";
                }
                if (arr[i].Trim() == "17")
                {
                    temp = temp + "交通/運輸,";
                }
                if (arr[i].Trim() == "18")
                {
                    temp = temp + "資訊,";
                }
                if (arr[i].Trim() == "19")
                {
                    temp = temp + "機械,";
                }

                if (arr[i].Trim() == "20")
                {
                    temp = temp + "工業安全,";
                }
                if (arr[i].Trim() == "21")
                {
                    temp = temp + "汽車,";
                }
                if (arr[i].Trim() == "22")
                {
                    temp = temp + "捷運/高鐵,";
                }
                if (arr[i].Trim() == "23")
                {
                    temp = temp + "都市計劃,";
                }
                if (arr[i].Trim() == "24")
                {
                    temp = temp + "航太,";
                }
                if (arr[i].Trim() == "25")
                {
                    temp = temp + "土木,";
                }
                if (arr[i].Trim() == "26")
                {
                    temp = temp + "建築裝璜,";
                }
                if (arr[i].Trim() == "27")
                {
                    temp = temp + "環保,";
                }
                if (arr[i].Trim() == "28")
                {
                    temp = temp + "能源/發電,";
                }
                if (arr[i].Trim() == "29")
                {
                    temp = temp + "石油科學,";
                }
                if (arr[i].Trim() == "30")
                {
                    temp = temp + "核能/核子科學,";
                }
                if (arr[i].Trim() == "31")
                {
                    temp = temp + "半導體,";
                }
                if (arr[i].Trim() == "32")
                {
                    temp = temp + "營造工程,";
                }
                if (arr[i].Trim() == "33")
                {
                    temp = temp + "法律,";
                }
                if (arr[i].Trim() == "34")
                {
                    temp = temp + "保險,";
                }
                if (arr[i].Trim() == "35")
                {
                    temp = temp + "財務經濟,";
                }
                if (arr[i].Trim() == "36")
                {
                    temp = temp + "外匯金融,";
                }
                if (arr[i].Trim() == "37")
                {
                    temp = temp + "會計稅務,";
                }
                if (arr[i].Trim() == "38")
                {
                    temp = temp + "會計,";
                }

                if (arr[i].Trim() == "39")
                {
                    temp = temp + "企管,";
                }
                if (arr[i].Trim() == "40")
                {
                    temp = temp + "商業/貿易,";
                }
                if (arr[i].Trim() == "41")
                {
                    temp = temp + "證券,";
                }
                if (arr[i].Trim() == "42")
                {
                    temp = temp + "統計,";
                }
                if (arr[i].Trim() == "43")
                {
                    temp = temp + "歷史,";
                }
                if (arr[i].Trim() == "44")
                {
                    temp = temp + "天文,";
                }
                if (arr[i].Trim() == "45")
                {
                    temp = temp + "人文,";
                }
                if (arr[i].Trim() == "46")
                {
                    temp = temp + "人口發展,";
                }
                if (arr[i].Trim() == "47")
                {
                    temp = temp + "政治,";
                }
                if (arr[i].Trim() == "48")
                {
                    temp = temp + "新聞,";
                }
                if (arr[i].Trim() == "49")
                {
                    temp = temp + "大眾傳播,";
                }
                if (arr[i].Trim() == "50")
                {
                    temp = temp + "教育,";
                }
                if (arr[i].Trim() == "51")
                {
                    temp = temp + "哲學,";
                }
                if (arr[i].Trim() == "52")
                {
                    temp = temp + "文化,";
                }
                if (arr[i].Trim() == "53")
                {
                    temp = temp + "文學,";
                }
                if (arr[i].Trim() == "54")
                {
                    temp = temp + "心理,";
                }
                if (arr[i].Trim() == "55")
                {
                    temp = temp + "藝術,";
                }
                if (arr[i].Trim() == "56")
                {
                    temp = temp + "社會學,";
                }
                if (arr[i].Trim() == "57")
                {
                    temp = temp + "消防,";
                }

                if (arr[i].Trim() == "58")
                {
                    temp = temp + "紡織,";
                }
                if (arr[i].Trim() == "59")
                {
                    temp = temp + "傳記,";
                }
                if (arr[i].Trim() == "60")
                {
                    temp = temp + "軍事/國防,";
                }
                if (arr[i].Trim() == "61")
                {
                    temp = temp + "美容,";
                }
                if (arr[i].Trim() == "62")
                {
                    temp = temp + "體育,";
                }
                if (arr[i].Trim() == "63")
                {
                    temp = temp + "宗教,";
                }
                if (arr[i].Trim() == "64")
                {
                    temp = temp + "酒類,";
                }
                if (arr[i].Trim() == "65")
                {
                    temp = temp + "觀光/旅遊,";
                }
                if (arr[i].Trim() == "66")
                {
                    temp = temp + "地理,";
                }
                if (arr[i].Trim() == "67")
                {
                    temp = temp + "食品/餐飲,";
                }
                if (arr[i].Trim() == "68")
                {
                    temp = temp + "時裝,";
                }
                if (arr[i].Trim() == "69")
                {
                    temp = temp + "音樂,";
                }
                if (arr[i].Trim() == "70")
                {
                    temp = temp + "農林漁牧,";
                }
                if (arr[i].Trim() == "71")
                {
                    temp = temp + "廣告行銷,";
                }
                if (arr[i].Trim() == "72")
                {
                    temp = temp + "電影,";
                }
                if (arr[i].Trim() == "73")
                {
                    temp = temp + "體育/運動,";
                }
                if (arr[i].Trim() == "74")
                {
                    temp = temp + "珠寶,";
                }
                if (arr[i].Trim() == "75")
                {
                    temp = temp + "採礦/礦物,";
                }
                if (arr[i].Trim() == "76")
                {
                    temp = temp + "戲劇,";
                }

                if (arr[i].Trim() == "77")
                {
                    temp = temp + "動物,";
                }
                if (arr[i].Trim() == "78")
                {
                    temp = temp + "植物,";
                }
                if (arr[i].Trim() == "79")
                {
                    temp = temp + "留學,";
                }
                if (arr[i].Trim() == "80")
                {
                    temp = temp + "論文,";
                }
                if (arr[i].Trim() == "81")
                {
                    temp = temp + "ISO,";
                }
                if (arr[i].Trim() == "82")
                {
                    temp = temp + "公證/移民,";
                }
                if (arr[i].Trim() == "83")
                {
                    temp = temp + "專利,";
                }
                if (arr[i].Trim() == "84")
                {
                    temp = temp + "技術手冊,";
                }
                if (arr[i].Trim() == "85")
                {
                    temp = temp + "公司章程,";
                }
                if (arr[i].Trim() == "86")
                {
                    temp = temp + "印刷/出版,";
                }
                if (arr[i].Trim() == "87")
                {
                    temp = temp + "合約書,";
                }

            }

            return temp;
        }


        public string softwareskill(string str)
        {
            string[] arr = str.Split('|');
            string temp = "";

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Trim() == "1")
                {
                    temp = temp + "Access,";
                }
                if (arr[i].Trim() == "2")
                {
                    temp = temp + "Publisher,";
                }
                if (arr[i].Trim() == "3")
                {
                    temp = temp + "Visio,";
                }
                if (arr[i].Trim() == "4")
                {
                    temp = temp + "FrontPage,";
                }
                if (arr[i].Trim() == "5")
                {
                    temp = temp + "Dreamweaver,";
                }
                if (arr[i].Trim() == "6")
                {
                    temp = temp + "PageMaker,";
                }
                if (arr[i].Trim() == "7")
                {
                    temp = temp + "FrameMaker,";
                }
                if (arr[i].Trim() == "8")
                {
                    temp = temp + "QuarkXPress,";
                }
                if (arr[i].Trim() == "9")
                {
                    temp = temp + "Robohelp,";
                }
                if (arr[i].Trim() == "10")
                {
                    temp = temp + "AcrobatWriter,";
                }
                if (arr[i].Trim() == "11")
                {
                    temp = temp + "Photoshop,";
                }
                if (arr[i].Trim() == "12")
                {
                    temp = temp + "Illustrator,";
                }
                if (arr[i].Trim() == "13")
                {
                    temp = temp + "Corel Draw,";
                }
                if (arr[i].Trim() == "14")
                {
                    temp = temp + "InDesign,";
                }
                if (arr[i].Trim() == "15")
                {
                    temp = temp + "Trados,";
                }
                if (arr[i].Trim() == "16")
                {
                    temp = temp + "SDLX,";
                }
                if (arr[i].Trim() == "17")
                {
                    temp = temp + "Deja vu,";
                }
                if (arr[i].Trim() == "18")
                {
                    temp = temp + "STAR Transit,";
                }
                if (arr[i].Trim() == "19")
                {
                    temp = temp + "IBM TM,";
                }

            }

            return temp;
        }




    }
}
