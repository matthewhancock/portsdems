using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Site;
using static Common.Util.Html;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace portsmouth_democrats {
    public class Startup : Common.StartupTemplate<Application> {
        private static string _css, _javascript = null;
        private static Dictionary<string, byte[]> _images = new Dictionary<string, byte[]>();
        public override async Task<string> Css(string[] Path) {
            if (_css == null) {
                _css = await Common.Util.File.LoadToString("_files/css/this.css");
            }
            return _css;
        }

        public override async Task<string> Javascript(string[] Path) {
            if (_javascript == null) {
                _javascript = await Common.Util.File.LoadToString("_files/js/this.js");
                //_javascript = await meshNet.Util.File.LoadToString("_files/js/this-typescript.min.js");
            }
            return _javascript;
        }

        public override async Task<byte[]> Image(string[] Path) {
            byte[] file = null;
            var pathl = Path.Length;
            var filename = Path[1];
            if (!_images.ContainsKey(filename)) {
                try {
                    file = await Common.Util.File.LoadToBuffer($"_files/images/{filename}");
                    _images.Add(filename, file);
                } catch { }
            } else {
                file = _images[filename];
            }
            return file;
        }

        private static class Pages {
            public static Page Home = new portsmouth_democrats.Pages.Home();
            public static Page Committee = new portsmouth_democrats.Pages.Committee();
            public static Page ElectedOfficials = new portsmouth_democrats.Pages.ElectedOfficials();
            public static Page GetInvolved = new portsmouth_democrats.Pages.GetInvolved();
        }

        private static string tags = (new Head.Tag("link", new Dictionary<string, string> { { "rel", "stylesheet" }, { "type", "text/css" }, { "href", "/css/" } })).Output() +
            (new Head.Tag("link", new Dictionary<string, string> { { "rel", "stylesheet" }, { "type", "text/css" }, { "href", "//cloud.typography.com/607958/655786/css/fonts.css" } })).Output() +
            (new Head.Tag.Javascript("/js/")).Output() + (new Head.Tag.Javascript("//platform.twitter.com/widgets.js")).Output() + (new Head.Tag.Javascript("//connect.facebook.net/en_US/sdk.js#xfbml=1&appId=175259985884771&version=v2.0")).Output();
        private static string body_start = @"<div id=""c""><header id=""h"">Portsmouth Democrats</header><nav id=""n"" data-key=""";
        private static string body_mid = "\"><a id=\"link-" + Pages.Home.Key + "\" href=\"/" + Pages.Home.Path + "\" data-page=\"" + Pages.Home.Key + "\" onclick=\"return link(this)\">" + Pages.Home.TitleNav + "</a>" +
                                           @"<a id=""link-" + Pages.GetInvolved.Key + "\" href=\"/" + Pages.GetInvolved.Path + "\" data-page=\"" + Pages.GetInvolved.Key + "\" onclick=\"return link(this)\">" + Pages.GetInvolved.TitleNav + "</a>" +
                                           @"<a id=""link-" + Pages.Committee.Key + "\" href=\"/" + Pages.Committee.Path + "\" data-page=\"" + Pages.Committee.Key + "\" onclick=\"return link(this)\">" + Pages.Committee.TitleNav + "</a>" +
                                           @"<a id=""link-" + Pages.ElectedOfficials.Key + "\" href=\"/" + Pages.ElectedOfficials.Path + "\" data-page=\"" + Pages.ElectedOfficials.Key + "\" onclick=\"return link(this)\">" + Pages.ElectedOfficials.TitleNav + "</a>" +
                                           @"<a id=""link-" + "donate\" href=\"https://secure.actblue.com/entity/fundraisers/23420\" target=\"_blank\">Donate</a></nav><hr /><main id=\"m\"><section id=\"content\">";
        private static string body_end = @"</section><aside id=""social""><a href=""https://twitter.com/PortsDems"" class=""twitter-follow-button"" data-show-count=""false"" data-size=""large"" data-dnt=""true"">Follow @PortsDems</a><div class=""fb-like-box"" data-href=""https://www.facebook.com/PortsmouthDemocrats"" data-colorscheme=""light"" data-show-faces=""false"" data-header=""false"" data-stream=""false"" data-show-border=""false""></div></aside></main></div>";

        protected override async Task Page(HttpResponse Response, Page Page) {
            await Common.Util.Html.WriteOutput(Response, Page.Title, tags + "<meta name=\"description\" content=\"" + Page.Description + "\">", body_start + Page.Key + body_mid + Page.Content + body_end);
        }

        public override List<Page> RegisterPages() {
            var list = new List<Page>();

            list.Add(Pages.Home);
            list.Add(Pages.Committee);
            list.Add(Pages.ElectedOfficials);
            list.Add(Pages.GetInvolved);

            return list;
        }
    }
}
