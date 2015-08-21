using System;

namespace portsmouth_democrats.Pages {
	public class Home : Site.Page {
		
		public static string OutputPage() {
			return "<div class=\"tac\"><h2>Upcoming Events</h2><h3>Ward Officials Caucus</h3><div class=\"b\">Saturday, August 29, 2015<br />9:15AM<br />Portsmouth Public Library (Levenson Room)<br /><a href=\"http://binged.it/1hylcKS\" target=\"_blank\">175 Parrott Avenue</a></div><br />The caucus will nominate all Democratic candidates for Ward officers, to be elected in the November 3 City Elections. These positions include a Moderator, Clerk, three Selectmen, and a Ward Registrar. In addition, a Registrar at Large will be nominated. Ward officers are responsible for conducting all elections over the next two years.<br /><br />All candidates must be registered Democratic voters and have resided in Portsmouth for at least two years prior to November 3, 2015. Nominations are open to anyone interested in working at the polling places on election days. All poll workers receive nominal hourly compensation. Candidates unable to attend the caucus should contact the Chair, Larry Drake, at 603-373-8517, prior to the caucus for more information. In addition to the elected positions, at least two ballot inspectors will be appointed for each of the five wards.<br /><br />Immediately following the caucus will be a general meeting of Portsmouth Democrats, including brief remarks from elected representatives reporting on the situation in Concord. Light refreshments will be served.<h3>Portsmouth Democrats Monthly Roundtable</h3><div class=\"b\">Tuesday, September 15, 2015<br />6:30PM<br />Cafe Nostimo<br /><a href=\"http://binged.it/1cFa7EC\" target=\"_blank\">72 Mirona Road</a></div><br />All Democrats are welcome. This is a social gathering with no agenda or speakers, just good food, good conversation, with good people.<h3>Portsmouth Democrats Annual Banquet</h3><div class=\"b\">Friday, September 25, 2015<br />6PM - Cocktail Hour<br />7PM - Dinner/Program<br />Portsmouth Harbor Events Conference Center<br /><a href=\"https://goo.gl/maps/VciCI\" target=\"_blank\">Portwalk Place</a></div><br />Presidential candidate Senator Bernie Sanders will be our Keynote Speaker. <a href=\"https://secure.actblue.com/contribute/page/portsmouthdemsbanquet-feelthebern\" target=\"_blank\">Purchase tickets here</a>.";
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
