using System;
using System.Text;
using RabbitMQ.Client;

namespace Sender
{
    class MainClass
    {
        static void Main(string[] args)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection()) 
            using(var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "hello",
                                       durable: false,
                                       autoDelete: false,
                                       arguments: null);
                string message = "Hello world";

                //it is use to encrept the message
                var body = Encoding.UTF8.GetBytes(message);
                channel.BasicPublish(exchange: "",
                                      routingKey: "Hello",
                                      basicProperties: null,
                                      body: body);
                Console.WriteLine("[x] message send {0}", message);
            }
            Console.WriteLine("Press enter to exit from the application");
            Console.ReadLine();
        }
    }
}
