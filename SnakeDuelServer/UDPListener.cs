using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

public class UDPListener
{
    private UdpClient udpListener;

    public UDPListener(int port)
    {
        udpListener = new UdpClient(port);
        Console.WriteLine("UDP Listener started on port " + port);
    }

    public async void ListenForMessagesAsync()
    {
        while (true)
        {
            UdpReceiveResult result = await udpListener.ReceiveAsync();
            string receivedText = Encoding.ASCII.GetString(result.Buffer);
            Console.WriteLine("Received: " + receivedText);
        }
    }

    void OnApplicationQuit()
    {
        udpListener.Close();
    }
}