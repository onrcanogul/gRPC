using Google.Protobuf;
using Grpc.Core;
using grpcMessageService;

namespace grpcServer.Services;

public class MessageService : Message.MessageBase
{
    public override async Task<MessageResponse> SendMessage(MessageRequest request, ServerCallContext context)
    {

        Console.WriteLine($"message : {request.Message} | name : {request.Name}");

        return new MessageResponse() {
            Message = "new message",
        };
    }
}
