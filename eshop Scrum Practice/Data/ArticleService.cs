using System.Collections.Generic;
using System.Threading.Tasks;

namespace eshop_Scrum_Practice.Data
{
    public class ArticleService
    {
        private static readonly List<Article> TempStorage = new List<Article>();

        public ArticleService()
        {
            TempStorage.AddRange(new Article[]
                {
                    new Article{Id= 0, Name = "Cheese", Price=63M },
                    new Article{Id= 1, Name = "Salad", Price=1244M },
                    new Article{Id= 2, Name = "Meat", Price=312M },
                    new Article{Id= 3, Name = "Corn", Price=412M },
                });
        }

        public Task<Article[]> GetAllAsync()
            => Task.FromResult(TempStorage.ToArray());

        public Task<Article> GetSingleAsync(int index)
            => Task.FromResult(TempStorage[index]);
    }
}
