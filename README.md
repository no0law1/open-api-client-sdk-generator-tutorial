# open-api-client-sdk-generator-tutorial
Repository to teach a bit about how to generate a client sdk using Open Api specification

* [Medium Article](https://medium.com/@no0law1/generate-client-sdk-for-net-core-using-open-api-no0law1-4767fa86a17f)

### Pre Requisites

Before we begin, we are going to need two things:

-   [dotnet](https://dotnet.microsoft.com/download)
-   [npm](https://nodejs.org/en/)

Once we have them we can start our journey.

### Setup

**Step 1: Create a Web Api**

Using [dotnet command line interface](https://docs.microsoft.com/en-us/dotnet/core/tools/) create a webapi with the command `dotnet new`, just like this:

`dotnet new webapi --name Api --language "C#"`

**Step 2: Generate Open API spec of our Web Api**

The `webapi` template already has a resource called _WeatherForecast_ which we can use to generate our client sdk, so our next logical step will be to add the Swashbuckle required package to our project using `dotnet add package`. _(The command must be executed on the same directory as where the csproj is located.)_

`dotnet add package Swashbuckle.AspNetCore.SwaggerGen --version 5.5.1`

Now that we have the necessary package, it’s time for some code.

We will only need to add some lines on _Startup.cs_ file.  
Go to **ConfigureServices** method and add the _AddSwaggerGen_ method.

```csharp
services.AddSwaggerGen(options =>  
{  
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "1" });  
});
```

This method will register the swagger document generator which we will need to retrieve the json document afterwards.

Now we need to install a tool in order to get the json file with the Open API spec of our API called [_Swashbuckle.AspNetCore.Cli_](https://github.com/domaindrivendev/Swashbuckle.AspNetCore#swashbuckleaspnetcorecli) using this command:

`dotnet tool install --global Swashbuckle.AspNetCore.Cli`

But before running this tool, we must generate a _dll_ of our project, so:  
1. `dotnet restore Api/Api.csproj`  
2. `dotnet build -c Release Api/Api.csproj`

Afterwards, validate if our _dll_ was properly generated in `Api/bin/Release/netcoreapp3.1` .

Now that we have a proper _dll_, we can use the tool we installed previously by executing this command:

```
swagger tofile --output swagger.json Api/bin/Release/netcoreapp3.1/Api.dll v1
```

This command will generate the open api spec into a file named _swagger.json_ which we will then use it to generate our Client SDK.

**Step 3: Generate Client SDK for .NET Core**

In the beginning I told you it was necessary to install npm. Now it’s time to use it. We are going to install a package from [OpenAPI Generator](https://openapi-generator.tech/) that will help us generate our Client SDK.

Install the Open Api Generator Command Line Interface globally by executing this command:

```
npm install @openapitools/openapi-generator-cli -g
```

And finally execute Open Api Generator CLI to generate our SDK with this command:

`openapi-generator generate -i swagger.json -g csharp-netcore -o Api.Client.Sdk --additional-properties packageName=Api.Client.Sdk`

The command will create a directory called Api.Client.Sdk where the generated client sdk of our API with the specified package name is.

---

### Wrap Up

That is basically it. Now you can generate your API SDK without any code, you can even automate the SDK generation and pack it into your package manager.  
If you need a different technology for your SDK, open api generator provides a lot more generators which are listed [here](https://openapi-generator.tech/docs/generators).

I’ll leave some useful links below if you’d like to know more about some topics talked here:

-   [OpenAPI Specification](https://swagger.io/specification/)
-   [OpenAPI Generator](https://openapi-generator.tech/)
