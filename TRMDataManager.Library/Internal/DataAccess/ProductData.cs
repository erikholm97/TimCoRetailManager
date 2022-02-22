﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRMDataManager.Library.DataAccess;

namespace TRMDataManager.Library.Internal.DataAccess
{
    public class ProductData
    {
        public List<ProductModel> GetProducts()
        {
            SQLDataAccess sqlAccess = new SQLDataAccess();

            var output = sqlAccess.LoadData<ProductModel, dynamic>("dbo.spProduct_GetAll", new { }, "TRM.Data");

            return output;
        }
    }
}
