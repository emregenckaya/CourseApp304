#pragma checksum "C:\Users\Genckaya\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59bb9023e245c6597223ca45f9b331fb05e912fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Instructor_InstructorCreate), @"mvc.1.0.view", @"/Views/Instructor/InstructorCreate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Instructor/InstructorCreate.cshtml", typeof(AspNetCore.Views_Instructor_InstructorCreate))]
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
#line 1 "C:\Users\Genckaya\source\repos\CourseApp304\CourseApp304\Views\_ViewImports.cshtml"
using CourseApp304;

#line default
#line hidden
#line 2 "C:\Users\Genckaya\source\repos\CourseApp304\CourseApp304\Views\_ViewImports.cshtml"
using CourseApp304.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59bb9023e245c6597223ca45f9b331fb05e912fe", @"/Views/Instructor/InstructorCreate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05888fb4810b008c0674f9671848efd142deb4be", @"/Views/_ViewImports.cshtml")]
    public class Views_Instructor_InstructorCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CourseApp304.Models.Instructor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Genckaya\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorCreate.cshtml"
   int counter = 0;

#line default
#line hidden
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(63, 1703, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffa738497aeb4d5f840b7d050ea9499e", async() => {
                BeginContext(101, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(107, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ad260ebe785e4f1da62629f43bc3985f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 5 "C:\Users\Genckaya\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorCreate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(143, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(149, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "292d7a80d0084e5b92965d816d9fce81", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 6 "C:\Users\Genckaya\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorCreate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(187, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 7 "C:\Users\Genckaya\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorCreate.cshtml"
     foreach (var course in Model.Courses)
    {

#line default
#line hidden
                BeginContext(240, 56, true);
                WriteLiteral("    <div class=\"row my-2\">\r\n        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 296, "\"", 314, 1);
#line 10 "C:\Users\Genckaya\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorCreate.cshtml"
WriteAttributeValue("", 304, course.Id, 304, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 315, "\"", 342, 3);
                WriteAttributeValue("", 322, "Courses[", 322, 8, true);
#line 10 "C:\Users\Genckaya\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorCreate.cshtml"
WriteAttributeValue("", 330, counter, 330, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 338, "].Id", 338, 4, true);
                EndWriteAttribute();
                BeginContext(343, 33, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 376, "\"", 403, 1);
#line 11 "C:\Users\Genckaya\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorCreate.cshtml"
WriteAttributeValue("", 384, course.Description, 384, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 404, "\"", 440, 3);
                WriteAttributeValue("", 411, "Courses[", 411, 8, true);
#line 11 "C:\Users\Genckaya\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorCreate.cshtml"
WriteAttributeValue("", 419, counter, 419, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 427, "].Description", 427, 13, true);
                EndWriteAttribute();
                BeginContext(441, 33, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 474, "\"", 507, 3);
                WriteAttributeValue("", 481, "Courses[", 481, 8, true);
#line 12 "C:\Users\Genckaya\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorCreate.cshtml"
WriteAttributeValue("", 489, counter, 489, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 497, "].isActive", 497, 10, true);
                EndWriteAttribute();
                BeginContext(508, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(511, 64, false);
#line 12 "C:\Users\Genckaya\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorCreate.cshtml"
                                                           Write(Html.Raw(course.isActive ? "value=\"true\"" : "value=\"false\""));

#line default
#line hidden
                EndContext();
                BeginContext(576, 33, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 609, "\"", 638, 3);
                WriteAttributeValue("", 616, "Courses[", 616, 8, true);
#line 13 "C:\Users\Genckaya\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorCreate.cshtml"
WriteAttributeValue("", 624, counter, 624, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 632, "].Name", 632, 6, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 639, "\"", 659, 1);
#line 13 "C:\Users\Genckaya\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorCreate.cshtml"
WriteAttributeValue("", 647, course.Name, 647, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(660, 54, true);
                WriteLiteral(" class=\"form-control\" />\r\n        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 714, "\"", 744, 3);
                WriteAttributeValue("", 721, "Courses[", 721, 8, true);
#line 14 "C:\Users\Genckaya\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorCreate.cshtml"
WriteAttributeValue("", 729, counter, 729, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 737, "].Price", 737, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 745, "\"", 766, 1);
#line 14 "C:\Users\Genckaya\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorCreate.cshtml"
WriteAttributeValue("", 753, course.Price, 753, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(767, 54, true);
                WriteLiteral(" class=\"form-control\" />\r\n        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 821, "\"", 857, 3);
                WriteAttributeValue("", 828, "Courses[", 828, 8, true);
#line 15 "C:\Users\Genckaya\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorCreate.cshtml"
WriteAttributeValue("", 836, counter, 836, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 844, "].Description", 844, 13, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 858, "\"", 885, 1);
#line 15 "C:\Users\Genckaya\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorCreate.cshtml"
WriteAttributeValue("", 866, course.Description, 866, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(886, 38, true);
                WriteLiteral(" class=\"form-control\" />\r\n    </div>\r\n");
                EndContext();
#line 17 "C:\Users\Genckaya\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorCreate.cshtml"
        { counter++; }
    }

#line default
#line hidden
                BeginContext(955, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(1027, 96, true);
                WriteLiteral("\r\n\r\n    <div class=\"row mt-2\">\r\n        <div class=\"col\"><input type=\"text\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 1123, "\"", 1152, 3);
                WriteAttributeValue("", 1130, "Courses[", 1130, 8, true);
#line 22 "C:\Users\Genckaya\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorCreate.cshtml"
WriteAttributeValue("", 1138, counter, 1138, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 1146, "].Name", 1146, 6, true);
                EndWriteAttribute();
                BeginContext(1153, 75, true);
                WriteLiteral(" /></div>\r\n        <div class=\"col\"><input type=\"text\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 1228, "\"", 1258, 3);
                WriteAttributeValue("", 1235, "Courses[", 1235, 8, true);
#line 23 "C:\Users\Genckaya\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorCreate.cshtml"
WriteAttributeValue("", 1243, counter, 1243, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 1251, "].Price", 1251, 7, true);
                EndWriteAttribute();
                BeginContext(1259, 75, true);
                WriteLiteral(" /></div>\r\n        <div class=\"col\"><input type=\"text\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 1334, "\"", 1370, 3);
                WriteAttributeValue("", 1341, "Courses[", 1341, 8, true);
#line 24 "C:\Users\Genckaya\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorCreate.cshtml"
WriteAttributeValue("", 1349, counter, 1349, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 1357, "].Description", 1357, 13, true);
                EndWriteAttribute();
                BeginContext(1371, 77, true);
                WriteLiteral(" /></div>\r\n        <div class=\"col\"><input type=\"hidden\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 1448, "\"", 1481, 3);
                WriteAttributeValue("", 1455, "Courses[", 1455, 8, true);
#line 25 "C:\Users\Genckaya\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorCreate.cshtml"
WriteAttributeValue("", 1463, counter, 1463, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 1471, "].isActive", 1471, 10, true);
                EndWriteAttribute();
                BeginContext(1482, 192, true);
                WriteLiteral(" value=\"true\" /></div>\r\n    </div>\r\n\r\n    <div class=\"row mt-2\">\r\n        <div class=\"col text-center\">\r\n            <button class=\"btn btn-success\" type=\"submit\">Submit</button>\r\n            ");
                EndContext();
                BeginContext(1674, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c92078169d7c45dd878d471cb8f9ca86", async() => {
                    BeginContext(1717, 6, true);
                    WriteLiteral("Cancel");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1727, 32, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1766, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourseApp304.Models.Instructor> Html { get; private set; }
    }
}
#pragma warning restore 1591