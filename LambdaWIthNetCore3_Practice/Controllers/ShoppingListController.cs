using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LambdaWIthNetCore3_Practice.Models;
using LambdaWIthNetCore3_Practice.Services;

namespace LambdaWIthNetCore3_Practice.Controllers
{
    //Adding comment
    [Route("api/[controller]")]
    public class ShoppingListController : Controller
    {
        private readonly IShoppingListService _shoppingListService;

        public ShoppingListController(IShoppingListService shoppingListService)
        {
            _shoppingListService = shoppingListService;
        }

        [HttpGet]
        public IActionResult GetShoppingList()
        {
            var items = _shoppingListService.GetShoppingList();
            return Ok(items);
        }

        [HttpPost]
        public IActionResult AddShoppingItem([FromBody]Shopping item)
        {
            _shoppingListService.AddShoppingItem(item);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteShoppingList([FromBody]Shopping item)
        {
            _shoppingListService.DeleteShoppingItem(item.Name);
            return Ok();
        }
    }
}
