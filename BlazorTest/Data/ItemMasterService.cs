using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest.Data
{
    public class ItemMasterService
    {
        public Task<ItemMaster[]> GetItemMasters()
        {
            var rd = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new ItemMaster
            {
                ItemName = "Item" + rd.Next(1, 100),
                SaleCount = rd.Next(20, 100),
            }).ToArray());
        }
    }
}
