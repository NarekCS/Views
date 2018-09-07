using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace Asp
{
    public class ASPV_Views_Home_Index_cshtml : RazorPage<string[]>
    {
        public IUrlHelper Url { get; private set; }
        public IViewComponentHelper Component { get; private set; }
        public IJsonHelper Json { get; private set; }
        public IHtmlHelper<string[]> Html { get; private set; }
        public override async Task ExecuteAsync()
        {
            Layout = null;
            WriteLiteral(@"<!DOCTYPE html><html><head> 
                    <meta name=""viewport"" content=""width=device-width"" />  
                    <title>Razor</title> 
                    <link asp-href-include=""lib/bootstrap/dist/css/*.min.css""
                    rel=""stylesheet"" />     
                    </head><body class=""m-1 p-1"">This is a list of fruit names:");
            foreach (string name in Model)
            {
                WriteLiteral("<span><b>");
                Write(name);
                WriteLiteral("</b></span>");
            }
            WriteLiteral("</body></html>");
        }
    }
}

