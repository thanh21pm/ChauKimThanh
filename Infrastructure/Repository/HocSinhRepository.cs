﻿using Infrastructure.EF;
using Infrastructure.Entities;
using Infrastructure.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public interface IHocSinhRepository : IRepository<HocSinh>
    {
    }

    public class HocSinhRepository : Repository<HocSinh>, IHocSinhRepository
    {
        public HocSinhRepository(EXDbContext context) : base(context)
        {
        }
    }
}
