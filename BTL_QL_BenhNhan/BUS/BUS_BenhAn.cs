﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_BenhAn
    {
        public DTO_BenhAn GetBenhAnByMaBN(string maBN)
        {
            return DAL_BenhAn.GetBenhAnByMaBN(maBN);
        }
    }
}
