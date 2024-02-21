using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RedirectPaymentForm.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RedirectPaymentForm.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            PaymentModel pago = new PaymentModel();
            pago.vads_action_mode = "INTERACTIVE";
            pago.vads_ctx_mode = "TEST";               /* TEST / PRODUCTION*/
            pago.vads_currency = "604";                /*Soles = 604 / Dólar = 840*/
            pago.vads_page_action = "PAYMENT";
            pago.vads_payment_config = "SINGLE";
            pago.vads_site_id = "~~CHANGE_ME_ID~~";    
            pago.vads_version = "V2";
            pago.KEY = "~~CHANGE_ME_KEY~~";    
            return View(pago);
        }  
    }   
}

