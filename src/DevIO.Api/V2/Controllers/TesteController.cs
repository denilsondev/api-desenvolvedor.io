﻿using DevIO.Api.Controllers;
using DevIO.Business.Intefaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.Api.V2.Controllers
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/teste")]
    public class TesteController: MainController
    {
        public TesteController(INotificador notificador, IUSer appuser): base(notificador, appuser)
        {

        }

        [HttpGet]
        public string Valor()
        {
            return "Sou a V2";
        }
    }
}
