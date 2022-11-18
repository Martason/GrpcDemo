//gRPC server kan prata med vilken client som hellst. skulle kunna vara en annan gRPC server eller en webApp. 
using Grpc.Net.Client;
using GrpcClient;

var input = new HelloRequest { Name = "Märta" };

var channel = GrpcChannel.ForAddress("https://localhost:7139"); //TODO Sätt detta i appsetnings.json senare. 
var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(input);
Console.WriteLine("Greeting: " + reply.Message);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();

Console.ReadLine();

//Måste lägga till nuget packet för att göra clienten. 

