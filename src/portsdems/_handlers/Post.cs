using Microsoft.AspNet.Http;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Collections.Specialized;
using System.Net.Http;

namespace portsmouth_democrats.Handlers {
	public class Post {
		public static async Task ProcessRequestAsync(HttpContext Context, string Action) {
			var form = Context.Request.Form;

			switch (Action) {
				case Forms.Subscribe.Action.MailingList:
					var email = form[Forms.Subscribe.Keys.EmailAddress];
					if (email != null) {
                        bool alreadySubscribed = false;
						using (SqlConnection target = new SqlConnection(Application.DBConnectionString)) {
							await target.OpenAsync();
							using (SqlCommand command = new SqlCommand("INSERT INTO portsdems.mailinglist SELECT @email WHERE NOT EXISTS (SELECT 1 FROM portsdems.mailinglist ml WHERE ml.emailAddress = @email)", target)) {
								command.Parameters.Add("@email", System.Data.SqlDbType.VarChar);
								command.Parameters["@email"].Value = email;
								int count = await command.ExecuteNonQueryAsync();
                                if (count == 0) {
                                    alreadySubscribed = true;
                                }
							}
						}
                        if (!alreadySubscribed) {
                            using (HttpClient client = new HttpClient()) {
                                var response = await client.PostAsync("http://tinyletter.com/portsdems", new FormUrlEncodedContent(new System.Collections.Generic.KeyValuePair<string, string>[] { new System.Collections.Generic.KeyValuePair<string, string>("email", email) }));
                                var responses = response.Content.ReadAsStringAsync();
                            }
                            await Context.Response.WriteAsync(Response.Substitute(Forms.Subscribe.HtmlID.FormContainer, "<div class=\"description tac\">Thanks! You've been added to our mailing list.</div>"));
                        } else {
                            await Context.Response.WriteAsync(Response.Substitute(Forms.Subscribe.HtmlID.FormContainer, "<div class=\"description tac\">Thanks! You're already subscribed to our mailing list.</div>"));
                        }
					}
					break;
			}
		}


		public class Response {
			public static string Form(string Content) {
				return "{\"ok\":true,\"form\":\"" + Fix(Content) + "\"}";
			}
			public static string Substitute(string ID, string Value) {
				return "{\"ok\":true,\"reenable\":true,\"substitute\":{\"id\":\"" + ID + "\", \"value\":\"" + Fix(Value) + "\"}}";
			}
			public static string Push(string Href, string Title, string Content, string HrefID = null) {
				if (Href != null) {
					return "{\"ok\":true,\"push\":{\"state\":{\"href\":\"" + Href + "\", \"title\":\"" + Fix(Title) + "\", \"content\":\"" + Fix(Content) + "\", \"hrefid\":\"" + Fix(HrefID) + "\"}}}";
				} else {
					return "{\"ok\":true,\"push\":{\"state\":{\"href\":\"" + Href + "\", \"title\":\"" + Fix(Title) + "\", \"content\":\"" + Fix(Content) + "\"}}}";
				}
			}
			public static string OK(string Message) {
				return "{\"ok\":true,\"reenable\":true,\"message\":\"" + Fix(Message) + "\"}";
			}
			public static string Error(string Message) {
				return "{\"ok\":false,\"message\":\"" + Fix(Message) + "\"}";
			}
			public static string Fix(string s) {
				return Util.Json.Fix(s);
			}
		}
	}
}