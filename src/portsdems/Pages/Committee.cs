using System;

namespace portsmouth_democrats.Pages {
	public class Committee : Site.Page {

		public static string OutputPage() {
			return "<div class=\"tac\">Larry Drake, Chair<br />Laurie McCray, 1st Vice Chair<br />Matthew Hancock, 2nd Vice Chair<br />Brian Wazlaw, Treasurer<br />Anne Gabel, Secretary<h2>Ward 1</h2>Lisa Bellanti, Chair<br />Norm Patenaude, Vice Chair<br />Jim Splaine, Secretary<br />Norm Patenaude, Treasurer<h2>Ward 2</h2>Robin McLane, Chair<br />Dina Mitchell, Vice Chair<br />Barbara Tsairis, Secretary<br />William Tucker, Treasurer<h2>Ward 3</h2>Damon Thomas, Chair<br />Ray Mullaly, Vice Chair<br />Catherine Jones, Secretary<br />Walter Hamilton, Treasurer<h2>Ward 4</h2>Sharon Nichols, Chair<br />Pat Rowe, Secretary<h2>Ward 5</h2>Sue Hubbard, Chair<br />Don Margeson, Vice Chair<h2>At-large Delegates</h2>Matthew Hancock<br />Rob Stuart<br />Peter Somssich<h2>Chair Emeritus</h2>Peter Somssich</div>";
		}

		public override Func<string> Content {
			get {
				return OutputPage;
			}
		}

		public override string Description {
			get {
				return "The executive committee members of the Democratic Party in Portsmouth, New Hampshire.";
			}
		}

		public override string Key {
			get {
				return "committee";
			}
		}
		public override string Path {
			get {
				return "Committee";
			}
		}
		public override string Header {
			get {
				return "Committee";
			}
		}

		public override string Title {
			get {
				return "Portsmouth Democrats - " + Header;
			}
		}

		public override string TitleNav {
			get {
				return "Committee";
			}
		}

	}
}