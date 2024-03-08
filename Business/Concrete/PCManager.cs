using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    // Bir class yapılmadan önce her zaman Interface yapılmış olması gerekmektedir. O yüzden Interface kullanılır
    // Class'ların bir birine bağımlılığı çözmek içi Intarface kullanılır.
    /*
    public class PCManager
    {
        // Kimler PC için alım başvurusu yaptı.
        public void ApplyForPC(PersonelComputer pc)
        {

        }

        // PC özelliklerinin hepsini getiren liste operasyonu.
        public List<PersonelComputer> GetList()
        {
            return null;
        }

        public bool CheckPC (PersonelComputer pc) // Parametresi PersonelComputer
        {
            return true;
        }

        // **** Aşağıdaki kullanım hatalı kullanımdır. Yukarıdaki gibi nesneleri "Encapsulation" kullanımı yapılmalıdır. 
        //public void DifferentMethod()
        //{
        //    YanlisMethod("Intel", "Nvidia", 16, 256);
        //}
        //public void YanlisMethod(string CPU, string GraphicDrive, int RAM, int SS)
        //{

        //}
    }
    */

    public class PCManager : IApplicantService
    {
        public void ApplyForPC(PersonelComputer pc)
        {
            throw new NotImplementedException();
        }

        // Adaptor Design Patern
        public bool CheckPC(PersonelComputer pc)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(22007071234, "Göktuğ", "İNAL", 1993)))
                .Result.Body.TCKimlikNoDogrulaResult;
        }

        public List<PersonelComputer> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
