using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TinderApp.Services
{
    public interface IDataStore<T>
    {
        Task<bool> UpdateItemAsync(T item);
        Task<T> GetItemAsync(string id);
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
        Task<List<T>> GetUnseenItemsAsync(bool forceRefresh = false);
        Task<List<T>> GetLikedItemsAsync(bool forceRefresh = false);;
    }
}
