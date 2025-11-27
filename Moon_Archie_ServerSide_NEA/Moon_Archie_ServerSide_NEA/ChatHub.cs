using Microsoft.AspNetCore.SignalR;

public class ChatHub : Hub
{
    // creates a send message method that takes a string input representing the message
    public async Task SendMessage(string message)
    {
        // sends out the sent message as a recieved message to all connected clients 
        // Uses the recieveMessage event
        await Clients.All.SendAsync("ReceiveMessage", message);
    }
}
