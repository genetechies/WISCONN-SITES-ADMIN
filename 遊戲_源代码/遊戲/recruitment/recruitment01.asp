<%@ codepage=950%>
 <%   
 'connection for MS Access in fa lab
	dim strConnectMS, objConnMS

	strConnectMS = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" &  Server.MapPath("/App_Data/db.mdb")

	set objConnMS = Server.CreateObject("ADODB.Connection")
	objConnMS.Open strConnectMS   
     
 ' Declare var 
   Dim sUserName,sAge,sSex,sCountry,sWorkType,sTopGraduation,sIsLearning,sLanguage,sMasterLanguage,sExperience,sSeniority
   Dim sTranslationAmount,sTransLationSkill,sSoftwareSkill,sTEL,sEmail,sQQ,sMSN,sCreateDate
	 
' Get users parameter
   sUserName = Request.Form("username") 
   sAge = Request.Form("age") 
   sSex = Request.Form("rGender")
   sCountry = "台灣"
   sWorkType = ""
   sIsLearning = Request.Form("rislearning")
   sTopGraduation = Request.Form("topgraduation")
   sLanguage = ""
   sMasterLanguage = Request.Form("masterlanguage")

   sExperience = Request.Form("experience")
   sSeniority = Request.Form("seniority")
   sTranslationAmount = Request.Form("translationamount")
   sTransLationSkill = ""
   sSoftwareSkill = ""
   sTEL = Request.Form("tel")
   sEmail = Request.Form("email")
   sQQ = Request.Form("qq")
   sMSN = Request.Form("msn")
   sCreateDate = now
   
  for i=1 to 5
      If Len(sWorkType) <1 Then 
	    Dim dWorkType 
		dWorkType = Request.Form("worktype" & i)
        If Len(dWorkType) > 0 then
          sWorkType = cstr(dWorkType)
        end if 
      Else
        Dim ddWorkType 
		ddWorkType = Request.Form("worktype" & i)
        If  Len(ddWorkType) > 0 then
           sWorkType = sWorkType & "|" & cstr(i)
        end if
      End if
   Next
   
   for i=1 to 19
      If Len(sLanguage) <1 Then 
	    Dim dLanguage 
		dLanguage = Request.Form("Language" & i)
        If Len(dLanguage) > 0 then
          sLanguage = cstr(i)
        end if 
      Else
        Dim ddLanguage
		ddLanguage = Request.Form("Language" & i)
        If  Len(ddLanguage) > 0 then
           sLanguage = sLanguage & "|" & cstr(i)
        end if
      End if
   Next
   
   for i=1 to 87
      If Len(sTransLationSkill) <1 Then 
	    Dim dTransLationSkill 
		dTransLationSkill = Request.Form("translationskill" & i)
        If Len(dTransLationSkill) > 0 then
          sTransLationSkill = cstr(i)
        end if 
      Else
        Dim ddTransLationSkill
		ddTransLationSkill = Request.Form("translationskill" & i)
        If  Len(ddTransLationSkill) > 0 then
           sTransLationSkill = sTransLationSkill & "|" & cstr(i)
        end if
      End if
    Next

	for i=1 to 19
      If Len(sSoftwareSkill) <1 Then 
	    Dim dSoftwareSkill
		dSoftwareSkill = Request.Form("softwareskill" & i)
        If Len(dSoftwareSkill) > 0 then
          sSoftwareSkill = cstr(i)
        end if 
      Else
        Dim ddSoftwareSkill
		ddSoftwareSkill = Request.Form("softwareskill" & i)
        If  Len(ddSoftwareSkill) > 0 then
           sSoftwareSkill = sSoftwareSkill & "|" & cstr(i)
        end if
      End if
     Next
    
   
  sql="insert into TranslatorList(UserName,Age,Sex,Country,WorkType,TopGraduation,IsLearning,[Language],MasterLanguage,Experience,Seniority,TranslationAmount,TransLationSkill,SoftwareSkill,TEL,Email,QQ,MSN,CreateDate) values('"&sUserName&"','"&sAge&"','"&sSex&"','"&sCountry&"','"&sWorkType&"','"&sTopGraduation&"','"&sIsLearning&"','"&sLanguage&"','"&sMasterLanguage&"','"&sExperience&"','"&sSeniority&"','"&sTranslationAmount&"','"&sTransLationSkill&"','"&sSoftwareSkill&"','"&sTEL&"','"&sEmail&"','"&sQQ&"','"&sMSN&"','"&sCreateDate&"')"   
  'sql="insert into TranslatorList(UserName,Age,Sex,Country,WorkType,TopGraduation,IsLearning,[Language]) values('"&sUserName&"','"&sAge&"','"&sSex&"','"&sCountry&"','"&sWorkType&"','"&sTopGraduation&"','"&sIsLearning&"','"&sLanguage&"')"   
  

  objConnMS.execute(sql)   
  objConnMS.close()   
  set   objConnMS=nothing  
  
  response.write"<script>alert('感謝您撥空填寫簡歷，我們已收到，若有相關案件會儘速請專案小組與您聯絡噢！');window.location.href='index-houguan-game-translation.aspx';</script>"
  %> 