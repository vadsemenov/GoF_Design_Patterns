using Facade.Services;

namespace Facade;

public class MultifunctionPrinterFacade
{
    private PrintService _printService;
    private ScanService _scanService;
    private SendFaxService _sendFaxService;

    public MultifunctionPrinterFacade(PrintService printService, ScanService scanService, SendFaxService sendFaxService)
    {
        _printService = printService;
        _scanService = scanService;
        _sendFaxService = sendFaxService;
    }

    public void CopyPaper()
    {
        Console.WriteLine("Multifunction Printer make paper copy:");
        _scanService.Scan();
        _printService.Print();
    }

    public void SendFax()
    {
        Console.WriteLine("Multifunction Printer send fax:");
        _scanService.Scan();
        _sendFaxService.SendFax();
    }
}