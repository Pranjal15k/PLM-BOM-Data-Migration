using System;
using System.Collections.Generic;
using System.Linq;
using BOMMigration.Console.Models;

namespace BOMMigration.Console.Services
{
    public class BomService
    {
        public void PrintBomTree(List<BomRelation> relations, string parent, string indent = "")
        {
            var children = relations.Where(r => r.ParentPart == parent);

            foreach (var child in children)
            {
                System.Console.WriteLine($"{indent}├─ {child.ChildPart} (Qty: {child.Quantity})");
                PrintBomTree(relations, child.ChildPart, indent + "│  ");
            }
        }
    }
}
