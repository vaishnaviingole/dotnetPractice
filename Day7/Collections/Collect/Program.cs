using Collect;
using System;
using System.Collections.Generic;
 List<Part> parts = new List<Part>();

        // Add parts to the list.
        parts.Add(new Part() { PartName = "Amy", PartId = 1 });
        parts.Add(new Part() { PartName = "Sheldon", PartId = 2 });
        parts.Add(new Part() { PartName = "Ted", PartId = 4 });
        parts.Add(new Part() { PartName = "Rosa", PartId = 3 });
        parts.Add(new Part() { PartName = "Gina", PartId = 5 });
        parts.Add(new Part() { PartName = "Jake", PartId = 6 });

        // Write out the parts in the list. This will call the overridden ToString method
        // in the Part class.
        Console.WriteLine();
        foreach (Part aPart in parts)
        {
            Console.WriteLine(aPart);
        }

         Console.WriteLine("\nContains(\"2\"): {0}",
        parts.Contains(new Part { PartId =2 , PartName = "" }));

   Console.WriteLine("Inserting at position  2");
   parts.Insert(2,new Part(){PartName="Penny",PartId=12});
   
   
   parts.Remove(new Part(){PartId=12},PartName="penny}");
   Console.WriteLine("Removing penny");
   foreach(Part apart in parts){
    Console.WriteLine(apart);
   }