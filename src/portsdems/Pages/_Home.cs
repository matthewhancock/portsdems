using System;

namespace portsmouth_democrats.Pages {
	public class Home : Site.Page {
		
		public static string OutputPage() {
			return "<div class=\"tac\"><h2>Upcoming Events</h2><h3>Portsmouth Democrats Annual Banquet [SOLD OUT]</h3><div class=\"b\">Friday, September 25, 2015<br />6PM - Cocktail Hour<br />7PM - Dinner/Program<br />Portsmouth Harbor Events Conference Center<br /><a href=\"https://goo.gl/maps/VciCI\" target=\"_blank\">Portwalk Place</a></div><br />Presidential candidate Senator Bernie Sanders will be our Keynote Speaker. Tickets are sold out, but you can still <a href=\"https://secure.actblue.com/contribute/page/portsmouthdemsbanquet-feelthebern\" target=\"_blank\">sponsor the event</a>.<h3>Portsmouth Democrats Monthly Roundtable</h3><div class=\"b\">Tuesday, October 21, 2015<br />6:30PM<br />Cafe Nostimo<br /><a href=\"http://binged.it/1cFa7EC\" target=\"_blank\">72 Mirona Road</a></div><br />All Democrats are welcome. This is a social gathering with no agenda or speakers, just good food, good conversation, with good people.";
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
