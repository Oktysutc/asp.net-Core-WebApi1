using Microsoft.AspNetCore.Mvc;
using helloWebApi.Models;
using ServiceStack;
using ServiceStack.Text;

namespace helloWebApi.controllers
{
    [ApiController]//api yapısına destekler hata sayfalarının kullanmakarını sağlar
    [Route("home")]// LOCAL DAN SONRA GİRİLEN İFADEYİ DÖNDÜRÜRÜR
    public class HomeController: ControllerBase
    {
        [HttpGet]// 
        public IActionResult GetMessage()// döndüreceğimiz cevapları kendimiz seçmek istersek action kullanırız
        {
            var result= new ResponseModel()
            {
                HttpStatus=200,
                Message="hello"
                
            };
            return Ok(result);
        }

    }
}

