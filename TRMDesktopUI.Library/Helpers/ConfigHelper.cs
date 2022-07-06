﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDesktopUI.Library.Helpers
{
    public class ConfigHelper : IConfigHelper
    {
        //TODO: Move this from config to API.
        public decimal GetTaxRate()
        {
            decimal output = 0;

            string rateText = ConfigurationManager.AppSettings["taxRate"];

            bool isValidTaxRate = Decimal.TryParse(rateText, out output);

            if (isValidTaxRate is false)
            {
                throw new ConfigurationErrorsException("The tax rate is not set up properly.");
            }

            return output;
        }
    }
}
