using System;

namespace ConsoleApp1
{
    public interface IContract
    {
        public string Name { get; set; }
        
        public int Age { get; set; }

        public bool hasWorkedBefore { get; set; }
        
        public bool Hired { get; set; }
        
        public DateTime dateHired { get; set; }
    }
}