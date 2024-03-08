using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PhoneManager : IApplicantService
    {
        public void ApplyForPC(PersonelComputer pc)
        {
            throw new NotImplementedException();
        }

        public bool CheckPC(PersonelComputer pc)
        {
            throw new NotImplementedException();
        }

        public List<PersonelComputer> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
