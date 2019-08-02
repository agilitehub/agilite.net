 # agilite
A C# module that provides seamless interactions with [Agilit-e](https://agilite.io) APIs.

Created by [Agilit-e](https://agilite.io)

**Installation**

Using NuGet Package Manager:

```
PM> Install-Package Agilite
```

In C#:

```csharp

var agilite = new Agilite(new AgiliteConfig {
	ApiKey = "{agilite_api_key}",
	ApiServerUrl = "{api_server_url}", //Defaults to "https://api.agilite.io"               
});

var keywords = agilite.Keywords.GetData();
if (keywords.IsSuccess) {
	foreach (var keyword in keywords.ResponseData) {
		Console.WriteLine(keyword.Data.Key);
		Console.WriteLine(keyword.Data.IsActive);
	}
}
else
{
	Console.WriteLine(keywords.Error.ErrorMessage);
}
```
