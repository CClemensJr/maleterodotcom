﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Controllers
{
    [Authorize(Policy = "WashingtonStateOnly")]
    public class PolicyController : Controller
    {

    }
}
