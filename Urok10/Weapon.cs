using System;
using System.Collections.Generic;
using System.Text;

namespace Urok10
{
    public class Weapon
    {
        public int Damage { get; set; }
        public int Material { get; set; }
        public string Type { get; set; }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Type of weapon: {Type}, material: {Material}, damage: {Damage}");
        }
    }
}
