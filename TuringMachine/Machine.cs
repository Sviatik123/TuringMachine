using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace TuringMachine
{
    class Machine
    {
        public List<Command> Commands { get; set; }
        public int CurrPosition { get; set; }
        public string CurrState { get; set; }
        public string Word { get; set; }
        public List<string> Protocol { get; set; }

        public Machine()
        {
            Commands = new List<Command>();
            CurrPosition = 0;
            CurrState = "q0";
            Protocol = new List<string>();
        }
        public void ParseCommands(string filename)
        {
            using(StreamReader sr = new StreamReader(filename))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    Commands.Add(new Command(line));
                }
            }
        }

        public string Run(string inputWord)
        {
            Word = "_" + inputWord + "_";
            while (true)
            {
                
                Protocol.Add(Word);
                //System.Console.WriteLine(Word);
                if (CurrState == "qf")
                {
                    break;
                }
                foreach (var el in Commands)
                {
                    if(el.OldState == CurrState && el.OldSymb == Word[CurrPosition])
                    {
                        Word = Word.Substring(0, CurrPosition) + el.NewSymb + Word.Substring(CurrPosition + 1, Word.Length - CurrPosition - 1);
                        CurrState = el.NewState;
                        if(el.Direction == 'R')
                        {
                            CurrPosition++;
                        }
                        else if(el.Direction == 'L')
                        {
                            CurrPosition--;
                        }
                        break;
                    }
                }
                AddLambda();
            }
            return Word.Replace("_", "");
        }
        public void PrintProtocol(string filename)
        {
            using(StreamWriter sw = new StreamWriter(filename))
            {
                foreach (var el in Protocol)
                {
                    sw.WriteLine(el);
                }
            }
        }
        private void AddLambda()
        {
            if(Word.Substring(0, 3) != "___")
            {
                Word = "___" + Word;
                CurrPosition += 3;
            }
            if (Word.Substring(Word.Length - 4, 3) != "___")
            {
                Word += "___";
            }
        }
    }
}
