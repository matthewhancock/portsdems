using System;

namespace portsmouth_democrats.Pages {
	public class Home : Site.Page {
		
		public static string OutputPage() {
			return "<div class=\"tac\"><h2>Upcoming Events</h2><h3>New Hampshire Young Democrats Summer BBQ</h3><div class=\"b\">Saturday, July 25, 2015<br />4-6PM<br />The home of Stefany Shaheen and Craig Welch<br />77 South Street<br />Parking: <a href=\"http://binged.it/1LDMfAB\" target=\"_blank\">1 Junkins Ave (City Hall)</a></div><br />Join the New Hampshire Young Democrats for good food, great company, fun games, and minimal rhetoric.<br /><br /><a href=\"https://secure.actblue.com/contribute/page/nhydbbq2015\" target=\"_blank\">Click here to RSVP</a> or email Kayla at kaylammccarthy@gmail.com.<h3>Portsmouth Democrats Monthly Roundtable</h3><div class=\"b\">Tuesday, August 18, 2015<br />6:30PM<br />Cafe Nostimo<br /><a href=\"http://binged.it/1cFa7EC\" target=\"_blank\">72 Mirona Road</a></div><br />All Democrats are welcome. This is a social gathering with no agenda or speakers, just good food, good conversation, with good people.";
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
