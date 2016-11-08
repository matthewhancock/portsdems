using System;

namespace portsmouth_democrats.Pages {
	public class Home : Common.Site.Page {
		
		public static string OutputPage() {
			return "<div class=\"tac\">" +
                "<h2>VOTE · VOTE · VOTE · VOTE</h2>Find Your Polling Location: <a href=\"https://www.iwillvote.com/home/\" target=\"_blank\">iwillvote.com</a>" +
                "<hr class=\"gray\" />" +
                "<h2>GOTV · Get Out The Vote · GOTV</h2>Our campaign office is located at <a href=\"https://binged.it/2ahNSHP\" target=\"_blank\">125 Brewery Lane</a>" +
                "<h3>Phone Banks</h3><div class=\"f\"><div class=\"f1\"><div class=\"b\">Every Day</div>8am - 8pm</div></div>" +
                "<h3>Canvasses</h3><div class=\"f\"><div class=\"f1\"><div class=\"b\">Every Day</div>Launches at 8am, 11am, 2pm, and 5pm</div></div>" +
                "<hr class=\"gray\" />" + 
                "<h2>Upcoming Events</h2>" +
                "<h3>Elizabeth Warren Canvass Kickoff</h3><div class=\"b\">Tuesday, November 8, 2016<br />11am<br />Portsmouth Democrats Campaign Office<br /><a href=\"https://binged.it/2ahNSHP\" target=\"_blank\">125 Brewery Lane</a></div><br />This canvass launch will start with a brief speech from special guest Senator Elizabeth Warren of Massachusetts." +
                "<h3>Portsmouth Democrats Monthly Gathering</h3><div class=\"b\">Tuesday, November 15, 2016<br />6:30pm<br />Cafe Nostimo<br /><a href=\"http://binged.it/1cFa7EC\" target=\"_blank\">72 Mirona Road</a></div><br />All Democrats are welcome. This is a social gathering with no agenda or speakers, just good food, good conversation, with good people.";
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
