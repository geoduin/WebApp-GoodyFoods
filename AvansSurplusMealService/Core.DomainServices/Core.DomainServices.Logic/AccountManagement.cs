using Core.Domain.Domain;
using Core.DomainServices.Core.DomainService.Intf;
using IAccountManagement = Core.DomainServices.Core.DomainService.Intf.IAccountManagement;

namespace Core.DomainServices.Core.DomainServices.Logic
{
    public class AccountManagement : IAccountManagement
    {
        private IPersonelRepo personelRepo;
        public IStudentRepo StudentRepo { get; }
        public AccountManagement(IPersonelRepo PersonelRepo, IStudentRepo studentRepo)
        {
            personelRepo = PersonelRepo;
            StudentRepo = studentRepo;
        }

        public Personel AssignCantineToPersonel(Personel personel, Cantine cantine)
        {
            throw new NotImplementedException();
        }

        public Personel AssignCantineToPersonel(Personel personel, string city, string location)
        {
            throw new NotImplementedException();
        }

        public bool BlockStudentWithNoShows(int StudentId)
        {
            throw new NotImplementedException();
        }

        public bool BlockStudentWithNoShows(string studentEmail)
        {
            throw new NotImplementedException();
        }

        public string GetEmail()
        {
            throw new NotImplementedException();
        }

        public string GetRole()
        {
            throw new NotImplementedException();
        }

        public bool UnblockStudent(string Email)
        {
            throw new NotImplementedException();
        }
    }
}
