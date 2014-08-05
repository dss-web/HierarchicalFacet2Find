﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HierarchicalFacet2Find
{
    public class HierarchicalFacet : List<HierarchyPath>
    {

    }

    public class HierarchyPath : List<HierarchyPath>
    {
        public string Path { get; set; }
        public string Name { get; set; }
        public new int Count { get; set; }
    }
}
