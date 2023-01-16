using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Sockets;
using System.Net;

namespace UnitTesting
{

    namespace TCPServerTest
    {
        class TestEnvironment : IDisposable
        {
            TcpListener TcpServer;

            readonly public int TcpServerAddress;

            public TestEnvironment(int TcpServerAddress = 5678)
            {
                this.TcpServerAddress = TcpServerAddress;

                TcpServer = new TcpListener(IPAddress.Loopback, TcpServerAddress);

                TcpServer.Start();
            }

            public void Dispose()
            {
                TcpServer.Stop();
            }
        }


    [TestClass]
    public class CalculatorTests
    {
            [TestMethod]
            public void TestMethod1()
            {
                

            }
        }

    }




    
}
