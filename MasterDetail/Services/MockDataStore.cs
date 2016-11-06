using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MasterDetail.Models;

using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(MasterDetail.Services.MockDataStore))]
namespace MasterDetail.Services
{
	public class MockDataStore : IDataStore<Item>
	{
		bool isInitialized;
		List<Item> items;

		public async Task<bool> AddItemAsync(Item item)
		{
			await InitializeAsync();

			items.Add(item);

			return await Task.FromResult(true);
		}

		public async Task<bool> UpdateItemAsync(Item item)
		{
			await InitializeAsync();

			var _item = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
			items.Remove(_item);
			items.Add(item);

			return await Task.FromResult(true);
		}

		public async Task<bool> DeleteItemAsync(Item item)
		{
			await InitializeAsync();

			var _item = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
			items.Remove(_item);

			return await Task.FromResult(true);
		}

		public async Task<Item> GetItemAsync(string id)
		{
			await InitializeAsync();

			return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
		}

		public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
		{
			await InitializeAsync();

			return await Task.FromResult(items);
		}

		public Task<bool> PullLatestAsync()
		{
			return Task.FromResult(true);
		}


		public Task<bool> SyncAsync()
		{
			return Task.FromResult(true);
		}

		public async Task InitializeAsync()
		{
			if (isInitialized)
				return;

			items = new List<Item>();
			var _items = new List<Item>
			{
				new Item { Id = Guid.NewGuid().ToString(), Text = "First item", Description="This is a nice description"},
				new Item { Id = Guid.NewGuid().ToString(), Text = "Second item", Description="This is a nice description"},
				new Item { Id = Guid.NewGuid().ToString(), Text = "Third item", Description="This is a nice description"},
				new Item { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description="This is a nice description"},
				new Item { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description="This is a nice description"},
				new Item { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description="This is a nice description"},
			};

			foreach (Item item in _items)
			{
				items.Add(item);
			}

			isInitialized = true;
		}
	}
}
