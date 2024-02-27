namespace PatternState.Pattern
{
    public class TrafficLight
    {
        public string Color { get; set; }

        public IState State { get; private set; }

        public void SetInMaintenance()
        {
            ChangeState(new OrangeBlinkingState(this));
        }

        public void OpenTraffic()
        {
            ChangeState(new GreenState(this));
        }

        public void CloseTraffic()
        {
            ChangeState(new RedState(this));
        }

        private void ChangeState(IState state)
        {
            State = state;
            state.Handle();
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return $"Traffic light - State : {State}";
        }
    }
}
