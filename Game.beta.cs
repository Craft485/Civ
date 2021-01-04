using System;
using System.IO;

namespace ProgramBeta {
    public class Entry {
        static string save;
        static void Main () {
            System.Console.WriteLine("Continue or start new game?(c or g)");
            char response = Convert.ToChar(System.Console.ReadLine());
            if (char.ToLower(response) == 'c') {
                // Check for saved game
                save = File.ReadAllText("./save.txt");
                System.Console.WriteLine(save);
                // If saved game is present, load it
            } else if (char.ToLower(response) == 'g') {
                // Enter leader selection
                System.Console.WriteLine("Enter a number than corresponds with one of the following leaders:");
                // My variable naming abilities are impeccable
                for (int i = 0; i < civ_innit.list.Length; i++) {
                    civ a = civ_innit.list[i];
                    System.Console.WriteLine("{0}: {1}", i + 1, a.name);
                }
                Int16 civSelect = Convert.ToInt16(System.Console.ReadLine());
                Console.WriteLine(civ_innit.list.GetValue(civSelect));
                // Create new save game
                // File.WriteAllText("./save.txt");
            } else {
                System.Console.WriteLine("Invalid response received");
                Main();
                return;
            }
        }
    }
    public class civ {
        public string name;
        public int power;
        public civ(string Name, int Power) {
            name = Name;
            power = Power;
        }
    }
    public class civ_innit {
        public static civ[] list = {new civ("Washinton", 5), new civ("Harold", 3), new civ("Pedros", 1)};
    }
}