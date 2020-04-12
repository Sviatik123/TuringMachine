namespace TuringMachine
{
    class Command
    {
        public string OldState { get; set; }
        public char OldSymb { get; set; }
        public string NewState { get; set; }
        public char NewSymb { get; set; }
        public char Direction { get; set; }
        public Command()
        {

        }
        public Command(string oldState, char oldSymb, string newState, char newSymb, char direction)
        {
            OldState = oldState;
            OldSymb = oldSymb;
            NewState = newState;
            NewSymb = newSymb;
            Direction = direction;
        }
        public Command(string data)
        {
            string[] command = data.Split();
            OldState = command[1];
            OldSymb = command[0][0];
            NewState = command[4];
            NewSymb = command[3][0];
            Direction = command[5][0];
        }
    }
}
