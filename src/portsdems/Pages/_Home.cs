using System;

namespace portsmouth_democrats.Pages {
	public class Home : Site.Page {
		
		public static string OutputPage() {
			return "<div class=\"tac\"><h2>Upcoming Events</h2><h3>Social Security and Medicare Anniversary Party</h3><div class=\"b\">Thursday, August 6, 2015<br />5:30PM<br />Fig Tree Kitchen - Strawberry Banke<br /><a href=\"http://binged.it/1MyUMUV\" target=\"_blank\">14 Hancock St</a></div><br />This event is being held by the National Committee to Preserve Social Security and Medicare in NH. Have some food and a cake to celebrate the anniversaries as they share stories, and talk about the future of these two vital programs.<h3>Portsmouth Democrats Monthly Roundtable</h3><div class=\"b\">Tuesday, August 18, 2015<br />6:30PM<br />Cafe Nostimo<br /><a href=\"http://binged.it/1cFa7EC\" target=\"_blank\">72 Mirona Road</a></div><br />All Democrats are welcome. This is a social gathering with no agenda or speakers, just good food, good conversation, with good people.";
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
