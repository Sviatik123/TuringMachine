using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuringMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Додавання в унарній системі

            Machine m = new Machine();
            m.ParseCommands("../../Commands/commands_add.txt");
            Console.WriteLine(m.Run("111+11"));
            m.PrintProtocol("../../Protocols/protocol_add.txt");
            
            // Віднімання в унарній системі

            Machine m1 = new Machine();
            m1.ParseCommands("../../Commands/commands_sub.txt");
            Console.WriteLine(m1.Run("111-111111"));
            m1.PrintProtocol("../../Protocols/protocol_sub.txt");

            // Множення в унарній системі

            Machine m2 = new Machine();
            m2.ParseCommands("../../Commands/commands_myl.txt");
            Console.WriteLine(m2.Run("1111*11"));
            m2.PrintProtocol("../../Protocols/protocol_myl.txt");

            // Додавання в двійковій системі

            Machine m3 = new Machine();
            m3.ParseCommands("../../Commands/commands_add2.txt");
            Console.WriteLine(m3.Run("11+10"));
            m3.PrintProtocol("../../Protocols/protocol_add2.txt");

            // Переведення з унарної системи в десяткову

            Machine m4 = new Machine();
            m4.ParseCommands("../../Commands/commands_trans.txt");
            Console.WriteLine(m4.Run("1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111"));
            m4.PrintProtocol("../../Protocols/protocol_trans.txt");
        }
    }
}
