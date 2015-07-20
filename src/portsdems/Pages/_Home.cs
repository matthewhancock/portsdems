using System;

namespace portsmouth_democrats.Pages {
	public class Home : Site.Page {

		public static string OutputPage() {
			return "<div class=\"tac\"><h2>Upcoming Events</h2><h3>Thank You Dinner for Terie Norelli</h3><div class=\"b\">Saturday, March 21<br />6PM<br /><a href=\"http://binged.it/1M3LMoV\" target=\"_blank\">Portsmouth Harbor Events and Conference Center</a></div><br />The Portsmouth Democratic Committee will hold a dinner the evening of Saturday, March 21st to thank Terie Norelli for all her years of service in the legislature. A number of political and community leaders who know Terie personally will be featured. The event is a fundraiser for the Portsmouth Democratic Committee, to help us get prepared for the big 2016 elections.<br /><br />The dinner will be held at the Portsmouth Harbor Events and Conference Center in downtown Portsmouth.<br /><br />Doors open at 6:00 pm for a cash bar and dinner will be served at 7:00 pm.<br /><br />It’s first come - first serve and tickets are going fast. We anticipate a sell-out. Here’s a link to the Act Blue page where you can buy your ticket online: <a href=\"https://secure.actblue.com/contribute/page/terie-dinner\" target=\"_blank\">https://secure.actblue.com/contribute/page/terie-dinner</a>";
		}

		public override Func<string> Content {
			get {
				return OutputPage;
			}
		}

		public override string Description {
			get {
				return "The Portsmouth Democratic Committee (Portsmouth Democrats) is the official Democratic Party committee of the City of Portsmouth, New Hampshire.";
			}
		}

		public override string Key {
			get {
				return "home";
			}
		}
		public override string Path {
			get {
				return string.Empty;
			}
		}
		public override string Header {
			get {
				return "Portsmouth Democrats";
			}
		}

		public override string Title {
			get {
				return "Portsmouth Democrats";
			}
		}

		public override string TitleNav {
			get {
				return "Home";
			}
		}
	}
}