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
using System.Collections.Generic;

namespace Web.Admin.Manager {
    public partial class EditRight : System.Web.UI.Page {
        private BLL.Manager bll = new BLL.Manager();
        private BLL.Right rbll = new BLL.Right();

        protected void Page_Load(object sender, EventArgs e) {
            CommonFunction.IsAdmin();
            if (!IsPostBack) {
                if (Session["Admin"] == null || Session["Admin"].ToString().ToLower() != "admin") {
                    ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');window.location.href='Manage.aspx';", true);
                    return;
                }
                if (!string.IsNullOrEmpty(Request.QueryString["m_id"])) {
                    int m_id = Convert.ToInt32(Request.QueryString["m_id"]);
                    Model.Manager model = bll.GetModel(m_id);
                    if (model != null && model.AdminName.ToLower() == "admin") {
                        ClientScript.RegisterStartupScript(GetType(), "norequire", "alert('该管理員是系統管理員，無需分配權限!');window.location.href='Manage.aspx';", true);
                        return;
                    }
                    if (model != null) {
                        lblManager.Text = model.AdminName;

                        Model.Right websetmodel = rbll.GetModel(model.AdminName, "webset");  //basic set --ok
                        Model.Right newsmodel = rbll.GetModel(model.AdminName, "news");
                        //Model.Right jbnewsmodel = rbll.GetModel(model.AdminName, "jbnews");
                        Model.Right articleclassmodel = rbll.GetModel(model.AdminName, "articleclass");
                        Model.Right newsclassmodel = rbll.GetModel(model.AdminName, "guoclass");
                        Model.Right linyuclassmodel = rbll.GetModel(model.AdminName, "linyuclass");
                        Model.Right signmodel = rbll.GetModel(model.AdminName, "guopic");
                        Model.Right pluppicmodel = rbll.GetModel(model.AdminName, "pluppic");

                        Model.Right signtypemodel = rbll.GetModel(model.AdminName, "linyuxinxi");

                        Model.Right guestmodel = rbll.GetModel(model.AdminName, "guest");
                        Model.Right guestemailmodel = rbll.GetModel(model.AdminName, "guestemail");
                        Model.Right zhaopinmodel = rbll.GetModel(model.AdminName, "zhaopin");
                        Model.Right yingpinmodel = rbll.GetModel(model.AdminName, "yingpin");
                        Model.Right Outjianlimodel = rbll.GetModel(model.AdminName, "outjianli");
                        Model.Right outlyxxmodel = rbll.GetModel(model.AdminName, "outlyxx");
                        Model.Right exceldrmodel = rbll.GetModel(model.AdminName, "exceldr");
                        Model.Right lyxxrovermodel = rbll.GetModel(model.AdminName, "lyxxrover");

                        Model.Right newsrovermodel = rbll.GetModel(model.AdminName, "newsrover");

                        Model.Right Outlogomodel = rbll.GetModel(model.AdminName, "outlogo");
                        Model.Right Logodrmodel = rbll.GetModel(model.AdminName, "logodr");

                        Model.Right friendlymodel = rbll.GetModel(model.AdminName, "friendly");
                        Model.Right friendlyupdownmodel = rbll.GetModel(model.AdminName, "friendlyupdown");
                        Model.Right partnersupdownmodel = rbll.GetModel(model.AdminName, "partnersupdown");

                        Model.Right zone = rbll.GetModel(model.AdminName, "zone");
                        Model.Right zonetype = rbll.GetModel(model.AdminName, "zonetype");
                        Model.Right zonedelbox = rbll.GetModel(model.AdminName, "zonedelbox");
                        Model.Right team = rbll.GetModel(model.AdminName, "team");
                        Model.Right teamtype = rbll.GetModel(model.AdminName, "teamtype");
                        Model.Right subweb = rbll.GetModel(model.AdminName, "subweb");

                        #region 子網站管理
                        this.cbxWeb.DataSource = new CbxSubweb().CbxTable();
                        this.cbxWeb.DataTextField = "SWName";//绑定的字段名  
                        this.cbxWeb.DataValueField = "SWID";//绑定的值
                        this.cbxWeb.DataBind();

                        DataSet ds = new BLL.Right().GetList("UserName='" + model.AdminName + "' and Rights=0");
                        if (ds.Tables[0].Rows.Count == new BLL.SubWeb().GetModelList("").Count)
                        {
                            cbxWeb.Items[0].Selected = true;
                        }
                        else
                        {
                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                for (int j = 0; j < cbxWeb.Items.Count; j++)
                                {
                                    if (ds.Tables[0].Rows[i]["PageName"].ToString() == cbxWeb.Items[j].Value)
                                    {
                                        cbxWeb.Items[j].Selected = true;
                                    }
                                }
                            } 
                        }
                        #endregion


                        #region 網站基本設置
                        if (websetmodel != null)
                        {
                            int rights = websetmodel.Rights;
                            
                            if ((rights & (int)RightStatus.Update) == (int)RightStatus.Update)
                            {
                                chWebsetUpdate.Checked = true;
                            }

                        }
                        #endregion

                        #region 前台網頁管理權限
                        //if (jbnewsmodel != null)
                        //{
                        //    int rights = jbnewsmodel.Rights;
                            
                        //    if ((rights & (int)RightStatus.Update) == (int)RightStatus.Update)
                        //    {
                        //        cbjbNewsUpdate.Checked = true;
                        //    }
                        //    if ((rights & (int)RightStatus.Select) == (int)RightStatus.Select)
                        //    {
                        //        cbjbNewsSelect.Checked = true;
                        //    }
                            
                        //}
                        #endregion

                        #region 網頁管理權限
                        if (newsmodel != null)
                        {
                            int rights = newsmodel.Rights;
                            if ((rights & (int)RightStatus.Insert) == (int)RightStatus.Insert)
                            {
                                cbNewsInsert.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Delete) == (int)RightStatus.Delete)
                            {
                                cbNewsDelete.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Update) == (int)RightStatus.Update)
                            {
                                cbNewsUpdate.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Select) == (int)RightStatus.Select)
                            {
                                cbNewsSelect.Checked = true;
                            }
                        }
                        #endregion

                        #region 文章類別管理權限
                        if (articleclassmodel != null)
                        {
                            int rights = articleclassmodel.Rights;
                            if ((rights & (int)RightStatus.Insert) == (int)RightStatus.Insert)
                            {
                                cbArticleclassInsert.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Delete) == (int)RightStatus.Delete)
                            {
                                cbArticleclassDelete.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Update) == (int)RightStatus.Update)
                            {
                                cbArticleclassUpdate.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Select) == (int)RightStatus.Select)
                            {
                                cbArticleclassSelect.Checked = true;
                            }
                        }
                        #endregion


                        #region 國家類別管理權限
                        if (newsclassmodel != null)
                        {
                            int rights = newsclassmodel.Rights;
                            if ((rights & (int)RightStatus.Insert) == (int)RightStatus.Insert)
                            {
                                cbActualprojectInsert.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Delete) == (int)RightStatus.Delete)
                            {
                                cbActualprojectDelete.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Update) == (int)RightStatus.Update)
                            {
                                cbActualprojectUpdate.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Select) == (int)RightStatus.Select)
                            {
                                cbActualprojectSelect.Checked = true;
                            }
                        }
                        #endregion

                        #region 領域類別管理權限
                        if (linyuclassmodel != null)
                        {
                            int rights = linyuclassmodel.Rights;
                            if ((rights & (int)RightStatus.Insert) == (int)RightStatus.Insert)
                            {
                                cbLinyuclassInsert.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Delete) == (int)RightStatus.Delete)
                            {
                                cbLinyuclassDelete.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Update) == (int)RightStatus.Update)
                            {
                                cbLinyuclassUpdate.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Select) == (int)RightStatus.Select)
                            {
                                cbLinyuclassSelect.Checked = true;
                            }
                        }
                        #endregion


                        #region LOGO小圖管理權限
                        if (signmodel != null)
                        {
                            int rights = signmodel.Rights;
                            if ((rights & (int)RightStatus.Insert) == (int)RightStatus.Insert)
                            {
                                cbSignInsert.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Delete) == (int)RightStatus.Delete)
                            {
                                cbSignDelete.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Update) == (int)RightStatus.Update)
                            {
                                cbSignUpdate.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Select) == (int)RightStatus.Select)
                            {
                                cbSignSelect.Checked = true;
                            }
                        }
                        #endregion

                        //#region LOGO圖批量上傳
                        //if (pluppicmodel != null)
                        //{
                        //    int rights = pluppicmodel.Rights;
                            
                        //    if ((rights & (int)RightStatus.Select) == (int)RightStatus.Select)
                        //    {
                        //        chPluppicSelect.Checked = true;
                        //    }
                        //}
                        //#endregion

                        #region 領域廠商管理權限
                        if (signtypemodel != null)
                        {
                            int rights = signtypemodel.Rights;
                            if ((rights & (int)RightStatus.Insert) == (int)RightStatus.Insert)
                            {
                                cbSignTypeInsert.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Delete) == (int)RightStatus.Delete)
                            {
                                cbSignTypeDelete.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Update) == (int)RightStatus.Update)
                            {
                                cbSignTypeUpdate.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Select) == (int)RightStatus.Select)
                            {
                                cbSignTypeSelect.Checked = true;
                            }
                        }
                        #endregion

                        #region 線上詢價權限
                        if (guestmodel != null) {
                            int rights = guestmodel.Rights;

                            if ((rights & (int)RightStatus.Delete) == (int)RightStatus.Delete) {
                                cbGuestDelete.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Update) == (int)RightStatus.Update) {
                                cbGuestUpdate.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Select) == (int)RightStatus.Select) {
                                cbGuestSelect.Checked = true;
                            }
                        }
                        #endregion

                        #region 指定發送E-MAIL 權限
                        if (guestemailmodel != null)
                        {
                            int rights = guestemailmodel.Rights;
                            if ((rights & (int)RightStatus.Insert) == (int)RightStatus.Insert)
                            {
                                cbEmailInsert.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Delete) == (int)RightStatus.Delete)
                            {
                                cbEmailDelete.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Update) == (int)RightStatus.Update)
                            {
                                cbEmailUpdate.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Select) == (int)RightStatus.Select)
                            {
                                cbEmailSelect.Checked = true;
                            }
                        }
                        #endregion

                        //#region 人才招募管理權限
                        //if (zhaopinmodel != null)
                        //{
                        //    int rights = zhaopinmodel.Rights;
                        //    if ((rights & (int)RightStatus.Insert) == (int)RightStatus.Insert)
                        //    {
                        //        cbZhaopinInsert.Checked = true;
                        //    }
                        //    if ((rights & (int)RightStatus.Delete) == (int)RightStatus.Delete)
                        //    {
                        //        cbZhaopinDelete.Checked = true;
                        //    }
                        //    if ((rights & (int)RightStatus.Update) == (int)RightStatus.Update)
                        //    {
                        //        cbZhaopinUpdate.Checked = true;
                        //    }
                        //    if ((rights & (int)RightStatus.Select) == (int)RightStatus.Select)
                        //    {
                        //        cbZhaopinSelect.Checked = true;
                        //    }
                        //}
                        //#endregion

                        #region 求職履歷管理權限
                        if (yingpinmodel != null)
                        {
                            int rights = yingpinmodel.Rights;

                            if ((rights & (int)RightStatus.Delete) == (int)RightStatus.Delete)
                            {
                                cbYingpinDelete.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Update) == (int)RightStatus.Update)
                            {
                                cbYingpinUpdate.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Select) == (int)RightStatus.Select)
                            {
                                cbYingpinSelect.Checked = true;
                            }
                        }
                        #endregion

                        #region 匯出履歷權限
                        if (Outjianlimodel != null)
                        {
                            int rights = Outjianlimodel.Rights;

                            
                            if ((rights & (int)RightStatus.Select) == (int)RightStatus.Select)
                            {
                                cbOutjianliSelect.Checked = true;
                            }
                        }
                        #endregion

                        //#region 匯出領域廠商信息權限
                        //if (outlyxxmodel != null)
                        //{
                        //    int rights = outlyxxmodel.Rights;


                        //    if ((rights & (int)RightStatus.Select) == (int)RightStatus.Select)
                        //    {
                        //        cboutlyxxSelect.Checked = true;
                        //    }
                        //}
                        //#endregion


                        //#region 匯入領域廠商信息權限
                        //if (exceldrmodel != null)
                        //{
                        //    int rights = exceldrmodel.Rights;


                        //    if ((rights & (int)RightStatus.Select) == (int)RightStatus.Select)
                        //    {
                        //        cbexceldrSelect.Checked = true;
                        //    }
                        //}
                        //#endregion

                        #region 回收桶權限
                        if (lyxxrovermodel != null)
                        {
                            int rights = lyxxrovermodel.Rights;

                            if ((rights & (int)RightStatus.Delete) == (int)RightStatus.Delete)
                            {
                                cblyxxroverDelete.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Update) == (int)RightStatus.Update)
                            {
                                cblyxxroverUpdate.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Select) == (int)RightStatus.Select)
                            {
                                cblyxxroverSelect.Checked = true;
                            }
                        }
                        #endregion

                        #region 文章回收桶權限
                        if (newsrovermodel != null)
                        {
                            int rights = newsrovermodel.Rights;

                            if ((rights & (int)RightStatus.Delete) == (int)RightStatus.Delete)
                            {
                                cbActualroverDelete.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Update) == (int)RightStatus.Update)
                            {
                                cbActualroverUpdate.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Select) == (int)RightStatus.Select)
                            {
                                cbActualroverSelect.Checked = true;
                            }
                        }
                        #endregion


                        //#region 匯出LOGO圖信息
                        //if (Outlogomodel != null)
                        //{
                        //    int rights = Outlogomodel.Rights;


                        //    if ((rights & (int)RightStatus.Select) == (int)RightStatus.Select)
                        //    {
                        //        cbOutlogoSelect.Checked = true;
                        //    }
                        //}
                        //#endregion


                        //#region 匯入LOGO圖信息
                        //if (Logodrmodel != null)
                        //{
                        //    int rights = Logodrmodel.Rights;


                        //    if ((rights & (int)RightStatus.Insert) == (int)RightStatus.Insert)
                        //    {
                        //        cbLogodrInsert.Checked = true;
                        //    }
                        //}
                        //#endregion

                        #region 友好連結及合作夥伴
                        if (friendlymodel != null)
                        {
                            int rights = friendlymodel.Rights;
                            if ((rights & (int)RightStatus.Insert) == (int)RightStatus.Insert)
                            {
                                cbFpInsert.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Delete) == (int)RightStatus.Delete)
                            {
                                cbFpDelete.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Update) == (int)RightStatus.Update)
                            {
                                cbFpUpdate.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Select) == (int)RightStatus.Select)
                            {
                                cbFpSelect.Checked = true;
                            }
                        }
                        #endregion
                        #region 友好連結匯入匯出權限
                        if (friendlyupdownmodel != null)
                        {
                            int rights = friendlyupdownmodel.Rights;
                            if ((rights & (int)RightStatus.Insert) == (int)RightStatus.Insert)
                            {
                                cbFriendlyUpload.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Delete) == (int)RightStatus.Delete)
                            {
                                cbFriendlyDownload.Checked = true;
                            }
                        }
                        #endregion
                        #region 合作夥伴匯入匯出權限
                        if (partnersupdownmodel != null)
                        {
                            int rights = partnersupdownmodel.Rights;
                            if ((rights & (int)RightStatus.Insert) == (int)RightStatus.Insert)
                            {
                                cbPartnersUpload.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Delete) == (int)RightStatus.Delete)
                            {
                                cbPartnersDownload.Checked = true;
                            }
                        }
                        #endregion


                        //#region 翻译领域
                        //if (zone != null)
                        //{
                        //    int rights = zone.Rights;
                        //    if ((rights & (int)RightStatus.Insert) == (int)RightStatus.Insert)
                        //    {
                        //        this.cbZoneAdd.Checked = true;
                        //    }
                        //    if ((rights & (int)RightStatus.Delete) == (int)RightStatus.Delete)
                        //    {
                        //        this.cbZoneDel.Checked = true;
                        //    }
                        //    if ((rights & (int)RightStatus.Update) == (int)RightStatus.Update)
                        //    {
                        //        this.cbZoneEdit.Checked = true;
                        //    }
                        //    if ((rights & (int)RightStatus.Select) == (int)RightStatus.Select)
                        //    {
                        //        this.cbZoneQuery.Checked = true;
                        //    }
                        //}

                        //if (zonetype != null)
                        //{
                        //    int rights = zonetype.Rights;
                        //    if ((rights & (int)RightStatus.Insert) == (int)RightStatus.Insert)
                        //    {
                        //        this.cbZoneTypeAdd.Checked = true;
                        //    }
                        //    if ((rights & (int)RightStatus.Delete) == (int)RightStatus.Delete)
                        //    {
                        //        this.cbZoneTypeDel.Checked = true;
                        //    }
                        //    if ((rights & (int)RightStatus.Update) == (int)RightStatus.Update)
                        //    {
                        //        this.cbZoneTypeEdit.Checked = true;
                        //    }
                        //    if ((rights & (int)RightStatus.Select) == (int)RightStatus.Select)
                        //    {
                        //        this.cbZoneTypeQuery.Checked = true;
                        //    }
                        //}
                        //if (zonedelbox != null)
                        //{
                        //    int rights = zonedelbox.Rights;
                        //    if ((rights & (int)RightStatus.Select) == (int)RightStatus.Select)
                        //    {
                        //        this.cbZoneDelBoxSelect.Checked = true;
                        //    }
                        //    if ((rights & (int)RightStatus.Delete) == (int)RightStatus.Delete)
                        //    {
                        //        this.cbZoneDelBoxDelete.Checked = true;
                        //    }
                        //    if ((rights & (int)RightStatus.Update) == (int)RightStatus.Update)
                        //    {
                        //        this.cbZoneDelBoxUpdate.Checked = true;
                        //    }
                        //}
                        //#endregion

                        #region 翻译团队
                        if (team != null)
                        {
                            int rights = team.Rights;
                            if ((rights & (int)RightStatus.Insert) == (int)RightStatus.Insert)
                            {
                                this.cbTeamAdd.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Delete) == (int)RightStatus.Delete)
                            {
                                this.cbTeamDel.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Update) == (int)RightStatus.Update)
                            {
                                this.cbTeamEdit.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Select) == (int)RightStatus.Select)
                            {
                                this.cbTeamQuery.Checked = true;
                            }
                        }
                        #endregion

                        #region 翻译团队類型
                        if (teamtype != null)
                        {
                            int rights = teamtype.Rights;
                            if ((rights & (int)RightStatus.Insert) == (int)RightStatus.Insert)
                            {
                                this.cbTeamTypeAdd.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Delete) == (int)RightStatus.Delete)
                            {
                                this.cbTeamTypeDel.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Update) == (int)RightStatus.Update)
                            {
                                this.cbTeamTypeEdit.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Select) == (int)RightStatus.Select)
                            {
                                this.cbTeamTypeQuery.Checked = true;
                            }
                        }
                        #endregion

                        #region 子網站管理
                        if (subweb != null)
                        {
                            int rights = subweb.Rights;
                            if ((rights & (int)RightStatus.Insert) == (int)RightStatus.Insert)
                            {
                                this.cbSwInsert.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Delete) == (int)RightStatus.Delete)
                            {
                                this.cbSwDelete.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Update) == (int)RightStatus.Update)
                            {
                                this.cbSwUpdate.Checked = true;
                            }
                            if ((rights & (int)RightStatus.Select) == (int)RightStatus.Select)
                            {
                                this.cbSwSelect.Checked = true;
                            }
                        }
                        #endregion
                    }
                }
            }
        }
        protected void Sub_Click(object sender, EventArgs e) {
            if (Session["Admin"] == null || Session["Admin"].ToString().ToLower() != "admin") {
                ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');window.location.href='Manage.aspx';", true);
                return;
            }
            if (!string.IsNullOrEmpty(Request.QueryString["m_id"])) {
                int m_id = Convert.ToInt32(Request.QueryString["m_id"]);
                Model.Manager model = bll.GetModel(m_id);

                //添加子網站管理
                Model.Right rightModle = new Model.Right();
                rightModle.UserName = model.AdminName;
                rightModle.Rights = 0;

                //刪除子網站管理
                try
                {
                    rbll.DeleteWeb(model.AdminName, 0);
                }
                catch (Exception)
                { 
                    
                }
                
                //重新賦值權限
                List<Model.SubWeb> web = new BLL.SubWeb().GetModelList("");
                for (int i = 0; i < cbxWeb.Items.Count;i++)
                {
                    if (cbxWeb.Items[0].Selected == true)
                    {
                        for (int j = 0; j < web.Count; j++)
                        {
                            rightModle.PageName = web[j].SWID.ToString();
                            rbll.Add(rightModle);
                        }
                        break;
                    }
                    else
                    {
                        if (i != 0)
                        {
                            if (cbxWeb.Items[i].Selected == true)
                            {
                                rightModle.PageName = cbxWeb.Items[i].Value;
                                rbll.Add(rightModle);
                            }
                        }
                    }
                }


                if (model != null)
                {
                    #region 網站基本設置
                    RightStatus websetrights = RightStatus.Empty;

                    if (chWebsetUpdate.Checked)
                    {
                        websetrights = websetrights | RightStatus.Update;
                    }

                    Model.Right rmodel = rbll.GetModel(model.AdminName, "webset");
                    if (rmodel != null)
                    {
                        if (websetrights != RightStatus.Empty)
                        {
                            rmodel.Rights = (int)websetrights;
                            rbll.Update(rmodel);
                        }
                        else
                        {
                            rbll.Delete(rmodel.RightID);
                        }
                    }
                    else
                    {
                        if (websetrights != RightStatus.Empty)
                        {
                            rmodel = new Model.Right();
                            rmodel.PageName = "webset";
                            rmodel.Rights = (int)websetrights;
                            rmodel.UserName = model.AdminName;
                            rbll.Add(rmodel);
                        }
                    }
                    #endregion

                    #region 前台網頁權限
                    /*
                    RightStatus jbnewsrights = RightStatus.Empty;

                    if (cbjbNewsUpdate.Checked)
                    {
                        jbnewsrights = jbnewsrights | RightStatus.Update;
                    }
                    if (cbjbNewsSelect.Checked)
                    {
                        jbnewsrights = jbnewsrights | RightStatus.Select;
                    }

                    rmodel = rbll.GetModel(model.AdminName, "jbnews");
                    if (rmodel != null)
                    {
                        if (jbnewsrights != RightStatus.Empty)
                        {
                            rmodel.Rights = (int)jbnewsrights;
                            rbll.Update(rmodel);
                        }
                        else
                        {
                            rbll.Delete(rmodel.RightID);
                        }
                    }
                    else
                    {
                        if (jbnewsrights != RightStatus.Empty)
                        {
                            rmodel = new Model.Right();
                            rmodel.PageName = "jbnews";
                            rmodel.Rights = (int)jbnewsrights;
                            rmodel.UserName = model.AdminName;
                            rbll.Add(rmodel);
                        }
                    }
                    */
                    #endregion


                    #region 網頁管理權限
                    RightStatus newsrights = RightStatus.Empty;
                    if (cbNewsInsert.Checked)
                    {
                        newsrights = newsrights | RightStatus.Insert;
                    }
                    if (cbNewsDelete.Checked)
                    {
                        newsrights = newsrights | RightStatus.Delete;
                    }
                    if (cbNewsUpdate.Checked)
                    {
                        newsrights = newsrights | RightStatus.Update;
                    }
                    if (cbNewsSelect.Checked)
                    {
                        newsrights = newsrights | RightStatus.Select;
                    }

                    rmodel = rbll.GetModel(model.AdminName, "news");
                    if (rmodel != null)
                    {
                        if (newsrights != RightStatus.Empty)
                        {
                            rmodel.Rights = (int)newsrights;
                            rbll.Update(rmodel);
                        }
                        else
                        {
                            rbll.Delete(rmodel.RightID);
                        }
                    }
                    else
                    {
                        if (newsrights != RightStatus.Empty)
                        {
                            rmodel = new Model.Right();
                            rmodel.PageName = "news";
                            rmodel.Rights = (int)newsrights;
                            rmodel.UserName = model.AdminName;
                            rbll.Add(rmodel);
                        }
                    }
                    #endregion

                    #region 文章類別管理權限
                    RightStatus articleclassrights = RightStatus.Empty;
                    if (cbArticleclassInsert.Checked)
                    {
                        articleclassrights = articleclassrights | RightStatus.Insert;
                    }
                    if (cbArticleclassDelete.Checked)
                    {
                        articleclassrights = articleclassrights | RightStatus.Delete;
                    }
                    if (cbArticleclassUpdate.Checked)
                    {
                        articleclassrights = articleclassrights | RightStatus.Update;
                    }
                    if (cbArticleclassSelect.Checked)
                    {
                        articleclassrights = articleclassrights | RightStatus.Select;
                    }

                    rmodel = rbll.GetModel(model.AdminName, "articleclass");
                    if (rmodel != null)
                    {
                        if (articleclassrights != RightStatus.Empty)
                        {
                            rmodel.Rights = (int)articleclassrights;
                            rbll.Update(rmodel);
                        }
                        else
                        {
                            rbll.Delete(rmodel.RightID);
                        }
                    }
                    else
                    {
                        if (articleclassrights != RightStatus.Empty)
                        {
                            rmodel = new Model.Right();
                            rmodel.PageName = "articleclass";
                            rmodel.Rights = (int)articleclassrights;
                            rmodel.UserName = model.AdminName;
                            rbll.Add(rmodel);
                        }
                    }
                    #endregion

                    #region 國家類別管理權限
                    RightStatus actualproject = RightStatus.Empty;
                    if (cbActualprojectInsert.Checked)
                    {
                        actualproject = actualproject | RightStatus.Insert;
                    }
                    if (cbActualprojectDelete.Checked)
                    {
                        actualproject = actualproject | RightStatus.Delete;
                    }
                    if (cbActualprojectUpdate.Checked)
                    {
                        actualproject = actualproject | RightStatus.Update;
                    }
                    if (cbActualprojectSelect.Checked)
                    {
                        actualproject = actualproject | RightStatus.Select;
                    }

                    rmodel = rbll.GetModel(model.AdminName, "guoclass");
                    if (rmodel != null)
                    {
                        if (actualproject != RightStatus.Empty)
                        {
                            rmodel.Rights = (int)actualproject;
                            rbll.Update(rmodel);
                        }
                        else
                        {
                            rbll.Delete(rmodel.RightID);
                        }
                    }
                    else
                    {
                        if (actualproject != RightStatus.Empty)
                        {
                            rmodel = new Model.Right();
                            rmodel.PageName = "guoclass";
                            rmodel.Rights = (int)actualproject;
                            rmodel.UserName = model.AdminName;
                            rbll.Add(rmodel);
                        }
                    }
                    #endregion


                    #region 領域類別管理權限
                    RightStatus linyuproject = RightStatus.Empty;
                    if (cbLinyuclassInsert.Checked)
                    {
                        linyuproject = linyuproject | RightStatus.Insert;
                    }
                    if (cbLinyuclassDelete.Checked)
                    {
                        linyuproject = linyuproject | RightStatus.Delete;
                    }
                    if (cbLinyuclassUpdate.Checked)
                    {
                        linyuproject = linyuproject | RightStatus.Update;
                    }
                    if (cbLinyuclassSelect.Checked)
                    {
                        linyuproject = linyuproject | RightStatus.Select;
                    }

                    rmodel = rbll.GetModel(model.AdminName, "linyuclass");
                    if (rmodel != null)
                    {
                        if (linyuproject != RightStatus.Empty)
                        {
                            rmodel.Rights = (int)linyuproject;
                            rbll.Update(rmodel);
                        }
                        else
                        {
                            rbll.Delete(rmodel.RightID);
                        }
                    }
                    else
                    {
                        if (linyuproject != RightStatus.Empty)
                        {
                            rmodel = new Model.Right();
                            rmodel.PageName = "linyuclass";
                            rmodel.Rights = (int)linyuproject;
                            rmodel.UserName = model.AdminName;
                            rbll.Add(rmodel);
                        }
                    }
                    #endregion


                    #region LOGO小圖管理權限
                    RightStatus signrights = RightStatus.Empty;
                    if (cbSignInsert.Checked)
                    {
                        signrights = signrights | RightStatus.Insert;
                    }
                    if (cbSignDelete.Checked)
                    {
                        signrights = signrights | RightStatus.Delete;
                    }
                    if (cbSignUpdate.Checked)
                    {
                        signrights = signrights | RightStatus.Update;
                    }
                    if (cbSignSelect.Checked)
                    {
                        signrights = signrights | RightStatus.Select;
                    }
                    rmodel = rbll.GetModel(model.AdminName, "guopic");
                    if (rmodel != null)
                    {
                        if (signrights != RightStatus.Empty)
                        {
                            rmodel.Rights = (int)signrights;
                            rbll.Update(rmodel);
                        }
                        else
                        {
                            rbll.Delete(rmodel.RightID);
                        }
                    }
                    else
                    {
                        if (signrights != RightStatus.Empty)
                        {
                            rmodel = new Model.Right();
                            rmodel.PageName = "guopic";
                            rmodel.Rights = (int)signrights;
                            rmodel.UserName = model.AdminName;
                            rbll.Add(rmodel);
                        }
                    }
                    #endregion


                    //#region LOGO圖批量上傳權限
                    //RightStatus pluppicrights = RightStatus.Empty;

                    //if (chPluppicSelect.Checked)
                    //{
                    //    pluppicrights = pluppicrights | RightStatus.Select;
                    //}
                    //rmodel = rbll.GetModel(model.AdminName, "pluppic");
                    //if (rmodel != null)
                    //{
                    //    if (pluppicrights != RightStatus.Empty)
                    //    {
                    //        rmodel.Rights = (int)pluppicrights;
                    //        rbll.Update(rmodel);
                    //    }
                    //    else
                    //    {
                    //        rbll.Delete(rmodel.RightID);
                    //    }
                    //}
                    //else
                    //{
                    //    if (pluppicrights != RightStatus.Empty)
                    //    {
                    //        rmodel = new Model.Right();
                    //        rmodel.PageName = "pluppic";
                    //        rmodel.Rights = (int)pluppicrights;
                    //        rmodel.UserName = model.AdminName;
                    //        rbll.Add(rmodel);
                    //    }
                    //}
                    //#endregion

                    #region 領域廠商管理權限
                    RightStatus signtyperights = RightStatus.Empty;
                    if (cbSignTypeInsert.Checked)
                    {
                        signtyperights = signtyperights | RightStatus.Insert;
                    }
                    if (cbSignTypeDelete.Checked)
                    {
                        signtyperights = signtyperights | RightStatus.Delete;
                    }
                    if (cbSignTypeUpdate.Checked)
                    {
                        signtyperights = signtyperights | RightStatus.Update;
                    }
                    if (cbSignTypeSelect.Checked)
                    {
                        signtyperights = signtyperights | RightStatus.Select;
                    }
                    rmodel = rbll.GetModel(model.AdminName, "linyuxinxi");
                    if (rmodel != null)
                    {
                        if (signtyperights != RightStatus.Empty)
                        {
                            rmodel.Rights = (int)signtyperights;
                            rbll.Update(rmodel);
                        }
                        else
                        {
                            rbll.Delete(rmodel.RightID);
                        }
                    }
                    else
                    {
                        if (signtyperights != RightStatus.Empty)
                        {
                            rmodel = new Model.Right();
                            rmodel.PageName = "linyuxinxi";
                            rmodel.Rights = (int)signtyperights;
                            rmodel.UserName = model.AdminName;
                            rbll.Add(rmodel);
                        }
                    }
                    #endregion


                    

                    #region 線上詢價權限
                    RightStatus guestrights = RightStatus.Empty;
                    
                    if (cbGuestDelete.Checked) {
                        guestrights = guestrights | RightStatus.Delete;
                    }
                    if (cbGuestUpdate.Checked) {
                        guestrights = guestrights | RightStatus.Update;
                    }
                    if (cbGuestSelect.Checked) {
                        guestrights = guestrights | RightStatus.Select;
                    }

                    rmodel = rbll.GetModel(model.AdminName, "guest");
                    if (rmodel != null) {
                        if (guestrights != RightStatus.Empty) {
                            rmodel.Rights = (int)guestrights;
                            rbll.Update(rmodel);
                        } else {
                            rbll.Delete(rmodel.RightID);
                        }
                    } else {
                        if (guestrights != RightStatus.Empty) {
                            rmodel = new Model.Right();
                            rmodel.PageName = "guest";
                            rmodel.Rights = (int)guestrights;
                            rmodel.UserName = model.AdminName;
                            rbll.Add(rmodel);
                        }
                    }
                    #endregion


                    #region 指定發送E-MAIL權限
                    RightStatus guestemailright = RightStatus.Empty;
                    if (cbEmailInsert.Checked)
                    {
                        guestemailright = guestemailright | RightStatus.Insert;
                    }
                    if (cbEmailDelete.Checked)
                    {
                        guestemailright = guestemailright | RightStatus.Delete;
                    }
                    if (cbEmailUpdate.Checked)
                    {
                        guestemailright = guestemailright | RightStatus.Update;
                    }
                    if (cbEmailSelect.Checked)
                    {
                        guestemailright = guestemailright | RightStatus.Select;
                    }

                    rmodel = rbll.GetModel(model.AdminName, "guestemail");
                    if (rmodel != null)
                    {
                        if (guestemailright != RightStatus.Empty)
                        {
                            rmodel.Rights = (int)guestemailright;
                            rbll.Update(rmodel);
                        }
                        else
                        {
                            rbll.Delete(rmodel.RightID);
                        }
                    }
                    else
                    {
                        if (guestemailright != RightStatus.Empty)
                        {
                            rmodel = new Model.Right();
                            rmodel.PageName = "guestemail";
                            rmodel.Rights = (int)guestemailright;
                            rmodel.UserName = model.AdminName;
                            rbll.Add(rmodel);
                        }
                    }
                    #endregion


                    //#region 人才招募管理權限
                    //RightStatus Zhaopinright = RightStatus.Empty;
                    //if (cbZhaopinInsert.Checked)
                    //{
                    //    Zhaopinright = Zhaopinright | RightStatus.Insert;
                    //}
                    //if (cbZhaopinDelete.Checked)
                    //{
                    //    Zhaopinright = Zhaopinright | RightStatus.Delete;
                    //}
                    //if (cbZhaopinUpdate.Checked)
                    //{
                    //    Zhaopinright = Zhaopinright | RightStatus.Update;
                    //}
                    //if (cbZhaopinSelect.Checked)
                    //{
                    //    Zhaopinright = Zhaopinright | RightStatus.Select;
                    //}

                    //rmodel = rbll.GetModel(model.AdminName, "zhaopin");
                    //if (rmodel != null)
                    //{
                    //    if (Zhaopinright != RightStatus.Empty)
                    //    {
                    //        rmodel.Rights = (int)Zhaopinright;
                    //        rbll.Update(rmodel);
                    //    }
                    //    else
                    //    {
                    //        rbll.Delete(rmodel.RightID);
                    //    }
                    //}
                    //else
                    //{
                    //    if (Zhaopinright != RightStatus.Empty)
                    //    {
                    //        rmodel = new Model.Right();
                    //        rmodel.PageName = "zhaopin";
                    //        rmodel.Rights = (int)Zhaopinright;
                    //        rmodel.UserName = model.AdminName;
                    //        rbll.Add(rmodel);
                    //    }
                    //}
                    //#endregion



                    #region 求職履歷管理權限
                    RightStatus yingpinright = RightStatus.Empty;

                    if (cbYingpinDelete.Checked)
                    {
                        yingpinright = yingpinright | RightStatus.Delete;
                    }
                    if (cbYingpinUpdate.Checked)
                    {
                        yingpinright = yingpinright | RightStatus.Update;
                    }
                    if (cbYingpinSelect.Checked)
                    {
                        yingpinright = yingpinright | RightStatus.Select;
                    }

                    rmodel = rbll.GetModel(model.AdminName, "yingpin");
                    if (rmodel != null)
                    {
                        if (yingpinright != RightStatus.Empty)
                        {
                            rmodel.Rights = (int)yingpinright;
                            rbll.Update(rmodel);
                        }
                        else
                        {
                            rbll.Delete(rmodel.RightID);
                        }
                    }
                    else
                    {
                        if (yingpinright != RightStatus.Empty)
                        {
                            rmodel = new Model.Right();
                            rmodel.PageName = "yingpin";
                            rmodel.Rights = (int)yingpinright;
                            rmodel.UserName = model.AdminName;
                            rbll.Add(rmodel);
                        }
                    }
                    #endregion



                    #region 匯出履歷權限
                    RightStatus outjianliright = RightStatus.Empty;


                    if (cbOutjianliSelect.Checked)
                    {
                        outjianliright = outjianliright | RightStatus.Select;
                    }

                    rmodel = rbll.GetModel(model.AdminName, "outjianli");
                    if (rmodel != null)
                    {
                        if (outjianliright != RightStatus.Empty)
                        {
                            rmodel.Rights = (int)outjianliright;
                            rbll.Update(rmodel);
                        }
                        else
                        {
                            rbll.Delete(rmodel.RightID);
                        }
                    }
                    else
                    {
                        if (outjianliright != RightStatus.Empty)
                        {
                            rmodel = new Model.Right();
                            rmodel.PageName = "outjianli";
                            rmodel.Rights = (int)outjianliright;
                            rmodel.UserName = model.AdminName;
                            rbll.Add(rmodel);
                        }
                    }
                    #endregion



                    //#region 匯出領域廠商信息權限
                    //RightStatus outlyxxright = RightStatus.Empty;


                    //if (cboutlyxxSelect.Checked)
                    //{
                    //    outlyxxright = outlyxxright | RightStatus.Select;
                    //}

                    //rmodel = rbll.GetModel(model.AdminName, "outlyxx");
                    //if (rmodel != null)
                    //{
                    //    if (outlyxxright != RightStatus.Empty)
                    //    {
                    //        rmodel.Rights = (int)outlyxxright;
                    //        rbll.Update(rmodel);
                    //    }
                    //    else
                    //    {
                    //        rbll.Delete(rmodel.RightID);
                    //    }
                    //}
                    //else
                    //{
                    //    if (outlyxxright != RightStatus.Empty)
                    //    {
                    //        rmodel = new Model.Right();
                    //        rmodel.PageName = "outlyxx";
                    //        rmodel.Rights = (int)outlyxxright;
                    //        rmodel.UserName = model.AdminName;
                    //        rbll.Add(rmodel);
                    //    }
                    //}
                    //#endregion


                    //#region 匯入領域廠商信息權限
                    //RightStatus exceldrright = RightStatus.Empty;


                    //if (cbexceldrSelect.Checked)
                    //{
                    //    exceldrright = exceldrright | RightStatus.Select;
                    //}

                    //rmodel = rbll.GetModel(model.AdminName, "exceldr");
                    //if (rmodel != null)
                    //{
                    //    if (exceldrright != RightStatus.Empty)
                    //    {
                    //        rmodel.Rights = (int)exceldrright;
                    //        rbll.Update(rmodel);
                    //    }
                    //    else
                    //    {
                    //        rbll.Delete(rmodel.RightID);
                    //    }
                    //}
                    //else
                    //{
                    //    if (exceldrright != RightStatus.Empty)
                    //    {
                    //        rmodel = new Model.Right();
                    //        rmodel.PageName = "exceldr";
                    //        rmodel.Rights = (int)exceldrright;
                    //        rmodel.UserName = model.AdminName;
                    //        rbll.Add(rmodel);
                    //    }
                    //}
                    //#endregion

                    #region 回收桶權限
                    RightStatus lyxxroverrights = RightStatus.Empty;

                    if (cblyxxroverDelete.Checked)
                    {
                        lyxxroverrights = lyxxroverrights | RightStatus.Delete;
                    }
                    if (cblyxxroverUpdate.Checked)
                    {
                        lyxxroverrights = lyxxroverrights | RightStatus.Update;
                    }
                    if (cblyxxroverSelect.Checked)
                    {
                        lyxxroverrights = lyxxroverrights | RightStatus.Select;
                    }

                    rmodel = rbll.GetModel(model.AdminName, "lyxxrover");
                    if (rmodel != null)
                    {
                        if (lyxxroverrights != RightStatus.Empty)
                        {
                            rmodel.Rights = (int)lyxxroverrights;
                            rbll.Update(rmodel);
                        }
                        else
                        {
                            rbll.Delete(rmodel.RightID);
                        }
                    }
                    else
                    {
                        if (lyxxroverrights != RightStatus.Empty)
                        {
                            rmodel = new Model.Right();
                            rmodel.PageName = "lyxxrover";
                            rmodel.Rights = (int)lyxxroverrights;
                            rmodel.UserName = model.AdminName;
                            rbll.Add(rmodel);
                        }
                    }
                    #endregion


                    #region 文章回收桶權限
                    RightStatus actualprojectrover = RightStatus.Empty;

                    if (cbActualroverDelete.Checked)
                    {
                        actualprojectrover = actualprojectrover | RightStatus.Delete;
                    }
                    if (cbActualroverUpdate.Checked)
                    {
                        actualprojectrover = actualprojectrover | RightStatus.Update;
                    }
                    if (cbActualroverSelect.Checked)
                    {
                        actualprojectrover = actualprojectrover | RightStatus.Select;
                    }

                    rmodel = rbll.GetModel(model.AdminName, "newsrover");
                    if (rmodel != null)
                    {
                        if (actualprojectrover != RightStatus.Empty)
                        {
                            rmodel.Rights = (int)actualprojectrover;
                            rbll.Update(rmodel);
                        }
                        else
                        {
                            rbll.Delete(rmodel.RightID);
                        }
                    }
                    else
                    {
                        if (actualprojectrover != RightStatus.Empty)
                        {
                            rmodel = new Model.Right();
                            rmodel.PageName = "newsrover";
                            rmodel.Rights = (int)actualprojectrover;
                            rmodel.UserName = model.AdminName;
                            rbll.Add(rmodel);
                        }
                    }
                    #endregion



                    //#region 匯出LOGO圖信息
                    //RightStatus outlogoright = RightStatus.Empty;


                    //if (cbOutlogoSelect.Checked)
                    //{
                    //    outlogoright = outlogoright | RightStatus.Select;
                    //}

                    //rmodel = rbll.GetModel(model.AdminName, "outlogo");
                    //if (rmodel != null)
                    //{
                    //    if (outlogoright != RightStatus.Empty)
                    //    {
                    //        rmodel.Rights = (int)outlogoright;
                    //        rbll.Update(rmodel);
                    //    }
                    //    else
                    //    {
                    //        rbll.Delete(rmodel.RightID);
                    //    }
                    //}
                    //else
                    //{
                    //    if (outlogoright != RightStatus.Empty)
                    //    {
                    //        rmodel = new Model.Right();
                    //        rmodel.PageName = "outlogo";
                    //        rmodel.Rights = (int)outlogoright;
                    //        rmodel.UserName = model.AdminName;
                    //        rbll.Add(rmodel);
                    //    }
                    //}
                    //#endregion


                    //#region 匯入LOGO圖信息
                    //RightStatus logodrright = RightStatus.Empty;


                    //if (cbLogodrInsert.Checked)
                    //{
                    //    logodrright = logodrright | RightStatus.Insert;
                    //}

                    //rmodel = rbll.GetModel(model.AdminName, "logodr");
                    //if (rmodel != null)
                    //{
                    //    if (logodrright != RightStatus.Empty)
                    //    {
                    //        rmodel.Rights = (int)logodrright;
                    //        rbll.Update(rmodel);
                    //    }
                    //    else
                    //    {
                    //        rbll.Delete(rmodel.RightID);
                    //    }
                    //}
                    //else
                    //{
                    //    if (logodrright != RightStatus.Empty)
                    //    {
                    //        rmodel = new Model.Right();
                    //        rmodel.PageName = "logodr";
                    //        rmodel.Rights = (int)logodrright;
                    //        rmodel.UserName = model.AdminName;
                    //        rbll.Add(rmodel);
                    //    }
                    //}
                    //#endregion

                    #region 友好連結及合作夥伴
                    RightStatus friendlyright = RightStatus.Empty;
                    if (cbFpInsert.Checked)
                    {
                        friendlyright = friendlyright | RightStatus.Insert;
                    }
                    if (cbFpDelete.Checked)
                    {
                        friendlyright = friendlyright | RightStatus.Delete;
                    }
                    if (cbFpUpdate.Checked)
                    {
                        friendlyright = friendlyright | RightStatus.Update;
                    }
                    if (cbFpSelect.Checked)
                    {
                        friendlyright = friendlyright | RightStatus.Select;
                    }

                    rmodel = rbll.GetModel(model.AdminName, "friendly");
                    if (rmodel != null)
                    {
                        if (friendlyright != RightStatus.Empty)
                        {
                            rmodel.Rights = (int)friendlyright;
                            rbll.Update(rmodel);
                        }
                        else
                        {
                            rbll.Delete(rmodel.RightID);
                        }
                    }
                    else
                    {
                        if (friendlyright != RightStatus.Empty)
                        {
                            rmodel = new Model.Right();
                            rmodel.PageName = "friendly";
                            rmodel.Rights = (int)friendlyright;
                            rmodel.UserName = model.AdminName;
                            rbll.Add(rmodel);
                        }
                    }
                    #endregion
                    #region 友好連結匯入匯出權限
                    RightStatus friendlyupdownright = RightStatus.Empty;
                    if (cbFriendlyUpload.Checked)
                    {
                        friendlyupdownright = friendlyupdownright | RightStatus.Insert;
                    }
                    if (cbFriendlyDownload.Checked)
                    {
                        friendlyupdownright = friendlyupdownright | RightStatus.Delete;
                    }

                    rmodel = rbll.GetModel(model.AdminName, "friendlyupdown");
                    if (rmodel != null)
                    {
                        if (friendlyupdownright != RightStatus.Empty)
                        {
                            rmodel.Rights = (int)friendlyupdownright;
                            rbll.Update(rmodel);
                        }
                        else
                        {
                            rbll.Delete(rmodel.RightID);
                        }
                    }
                    else
                    {
                        if (friendlyupdownright != RightStatus.Empty)
                        {
                            rmodel = new Model.Right();
                            rmodel.PageName = "friendlyupdown";
                            rmodel.Rights = (int)friendlyupdownright;
                            rmodel.UserName = model.AdminName;
                            rbll.Add(rmodel);
                        }
                    }
                    #endregion

                    #region 合作夥伴匯入匯出權限
                    RightStatus partnersupdownright = RightStatus.Empty;
                    if (cbPartnersUpload.Checked)
                    {
                        partnersupdownright = partnersupdownright | RightStatus.Insert;
                    }
                    if (cbPartnersDownload.Checked)
                    {
                        partnersupdownright = partnersupdownright | RightStatus.Delete;
                    }

                    rmodel = rbll.GetModel(model.AdminName, "partnersupdown");
                    if (rmodel != null)
                    {
                        if (partnersupdownright != RightStatus.Empty)
                        {
                            rmodel.Rights = (int)partnersupdownright;
                            rbll.Update(rmodel);
                        }
                        else
                        {
                            rbll.Delete(rmodel.RightID);
                        }
                    }
                    else
                    {
                        if (partnersupdownright != RightStatus.Empty)
                        {
                            rmodel = new Model.Right();
                            rmodel.PageName = "partnersupdown";
                            rmodel.Rights = (int)partnersupdownright;
                            rmodel.UserName = model.AdminName;
                            rbll.Add(rmodel);
                        }
                    }
                    #endregion


                    //#region 翻译领域權限
                    //RightStatus zone = RightStatus.Empty;
                    //if (this.cbZoneAdd.Checked)
                    //{
                    //    zone = zone | RightStatus.Insert;
                    //}
                    //if (this.cbZoneDel.Checked)
                    //{
                    //    zone = zone | RightStatus.Delete;
                    //}
                    //if (this.cbZoneEdit.Checked)
                    //{
                    //    zone = zone | RightStatus.Update;
                    //}
                    //if (this.cbZoneQuery.Checked)
                    //{
                    //    zone = zone | RightStatus.Select;
                    //}

                    //rmodel = rbll.GetModel(model.AdminName, "zone");
                    //if (rmodel != null)
                    //{
                    //    if (zone != RightStatus.Empty)
                    //    {
                    //        rmodel.Rights = (int)zone;
                    //        rbll.Update(rmodel);
                    //    }
                    //    else
                    //    {
                    //        rbll.Delete(rmodel.RightID);
                    //    }
                    //}
                    //else
                    //{
                    //    if (zone != RightStatus.Empty)
                    //    {
                    //        rmodel = new Model.Right();
                    //        rmodel.PageName = "zone";
                    //        rmodel.Rights = (int)zone;
                    //        rmodel.UserName = model.AdminName;
                    //        rbll.Add(rmodel);
                    //    }
                    //}
                    //#endregion

                    //#region 翻译领域回收桶權限
                    //RightStatus zonedelbox = RightStatus.Empty;
                    //if (this.cbZoneAdd.Checked)
                    //{
                    //    zonedelbox = zonedelbox | RightStatus.Insert;
                    //}
                    //if (this.cbZoneDel.Checked)
                    //{
                    //    zonedelbox = zonedelbox | RightStatus.Delete;
                    //}
                    //if (this.cbZoneEdit.Checked)
                    //{
                    //    zonedelbox = zonedelbox | RightStatus.Update;
                    //}
                    //if (this.cbZoneQuery.Checked)
                    //{
                    //    zonedelbox = zonedelbox | RightStatus.Select;
                    //}

                    //rmodel = rbll.GetModel(model.AdminName, "zonedelbox");
                    //if (rmodel != null)
                    //{
                    //    if (zonedelbox != RightStatus.Empty)
                    //    {
                    //        rmodel.Rights = (int)zone;
                    //        rbll.Update(rmodel);
                    //    }
                    //    else
                    //    {
                    //        rbll.Delete(rmodel.RightID);
                    //    }
                    //}
                    //else
                    //{
                    //    if (zonedelbox != RightStatus.Empty)
                    //    {
                    //        rmodel = new Model.Right();
                    //        rmodel.PageName = "zonedelbox";
                    //        rmodel.Rights = (int)zonedelbox;
                    //        rmodel.UserName = model.AdminName;
                    //        rbll.Add(rmodel);
                    //    }
                    //}
                    //#endregion

                    //#region 翻译领域类别權限
                    //RightStatus zonetype = RightStatus.Empty;
                    //if (this.cbZoneTypeAdd.Checked)
                    //{
                    //    zonetype = zonetype | RightStatus.Insert;
                    //}
                    //if (this.cbZoneTypeDel.Checked)
                    //{
                    //    zonetype = zonetype | RightStatus.Delete;
                    //}
                    //if (this.cbZoneTypeEdit.Checked)
                    //{
                    //    zonetype = zonetype | RightStatus.Update;
                    //}
                    //if (this.cbZoneTypeQuery.Checked)
                    //{
                    //    zonetype = zonetype | RightStatus.Select;
                    //}

                    //rmodel = rbll.GetModel(model.AdminName, "zonetype");
                    //if (rmodel != null)
                    //{
                    //    if (zonetype != RightStatus.Empty)
                    //    {
                    //        rmodel.Rights = (int)zonetype;
                    //        rbll.Update(rmodel);
                    //    }
                    //    else
                    //    {
                    //        rbll.Delete(rmodel.RightID);
                    //    }
                    //}
                    //else
                    //{
                    //    if (zonetype != RightStatus.Empty)
                    //    {
                    //        rmodel = new Model.Right();
                    //        rmodel.PageName = "zonetype";
                    //        rmodel.Rights = (int)zonetype;
                    //        rmodel.UserName = model.AdminName;
                    //        rbll.Add(rmodel);
                    //    }
                    //}
                    //#endregion

             

                    #region 翻译团队權限
                    RightStatus team = RightStatus.Empty;
                    if (this.cbTeamAdd.Checked)
                    {
                        team = team | RightStatus.Insert;
                    }
                    if (this.cbTeamDel.Checked)
                    {
                        team = team | RightStatus.Delete;
                    }
                    if (this.cbTeamEdit.Checked)
                    {
                        team = team | RightStatus.Update;
                    }
                    if (this.cbTeamQuery.Checked)
                    {
                        team = team | RightStatus.Select;
                    }

                    rmodel = rbll.GetModel(model.AdminName, "team");
                    if (rmodel != null)
                    {
                        if (team != RightStatus.Empty)
                        {
                            rmodel.Rights = (int)team;
                            rbll.Update(rmodel);
                        }
                        else
                        {
                            rbll.Delete(rmodel.RightID);
                        }
                    }
                    else
                    {
                        if (team != RightStatus.Empty)
                        {
                            rmodel = new Model.Right();
                            rmodel.PageName = "team";
                            rmodel.Rights = (int)team;
                            rmodel.UserName = model.AdminName;
                            rbll.Add(rmodel);
                        }
                    }
                    #endregion

                    #region 翻译团队类别權限
                    RightStatus teamtype = RightStatus.Empty;
                    if (this.cbTeamTypeAdd.Checked)
                    {
                        teamtype = teamtype | RightStatus.Insert;
                    }
                    if (this.cbTeamTypeDel.Checked)
                    {
                        teamtype = teamtype | RightStatus.Delete;
                    }
                    if (this.cbTeamTypeEdit.Checked)
                    {
                        teamtype = teamtype | RightStatus.Update;
                    }
                    if (this.cbTeamTypeQuery.Checked)
                    {
                        teamtype = teamtype | RightStatus.Select;
                    }

                    rmodel = rbll.GetModel(model.AdminName, "teamtype");
                    if (rmodel != null)
                    {
                        if (teamtype != RightStatus.Empty)
                        {
                            rmodel.Rights = (int)teamtype;
                            rbll.Update(rmodel);
                        }
                        else
                        {
                            rbll.Delete(rmodel.RightID);
                        }
                    }
                    else
                    {
                        if (teamtype != RightStatus.Empty)
                        {
                            rmodel = new Model.Right();
                            rmodel.PageName = "teamtype";
                            rmodel.Rights = (int)teamtype;
                            rmodel.UserName = model.AdminName;
                            rbll.Add(rmodel);
                        }
                    }
                    #endregion


                    #region 子網站管理
                    RightStatus subweb = RightStatus.Empty;
                    if (this.cbSwInsert.Checked)
                    {
                        subweb = subweb | RightStatus.Insert;
                    }
                    if (this.cbSwDelete.Checked)
                    {
                        subweb = subweb | RightStatus.Delete;
                    }
                    if (this.cbSwUpdate.Checked)
                    {
                        subweb = subweb | RightStatus.Update;
                    }
                    if (this.cbSwSelect.Checked)
                    {
                        subweb = subweb | RightStatus.Select;
                    }

                    rmodel = rbll.GetModel(model.AdminName, "subweb");
                    if (rmodel != null)
                    {
                        if (subweb != RightStatus.Empty)
                        {
                            rmodel.Rights = (int)subweb;
                            rbll.Update(rmodel);
                        }
                        else
                        {
                            rbll.Delete(rmodel.RightID);
                        }
                    }
                    else
                    {
                        if (subweb != RightStatus.Empty)
                        {
                            rmodel = new Model.Right();
                            rmodel.PageName = "subweb";
                            rmodel.Rights = (int)subweb;
                            rmodel.UserName = model.AdminName;
                            rbll.Add(rmodel);
                        }
                    }
                    #endregion



                    ClientScript.RegisterStartupScript(GetType(), "success", "alert('權限分配成功!');window.location.href='Manage.aspx';", true);
                    return;
                } else {
                    ClientScript.RegisterStartupScript(GetType(), "error", "alert('該管理員不存在!!');window.location.href='Manage.aspx';", true);
                    return;
                }
            } else {
                ClientScript.RegisterStartupScript(GetType(), "error", "alert('該管理員不存在!!');window.location.href='Manage.aspx';", true);
                return;
            }
        }
    }
}
