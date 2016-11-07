using System;

namespace portsmouth_democrats.Pages {
	public class Home : Common.Site.Page {
		
		public static string OutputPage() {
			return "<div class=\"tac\"><h2>Campaign Events</h2>The campaign office is located at <a href=\"https://binged.it/2ahNSHP\" target=\"_blank\">125 Brewery Lane</a><h3>Phone Banks</h3><div class=\"f\"><div class=\"f1\"><div class=\"b\">Tuesdays and Thursdays<br/>Starting at 5PM</div></div><div class=\"f1\"><div class=\"b\">Tuesdays<br/>2-5PM</div>Senior to Senior Phone Bank</div><div class=\"f1\"><div class=\"b\">Wednesdays<br/>Starting at 5PM</div>Women to Women Phone Bank</div></div><h3>Canvasses</h3><div class=\"f\"><div class=\"f1\"><div class=\"b\">Saturday<br/>Starts at 10AM and 1PM</div></div><div class=\"f1\"><div class=\"b\">Sunday<br/>Starts at 11AM and 2PM</div>* Please note: there will be no canvass on September 11th</div></div>" + 
                "<h2>Upcoming Events</h2><h3>Portsmouth Democrats Monthly Gathering</h3><div class=\"b\">Tuesday, September 20, 2016<br />6:30PM<br />Cafe Nostimo<br /><a href=\"http://binged.it/1cFa7EC\" target=\"_blank\">72 Mirona Road</a></div><br />All Democrats are welcome. This is a social gathering with no agenda or speakers, just good food, good conversation, with good people.";
        }

        public override string Content {
            get {
                return OutputPage();
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
