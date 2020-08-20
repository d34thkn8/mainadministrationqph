﻿using System.Collections.Generic;

namespace QPH_MAIN.Core.Entities
{
    public partial class Tree : BaseEntity
    {
        public Tree()
        {
            Children = new List<Tree>();
        }
        public string title { get; set; }
        public int son { get; set; }
        public int parent { get; set; }
        public List<Tree> Children { get; set; }
    }
}
