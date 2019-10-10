using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TH2_CoreRazor_Contosa.Pages
{
    public class HelloModel : PageModel
    {

        public string UserName { get; set; }

        public void OnGet()
        {
            UserName = null;
        }

        public void OnPost()
        {
            this.UserName = Request.Form["UserName"];
        }
    }
}
    