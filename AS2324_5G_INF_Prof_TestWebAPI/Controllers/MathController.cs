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
    }


}
