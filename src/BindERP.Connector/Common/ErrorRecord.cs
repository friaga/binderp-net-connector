﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindERP.Connector.Common
{
    public record ErrorRecord
    {
        public string? Message
        {
            get;
            set;
        }

        public string? Code
        {
            get;
            set;
        }
    }
}
