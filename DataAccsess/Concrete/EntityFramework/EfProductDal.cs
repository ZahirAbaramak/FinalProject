﻿using Core.DataAccess.EntityFreamwork;
using DataAccsess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Concrete.EntityFramework
{
    //NuGet
    public class EfProductDal :EfEntityRepositoryBase<Product,NorthwindContext> ,IProductDal
    {
       
       
    }
}
