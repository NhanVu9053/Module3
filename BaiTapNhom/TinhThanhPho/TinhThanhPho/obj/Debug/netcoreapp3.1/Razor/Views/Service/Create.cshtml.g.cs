#pragma checksum "D:\WBD\Module3\BaiTapNhom\TinhThanhPho\TinhThanhPho\Views\Service\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a08f11f2e06a350c1b879e37650a0ac54b437124"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Create), @"mvc.1.0.view", @"/Views/Service/Create.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\WBD\Module3\BaiTapNhom\TinhThanhPho\TinhThanhPho\Views\_ViewImports.cshtml"
using TinhThanhPho;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WBD\Module3\BaiTapNhom\TinhThanhPho\TinhThanhPho\Views\_ViewImports.cshtml"
using TinhThanhPho.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a08f11f2e06a350c1b879e37650a0ac54b437124", @"/Views/Service/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f98b4207ed27d58197e70357302889f17fa3db5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Service_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Service", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" mt-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\WBD\Module3\BaiTapNhom\TinhThanhPho\TinhThanhPho\Views\Service\Create.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card bg-light"">
    <article class=""card-body mx-auto"" style=""max-width: 400px;"">
        <h4 class=""card-title mt-3 text-center"">Create Account</h4>
        <p class=""text-center"">Get started with your free account</p>
        <p>
            <a");
            BeginWriteAttribute("href", " href=\"", 325, "\"", 332, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-block btn-twitter\"> <i class=\"fab fa-twitter\"></i>   Login via Twitter</a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 439, "\"", 446, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-block btn-facebook\"> <i class=\"fab fa-facebook-f\"></i>   Login via facebook</a>\r\n        </p>\r\n        <p class=\"divider-text\">\r\n            <span class=\"bg-light\">OR</span>\r\n        </p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a08f11f2e06a350c1b879e37650a0ac54b4371246949", async() => {
                WriteLiteral("\r\n            <div class=\"form-group input-group\">\r\n                <div class=\"input-group-prepend\">\r\n                    <span class=\"input-group-text\"> <i class=\"fa fa-user\"></i> </span>\r\n                </div>\r\n                <input");
                BeginWriteAttribute("name", " name=\"", 976, "\"", 983, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" placeholder=""Full name"" type=""text"">
            </div> <!-- form-group// -->
            <div class=""form-group input-group"">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text""> <i class=""fa fa-envelope""></i> </span>
                </div>
                <input");
                BeginWriteAttribute("name", " name=\"", 1325, "\"", 1332, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" placeholder=""Email address"" type=""email"">
            </div> <!-- form-group// -->
            <div class=""form-group input-group"">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text""> <i class=""fa fa-phone""></i> </span>
                </div>
                <select class=""custom-select"" style=""max-width: 120px;"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a08f11f2e06a350c1b879e37650a0ac54b4371248550", async() => {
                    WriteLiteral("+971");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a08f11f2e06a350c1b879e37650a0ac54b4371249669", async() => {
                    WriteLiteral("+972");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a08f11f2e06a350c1b879e37650a0ac54b43712410910", async() => {
                    WriteLiteral("+198");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a08f11f2e06a350c1b879e37650a0ac54b43712412152", async() => {
                    WriteLiteral("+701");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </select>\r\n                <input");
                BeginWriteAttribute("name", " name=\"", 1991, "\"", 1998, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" placeholder=""Phone number"" type=""text"">
            </div> <!-- form-group// -->
            <div class=""form-group input-group"">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text""> <i class=""fa fa-building""></i> </span>
                </div>
                <select class=""form-control"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a08f11f2e06a350c1b879e37650a0ac54b43712413983", async() => {
                    WriteLiteral(" Select job type");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a08f11f2e06a350c1b879e37650a0ac54b43712415115", async() => {
                    WriteLiteral("Designer");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a08f11f2e06a350c1b879e37650a0ac54b43712416152", async() => {
                    WriteLiteral("Manager");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a08f11f2e06a350c1b879e37650a0ac54b43712417188", async() => {
                    WriteLiteral("Accaunting");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </select>
            </div> <!-- form-group end.// -->
            <div class=""form-group input-group"">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text""> <i class=""fa fa-lock""></i> </span>
                </div>
                <input class=""form-control"" placeholder=""Create password"" type=""password"">
            </div> <!-- form-group// -->
            <div class=""form-group input-group"">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text""> <i class=""fa fa-lock""></i> </span>
                </div>
                <input class=""form-control"" placeholder=""Repeat password"" type=""password"">
            </div> <!-- form-group// -->
            <div class=""form-group"">
                <button type=""submit"" class=""btn btn-primary btn-block""> Create Account  </button>
            </div> <!-- form-group// -->
            <p class=""text-center"">Have an account? <a");
                BeginWriteAttribute("href", " href=\"", 3579, "\"", 3586, 0);
                EndWriteAttribute();
                WriteLiteral(">Log In</a> </p>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </article>
</div> <!-- card.// -->
</div>
<!--container end.//-->

<br>
<br>
<article class=""bg-secondary mb-3"">
    <div class=""card-body text-center"">
        <h3 class=""text-white mt-3"">Bootstrap 4 UI KIT</h3>
        <p class=""h5 text-white"">
            Components and templates  <br> for Ecommerce, marketplace, booking websites
            and product landing pages
        </p>   <br>
        <p>
            <a class=""btn btn-warning"" target=""_blank"" href=""http://bootstrap-ecommerce.com/"">
                Bootstrap-ecommerce.com
                <i class=""fa fa-window-restore ""></i>
            </a>
        </p>
    </div>
    <br><br>
</article>





<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        getAllProvinces();
        function getAllProvinces() {
            $.ajax({
                url: '/Service/GetAllProvinces',
                method: 'GET',
                dataType: 'json',
                success: function (data) {
                    console.log(data);
                    for (let i = 0; i < data.length; i++) {
                        console.log(data[i]);
                        $('#ddlProvince').append(`<option value='${data[i].id}'>${data[i]._name}</option>`);
                    }
                }
            });
        }
        function getAllDistByPID(id) {
            $.ajax({
                url: '/Service/GetAllDistrictByProvinceId/' + id,
                method: 'GET',
                dataType: 'json',
                success: function (data) {
                    console.log(data);
                    $('#ddlDistrict').html('<option value="""">Chọn quận/huyện</option>');
                    for (let i = 0; i < data.length; i++) {
");
                WriteLiteral(@"                        $('#ddlDistrict').append(`<option value='${data[i].id}'>${data[i]._name}</option>`);
                    }
                }
            });
        }
        function getAllWardByPID(id) {
            $.ajax({
                url: '/Service/GetAllWardByDistrictId/' + id,
                method: 'GET',
                dataType: 'json',
                success: function (data) {
                    console.log(data);
                    $('#ddlWard').empty();
                    $('#ddlWard').append('<option value="""">Chọn phường/xã</option>');
                    for (let i = 0; i < data.length; i++) {

                        $('#ddlWard').append(`<option value='${data[i].id}'>${data[i]._name}</option>`);
                    }
                }
            });
        }
        $(""#ddlWard"").on('change', function () {
            var provinceText = $(""#ddlProvince option:selected"").text();
            var districtText = $(""#ddlDistrict option:selected"").text();
");
                WriteLiteral(@"            var wardText = $(""#ddlWard option:selected"").text();
            var html = ""Tỉnh thành: "" + provinceText + "" "" + ""Quận huyện: "" + districtText + "" "" + ""Xã phường: "" + wardText;
            $(""#divResult"").html(html);
        });
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591