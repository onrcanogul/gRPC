using Grpc.Net.Client;
using grpcMessageClient;
using grpcServer;

namespace GrpcClient{

class Program{
    static async Task Main(string[] args){
        var channel = GrpcChannel.ForAddress("http://localhost:5233");
        var greetClient = new Greeter.GreeterClient(channel);


        #region Unary
        // HelloReply reply = await greetClient.SayHelloAsync(new HelloRequest(){
        //     Name = "Request 1"
        // });

        // Console.WriteLine(reply.Message);
        #endregion
   
        var messageClient = new Message.MessageClient(channel);
        MessageResponse response  = await messageClient.SendMessageAsync(new() {
            Message = "request",
            Name = "requestName"
        });

        System.Console.WriteLine(response.Message);
   
   
    }
}
}
