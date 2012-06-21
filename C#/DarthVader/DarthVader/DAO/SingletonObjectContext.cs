//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

namespace DarthVader.DAO
{
    class SingletonObjectContext
    {
        private static readonly SingletonObjectContext instance = new SingletonObjectContext();
        private readonly DarthVaderEntities context;

        private SingletonObjectContext()
        {
            context = new DarthVaderEntities();
        }

        public static SingletonObjectContext Instance
        {
            get
            {
                return instance;
            }
        }

        public DarthVaderEntities Context
        {
            get
            {
                return context;
            }
        }
    }
}
