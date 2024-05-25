using Microsoft.AspNetCore.SignalR;

namespace Comics.Hubs
{
    public class ChatHub : Hub
    {

        public async Task Send(string message, string user)
        {
            await this.Clients.All.SendAsync ("Send", message, user);
        }

        public async Task UpDateSubjectGrades(int comicsID, string subjectName, int grade)
        {
            await this.Clients.All.SendAsync("UpDateSubjectGrades", comicsID, subjectName, grade);
        }
    }
}
