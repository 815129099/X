﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    
    #line 6 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
    using System.Web.Mvc;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
    using System.Web.Mvc.Ajax;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
    using System.Web.Mvc.Html;
    
    #line default
    #line hidden
    
    #line 9 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
    using System.Web.Routing;
    
    #line default
    #line hidden
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 2 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
    using NewLife;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    
    #line 3 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
    using NewLife.Web;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
    using XCode.Configuration;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/User/_List_Data.cshtml")]
    public partial class _Areas_Admin_Views_User__List_Data_cshtml : System.Web.Mvc.WebViewPage<IList<XCode.Membership.UserX>>
    {
        public _Areas_Admin_Views_User__List_Data_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 10 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
  
    var fact = ViewBag.Factory as IEntityOperate;
    var page = ViewBag.Page as Pager;
    var fields = ViewBag.Fields as IReadOnlyList<FieldItem>;
    var enableSelect = this.EnableSelect();
    //var provider = ManageProvider.Provider;

            
            #line default
            #line hidden
WriteLiteral("\r\n<table");

WriteLiteral(" class=\"table table-bordered table-hover table-striped table-condensed\"");

WriteLiteral(">\r\n    <thead>\r\n        <tr>\r\n");

            
            #line 20 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
            
            
            #line default
            #line hidden
            
            #line 20 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
             if (enableSelect)
            {

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" style=\"width:10px;\"");

WriteLiteral("><input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" id=\"chkAll\"");

WriteLiteral(" title=\"全选\"");

WriteLiteral(" /></th>\r\n");

            
            #line 23 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <th");

WriteLiteral(" class=\"text-center hidden-md hidden-sm hidden-xs\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 833), Tuple.Create("\"", 872)
            
            #line 24 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 840), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("ID"))
            
            #line default
            #line hidden
, 840), false)
);

WriteLiteral(">编号</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" title=\"名称。登录用户名\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 942), Tuple.Create("\"", 983)
            
            #line 25 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 949), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Name"))
            
            #line default
            #line hidden
, 949), false)
);

WriteLiteral(">名称</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1036), Tuple.Create("\"", 1084)
            
            #line 26 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1043), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("DisplayName"))
            
            #line default
            #line hidden
, 1043), false)
);

WriteLiteral(">昵称</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" title=\"性别。未知、男、女\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1155), Tuple.Create("\"", 1195)
            
            #line 27 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1162), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Sex"))
            
            #line default
            #line hidden
, 1162), false)
);

WriteLiteral(">性别</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1248), Tuple.Create("\"", 1289)
            
            #line 28 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1255), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Mail"))
            
            #line default
            #line hidden
, 1255), false)
);

WriteLiteral(">邮件</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1342), Tuple.Create("\"", 1385)
            
            #line 29 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1349), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Mobile"))
            
            #line default
            #line hidden
, 1349), false)
);

WriteLiteral(">手机</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1438), Tuple.Create("\"", 1481)
            
            #line 30 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1445), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("RoleID"))
            
            #line default
            #line hidden
, 1445), false)
);

WriteLiteral(">角色</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1534), Tuple.Create("\"", 1577)
            
            #line 31 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1541), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Online"))
            
            #line default
            #line hidden
, 1541), false)
);

WriteLiteral(">在线</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1630), Tuple.Create("\"", 1673)
            
            #line 32 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1637), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Enable"))
            
            #line default
            #line hidden
, 1637), false)
);

WriteLiteral(">启用</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1726), Tuple.Create("\"", 1769)
            
            #line 33 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1733), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Logins"))
            
            #line default
            #line hidden
, 1733), false)
);

WriteLiteral(">登录次数</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" style=\"min-width:134px;\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1849), Tuple.Create("\"", 1895)
            
            #line 34 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1856), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("LastLogin"))
            
            #line default
            #line hidden
, 1856), false)
);

WriteLiteral(">最后登录</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1950), Tuple.Create("\"", 1998)
            
            #line 35 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1957), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("LastLoginIP"))
            
            #line default
            #line hidden
, 1957), false)
);

WriteLiteral(">最后IP</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 2053), Tuple.Create("\"", 2106)
            
            #line 36 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 2060), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("LastLoginAddress"))
            
            #line default
            #line hidden
, 2060), false)
);

WriteLiteral(">物理地址</a></th>\r\n");

            
            #line 37 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
            
            
            #line default
            #line hidden
            
            #line 37 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
             if (this.Has(PermissionFlags.Update, PermissionFlags.Delete))
            {

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" style=\"min-width:100px;\"");

WriteLiteral(">操作</th>\r\n");

            
            #line 40 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");

            
            #line 44 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
        
            
            #line default
            #line hidden
            
            #line 44 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
         foreach (var entity in Model)
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n");

            
            #line 47 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
                
            
            #line default
            #line hidden
            
            #line 47 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
                 if (enableSelect)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" name=\"keys\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2547), Tuple.Create("\"", 2565)
            
            #line 49 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
      , Tuple.Create(Tuple.Create("", 2555), Tuple.Create<System.Object, System.Int32>(entity.ID
            
            #line default
            #line hidden
, 2555), false)
);

WriteLiteral(" /></td>\r\n");

            
            #line 50 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <td");

WriteLiteral(" class=\"text-center hidden-md hidden-sm hidden-xs\"");

WriteLiteral(">");

            
            #line 51 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
                                                                 Write(entity.ID);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 52 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
               Write(entity.Name);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 53 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
               Write(entity.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">");

            
            #line 54 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
                                   Write(entity.Sex);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 55 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
               Write(entity.Mail);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 56 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
               Write(entity.Mobile);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td><a");

WriteAttribute("href", Tuple.Create(" href=\"", 2927), Tuple.Create("\"", 2956)
, Tuple.Create(Tuple.Create("", 2934), Tuple.Create("Role?ID=", 2934), true)
            
            #line 57 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 2942), Tuple.Create<System.Object, System.Int32>(entity.RoleID
            
            #line default
            #line hidden
, 2942), false)
);

WriteLiteral(">");

            
            #line 57 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
                                                Write(entity.RoleName);

            
            #line default
            #line hidden
WriteLiteral("</a></td>\r\n                <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n                    <i");

WriteAttribute("class", Tuple.Create(" class=\"", 3049), Tuple.Create("\"", 3111)
, Tuple.Create(Tuple.Create("", 3057), Tuple.Create("glyphicon", 3057), true)
, Tuple.Create(Tuple.Create(" ", 3066), Tuple.Create("glyphicon-", 3067), true)
            
            #line 59 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 3077), Tuple.Create<System.Object, System.Int32>(entity.Online ? "ok" : "remove"
            
            #line default
            #line hidden
, 3077), false)
);

WriteAttribute("style", Tuple.Create(" style=\"", 3112), Tuple.Create("\"", 3162)
, Tuple.Create(Tuple.Create("", 3120), Tuple.Create("color:", 3120), true)
            
            #line 59 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
                    , Tuple.Create(Tuple.Create(" ", 3126), Tuple.Create<System.Object, System.Int32>(entity.Online ? "green" : "red"
            
            #line default
            #line hidden
, 3127), false)
, Tuple.Create(Tuple.Create("", 3161), Tuple.Create(";", 3161), true)
);

WriteLiteral("></i>\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n                    <i");

WriteAttribute("class", Tuple.Create(" class=\"", 3257), Tuple.Create("\"", 3319)
, Tuple.Create(Tuple.Create("", 3265), Tuple.Create("glyphicon", 3265), true)
, Tuple.Create(Tuple.Create(" ", 3274), Tuple.Create("glyphicon-", 3275), true)
            
            #line 62 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 3285), Tuple.Create<System.Object, System.Int32>(entity.Enable ? "ok" : "remove"
            
            #line default
            #line hidden
, 3285), false)
);

WriteAttribute("style", Tuple.Create(" style=\"", 3320), Tuple.Create("\"", 3370)
, Tuple.Create(Tuple.Create("", 3328), Tuple.Create("color:", 3328), true)
            
            #line 62 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
                    , Tuple.Create(Tuple.Create(" ", 3334), Tuple.Create<System.Object, System.Int32>(entity.Enable ? "green" : "red"
            
            #line default
            #line hidden
, 3335), false)
, Tuple.Create(Tuple.Create("", 3369), Tuple.Create(";", 3369), true)
);

WriteLiteral("></i>\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 64 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
                                  Write(entity.Logins.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 65 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
               Write(entity.LastLogin.ToFullString(""));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 66 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
               Write(entity.LastLoginIP);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 67 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
               Write(entity.LastLoginAddress);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 68 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
                
            
            #line default
            #line hidden
            
            #line 68 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
                 if (this.Has(PermissionFlags.Update, PermissionFlags.Delete))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 71 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
                   Write(Html.Partial("_List_Data_Action", (Object)entity));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n");

            
            #line 73 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tr>\r\n");

            
            #line 75 "..\..\Areas\Admin\Views\User\_List_Data.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </tbody>\r\n</table>");

        }
    }
}
#pragma warning restore 1591