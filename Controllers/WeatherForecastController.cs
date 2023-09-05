using Microsoft.AspNetCore.HttpLogging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Net.Mime;
using System.Text.Json.Nodes;

using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
  
    public class WeatherForecastController : ControllerBase
    {

      


        public WeatherForecastController()

        {
       
            
        }

        [HttpPost("")]
        [Consumes("application/json")]
       
        public ActionResult<Weather> Index([FromBody] Weather weather )

           
        {


            /* var result=  _sqlContext.Add<Weather>(new Weather()
                 {
                     Name="Dallas",
                     Description="ok",
                     WeatherId=2

                 });

                 await _sqlContext.SaveChangesAsync();*/

            


            return weather;


        }


        [HttpPost("/form")]

        
        public IActionResult Index1( [FromForm] Weather weather)


        {


            /* var result=  _sqlContext.Add<Weather>(new Weather()
                 {
                     Name="Dallas",
                     Description="ok",
                     WeatherId=2

                 });

                 await _sqlContext.SaveChangesAsync();*/

       




            return new JsonResult(weather);


        }


        [HttpGet("/from1")]


        public IActionResult Index2()


        {


            /* var result=  _sqlContext.Add<Weather>(new Weather()
                 {
                     Name="Dallas",
                     Description="ok",
                     WeatherId=2

                 });

                 await _sqlContext.SaveChangesAsync();*/




            return new JsonResult("hello deployed from Docker");


        }


        /*  [HttpPost("")]
          public async Task<string> Index(Weather id)
          {



              var result = _sqlContext.Add<Weather>(new Weather()
              {

                  WeatherId = id.WeatherId

              });

              await _sqlContext.SaveChangesAsync();

              return result.ToString();

          }*/







    }


 





}