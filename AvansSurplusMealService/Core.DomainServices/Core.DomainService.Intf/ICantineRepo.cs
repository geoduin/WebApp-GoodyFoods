using Core.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DomainServices.Core.DomainService.Intf
{
    public interface ICantineRepo
    {
        Cantine GetCantineById(int Id);
        Cantine GetCantineByCity(string city);

        List<Cantine> GetAllCantines();

        void UpdateCantine(Cantine cantine);

        void DeleteCantine(Cantine cantine);

        void DeleteCantineById(int id);

        void CreateCantine(Cantine cantine);

    }
}
