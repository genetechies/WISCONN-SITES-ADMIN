<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditRight.aspx.cs" Inherits="Web.Admin.Manager.EditRight" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>編輯權限</title>
    <link href="../Css.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <table class="table_main">
                <tr>
                    <td  class="table_tittle" align="center" colspan="2">編輯權限</td>
                </tr>
                <tr>
                    <td align="right" width="10%">管理員：</td>
                    <td align="left" >
                        <asp:Label ID="lblManager" runat="server" ></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="right" width="10%">網站基本設置：</td>
                    <td align="left">
                        <asp:CheckBox ID="chWebsetUpdate" runat="server" Text="修改" />
                    </td>
                </tr>
            <%--    <tr>
                    <td align="right" width="10%">前台網頁管理權限：</td>
                    <td align="left">
                        <asp:CheckBox ID="cbjbNewsUpdate" runat="server" Text="修改" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbjbNewsSelect" runat="server" Text="查詢" />&nbsp;&nbsp;&nbsp;
                    </td>
                </tr>--%>
                <tr>
                    <td align="right" width="10%">翻譯資訊文章管理權限：</td>
                    <td align="left">
                        <asp:CheckBox ID="cbNewsInsert" runat="server" Text="新增" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbNewsDelete" runat="server" Text="刪除" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbNewsUpdate" runat="server" Text="修改" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbNewsSelect" runat="server" Text="查詢" />&nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td align="right" width="10%">翻譯資訊文章類別管理權限：</td>
                    <td align="left">
                        <asp:CheckBox ID="cbArticleclassInsert" runat="server" Text="新增" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbArticleclassDelete" runat="server" Text="刪除" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbArticleclassUpdate" runat="server" Text="修改" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbArticleclassSelect" runat="server" Text="查詢" />&nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
                 <tr>
                    <td align="right" width="10%">翻譯資訊文章回收桶權限：</td>
                    <td align="left">
                        <asp:CheckBox ID="cbActualroverDelete" runat="server" Text="刪除" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbActualroverUpdate" runat="server" Text="復原" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbActualroverSelect" runat="server" Text="查詢" />&nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
                
                <tr>
                    <td align="right" width="10%">翻譯領域管理權限：</td>
                    <td align="left">
                        <asp:CheckBox ID="cbZoneAdd" runat="server" Text="新增" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbZoneDel" runat="server" Text="刪除" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbZoneEdit" runat="server" Text="修改" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbZoneQuery" runat="server" Text="查詢" />&nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td align="right" width="10%">翻譯領域類別管理權限：</td>
                    <td align="left">
                        <asp:CheckBox ID="cbZoneTypeAdd" runat="server" Text="新增" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbZoneTypeDel" runat="server" Text="刪除" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbZoneTypeEdit" runat="server" Text="修改" />&nbsp;&nbsp;&nbsp; 
                        <asp:CheckBox ID="cbZoneTypeQuery" runat="server" Text="查詢" />&nbsp;&nbsp;&nbsp;                       
                    </td>
                </tr>
                  <tr>
                    <td align="right" width="10%">翻譯領域回收桶權限：</td>
                    <td align="left">
                        <asp:CheckBox ID="cbZoneDelBoxDelete" runat="server" Text="刪除" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbZoneDelBoxUpdate" runat="server" Text="復原" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbZoneDelBoxSelect" runat="server" Text="查詢" />&nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
                <!--/领域 -->
                
                 <tr>
                    <td align="right" width="10%">翻譯團隊管理權限：</td>
                    <td align="left">
                        <asp:CheckBox ID="cbTeamAdd" runat="server" Text="新增" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbTeamDel" runat="server" Text="刪除" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbTeamEdit" runat="server" Text="修改" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbTeamQuery" runat="server" Text="查詢" />&nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td align="right" width="10%">翻譯團隊類別管理權限：</td>
                    <td align="left">
                        <asp:CheckBox ID="cbTeamTypeAdd" runat="server" Text="新增" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbTeamTypeDel" runat="server" Text="刪除" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbTeamTypeEdit" runat="server" Text="修改" />&nbsp;&nbsp;&nbsp;  
                        <asp:CheckBox ID="cbTeamTypeQuery" runat="server" Text="查詢" />&nbsp;&nbsp;&nbsp;                      
                    </td>
                </tr<!--/团队 -->
                
                <tr>
                    <td align="right" width="10%">國家類別管理權限：</td>
                    <td align="left">
                        <asp:CheckBox ID="cbActualprojectInsert" runat="server" Text="新增" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbActualprojectDelete" runat="server" Text="刪除" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbActualprojectUpdate" runat="server" Text="修改" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbActualprojectSelect" runat="server" Text="查詢" />&nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td align="right" width="10%">領域類別管理權限：</td>
                    <td align="left">
                        <asp:CheckBox ID="cbLinyuclassInsert" runat="server" Text="新增" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbLinyuclassDelete" runat="server" Text="刪除" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbLinyuclassUpdate" runat="server" Text="修改" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbLinyuclassSelect" runat="server" Text="查詢" />&nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td align="right" width="10%">LOGO小圖管理權限：</td>
                    <td align="left">
                        <asp:CheckBox ID="cbSignInsert" runat="server" Text="新增" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbSignDelete" runat="server" Text="刪除" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbSignUpdate" runat="server" Text="修改" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbSignSelect" runat="server" Text="查詢" />&nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td align="right" width="10%">LOGO圖批量上傳權限：</td>
                    <td align="left">
                        <asp:CheckBox ID="chPluppicSelect" runat="server" Text="批量上傳" />&nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td align="right" width="10%">匯出LOGO圖權限：</td>
                    <td align="left">
                        
                        <asp:CheckBox ID="cbOutlogoSelect" runat="server" Text="匯出" />&nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
                
                <tr>
                    <td align="right" width="10%">匯入LOGO圖權限：</td>
                    <td align="left">
                        <asp:CheckBox ID="cbLogodrInsert" runat="server" Text="匯入" />&nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
                
                <tr>
                    <td align="right" width="10%">領域廠商管理權限：</td>
                    <td align="left">
                        <asp:CheckBox ID="cbSignTypeInsert" runat="server" Text="新增" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbSignTypeDelete" runat="server" Text="刪除" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbSignTypeUpdate" runat="server" Text="修改" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbSignTypeSelect" runat="server" Text="查詢" />&nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td align="right" width="10%">匯出領域廠商權限：</td>
                    <td align="left">
                        
                        <asp:CheckBox ID="cboutlyxxSelect" runat="server" Text="匯出" />&nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
                
                <tr>
                    <td align="right" width="10%">匯入領域廠商權限：</td>
                    <td align="left">
                        <asp:CheckBox ID="cbexceldrSelect" runat="server" Text="匯入" />&nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
                 <tr>
                    <td align="right" width="10%">回收桶權限：</td>
                    <td align="left">
                        <asp:CheckBox ID="cblyxxroverDelete" runat="server" Text="刪除" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cblyxxroverUpdate" runat="server" Text="還原" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cblyxxroverSelect" runat="server" Text="查詢" />&nbsp;&nbsp;&nbsp;
                    </td>
                </tr>

                <tr>
                    <td align="right" width="10%">線上詢價管理權限：</td>
                    <td align="left">
                        <asp:CheckBox ID="cbGuestDelete" runat="server" Text="刪除" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbGuestUpdate" runat="server" Text="修改" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbGuestSelect" runat="server" Text="查詢" />&nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td align="right" width="10%">指定發送E-MAIL權限：</td>
                    <td align="left">
                        <asp:CheckBox ID="cbEmailInsert" runat="server" Text="新增" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbEmailDelete" runat="server" Text="刪除" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbEmailUpdate" runat="server" Text="修改" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbEmailSelect" runat="server" Text="查詢" />&nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td align="right" width="10%">人才招募管理權限：</td>
                    <td align="left">
                        <asp:CheckBox ID="cbZhaopinInsert" runat="server" Text="新增" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbZhaopinDelete" runat="server" Text="刪除" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbZhaopinUpdate" runat="server" Text="修改" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbZhaopinSelect" runat="server" Text="查詢" />&nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td align="right" width="10%">求職履歷管理權限：</td>
                    <td align="left">
                        <asp:CheckBox ID="cbYingpinDelete" runat="server" Text="刪除" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbYingpinUpdate" runat="server" Text="修改" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbYingpinSelect" runat="server" Text="查詢" />&nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td align="right" width="10%">匯出履歷權限：</td>
                    <td align="left">
                        <asp:CheckBox ID="cbOutjianliSelect" runat="server" Text="匯出" />&nbsp;&nbsp;&nbsp;
                        
                    </td>
                </tr>
                <tr>
                    <td align="right" width="10%">友好連結及合作夥伴：</td>
                    <td align="left">
                        <asp:CheckBox ID="cbFpInsert" runat="server" Text="新增" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbFpDelete" runat="server" Text="刪除" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbFpUpdate" runat="server" Text="修改" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbFpSelect" runat="server" Text="查詢" />&nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td align="right" width="10%">友好連結匯入匯出權限：</td>
                    <td align="left">
                        <asp:CheckBox ID="cbFriendlyUpload" runat="server" Text="匯入" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbFriendlyDownload" runat="server" Text="匯出" />&nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
                 <tr>
                    <td align="right" width="10%">合作夥伴匯入匯出權限：</td>
                    <td align="left">
                        <asp:CheckBox ID="cbPartnersUpload" runat="server" Text="匯入" />&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="cbPartnersDownload" runat="server" Text="匯出" />&nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td  align="center" colspan="2">
                       <asp:Button ID="Button1" runat="server" Text="提交"  OnClick="Sub_Click"/>&nbsp;&nbsp;&nbsp;
                       <input id="Reset1" type="reset" value="取消" onclick="history.go(-1)" />
                    </td>
                </tr>
           </table>
    </div>
    </form>
</body>
</html>
