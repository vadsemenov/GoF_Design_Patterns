using System;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            XMLDocument xml = new XMLDocument();
            JsonDocument json = new JsonDocument();
           XMLToJsonAdapter adapter = new XMLToJsonAdapter(xml);
           
           JsonService jsonService= new JsonService(json);
           JsonService jsonService2 = new JsonService(adapter);
        }
    }
}
