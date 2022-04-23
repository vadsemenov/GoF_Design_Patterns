using Facade.Services;

namespace Facade
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var multifunctionPrinterFacade =
                new MultifunctionPrinterFacade(
                    new PrintService(),
                    new ScanService(),
                    new SendFaxService());

            multifunctionPrinterFacade.CopyPaper();
            multifunctionPrinterFacade.SendFax();
        }
    }
}