//=================================
// Copyright (c) Tarteeb LLC
// Developed by CashOverflow Team
//=================================

using Microsoft.AspNetCore.Mvc;

namespace CashOverflow.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Get() => "Cash flows";
    }
}
