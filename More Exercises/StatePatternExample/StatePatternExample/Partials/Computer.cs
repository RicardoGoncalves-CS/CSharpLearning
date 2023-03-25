namespace StatePatternExample.Partials
{
    public partial class Computer
    {
        private State _state = new Off();

        private void SetState(State state)
        {
            _state = state;
        }

        public void PressPowerButton()
        {
            _state.PressPowerButton(this);
        }
    }

    public partial class Computer
    {
        private interface State
        {
            void PressPowerButton(Computer computer);
        }

        private class Off : State
        {
            public void PressPowerButton(Computer computer)
            {
                computer.SetState(new On());
            }
        }

        private class On : State
        {
            private bool _charging;

            public void PressPowerButton(Computer computer)
            {
                if (_charging)
                {
                    computer.SetState(new StandBy());
                }
                else
                {
                    computer.SetState(new Off());
                }
            }

            private class StandBy : State
            {
                public void PressPowerButton(Computer computer)
                {
                    computer.SetState(new On());
                }
            }
        }
    }
}