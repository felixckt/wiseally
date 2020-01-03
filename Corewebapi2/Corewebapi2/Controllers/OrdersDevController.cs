using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Corewebapi2.Models;
using Corewebapi2.Model;

namespace Corewebapi2.Controllers
{
    [Route("api/[controller]/[action]")]
    public class OrdersDevController : Controller
    {
        private Corewebapi2Context _context;

        public OrdersDevController(Corewebapi2Context context) {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get(DataSourceLoadOptions loadOptions) {
            var order = _context.Order.Select(i => new {
                i.OrderID,
                i.OrderDate,
                i.CustomerID,
                i.CustomerName,
                i.ShipCountry,
                i.ShipCity
            });

            // If you work with a large amount of data, consider specifying the PaginateViaPrimaryKey and PrimaryKey properties.
            // In this case, keys and data are loaded in separate queries. This can make the SQL execution plan more efficient.
            // Refer to the topic https://github.com/DevExpress/DevExtreme.AspNet.Data/issues/336.
            // loadOptions.PrimaryKey = new[] { "OrderID" };
            // loadOptions.PaginateViaPrimaryKey = true;

            return Json(await DataSourceLoader.LoadAsync(order, loadOptions));
        }

        [HttpPost]
        public async Task<IActionResult> Post(string values) {
            var model = new Order();
            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, valuesDict);

            if(!TryValidateModel(model))
                return BadRequest(GetFullErrorMessage(ModelState));

            var result = _context.Order.Add(model);
            await _context.SaveChangesAsync();

            return Json(result.Entity.OrderID);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int key, string values) {
            var model = await _context.Order.FirstOrDefaultAsync(item => item.OrderID == key);
            if(model == null)
                return StatusCode(409, "Order not found");

            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, valuesDict);

            if(!TryValidateModel(model))
                return BadRequest(GetFullErrorMessage(ModelState));

            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task Delete(int key) {
            var model = await _context.Order.FirstOrDefaultAsync(item => item.OrderID == key);

            _context.Order.Remove(model);
            await _context.SaveChangesAsync();
        }


        private void PopulateModel(Order model, IDictionary values) {
            string ORDER_ID = nameof(Order.OrderID);
            string ORDER_DATE = nameof(Order.OrderDate);
            string CUSTOMER_ID = nameof(Order.CustomerID);
            string CUSTOMER_NAME = nameof(Order.CustomerName);
            string SHIP_COUNTRY = nameof(Order.ShipCountry);
            string SHIP_CITY = nameof(Order.ShipCity);

            if(values.Contains(ORDER_ID)) {
                model.OrderID = Convert.ToInt32(values[ORDER_ID]);
            }

            if(values.Contains(ORDER_DATE)) {
                model.OrderDate = Convert.ToDateTime(values[ORDER_DATE]);
            }

            if(values.Contains(CUSTOMER_ID)) {
                model.CustomerID = Convert.ToInt32(values[CUSTOMER_ID]);
            }

            if(values.Contains(CUSTOMER_NAME)) {
                model.CustomerName = Convert.ToString(values[CUSTOMER_NAME]);
            }

            if(values.Contains(SHIP_COUNTRY)) {
                model.ShipCountry = Convert.ToString(values[SHIP_COUNTRY]);
            }

            if(values.Contains(SHIP_CITY)) {
                model.ShipCity = Convert.ToString(values[SHIP_CITY]);
            }
        }

        private string GetFullErrorMessage(ModelStateDictionary modelState) {
            var messages = new List<string>();

            foreach(var entry in modelState) {
                foreach(var error in entry.Value.Errors)
                    messages.Add(error.ErrorMessage);
            }

            return String.Join(" ", messages);
        }
    }
}