using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AjaxTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AjaxTest.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }

        public JsonResult OnPostGetTime(string name)
        {
            Person person = new Person
            {
                Name = name,
                DateTime = DateTime.Now
            };

            return new JsonResult(person);
        }
    }
}
