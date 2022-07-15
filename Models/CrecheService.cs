using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Creche.Models
{
    public class CrecheService
    {
        public int CadastrarInformacao(Informacao cad)
        {
            using( var context = new CrecheContext())
            {
                context.Add(cad);
                context.SaveChanges();

                return cad.Id;
            }
        }
    }
}