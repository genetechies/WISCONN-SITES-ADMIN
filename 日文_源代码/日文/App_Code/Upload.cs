using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.SessionState;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using Helper;

/// <summary>
/// Upload 的摘要说明
/// </summary>
public class Upload : IHttpHandler, IRequiresSessionState {
    public Upload() {
    }

    #region IHttpHandler Members

    public bool IsReusable {
        get { return true; }
    }

    public void ProcessRequest(HttpContext context) {

        try {
            if (context.Request.Files.Count > 0) {

                string uploadPath = context.Server.MapPath("~/UploadFiles/");

                if (Directory.Exists(uploadPath) == false) {
                    Directory.CreateDirectory(uploadPath);
                }

                for (int j = 0; j < context.Request.Files.Count; j++) {

                    HttpPostedFile uploadFile = context.Request.Files[j];

                    if (uploadFile.ContentLength > 0) {

                        uploadFile.SaveAs(Path.Combine(uploadPath, uploadFile.FileName));
                        AutoThumb.MakeThumbnail(Path.Combine(uploadPath, uploadFile.FileName), 160, 140);
                    }
                }
            }
        } catch (Exception ex) {
            HttpContext.Current.Response.Redirect("error.aspx?err=" + ex.Message);
            //HttpContext.Current.Response.Write(ex.Message);
        }
        //HttpContext.Current.Response.Write(" ");

    }

    #endregion
}