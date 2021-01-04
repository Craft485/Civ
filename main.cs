using System;
using System.IO;

namespace Program {
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
                string e;
                for (int i = 0; i < civ_innit.list.length; i++) {
                    civ a = civ_innit.list[i];
                    // e += $"{ i + 1 }: { a.name }\n";
                    e += Convert.ToString(i + 1) + ":" + a.name + "\n";
                }
                char civSelect = Convert.ToChar(System.Console.ReadLine());
                // Create new save game
                // File.WriteAllText("./save.txt");
            } else {
                System.Console.WriteLine("Invalid response received");
                Main();
                return;
            }
        }
    }
}