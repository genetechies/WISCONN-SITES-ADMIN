using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using System.Web;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace Helper
{
    public class AutoThumb
    {
        #region 自动缩略图函数
        /// <summary>
        /// 自动缩略图函数
        /// </summary>
        /// <param name="_FU">上传图片的FileUpload控件</param>
        /// <param name="_LB">存储图片名称的TextBox</param>
        /// <param name="_Thumbwidth">生成的缩略图宽度</param>
        /// <param name="_Prefix">缩略图名称后缀</param>
        /// <returns></returns>
        public static void UploadThumbnail(FileUpload _FU, TextBox _TB, int _Thumbwidth, string _Prefix)
        {
            try
            {

                //上传原始图片文件
                string fname;
                string fpath;
                fname = CommonFunction.ReplaceStr2(_FU.FileName);
                fpath = HttpContext.Current.Server.MapPath("~/") + "UploadFiles\\" + fname;
                _FU.SaveAs(fpath);

                //初始化缩略图长、宽、名称、存储路径
                string Fe = fname.Substring(fname.LastIndexOf(".") + 1);
                string thname = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + _Prefix + "." + Fe;
                string thpath = HttpContext.Current.Server.MapPath("~/") + "UploadFiles\\" + thname;


                //将原始图片信息读取入创建的 Image 对象中
                System.Drawing.Image image = System.Drawing.Image.FromFile(fpath);

                //获取原始图片长宽
                int srcWidth = image.Width;
                int srcHeight = image.Height;

                //指定缩略图片高度
                int thumbwidth = _Thumbwidth;

                //根据原始图片长宽按比例计算得缩略图高度
                int thumbHeight = srcHeight * thumbwidth / srcWidth;

                //根据缩略图长宽创建一个空的位图对象
                Bitmap bmp = new Bitmap(thumbwidth, thumbHeight);

                //创建一个绘图对象 并读取刚创建的空位图对象
                Graphics GR = Graphics.FromImage(bmp);

                //指定绘图对象为高质量绘图模式
                GR.SmoothingMode = SmoothingMode.HighQuality;
                GR.CompositingQuality = CompositingQuality.HighQuality;
                GR.InterpolationMode = InterpolationMode.High;

                //
                Rectangle rectDestination = new Rectangle(0, 0, thumbwidth, thumbHeight);

                //利用绘图对象进行图像重绘
                GR.DrawImage(image, rectDestination, 0, 0, srcWidth, srcHeight, GraphicsUnit.Pixel);

                //存储重绘的缩略图片
                bmp.Save(thpath);

                //释放资源
                bmp.Dispose();
                image.Dispose();

                //删除原始图片
                CommonFunction.DelFile(fpath);

                _TB.Text = "UploadFiles\\" + thname;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //生成缩略图
        public static void MakeThumbnail(string originalImagePath, int width, int height)
        {

            //获取原始图片  

            System.Drawing.Image originalImage = null;
            try
            {
                originalImage = System.Drawing.Image.FromFile(originalImagePath);
            }
            catch (System.OutOfMemoryException)
            {
                if (originalImage != null)
                {
                    originalImage.Dispose();
                    return;
                }
            }
            if (originalImage == null)
            {
                return;
            }
            //缩略图画布宽高  

            int towidth = width;

            int toheight = height;

            //原始图片写入画布坐标和宽高(用来设置裁减溢出部分)  

            int x = 0;

            int y = 0;

            int ow = originalImage.Width;

            int oh = originalImage.Height;

            //原始图片画布,设置写入缩略图画布坐标和宽高(用来原始图片整体宽高缩放)  

            int bg_x = 0;

            int bg_y = 0;

            int bg_w = towidth;

            int bg_h = toheight;

            //倍数变量  

            double multiple = 0;

            //获取宽长的或是高长与缩略图的倍数  

            if (originalImage.Width >= originalImage.Height)
            {
                multiple = (double)originalImage.Width / (double)width;
            }
            else
            {
                multiple = (double)originalImage.Height / (double)height;
            }

            //上传的图片的宽和高小等于缩略图  

            if (ow <= width && oh <= height)
            {
                //缩略图按原始宽高  
                bg_w = originalImage.Width;
                bg_h = originalImage.Height;
                bg_x = Convert.ToInt32(((double)towidth - (double)ow) / 2);
                bg_y = Convert.ToInt32(((double)toheight - (double)oh) / 2);

            }
            else
            {//上传的图片的宽和高大于缩略图  

                //宽高按比例缩放  
                bg_w = Convert.ToInt32((double)originalImage.Width / multiple);
                bg_h = Convert.ToInt32((double)originalImage.Height / multiple);
                bg_y = Convert.ToInt32(((double)height - (double)bg_h) / 2);
                bg_x = Convert.ToInt32(((double)width - (double)bg_w) / 2);

            }

            //新建一个bmp图片,并设置缩略图大小.  

            System.Drawing.Image bitmap = new System.Drawing.Bitmap(towidth, toheight);

            //新建一个画板  

            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bitmap);

            //设置高质量插值法  

            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            //设置高质量,低速度呈现平滑程度  

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            //清空画布并设置白色背景色  

            g.Clear(System.Drawing.Color.White);

            //在指定位置并且按指定大小绘制原图片的指定部分  

            //第一个System.Drawing.Rectangle是原图片的画布坐标和宽高,第二个是原图片写在画布上的坐标和宽高,最后一个参数是指定数值单位为像素  

            g.DrawImage(originalImage, new System.Drawing.Rectangle(bg_x, bg_y, bg_w, bg_h), new System.Drawing.Rectangle(x, y, ow, oh), System.Drawing.GraphicsUnit.Pixel);

            try
            {

                //获取图片类型  

                //string fileExtension = System.IO.Path.GetExtension(originalImagePath).ToLower();

                //按原图片类型保存缩略图片,不按原格式图片会出现模糊,锯齿等问题.  
                /*
                switch (fileExtension) {

                    case ".gif": bitmap.Save(originalImagePath + "_" + towidth + "x" + toheight + ".gif", System.Drawing.Imaging.ImageFormat.Gif); break;

                    case ".jpg": bitmap.Save(originalImagePath + "_" + towidth + "x" + toheight + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg); break;

                    case ".bmp": bitmap.Save(originalImagePath + "_" + towidth + "x" + toheight + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp); break;

                    case ".png": bitmap.Save(originalImagePath + "_" + towidth + "x" + toheight + ".gif", System.Drawing.Imaging.ImageFormat.Png); break;

                }
                 */
                bitmap.Save(originalImagePath + "_s.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (System.Exception)
            {

            }
            finally
            {
                if (originalImage != null)
                    originalImage.Dispose();
                if (bitmap != null)
                    bitmap.Dispose();
                if (g != null)
                    g.Dispose();

            }
        }
        #endregion
    }
}
