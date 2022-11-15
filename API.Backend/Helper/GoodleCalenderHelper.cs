using API.Backend.Models;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace API.Backend.Helper
{
    public class GoodleCalenderHelper
    {
        public static async Task<Event> CreateGoogleCalendar(GoogleCalender request)
        {
            string[] Scopes = { "https://www.googleapis.com/auth/calendar" };
            string ApplicationName = "Google Canlendar Api";
            UserCredential credential;
            using (var stream = new FileStream(Path.Combine(Directory.GetCurrentDirectory(), "Assets", "cre.json"), FileMode.Open, FileAccess.Read))
            {
                string credPath = "Assets"; 
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }
            // define services
            var services = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            // define request
            Event eventCalendar = new Event()
            {
                Summary = request.Summary,
                Location = request.Location,
                Start = new EventDateTime
                {
                    DateTime = request.Start, 
                    TimeZone = "Africa/Johannesburg"
                },
                End = new EventDateTime
                {
                    DateTime = request.End,
                    TimeZone = "Africa/Johannesburg"
                },
                Description = request.Description
            };
            var eventRequest = services.Events.Insert(eventCalendar, "primary");
            var requestCreate = await eventRequest.ExecuteAsync();
            return requestCreate;
        }
    }
}
