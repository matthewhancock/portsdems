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
                //try {
                //     _css = await Common.Util.File.LoadToString("_files/css/this.css");
                // } catch (Exception Ex) {
                //     _css = Ex.Message;
                // }
                _css = @"html, body { height: 100%;}
body {
margin:0;
padding:0;
color: #555;
font-size: 13px;
font-family:'Whitney A','Whitney B';
font-weight:400;
background-color:#EEE
}

aside,main,nav,section{display:block}

/* STANDARD */
a {
text-decoration: none;
color: #999;
}
a:hover, a.button:hover {
color: #777;
text-decoration: underline !important;
cursor: pointer;
}

h1,h2{
font-weight:normal;
font-family:'Whitney A','Whitney B';
}
h2 {
/*color:#fff;
background-color:#3c81aa;*/
padding:5px 10px;
text-align:center;
font-size:24px;
margin:.3em
}

.f{display:-webkit-flex;display:flex}
.f1{-webkit-flex:1;flex:1}


#c {
display:flex;
flex-direction:column;
width:1200px;
max-width:100%;
min-height:100%;
margin:0 auto;
background-color:#fff
}
#h {
padding: 10px 0 15px;
margin: 0;
font-size:62px;
letter-spacing:-1pt;
color: #3c81aa;
text-align:center
}
#social {
display:flex;
justify-content:center;
align-items:center;
height:50px;
margin:35px
}
#social > * {
margin:0 10px;
}
#n {
display:flex;
justify-content:center;
margin-top:10px
}
#n a {
font-size:32px;
text-decoration:none;
padding:.2em .4em;
text-align:center
}
#n a:hover {
text-decoration:underline;
}
#n[data-key='home'] #link-home,
#n[data-key='get-involved'] #link-get-involved,
#n[data-key='committee'] #link-committee,
#n[data-key='elected-officials'] #link-elected-officials {
color: #666;
}

#m {
flex:1;
}

#content {
padding:35px 12px;
font-family: 'Archer SSm A', 'Archer SSm B';
font-size:16px;
max-width:1024px;
width:100%;
margin:0 auto;
border-style: solid;
border-width:1px 0;
border-color:#ddd
}
#content a {color:#3C81AA}

#link-donate {
background-color:#3c81aa;
color:#fff;
margin-left:.4em
}

hr {
border: 0;
width: 100%;
}
hr.gray {
border-style: solid;
border-width:1px 0;
border-color:#ddd;
margin:1em 0 .5em
}
iframe, img {
border: 0;
}
blockquote {
margin: 0 5px;
padding: 25px 45px;
}
code {
font-family: Consolas, monospace;
font-size: 10px;
display:inline;
}


.description {font-size:13px;color:#999;line-height:1em;margin:4px 0 2px;text-align:left}
.hide {display: none;}
.b{font-weight:bold}
.ib {display:inline-block;}
.tac{text-align:center}
.form {font-family:'Whitney A','Whitney B';}

input[type=text], input[type=password], input[type=email], textarea {border-width:0 0 1px;border-style:solid;border-color:#ccc;width:250px;padding:5px;color:#444;font-family:inherit;font-size:1em}
input[type=text].narrow,input[type=password].narrow,input[type=email].narrow {width:30%}
input[type=button],input[type=submit] {height:30px;vertical-align:bottom;margin-left:.2em;background-color:#3C81AA;color:#fff;font-family:inherit;border:0;font-size:1em;cursor:pointer}
label[for] {vertical-align:top;}
select {max-width:100%;min-width:33%;border:1px solid #ccc;vertical-align:middle;padding:3px 2px;font-family:inherit}
select.small {height:24px;max-width:125px;min-width:32px;padding:1px;}
option {max-width:500px;padding:2px 5px;color:#444;font-size:12px;}
textarea {border:1px solid #ccc;width:80%;padding:5px;color:#444;height:140px;font-size:13px}

#twitter-widget-0.twitter-timeline {width:100% !important;max-width:700px !important;}
.twitter-tweet{margin:10px auto !important;}
.fb_iframe_widget{display:block !important}";
            }
            return _css;
        }

        public override async Task<string> Javascript(string[] Path) {
            if (_javascript == null) {
                //_javascript = await Common.Util.File.LoadToString("_files/js/this.js");
                ////_javascript = await meshNet.Util.File.LoadToString("_files/js/this-typescript.min.js");
                _javascript = @"window.onpopstate = function (event) { OutputState(event.state); };

var v = (function (v) {
	v.email = function (e) {
		return /[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?/.test(e);
	}

	return v;
})(v ? v : {});

var util = (function (util) {
	// showing/hiding CSS
	util.hide = function (elementIDs) {
		if (Array.isArray(elementIDs)) {
			for (var i = 0, l = elementIDs.length; i < l; i++) {
				var e = util.get(elementIDs[i]);
				if (e) { e.classList.add(""hide"") }
			}
		} else {
			var e = util.get(elementIDs);
			if (e) { e.classList.add(""hide"") }
		}
	}
	util.unhide = function (elementIDs) {
		if (Array.isArray(elementIDs)) {
			for (var i = 0, l = elementIDs.length; i < l; i++) {
				var e = util.get(elementIDs[i]);
				if (e) { e.classList.remove(""hide"") }
			}
		} else {
			var e = util.get(elementIDs);
			if (e) { e.classList.remove(""hide"") }
		}
	}
	// creating DOM elements
	util.create = function (tagName, cssClass) {
		var e = document.createElement(tagName);
		if (cssClass != null) {
			e.setAttribute(""class"", cssClass)
		}
		return e;
	}
	// getting DOM elements
	util.get = function (elementID) {
		return document.getElementById(elementID);
	}

	// STRUCTURES //
	util.callback = function () {
		var f = [];
		var fst = null;
		this.add = function (callback) {
			f[f.length] = callback;
		};
		this.complete = function (lastCallback) {
			if (fst != null) {
				fst();
			}
			var len = f.length;
			if (len > 0) {
				for (var i = 0; i < len; i++) {
					if (f[i] != null) {
						f[i]();
					}
				}
			}
			if (lastCallback && (typeof lastCallback === 'function')) {
				lastCallback();
			}
		};
		this.first = function (firstCallback) {
			fst = firstCallback;
		};
	};
	return util;
})(util ? util : {});

var lastSelected;
var navigating = false;

function link(linkDOM) {
	if (history.pushState) {
		if (lastSelected == null || linkDOM.id !== lastSelected.id) { // don't do anything if clicking same link...
			if (!navigating) {
				navigating = true;

				var r = new XMLHttpRequest();
				r.addEventListener(""load"", function (response) {
					if (r.readyState == 4) {
						var d = JSON.parse(r.responseText);
						var state = { href: linkDOM.href, title: d.title, hrefid: linkDOM.id, content: d.content, header: d.header, key: d.key };
						for (p in linkDOM.dataset) {
							state[p] = linkDOM.dataset[p];
						}
						history.pushState(state, state.title, state.href);
						OutputState(state, linkDOM);
						navigating = false;
					}
				});
				r.addEventListener(""error"", function (response) {
				}, false);
				r.open('GET', ""/json/"" + linkDOM.dataset.page);
				r.send(null);
			}
		}
		return false;
	} else {
		return true;
	}
}

var nav = document.getElementById('n');
function OutputState(state, linkDOM) {
	if (state) {
		OutputContent(state.content, state.title, state.header);
		nav.dataset['key'] = state.key;
	}
}
function OutputContent(content, title, header) {
	if (title) {
		document.title = title;
	}
	var c = document.getElementById('content');
	c.innerHTML = content;
}


function a(fid, btn) {
	btn.disabled = true;
	var btnDisabled = true;
	var f = util.get(fid); var e = f.querySelectorAll('input, select, div[contenteditable], textarea'); var ok = true; var fd = new FormData();
	for (var i = 0, l = e.length; i < l; i++) {
		var ei = e[i];
		if (ei.dataset.required && ei.value === '') {
			ok = false;
			ei.classList.add(""required"");
			if (ei.onkeyup == null) {
				ei.onkeyup = function (e) { if (btnDisabled) { btn.disabled = false; btnDisabled = false } };
			}
		} else {
			ei.classList.remove(""required"");
		}

		if (ei.type === 'email') {
			if (ei.value !== '' && !v.email(ei.value)) {
				ok = false;
			}
		}
		var key = ei.dataset.key;
		if (key != null) {
			if (ei.type) {
				if (ei.type === 'checkbox') {
					fd.append(key, ei.checked);
				} else {
					fd.append(key, ei.value);
				}
			} else if (ei.value) { // textarea
				fd.append(key, ei.value);
			} else if (ei.contentEditable) {
				fd.append(key, ei.innerHTML);
			}
		}
	}
	var e = util.get(fid + '_error');
	if (ok) {
		e.classList.add(""hide"");
		// submit...
		var r = new XMLHttpRequest();
		r.addEventListener(""load"", function (response) {
			try {
				var o = JSON.parse(this.responseText);
				if (o.ok) {
					if (o.message) {
						e.innerHTML = o.message;
						e.classList.remove(""hide"");
						if (o.reenable) { btn.disabled = false; }
					} else if (o.form) {
						var tempDiv = util.create('div');
						tempDiv.innerHTML = o.form;
						f.parentNode.replaceChild(tempDiv.firstChild, f);
					} else if (o.script) {
						f.innerHTML = """";
						var script = document.createElement('script');
						script.text = o.script;
						f.appendChild(script);
					} else if (o.substitute) {
						var s = util.get(o.substitute.id);
						if (s) { s.innerHTML = o.substitute.value; }
						if (o.reenable) { btn.disabled = false; }
					} else if (o.push) {
						var state = o.push.state;
						history.pushState(state, state.title, state.href);
						OutputState(state, null);
					} else {
						f.innerHTML = ""OK"";
					}
				} else {
					e.innerHTML = o.message ? o.message : ""Unknown Error..."";
					e.classList.remove(""hide"");
				}
			} catch (ex) {
				e.innerHTML = ""Unknown Server Error..."";
				e.classList.remove(""hide"");
				console.log(ex.message);
			}
		}, false);
		r.addEventListener(""error"", function (response) {
			e.innerHTML = ""Error...."";
			e.classList.remove(""hide"");
		}, false);
		r.open('POST', ""/"" + f.dataset.action);
		r.send(fd);
	} else {
		e.innerHTML = ""Please fix errors"";
		btn.disabled = false;
		btnDisabled = false;
		e.classList.remove(""hide"");
	}
};";
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

        public async override Task ProcessPostAsync(HttpContext Context, string Action) {
            await Handlers.Post.ProcessRequestAsync(Context, Action);
        }
    }
}
