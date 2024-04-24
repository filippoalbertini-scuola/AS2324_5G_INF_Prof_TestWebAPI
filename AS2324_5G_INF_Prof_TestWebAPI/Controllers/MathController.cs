using AS2324_5G_INF_Prof_TestWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AS2324_5G_INF_Prof_TestWebAPI.Controllers
{
    public class MathController : Controller
    {
        [HttpGet("GetDivision")]
        public JsonResult GetDivision(float numeratore, float denominatore)
        {
            string status_result = "OK";
            double res;

            if (denominatore == 0)
            {
                status_result = "KO";
                res = 0;
            }
            else
            {
                res = numeratore / denominatore;
            }

            return Json(new { output = res, status = status_result });
        }

        [HttpGet("GetFattoriale")]
        public JsonResult GetFattoriale(int numero)
        {
            string status_result = "OK";
            string message = "Valore calcolabile";
            int res;

            if (numero < 0)
            {
                status_result = "KO";
                res = 0;
                message = "Valore non calcolabile perchè il numero è inferiore a 0";
            }
            else
            {
                res = 1;

                for (int i = numero; i > 0; i--)
                    res *= i;
            }

            return Json(new { output = res, status = status_result, message = message });
        }

        [HttpGet("GetRandomNumbers")]
        public JsonResult GetRandomNumbers(int numero)
        {
            string status_result = "OK";
            string message = "Valore calcolabile";

            var numbers = new Number[numero];

            for (int i = 0; i < numbers.Length; i++)
            {
                // istanzia l'oggetto
                numbers[i] = new Number();

                // posiziona il valore causale
                numbers[i].Value = Random.Shared.Next(-100, 100);
            }


            return Json(new { output = numbers, status = status_result, message = message });

        }
    }


}
