using System;

namespace Program {
    public class civ {
        string name;
        int power;
        public civ(string Name, int Power) {
            name = Name;
            power = Power;
        }
    }
    public class civ_innit {
        static void Main() {
            civ[] list = {new civ("Washinton", 5), new civ("Harold", 3), new civ("Pedros", 1)};
        }
    }
}