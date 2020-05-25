using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ButterFlyApi.Controllers
{
    [RoutePrefix("api/v2/ ButterflyApiCalculate")]
    public class ButterflyApiCalculateController : ApiController
    { 
        [HttpGet]        
        public HttpResponseMessage Get(double number1, double number2,string operation) {

            try {
                return Request.CreateResponse(HttpStatusCode.OK, calculate(number1, number2, operation));
            }
            catch (Exception ex) {
                return Request.CreateResponse(HttpStatusCode.OK, ex.Message);
            }            
        }
        public double calculate(double number1, double number2, string operation) {
            
            try {
                switch (operation) {
                    case "add":
                        return number1 + number2;

                    case "sub":
                        return number1 - number2;

                    case "multiply":
                        return number1 * number2;

                    case "div":
                        return number1 / number2;
                    default:
                        throw new Exception("Invalid operation");
                }
            }
            catch (Exception ex) {
                throw ex;
            }
            
        }
    }
}
