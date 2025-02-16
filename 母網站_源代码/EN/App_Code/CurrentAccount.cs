using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///CurrentAccount 的摘要说明
/// </summary>
public class CurrentAccount
{

    //
    //TODO: 在此处添加构造函数逻辑
    //
    private const string Validate_Code = "NUM_CODE";//验证码

    /// <summary>
    /// 验证码校验函数
    /// </summary>
    /// <param name="code"></param>
    /// <returns></returns>
    public static bool VerifyValidateCode(string code)
    {

        if (!string.IsNullOrEmpty(code))
        {
            if (HttpContext.Current.Session[Validate_Code] != null)
            {
                if (HttpContext.Current.Session[Validate_Code].ToString() == code)
                {
                    //验证成功清空Session
                    HttpContext.Current.Session[Validate_Code] = null;
                    return true;
                }

            }
        }
        //验证失败清空Session
        HttpContext.Current.Session[Validate_Code] = null;
        return false;
    }

    /// <summary>
    /// 设置验证码
    /// </summary>
    /// <param name="code"></param>
    public static void SetValidateCode(string code)
    {
        HttpContext.Current.Session[Validate_Code] = code;
    }
}