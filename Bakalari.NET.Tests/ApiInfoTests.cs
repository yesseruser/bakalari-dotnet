namespace Bakalari.NET.Tests;

public class ApiInfoTests
{
    private HttpClient _client = new();

    [SetUp]
    public void Setup()
    {
        _client = HttpClientGenerator.CreateBySchoolName("example");
    }

    [TearDown]
    public void TearDown()
    {
        _client.Dispose();
    }
    
    [Test]
    Get
}