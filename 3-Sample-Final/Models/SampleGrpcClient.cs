namespace AvaloniaSampleTutorial.Models;

public class SampleGrpcClient()
{
    public MethodResponse Invoke(MethodRequest req)
    {
        //This is just a demo implementation.  For a real one we should
        //make a call to gRPC server, get the response and serialize it to json
        
        var sampleResp = @"{
    ""Response"": {
        ""Message"": ""Hello John"",
        ""Container"": []
    }
}";
        return new MethodResponse() { Response = sampleResp };
    }
}