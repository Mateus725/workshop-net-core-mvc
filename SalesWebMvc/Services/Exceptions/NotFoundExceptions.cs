﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services.Exceptions
{
    public class NotFoundExceptions : ApplicationException
    {

        public NotFoundExceptions(string message) : base(message)
        {
        }

    }
}
