﻿using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

/// <summary>
/// 圖片处理类
/// 1、生成缩略圖片或按照比例改变圖片的大小和画质
/// 2、将生成的缩略图放到指定的目录下
/// </summary>
public class ImageClass
{
    public System.Drawing.Image ResourceImage;
    private int ImageWidth;
    private int ImageHeight;

    public string ErrMessage;

    /// <summary>
    /// 类的构造函数
    /// </summary>
    /// <param name="ImageFileName">圖片檔案的全路径名称</param>
    public ImageClass(string ImageFileName)
    {
        ResourceImage = System.Drawing.Image.FromFile(ImageFileName);
        ErrMessage = "";
    }

    public bool ThumbnailCallback()
    {
        return false;
    }

    /// <summary>
    /// 生成缩略图重载方法1，返回缩略图的Image对象
    /// </summary>
    /// <param name="Width">缩略图的宽度</param>
    /// <param name="Height">缩略图的高度</param>
    /// <returns>缩略图的Image对象</returns>
    public System.Drawing.Image GetReducedImage(int Width, int Height)
    {
        try
        {
            System.Drawing.Image ReducedImage;

            System.Drawing.Image.GetThumbnailImageAbort callb = new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback);

            ReducedImage = ResourceImage.GetThumbnailImage(Width, Height, callb, IntPtr.Zero);

            return ReducedImage;
        }
        catch (Exception e)
        {
            ErrMessage = e.Message;
            return null;
        }
    }

    /// <summary>
    /// 生成缩略图重载方法2，将缩略图檔案保存到指定的路径
    /// </summary>
    /// <param name="Width">缩略图的宽度</param>
    /// <param name="Height">缩略图的高度</param>
    /// <param name="targetFilePath">缩略图保存的全檔案名，(带路径)，参数格式：D:Images ilename.jpg</param>
    /// <returns>成功返回true，否则返回false</returns>
    public bool GetReducedImage(int Width, int Height, string targetFilePath)
    {
        try
        {
            System.Drawing.Image ReducedImage;

            System.Drawing.Image.GetThumbnailImageAbort callb = new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback);

            ReducedImage = ResourceImage.GetThumbnailImage(Width, Height, callb, IntPtr.Zero);
            ReducedImage.Save(@targetFilePath, ImageFormat.Jpeg);

            ReducedImage.Dispose();

            return true;
        }
        catch (Exception e)
        {
            ErrMessage = e.Message;
            return false;
        }
    }

    /// <summary>
    /// 生成缩略图重载方法3，返回缩略图的Image对象
    /// </summary>
    /// <param name="Percent">缩略图的宽度百分比 如：需要百分之80，就填0.8</param>  
    /// <returns>缩略图的Image对象</returns>
    public System.Drawing.Image GetReducedImage(double Percent)
    {
        try
        {
            System.Drawing.Image ReducedImage;

            System.Drawing.Image.GetThumbnailImageAbort callb = new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback);

            ImageWidth = Convert.ToInt32(ResourceImage.Width * Percent);
            ImageHeight = Convert.ToInt32(ResourceImage.Width * Percent);

            ReducedImage = ResourceImage.GetThumbnailImage(ImageWidth, ImageHeight, callb, IntPtr.Zero);

            return ReducedImage;
        }
        catch (Exception e)
        {
            ErrMessage = e.Message;
            return null;
        }
    }

    /// <summary>
    /// 生成缩略图重载方法4，返回缩略图的Image对象
    /// </summary>
    /// <param name="Percent">缩略图的宽度百分比 如：需要百分之80，就填0.8</param>  
    /// <param name="targetFilePath">缩略图保存的全檔案名，(带路径)，参数格式：D:Images ilename.jpg</param>
    /// <returns>成功返回true,否则返回false</returns>
    public bool GetReducedImage(double Percent, string targetFilePath)
    {
        try
        {
            System.Drawing.Image ReducedImage;

            System.Drawing.Image.GetThumbnailImageAbort callb = new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback);

            ImageWidth = Convert.ToInt32(ResourceImage.Width * Percent);
            ImageHeight = Convert.ToInt32(ResourceImage.Width * Percent);

            ReducedImage = ResourceImage.GetThumbnailImage(ImageWidth, ImageHeight, callb, IntPtr.Zero);

            ReducedImage.Save(@targetFilePath, ImageFormat.Jpeg);

            ReducedImage.Dispose();

            return true;
        }
        catch (Exception e)
        {
            ErrMessage = e.Message;
            return false;
        }
    }
}


