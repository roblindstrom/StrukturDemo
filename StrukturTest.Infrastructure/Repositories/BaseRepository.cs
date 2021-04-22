

using StrukturTest.Domain.Infrastructure;

namespace StrukturTest.Infrastructure.Repositories
{
    public class BaseRepository<T> : IAsyncRepository<T> where T : class
    {
        protected readonly MyDbContext _myDbContext;
        public BaseRepository(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

        //Här körs anroppen mot databasen

        //Väldigt viktigt att i BaseRepository ska endast finnas metoder som flera klasser ska använda sig utav
        //Annars ska man skriva det i den specifika repositorien. Tex ModelRepository
    }
}
