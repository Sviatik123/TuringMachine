namespace TuringMachine
{
    class Command
    {
        public string CurrState { get; set; }
        public string CurrSymb { get; set; }
        public string NewState { get; set; }
        public string NewSymb { get; set; }
        public char Direction { get; set; }
        public Command()
        {

        }
        public Command(string currState, string currSymb, string newState, string newSymb, char direction)
        {
            CurrState = currState;
            CurrSymb = currSymb;
            NewState = newState;
            NewSymb = NewSymb;
            Direction = direction;
        }
        public Command(string data)
        {
            string[] command = data.Split();
            CurrState = command[0];
            CurrSymb = command[1];
            NewState = command[5];
            NewSymb = command[3];
            Direction = command[4][0];
        }
    }
}
