
using StrukturTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrukturTest.Domain.Infrastructure
{
    public interface IModelRepository : IAsyncRepository<Model>
    {

    }
}
