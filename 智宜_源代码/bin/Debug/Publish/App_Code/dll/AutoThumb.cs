using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.WebControls;
using System.Web;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ZeroStudio.Helper
{
    public class AutoThumb
    {
        #region 自动缩略图函数
        /// <summary>
        /// 自动缩略图函数
        /// </summary>
        /// <param name="_FU">上傳圖片的FileUpload控件</param>
        /// <param name="_LB">存储圖片名称的TextBox</param>
        /// <param name="_Thumbwidth">生成的缩略图宽度</param>
        /// <param name="_Prefix">缩略图名称后缀</param>
        /// <returns></returns>
        public static void UploadThumbnail(FileUpload _FU, TextBox _TB, int _Thumbwidth, string _Prefix)
        {
            try
            {
               
                //上傳原始圖片檔案
                string fname;
                string fpath;
                fname = CommonFunction.ReplaceStr2(_FU.FileName);
                fpath = HttpContext.Current.Server.MapPath("~/") + "UploadFiles\\" + fname;
                _FU.SaveAs(fpath);

                //初始化缩略图长、宽、名称、存储路径
                string Fe = fname.Substring(fname.LastIndexOf(".") + 1);
                string thname = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() +_Prefix+ "." + Fe;
                string thpath = HttpContext.Current.Server.MapPath("~/") + "UploadFiles\\" + thname;


                //将原始圖片信息读取入创建的 Image 对象中
                System.Drawing.Image image = System.Drawing.Image.FromFile(fpath);

                //获取原始圖片长宽
                int srcWidth = image.Width;
                int srcHeight = image.Height;

                //指定缩略圖片高度
                int thumbwidth = _Thumbwidth;

                //根据原始圖片长宽按比例计算得缩略图高度
                int thumbHeight = srcHeight * thumbwidth / srcWidth;

                //根据缩略图长宽创建一個空的位图对象
                Bitmap bmp = new Bitmap(thumbwidth, thumbHeight);

                //创建一個绘图对象 并读取刚创建的空位图对象
                Graphics GR = Graphics.FromImage(bmp);

                //指定绘图对象为高质量绘图模式
                GR.SmoothingMode = SmoothingMode.HighQuality;
                GR.CompositingQuality = CompositingQuality.HighQuality;
                GR.InterpolationMode = InterpolationMode.High;

                //
                Rectangle rectDestination = new Rectangle(0, 0, thumbwidth, thumbHeight);

                //利用绘图对象进行图像重绘
                GR.DrawImage(image, rectDestination, 0, 0, srcWidth, srcHeight, GraphicsUnit.Pixel);

                //存储重绘的缩略圖片
                bmp.Save(thpath);

                //释放资源
                bmp.Dispose();
                image.Dispose();

                //删除原始圖片
                CommonFunction.DelFile(fpath);

                _TB.Text = "UploadFiles\\" + thname;
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}
