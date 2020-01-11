using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LambdaWIthNetCore3_Practice.Models;

namespace LambdaWIthNetCore3_Practice.Services
{
    public class ShoppingListService : IShoppingListService
    {
        private readonly List<Shopping> _shoppingList = new List<Shopping>();

        public ShoppingListService()
        {
            _shoppingList = new List<Shopping>();
        }

        public List<Shopping> GetShoppingList()
        {
            return _shoppingList;
        }
        public void AddShoppingItem(Shopping item)
        {
            _shoppingList.Add(item);
        }

        public void DeleteShoppingItem(string name)
        {
            Shopping item = _shoppingList.Find(x => x.Name.ToLower() == name.ToLower());
            _shoppingList.Remove(item);
        }
    }
}
