using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LambdaWIthNetCore3_Practice.Models;

namespace LambdaWIthNetCore3_Practice.Services
{
    public interface IShoppingListService
    {
        List<Shopping> GetShoppingList();
        void AddShoppingItem(Shopping item);
        void DeleteShoppingItem(string name);
    }
}
