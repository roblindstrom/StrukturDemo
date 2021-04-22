
using StrukturTest.Domain.Infrastructure;
using StrukturTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrukturTest.Infrastructure.Repositories
{
    public class ModelRepository : BaseRepository<Model>, IModelRepository
    {
        public ModelRepository(MyDbContext dbContext) : base(dbContext)
        {

        }
        //Här ska anropp mot databasen finnas som är specifikt till Model


    }
}
