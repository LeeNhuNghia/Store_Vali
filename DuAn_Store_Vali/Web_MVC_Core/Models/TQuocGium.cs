﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Web_MVC_Core.Models
{
    public partial class TQuocGium
    {
        public TQuocGium()
        {
            TDanhMucSps = new HashSet<TDanhMucSp>();
        }

        public string MaNuoc { get; set; }
        public string TenNuoc { get; set; }

        public virtual ICollection<TDanhMucSp> TDanhMucSps { get; set; }
    }
}
