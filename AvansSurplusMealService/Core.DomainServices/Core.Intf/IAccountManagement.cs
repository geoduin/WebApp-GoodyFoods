using Core.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DomainServices.Core.Intf
{
    public interface IAccountManagement
    {
        //Will use identity framework to block user login
        Personel AssignCantineToPersonel(Personel personel, Cantine cantine);
        Personel AssignCantineToPersonel(Personel personel, string city, string location);

        bool BlockStudentWithNoShows(int StudentId);
        bool BlockStudentWithNoShows(string studentEmail);

        bool UnblockStudent(string Email);
    }
}
