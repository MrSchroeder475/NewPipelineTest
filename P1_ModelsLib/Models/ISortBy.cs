﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_ModelLib.Models
{
    interface ISortBy
    {
        internal IEnumerable<object> SortBy(EnumSortOptions sortOptions);
    }
}
