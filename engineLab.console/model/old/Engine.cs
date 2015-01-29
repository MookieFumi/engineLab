namespace engineLab.console.model.old
{
    public abstract class Engine
    {
        private bool _isOn;

        public void Start()
        {
            _isOn = true;
        }

        public void Stop()
        {
            _isOn = false;
        }

        public bool IsOn()
        {
            return _isOn;
        }

        public abstract void SpeedUp();

        public int Speed { get; protected set; }

        public int Cylinders { private get; set; }
    }
}