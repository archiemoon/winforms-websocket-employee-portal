using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.SignalR.Client;
using Winforms;

namespace Moon_Archie_Winforms_NEA
{
    public partial class Chat_Frm : Form
    {
        //public int ID_Length = LoginInfo.EmployeeID.Length;
        public bool connected = false;
        private HubConnection hubConnection;
        public Chat_Frm()
        {
            InitializeComponent();

            // Creates the signalR connection and tells it what host to connect to 
            hubConnection = new HubConnectionBuilder()
                .WithUrl("https://moonarchieserversidenea.azurewebsites.net/chatHub")
                .Build();

            // Event handler for when a message is recieved 
            hubConnection.On<string>("ReceiveMessage", (Message) =>
            {
                // Splits the name and the ID into seperate strings
                // Stores the ID as a string
                string[] Message_And_ID_Strings = Message.Split(':');
                string Id_From_Message = Message_And_ID_Strings[1];

                // Connects to the database and gets the name if the employee with that id
                string Query = "SELECT FirstName FROM EmployeeDetails " +
                               $"WHERE EmployeeID = '{Id_From_Message}'";
                string[,] Results = Database_Opperations_Class.Connect_Read_Write(Query, "read");

                // If the ID of the user isnt the same as the ID of the sender
                // The message is displayed with the name of the sender 
                if (LoginInfo.EmployeeID != Id_From_Message)
                {
                    // Stores the Message as a string
                    Message = Message_And_ID_Strings[0];
                    
                    // Displays the Message (Name + : + Message Text) in the text box
                    DisplayMessage(Results[0, 0] + $": {Message}\n", Messages_TxtBox);
                }

                // If there is a connection it adds the new message to the database
                // Any messages sent when there is no connection will not be stored 
                if (connected == true)
                {
                    Query = "INSERT INTO Messages (EmployeeID, Message) " +
                                   $"VALUES ('{LoginInfo.EmployeeID}', '{MessageInput_TxtBox.Text}');";
                    Database_Opperations_Class.Connect_Read_Write(Query, "Write");
                }
            });
        }
        private async void Chat_Frm_Load(object sender, EventArgs e)
        {
            // Gets the number of messages in the database
            string Query = "SELECT Count(*) " +
                           "FROM Messages";
            string[,] Results = Database_Opperations_Class.Connect_Read_Write(Query, "read");

            // Stores the count in the Message info static class
            Message_Info_Class.Message_Count = int.Parse(Results[0, 0]);

            // Calls the message loader to load the last 10 previous messages
            Message_Loader();

            // Starts the signalR connection when the form is opened
            await ConnectAsync();
        }
        private async Task ConnectAsync()
        {
            try
            {
                // Starts the SignalR connection
                await hubConnection.StartAsync();
                // Sets the connection button to green if connection is made
                Connect_Btn.BackColor = Color.LimeGreen;
                connected = true;
            }
            catch (Exception error)
            {
                if (error.Message == "The HubConnection cannot be started if it is not in the Disconnected state.")
                {
                    // If the error is because the connection is already made connection the button stays green 
                    Connect_Btn.BackColor = Color.LimeGreen;
                }
                else
                {
                    // If there is a connection error for another reason the button turns red
                    // The error message caught is displayed in the feed
                    DisplayMessage($"Connection error: {error.Message}\n", Messages_TxtBox);
                    Connect_Btn.BackColor = Color.Firebrick;
                }
            }
        }
        private async Task SendMessageAsync(string Message)
        {
            try
            {
                // Calls the send message method on the server
                await hubConnection.InvokeAsync("SendMessage", Message);

                // Splits the name and the ID into seperate strings
                string[] Message_And_ID_Strings = Message.Split(':');
                Message = Message_And_ID_Strings[0];

                // Displays the Message (You + : + Message Text) in the text box
                DisplayMessage($"You: {Message}\n", Messages_TxtBox);
            }
            catch (Exception ex)
            {
                // Displays any error messages that come from sending the message
                DisplayMessage($"Error sending message: {ex.Message}\n", Messages_TxtBox);
            }
        }
        private void DisplayMessage(string Message, RichTextBox Message_TxtBox)
        {
            // Displays the message in text box
            Message_TxtBox?.BeginInvoke(new Action(() => { Message_TxtBox.AppendText(Message + Environment.NewLine); }));
        }
        private async void Message_Send_Btn_Click(object sender, EventArgs e)
        {
            // Adds the id of the sender to the end of the message when the message is sent
            string Message = $"{MessageInput_TxtBox.Text}:{LoginInfo.EmployeeID}";

            // Calls the send message function and passes in the message and clears the text box
            await SendMessageAsync(Message);

            // Clears the message box
            MessageInput_TxtBox.Clear();
        }
        private async void Connect_Btn_Click(object sender, EventArgs e)
        {
            // Attempts to connect to the server when the connect button is pressed
            await ConnectAsync();
        }

        private void Load_Messages_Btn_Click(object sender, EventArgs e)
        {
            // Calls the message loader to load more previous messages
            Message_Loader();
        }

        private void Message_Loader()
        {
            // Creates an int to store how many times the loader will need to be looped
            int Loop_Count = 0;

            // Creates a string with the messages to add from the database
            string Messages_To_add = "";

            // If the count minus 9 >= 0, this means that there are more than 10 messages to load
            // The loop count is then set to 10 as we load 10 messages at a time 
            if (Message_Info_Class.Message_Count - 9 >= 0)
            {
                // Message count is updated for the next itteration
                Message_Info_Class.Message_Count = Message_Info_Class.Message_Count - 10;

                // The new start index is set to the new message count 
                Message_Info_Class.Start_Index = Message_Info_Class.Message_Count;
                Loop_Count = 10;
            }
            // If there are less than 10 messages 
            // We need to work out how many times to loop to avoid an index error
            else
            {
                // Start index is set to 0
                Message_Info_Class.Start_Index = 0;

                // The loop count is set for the count of messages 
                Loop_Count = Message_Info_Class.Message_Count;

                // The load messages button is made invisible as there are no more messages to load
                Load_Messages_Btn.Visible = false;
            }

            // Selects the message and employee name
            // From the employeeID of that message and stores them in a 2D array
            string Query = "SELECT EmployeeDetails.FirstName, Messages.Message " +
                           "FROM Messages " +
                           "JOIN EmployeeDetails ON Messages.EmployeeID = EmployeeDetails.EmployeeID;";
            string[,] Results = Database_Opperations_Class.Connect_Read_Write(Query, "read");

            // The index is set to the start index calculated above
            int index = Message_Info_Class.Start_Index;

            // Loops from x = 0 to x = Loop_Count
            for (int x = 0; x < Loop_Count; x++)
            {
                // If the Name is the same as the name of the user 
                if (Results[index, 0] == LoginInfo.First_Name)
                {
                    // The message is added to string of all messages to add (You: 'Message')
                    Messages_To_add = $"{Messages_To_add} You: {Results[index, 1]} \n\n";
                }
                else
                {
                    // The message is added to string of all messages to add (Employee Name: 'Message')
                    Messages_To_add = $"{Messages_To_add} {Results[index, 0]}: {Results[index, 1]}\n\n";
                }
                // The index count is incrimented
                index++;
            }
            // The messages to add are added at the top of the text box
            Messages_TxtBox.Text = Messages_To_add + Messages_TxtBox.Text;
        }
    }
}
