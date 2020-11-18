using Grpc.Net.Client;
using System;
using System.Threading.Tasks;

namespace GrpcClient
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var channel = GrpcChannel.ForAddress("http://localhost:5000");

            var client = new GrpcService.Greeter.GreeterClient(channel);

            var request = new GrpcService.HelloRequest()
            {
                Name = "kubra"
            };

            var response = await client.SayHelloAsync(request);

            Console.WriteLine(response.Message);
        }
    }
}
