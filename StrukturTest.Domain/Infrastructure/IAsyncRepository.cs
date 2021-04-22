using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrukturTest.Domain.Infrastructure
{
    public interface IAsyncRepository<TEntity> where TEntity : class
    {

        //Kopior av task ifrån vanliga repositories:
        //exempel:
        //Task<TEntity> GetByIdAsync(double ID);
    }
}
