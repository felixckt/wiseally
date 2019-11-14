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
using WebApplication4.Models;
using WebApplication4.Model;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]/[action]")]
    public class StudentsController : Controller
    {
        private WebApplication4Context _context;

        public StudentsController(WebApplication4Context context) {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get(DataSourceLoadOptions loadOptions) {
            var student = _context.Student.Select(i => new {
                i.StudentID,
                i.StudentName,
                i.DateOfBirth,
                i.Height,
                i.Weight
            });

            // If you work with a large amount of data, consider specifying the PaginateViaPrimaryKey and PrimaryKey properties.
            // In this case, keys and data are loaded in separate queries. This can make the SQL execution plan more efficient.
            // Refer to the topic https://github.com/DevExpress/DevExtreme.AspNet.Data/issues/336.
            // loadOptions.PrimaryKey = new[] { "StudentID" };
            // loadOptions.PaginateViaPrimaryKey = true;

            return Json(await DataSourceLoader.LoadAsync(student, loadOptions));
        }

        [HttpPost]
        public async Task<IActionResult> Post(string values) {
            var model = new Student();
            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, valuesDict);

            if(!TryValidateModel(model))
                return BadRequest(GetFullErrorMessage(ModelState));

            var result = _context.Student.Add(model);
            await _context.SaveChangesAsync();

            return Json(result.Entity.StudentID);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int key, string values) {
            var model = await _context.Student.FirstOrDefaultAsync(item => item.StudentID == key);
            if(model == null)
                return StatusCode(409, "Student not found");

            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, valuesDict);

            if(!TryValidateModel(model))
                return BadRequest(GetFullErrorMessage(ModelState));

            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task Delete(int key) {
            var model = await _context.Student.FirstOrDefaultAsync(item => item.StudentID == key);

            _context.Student.Remove(model);
            await _context.SaveChangesAsync();
        }


        private void PopulateModel(Student model, IDictionary values) {
            string STUDENT_ID = nameof(Student.StudentID);
            string STUDENT_NAME = nameof(Student.StudentName);
            string DATE_OF_BIRTH = nameof(Student.DateOfBirth);
            string HEIGHT = nameof(Student.Height);
            string WEIGHT = nameof(Student.Weight);

            if(values.Contains(STUDENT_ID)) {
                model.StudentID = Convert.ToInt32(values[STUDENT_ID]);
            }

            if(values.Contains(STUDENT_NAME)) {
                model.StudentName = Convert.ToString(values[STUDENT_NAME]);
            }

            if(values.Contains(DATE_OF_BIRTH)) {
                model.DateOfBirth = values[DATE_OF_BIRTH] != null ? Convert.ToDateTime(values[DATE_OF_BIRTH]) : (DateTime?)null;
            }

            if(values.Contains(HEIGHT)) {
                model.Height = Convert.ToDecimal(values[HEIGHT], CultureInfo.InvariantCulture);
            }

            if(values.Contains(WEIGHT)) {
                model.Weight = Convert.ToSingle(values[WEIGHT], CultureInfo.InvariantCulture);
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