using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eshop_Scrum_Practice.Data
{
    public class CartService
    {
        private static readonly List<CartItem> TempStorage = new List<CartItem>();
        public int Count { get; set; } = 0;
        public event Action OnChange;
        private void NotifyStateChanged() => OnChange?.Invoke();
        private void UpdateCount()
        {
            Count = TempStorage.Select(x => x.Count).Sum();
            NotifyStateChanged();
        }

        public Task AddItemAsync(Article article)
        {
            var find = TempStorage.Find(x => x.Article.Id == article.Id);
            if(find == default)
            {
                TempStorage.Add(new CartItem { Article = article, Count = 1 });
            }
            else
            {
                find.Count++;
            }

            UpdateCount();
            return Task.CompletedTask;
        }

        public Task RemoveItemASync(int index)
        {
            var item = TempStorage.ElementAt(index);
            if (item.Count == 1)
            {
                TempStorage.Remove(item);
            }
            else
            {
                item.Count--;
            }

            UpdateCount();
            return Task.CompletedTask;
        }

        public Task<CartItem[]> GetAllAsync()
        {
            return Task.FromResult(TempStorage.ToArray());
        }
    }
}
