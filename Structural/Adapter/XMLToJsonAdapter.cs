namespace Adapter
{
    public class XMLToJsonAdapter : IJsonDocument
    {
        public XMLDocument xml;

        public XMLToJsonAdapter(XMLDocument xml)
        {
            this.xml = xml;
        }
        public string GetJsonText()
        {
            return ConvertXMLToJson();
        }

        private string ConvertXMLToJson()
        {
            return @"{" + xml.GetXMLText() + "}";
        }
    }
}