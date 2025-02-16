using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Helper;
using DBUtility;

public partial class recruitment_index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Request["action"]=="save")
        {

	 
        string  sUserName = Request.Form["username"]; 
        string  sAge = Request.Form["age"]; 
        string  sSex = Request.Form["rGender"];
        string  sCountry = "台灣";
        string  sWorkType = " ";
        string  sIsLearning = Request.Form["rislearning"];
        string  sTopGraduation = Request.Form["topgraduation"];
        string  sLanguage = " ";
        string  sMasterLanguage = Request.Form["masterlanguage"];
        string  sExperience = Request.Form["experience"];
        string  sSeniority = Request.Form["seniority"];
        string  sTranslationAmount = Request.Form["translationamount"];
        string  sTransLationSkill = " ";
        string  sSoftwareSkill = " ";
        string  sTEL = Request.Form["tel"];
        string  sEmail = Request.Form["email"];
        string  sQQ = Request.Form["qq"];
        string  sMSN = Request.Form["msn"];
        string sCreateDate = DateTime.Now.ToShortDateString();
   
        for(int i=1;i<6;i++){
              if(sWorkType.Length <1)
              {
                    string dWorkType=""; 
                    dWorkType = Request.Form["worktype" + i];
                    if(dWorkType!=null)
                    {
                    sWorkType = dWorkType;
                    }
              }
              else{
                string ddWorkType=""; 
                ddWorkType = Request.Form["worktype" + i];
                if(ddWorkType!=null)
                {
                    sWorkType = sWorkType + "|" + i.ToString();
                }
              }
          }
   
       for(int i=1;i<20;i++)
       {
          if( sLanguage.Length <1){
                string dLanguage ="";
                dLanguage = Request.Form["Language" + i];
                if(dLanguage!=null)
                {
                  sLanguage = i.ToString();
                }
            }
         else{
                string ddLanguage="";
                ddLanguage = Request.Form["Language" + i];
                if(ddLanguage!=null)
                {
                    sLanguage = sLanguage + "|" + i.ToString();
                }
            }
      }
   
   for(int i=1;i<88;i++)
   {
      if(sTransLationSkill.Length <1 )
      {
            string dTransLationSkill ="";
            dTransLationSkill = Request.Form["translationskill" + i];
            if( dTransLationSkill!=null)
            {
              sTransLationSkill = i.ToString();
            }
      }
      else{
            string ddTransLationSkill="";
            ddTransLationSkill = Request.Form["translationskill" + i];
            if(  ddTransLationSkill!=null){
               sTransLationSkill = sTransLationSkill + "|" + i.ToString();
              }
            }
      }

    for(int i=1;i<20;i++)
    {
      if( sSoftwareSkill.Length <1)
      {
            string dSoftwareSkill="";
            dSoftwareSkill = Request.Form["softwareskill" + i];
            if( dSoftwareSkill!=null)
            {
              sSoftwareSkill = i.ToString();
            }
        }
       else{
            string ddSoftwareSkill="";
            ddSoftwareSkill = Request.Form["softwareskill" + i];
            if(  ddSoftwareSkill!=null)
            {
               sSoftwareSkill = sSoftwareSkill + "|" + i.ToString();
            }
        }
   }

        Model.TranslatorList model=new Model.TranslatorList();
        model.UserName=sUserName;
        model.Age=sAge;
        model.Sex=sSex;
        model.Country=sCountry;
        model.WorkType=sWorkType;
        model.TopGraduation=sTopGraduation;
        model.IsLearning=sIsLearning;
        model.Language=sLanguage;
        model.MasterLanguage=sMasterLanguage;
        model.Experience=sExperience;
        model.Seniority=sSeniority;
        model.TranslationAmount=sTranslationAmount;
        model.Mark=" ";
        model.TransLationSkill=sTransLationSkill;
        model.SoftwareSkill=sSoftwareSkill;
        model.TEL=sTEL;
        model.Email=sEmail;
        model.QQ=sQQ;
        model.MSN=sMSN;
        model.Creator=" ";
        model.CreateDate=sCreateDate;
        model.state=0;

        //new BLL.TranslatorList().Add(model);

        string sql1 = "insert into crowns.dbo.TranslatorList(UserName,Age,Sex,Country,WorkType,TopGraduation,IsLearning,[Language],MasterLanguage,Experience,Seniority,TranslationAmount,Mark,TransLationSkill,SoftwareSkill,TEL,Email,QQ,MSN,Creator,CreateDate,state) " +
            "values('" + model.UserName + "','" + model.Age + "','" + model.Sex + "','" + model.Country + "','" + model.WorkType + "','" + model.TopGraduation + "','" + model.IsLearning + "','" + model.Language + "','" + model.MasterLanguage + "','" + model.Experience + "','" + model.Seniority + "','" + model.TranslationAmount + "','" + model.Mark + "','" + model.TransLationSkill + "','" + model.SoftwareSkill + "','" + model.TEL + "','" + model.Email + "','" + model.QQ + "','" + model.MSN + "','" + model.Creator + "','" + model.CreateDate + "'," + model.state + ")";


        DbHelperSQL.ExecuteSql(sql1.ToString());

        MyTool.alert("感謝你的應徵，我們會在合適的時機與你聯繫！", "index.aspx");
    
   
  //sql="insert into TranslatorList(UserName,Age,Sex,Country,WorkType,TopGraduation,IsLearning,[Language],MasterLanguage,Experience,Seniority,TranslationAmount,TransLationSkill,SoftwareSkill,TEL,Email,QQ,MSN,CreateDate) values('"&sUserName&"','"&sAge&"','"&sSex&"','"&sCountry&"','"&sWorkType&"','"&sTopGraduation&"','"&sIsLearning&"','"&sLanguage&"','"&sMasterLanguage&"','"&sExperience&"','"&sSeniority&"','"&sTranslationAmount&"','"&sTransLationSkill&"','"&sSoftwareSkill&"','"&sTEL&"','"&sEmail&"','"&sQQ&"','"&sMSN&"','"&sCreateDate&"')"   
  //'sql="insert into TranslatorList(UserName,Age,Sex,Country,WorkType,TopGraduation,IsLearning,[Language]) values('"&sUserName&"','"&sAge&"','"&sSex&"','"&sCountry&"','"&sWorkType&"','"&sTopGraduation&"','"&sIsLearning&"','"&sLanguage&"')"   
  

  //objConnMS.execute(sql)   
  //objConnMS.close()   
  //set   objConnMS=nothing  
  
  //response.write"<script>alert('稰谅眤挤恶糶虏菌иΜ璝Τ闽ン穦鲸硉叫盡舱籔眤羛蹈揪');window.location.href='index-houguan-game-translation.aspx';</script>"
        }
    }
}
