using System;

namespace Adapter
{
    public class JsonService
    {
        public JsonService(IJsonDocument jsonDocument)
        {
            Console.WriteLine("JsonService(JsonText):"+ jsonDocument.GetJsonText());
        }
    }
}