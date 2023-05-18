using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VolleyballWebApp.Pages
{
    public class CalculatorModel : PageModel
    {
        public int Result { get; set; }

        public void OnGet()
        {


        }

        public void OnPost()
        {
            var form = Request.Form;

            bool r1 = int.TryParse(form["Number1"], out int number1);
            bool r2 = int.TryParse(form["Number2"], out int number2);


            if (r1 && r2)
            {
                Result = number1 + number2;
            }
            else
            {
                // handle problem 
            }
        }

        //public void OnPost()
        //{
        //    var form = Request.Form;

        //    int? number1=null;
        //    int? number2= null;
        //    try
        //    {
        //        number1 = Convert.ToInt32(form["Number1"]);
        //        number2 = Convert.ToInt32(form["Number2"]);
        //    }
        //    catch (Exception)
        //    {
        //        // handle problem 
        //    }

        //    if(number1 != null && number2 != null) 
        //    {
        //        int result = (int)number1 + (int)number2;
        //    }
        //}
    }
}
