using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JSend.WebApi;
using mathAPI.NetCore.Functions;
using mathAPI.NetCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mathAPI.NetCore.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        Response response = new Response();

        [Route("api/bmi")]
        [HttpPost]
        public IActionResult BMI([FromBody] BMIModel data)
        {
            //CONVERT TO DOUBLE
            var height = Convert.ToDouble(data.Height);
            var weight = Convert.ToDouble(data.Weight);

            if (weight.GetType() != typeof(double) || height.GetType() != typeof(double))
            {
                response.Status = "Fail";
                response.Description = "Please enter your weight and height as a number";
                return BadRequest(response);
            }
            else
            {
                response.Status = "Success";
                response.Description = "Calculated BMI";
                response.Data = Math.Round(Calculation.BMICalc(weight, height), 2);

                return Ok(response);
            }
        }

        [Route("api/area")]
        [HttpPost]
        public IActionResult Area([FromBody] AreaModel data)
        {
            //CONVERT TO DOUBLE
            var length = Convert.ToDouble(data.Length);
            var breath = Convert.ToDouble(data.Breath);

            if (length.GetType() != typeof(double) || breath.GetType() != typeof(double))
            {
                response.Status = "Fail";
                response.Description = "Please input a number";

                return BadRequest(response);
            }
            else
            {
                response.Status = "Success";
                response.Description = "Calculated Area";
                response.Data = Math.Round(Calculation.AreaCalc(length, breath), 2);
                return Ok(response);
            }
        }
    }
}