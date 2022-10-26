using System.Net.Sockets;
using System.Net;
using System.Text;

namespace 同步客户端
{
    public partial class SyncClient : Form
    {
        private IPAddress serverIP;                         //服务端IP地址
        private int serverPort;                             //服务端监听端口
        private IPEndPoint serverIPEndPoint;                //服务端地址端口
        private Socket clientSocket;                        //客户端套接字
        private Thread threadReceive;                       //接收线程
        public SyncClient()
        {
            InitializeComponent();

        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            serverIP = IPAddress.Parse(tBIP.Text);               //服务端IP地址
            serverPort = Int32.Parse(tBPort.Text);               //服务端监听端口
            serverIPEndPoint = new IPEndPoint(serverIP, serverPort);//实例化地址端口类
                                                                    //实例化一个TCP流式套接字
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
                          ProtocolType.Tcp);
            clientSocket.Connect(serverIPEndPoint);              //向服务端发送连接请求
            threadReceive = new Thread(new ThreadStart(ReceiveThread));   //实例化接收线程
            threadReceive.Start();                                        //启动接收线程
        }

        private void ReceiveThread()
        {
            if (clientSocket.Connected)                      //如果与服务端连接成功
            {
                while (true)
                {
                    Byte[] receiveByte = new Byte[1024];      //存放接收到消息的缓存
                    clientSocket.Receive(receiveByte, receiveByte.Length, 0);//同步接收服务端消息
                                                                             //将服务端消息转换为字符串
                    string receiveString = Encoding.Default.GetString(receiveByte);
                    ShowMessage(receiveString);               //输出接收的消息
                }
            }
        }

        delegate void ShowMessageCallback(string message);      //显示接收的消息委托
                                                                //显示接收的消息
        void ShowMessage(string message)
        {
            if (this.InvokeRequired) this.Invoke(new ShowMessageCallback(ShowMessage), new
                object[] { message });
            else tBReceive.AppendText(message + "\n");
        }

        private void bSend_Click(object sender, EventArgs e)
        {
            if (clientSocket != null && clientSocket.Connected)  //判断是否已经与服务端建立连接
        {
                //将需要发送的字符串转换为Byte数组
                Byte[] sendByte = Encoding.Default.GetBytes(tBSend.Text);
                clientSocket.Send(sendByte, sendByte.Length, 0);  //向服务端同步发送消息
            }
        }
    }
}