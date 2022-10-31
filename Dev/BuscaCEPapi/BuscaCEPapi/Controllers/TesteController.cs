using BuscaCEPapi.Entities;
using Microsoft.AspNetCore.Mvc;
using Refit;
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace BuscaCEPapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TesteController : Controller
    {
        [HttpGet]
        [Route("{cep}")]
        public async Task<IActionResult> testaCEP([FromRoute]string cep)
        {
            try
            {
                var CepClient = RestService.For<ICepApiService>("http://viacep.com.br");

                var Address = await CepClient.GetAddressAsync(cep);
                
                CepResponse re = Address;

                SmtpClient client = new SmtpClient("smtp-mail.outlook.com",587);


                client.Host = "smtp-mail.outlook.com";
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("lhfl12@hotmail.com", "Nissan+-.123");
                client.DeliveryMethod = SmtpDeliveryMethod.Network;

                MailMessage mail = new MailMessage();
                mail.Sender = new MailAddress("lhfl12@hotmail.com");
                mail.From = new MailAddress("lhfl12@hotmail.com");
                mail.To.Add(new MailAddress("lhfl@updi.net","Luiz Henrique"));
                mail.Subject = "Luiz";
                mail.Body = " endereço: " + re;
                mail.IsBodyHtml = true;
                
                try
                {
                    client.Send(mail);
                }catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
                finally
                {
                    client.Dispose();
                }

                return Ok(Address);


            }
            catch(Exception ex)
            {
                return BadRequest("Erro " + Convert.ToString(ex.Message));
            }
        }
    }
}
