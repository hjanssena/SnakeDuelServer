UDPSender sender = new UDPSender("127.0.0.1", 4444);
sender.SendMessage("ping");
sender.Close();

UDPListener listener = new UDPListener(4445);
listener.ListenForMessagesAsync();
while (true)
{
    
}