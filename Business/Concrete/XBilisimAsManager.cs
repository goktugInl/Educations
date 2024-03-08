using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class XBilisimAsManager:ICompanyService
    {
        private IApplicantService _applicantService;
        // Constractor - Farklı bir class da bu class çağrıldığında bu constractor çalışır.
        // Interface'ler referans tutuculardır.
        // Oluşturulan Intarface hangi class'da referans olarak kullanılırsa o class çağırılken referan olarak kullanılabilir.
        public XBilisimAsManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }
        public void GivePC(PersonelComputer personelComputer)
        {
            // Eğer bir iş sınıfı diğer sınıfı new yapıyorsa o uygulama ileride yapılan değişiklide patlar.
            // New yapılıyorsa iş sınıfları birbirine bağılmı çalışır değişiklik yapılamaz.
            // Bir class yapılmadan önce her zaman Interface yapılmış olması gerekmektedir. O yüzden Interface kullanılır
            //PCManager pCManager = new PCManager();
            if (_applicantService.CheckPC(personelComputer))
            {
                Console.WriteLine(personelComputer.GraphicDrive + "talep için Grafik Kart Verildi");
            }
            else
            {
                Console.WriteLine("PC Talep Edilmedi");
            }
        }
    }
    // Sonar Qube -> yazılım kalite ölçme programı
}
