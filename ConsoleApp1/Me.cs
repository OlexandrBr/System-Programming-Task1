
namespace ConsoleApp1
{
    internal class Me : PersonBase
    {
        public void ShowPIBInfo()
        {
            ShowInfo("ПІБ: Брузгін Олександр Семенович", "Інформація про мене");
        }

        public void ShowAddressInfo()
        {
            ShowInfo("Місто та адреса: Миколаїв, 5-та Слобідська 143", "Інформація про мене");
        }

        public void ShowKYRSInfo()
        {
            ShowInfo("Курс: Системне програмування", "Інформація про мене");
        }
    }
}