namespace Adapter
{
    public class JsonDocument : IJsonDocument
    {
        public string GetJsonText()
        {
            return @"{This is string from JsonDocument}";
        }
    }
}