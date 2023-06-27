using Core.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DomainServices.Core.DomainService.Intf
{
    public interface IStudentRepo: IUserRepo<Student>
    {
        Student GetStudentByStudentId(string studentId);
    }


}
