# Alexa.NET.Conversations
Extension for Alexa.NET that supports Alexa Conversations

### Add Conversation Support to your skill

```csharp
DialogApiInvokedRequest.AddToRequestConverter();
DialogDelegateRequestDirective.AddSupport()
```

### Identify a Conversations Request

```csharp
if skillRequest.Request is DialogApiInvokedRequest
...
```

### Return a conversation api response
```csharp
var response = ResponseBuilder.Empty();
response.Response = new DialogConversationResponse{
	ApiResponse = new Dictionary<string,object>{
	//... API properties returned here ...
	}
}
```

