using System;
using System.Collections.Generic;

namespace portsmouth_democrats.Pages {
	public class GetInvolved : Site.Page {

		public static string OutputPage() {
			var token = Guid.NewGuid().ToString("N");
			return "<div class=\"tac\"><h2>Mailing List</h2>Subscribe to our mailing list to get regular updates.<br /><br /><div id=\"" + Forms.Subscribe.HtmlID.FormContainer + "\"><div id=\"f_" + token + "\" data-action=\"" + Forms.Subscribe.Action.MailingList + "\" class=\"form\"><div class=\"ib\">" + new Site.Form.Field.Textbox(Forms.Subscribe.Keys.EmailAddress, "Email Address", true, null, new Dictionary<string, string>() { { "autofocus", "" } }, "email").Output() + "</div><input type=\"button\" onclick=\"a('f_" + token + "',this)\" value=\"Subscribe\" /><span id=\"f_" + token + "_error\" class=\"error hide\"></span></div></div><br />" +
				"<h2>Monthly Roundtable Meeting</h2>Portsmouth Democrats meet on the third Thursday of every month from 6:30 to 8:30 for an informal a la carte dinner at Cafe Nostimo on Mirona Road (<a href=\"http://binged.it/1zSn7kI\" target=\"_blank\">directions</a>).<br /><br />Newcomers are always welcome. No RSVP required. Come as you are." +
				"<h2>Social Networks</h2>Follow us on <a href=\"https://facebook.com/PortsmouthDemocrats\" target=\"_blank\">Facebook</a> and <a href=\"https://twitter.com/PortsDems\" target=\"_blank\">Twitter</a> for regular updates.<br /><br />These pages are particularly important close to elections as they will be updated frequently with events and other ways to get involved." +
				"<h2>New Hampshire Democratic Party</h2>The NHDP is the Democratic Party for the state and has <a href=\"http://nhdp.org/get-involved/\" target=\"_blank\">more ways to get involved</a>. They are also on <a href=\"https://facebook.com/NHDems\" target=\"_blank\">Facebook</a> and <a href=\"https://twitter.com/NHDems\" target=\"_blank\">Twitter</a>.</div>";
        }

		public override Func<string> Content {
			get {
				return OutputPage;
			}
		}

		public override string Description {
			get {
				return "How to get involved and help elect Democrats in Portsmouth, New Hampshire.";
			}
		}

		public override string Key {
			get {
				return "get-involved";
			}
		}
		public override string Path {
			get {
				return "Get-Involved";
			}
		}
		public override string Header {
			get {
				return "Get Involved";
			}
		}

		public override string Title {
			get {
				return "Portsmouth Democrats - " + Header;
			}
		}

		public override string TitleNav {
			get {
				return "Get Involved";
			}
		}
	}
}