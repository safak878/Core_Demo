﻿using DataAccesLayer.Abstract;
using DataAccesLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Entitiy_Framework
{
    public class EFBlogRepository:GenericRepository<Blog>,IBlogDal
    {
    }
}
