# Qwen.ASPClient

**Qwen.ASPClient** is a lightweight and efficient ASP.NET wrapper for the Qwen AI API, providing seamless integration into .NET applications.

## Features
- Simple and fluent API
- Supports Dependency Injection
- Built-in error handling
- Utilizes `HttpClient` best practices for performance

## Installation

Install the package via NuGet:
```sh
dotnet add package Qwen.ASPClient
```

## Usage Example

```csharp
var client = new QwenClient("your-api-key");
var response = await client.GenerateResponseAsync("Hello Qwen!");
Console.WriteLine(response.Choices[0].Message.Content);
```

## Dependency Injection

To register the client in an ASP.NET Core application:

```csharp
services.AddSingleton<IQwenClient>(provider =>
    new QwenClient(Configuration["Qwen:ApiKey"]));
```

## Error Handling

The library provides structured error handling with custom exceptions:

```csharp
try
{
    var response = await client.GenerateResponseAsync("Tell me a joke!");
    Console.WriteLine(response.Choices[0].Message.Content);
}
catch (QwenException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
```

## Contributing

Contributions are welcome! If you'd like to contribute, please follow these steps:
1. Fork the repository
2. Create a feature branch (`git checkout -b feature-name`)
3. Commit your changes (`git commit -m "Add new feature"`)
4. Push to the branch (`git push origin feature-name`)
5. Open a Pull Request

## Reporting Issues

If you encounter any issues or have feature requests, please open an issue on GitHub:
[Issues](https://github.com/Anwar-alhitar/Qwen.ASPClient/issues)

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

### Created by [Anwar Al-Hitar](https://github.com/Anwar-alhitar)