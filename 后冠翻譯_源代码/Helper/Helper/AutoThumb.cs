using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Web;
using System.Web.UI.WebControls;

namespace Helper;

public class AutoThumb
{
	public static void UploadThumbnail(FileUpload _FU, TextBox _TB, int _Thumbwidth, string _Prefix)
	{
		try
		{
			string fname = CommonFunction.ReplaceStr2(_FU.FileName);
			string fpath = HttpContext.Current.Server.MapPath("~/") + "UploadFiles\\" + fname;
			_FU.SaveAs(fpath);
			string Fe = fname.Substring(fname.LastIndexOf(".") + 1);
			string thname = DateTime.Now.Year.ToString() + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond + _Prefix + "." + Fe;
			string thpath = HttpContext.Current.Server.MapPath("~/") + "UploadFiles\\" + thname;
			System.Drawing.Image image = System.Drawing.Image.FromFile(fpath);
			int srcWidth = image.Width;
			int srcHeight = image.Height;
			int thumbHeight = srcHeight * _Thumbwidth / srcWidth;
			Bitmap bmp = new Bitmap(_Thumbwidth, thumbHeight);
			Graphics GR = Graphics.FromImage(bmp);
			GR.SmoothingMode = SmoothingMode.HighQuality;
			GR.CompositingQuality = CompositingQuality.HighQuality;
			GR.InterpolationMode = InterpolationMode.High;
			Rectangle rectDestination = new Rectangle(0, 0, _Thumbwidth, thumbHeight);
			GR.DrawImage(image, rectDestination, 0, 0, srcWidth, srcHeight, GraphicsUnit.Pixel);
			bmp.Save(thpath);
			bmp.Dispose();
			image.Dispose();
			CommonFunction.DelFile(fpath);
			_TB.Text = "UploadFiles\\" + thname;
		}
		catch (Exception ex)
		{
			throw new Exception(ex.Message);
		}
	}

	public static void MakeThumbnail(string originalImagePath, int width, int height)
	{
		System.Drawing.Image originalImage = null;
		try
		{
			originalImage = System.Drawing.Image.FromFile(originalImagePath);
		}
		catch (OutOfMemoryException)
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
		int x = 0;
		int y = 0;
		int ow = originalImage.Width;
		int oh = originalImage.Height;
		int bg_x = 0;
		int bg_y = 0;
		int bg_w = width;
		int bg_h = height;
		double multiple = 0.0;
		multiple = ((originalImage.Width < originalImage.Height) ? ((double)originalImage.Height / (double)height) : ((double)originalImage.Width / (double)width));
		if (ow <= width && oh <= height)
		{
			bg_w = originalImage.Width;
			bg_h = originalImage.Height;
			bg_x = Convert.ToInt32(((double)width - (double)ow) / 2.0);
			bg_y = Convert.ToInt32(((double)height - (double)oh) / 2.0);
		}
		else
		{
			bg_w = Convert.ToInt32((double)originalImage.Width / multiple);
			bg_h = Convert.ToInt32((double)originalImage.Height / multiple);
			bg_y = Convert.ToInt32(((double)height - (double)bg_h) / 2.0);
			bg_x = Convert.ToInt32(((double)width - (double)bg_w) / 2.0);
		}
		System.Drawing.Image bitmap = new Bitmap(width, height);
		Graphics g = Graphics.FromImage(bitmap);
		g.InterpolationMode = InterpolationMode.HighQualityBicubic;
		g.SmoothingMode = SmoothingMode.HighQuality;
		g.Clear(Color.White);
		g.DrawImage(originalImage, new Rectangle(bg_x, bg_y, bg_w, bg_h), new Rectangle(x, y, ow, oh), GraphicsUnit.Pixel);
		try
		{
			bitmap.Save(originalImagePath + "_s.jpg", ImageFormat.Jpeg);
		}
		catch (Exception)
		{
		}
		finally
		{
			originalImage?.Dispose();
			bitmap?.Dispose();
			g?.Dispose();
		}
	}
}
