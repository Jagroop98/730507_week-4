using System;

namespace _730507_week_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Node
    {
      class Village

        {
        // Node is an ADT
        // what KInd of DATA do we need in a NODE?
        public Village nextVillage;
        public String VillageName;
            public Village previousVillage;
            public bool isAstrildeHere = false;
        }
        class countryside
        {
            Village maple = new Village();
            Village Toronto = new Village();
            Village Ajax = new Village();
            Village First;
            Village Last;
                public void Launch()
            {
                maple.VillageName = "maple";
                maple.nextVillage = Toronto;
                maple.previousVillage = null;
                Toronto.VillageName = "Toronto";
                Toronto.nextVillage = Ajax;
                Toronto.previousVillage = maple;
                Ajax.VillageName = "Ajax";
                Ajax.nextVillage = null;
                Ajax.nextVillage = Toronto;
            }
        }
 
    }
}
