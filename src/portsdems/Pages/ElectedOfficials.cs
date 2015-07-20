using System;

namespace portsmouth_democrats.Pages {
	public class ElectedOfficials : Site.Page {

		public static string OutputPage() {
			return "<div class=\"tac\">Elected Democrats that represent Portsmouth, New Hampshire.<h2>Senator Jeanne Shaheen</h2><a href=\"http://www.shaheen.senate.gov/\" target=\"_blank\">Official Website</a><br /><a href=\"https://www.facebook.com/SenatorShaheen\" target=\"_blank\">Facebook</a><br /><a href=\"https://twitter.com/senatorshaheen\" target=\"_blank\">Twitter</a>" +
				"<h2>Governor Maggie Hassan</h2><a href=\"http://www.governor.nh.gov/\" target=\"_blank\">Official Website</a><br /><a href=\"https://www.facebook.com/GovernorHassan\" target=\"_blank\">Facebook</a><br /><a href=\"https://twitter.com/governorhassan\" target=\"_blank\">Twitter</a>" +
				"<h2>State Senator Martha Fuller Clark</h2><a href=\"http://www.gencourt.state.nh.us/senate/members/webpages/district21.aspx\" target=\"_blank\">Official Website</a><br /><a href=\"https://www.facebook.com/MarthaFullerClarkForStateSenate\" target=\"_blank\">Facebook</a><br /><a href=\"https://twitter.com/mfclark\" target=\"_blank\">Twitter</a>" +
				"<h2>State Representatives</h2>Laura Pantelakos (Ward 1)<br /><a href=\"http://www.gencourt.state.nh.us/house/members/member.aspx?member=366385\" target=\"_blank\">Official Website</a><br /><br />Becky McBeath (Ward 2)<br /><a href=\"http://www.gencourt.state.nh.us/house/members/member.aspx?member=377309\" target=\"_blank\">Official Website</a><br /><br />" +
				"Debbie DiFranco (Ward 3)<br /><a href=\"http://www.gencourt.state.nh.us/house/members/member.aspx?member=377290\" target=\"_blank\">Official Website</a><br /><br />Gerry Ward (Ward 4)<br /><a href=\"http://www.gencourt.state.nh.us/house/members/member.aspx?member=377188\" target=\"_blank\">Official Website</a><br /><br />" +
				"Pamela Gordon (Ward 5)<br /><a href=\"http://www.gencourt.state.nh.us/house/members/member.aspx?member=377298\" target=\"_blank\">Official Website</a><br /><br />Jackie Cali-Pitts (Wards 1,2,4,5)<br /><a href=\"http://www.gencourt.state.nh.us/house/members/member.aspx?member=376191\" target=\"_blank\">Official Website</a>" +
				"<h2>City Council</h2>Bob Lister (Mayor)<br /><a href=\"http://cityofportsmouth.com/mayor/\" target=\"_blank\">Official Website</a><br /><br />Jim Splaine (Assistant Mayor)<br /><a href=\"http://cityofportsmouth.com/citycouncil/index-contact-splaine.htm\" target=\"_blank\">Official Website</a><br /><br />Zelita Morgan<br /><a href=\"http://cityofportsmouth.com/citycouncil/index-contact-morgan.htm\" target=\"_blank\">Official Website</a><br /><br />Stefany Shaheen<br /><a href=\"http://cityofportsmouth.com/citycouncil/index-contact-shaheen.htm\" target=\"_blank\">Official Website</a><br /><br />Eric Spear<br /><a href=\"http://cityofportsmouth.com/citycouncil/index-contact-spear.htm\" target=\"_blank\">Official Website</a><h2>School Board</h2>Leslie Stevens (Chair)<br />Gary Epler<br />Thomas P. Martin<br />Helene \"Lennie\" Mullaney<br />Ann M.Walker</div>";
		}

		public override Func<string> Content {
			get {
				return OutputPage;
			}
		}

		public override string Description {
			get {
				return "Elected Democrats that represent Portsmouth, New Hampshire.";
			}
		}

		public override string Key {
			get {
				return "elected-officials";
			}
		}
		public override string Path {
			get {
				return "Elected-Officials";
			}
		}
		public override string Header {
			get {
				return "Elected Officials";
			}
		}

		public override string Title {
			get {
				return "Portsmouth Democrats - " + Header;
			}
		}

		public override string TitleNav {
			get {
				return "Elected Officials";
			}
		}

	}
}