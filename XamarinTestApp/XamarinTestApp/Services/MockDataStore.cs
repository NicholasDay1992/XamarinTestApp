using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XamarinTestApp.Models;

namespace XamarinTestApp.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>()
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "App01", Description="Page for App01" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "App02", Description="Page for App02" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "App03", Description="Page for App03" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "App04", Description="Page for App04" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "App05", Description="Page for App05" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "App06", Description="Page for App06" }
            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}