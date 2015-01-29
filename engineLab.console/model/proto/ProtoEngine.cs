using System;
using engineLab.console.model.proto.behaviors;

namespace engineLab.console.model.proto
{
    public abstract class ProtoEngine
    {
        protected ProtoEngine()
        {
        }

        protected ProtoEngine(ISpeedUpBehavior speedUpBehavior)
        {
            SpeedUpBehavior = speedUpBehavior;
        }

        protected ISpeedUpBehavior SpeedUpBehavior { get; set; }

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

        public void SpeedUp()
        {
            if (SpeedUpBehavior == null)
            {
                throw new ArgumentNullException();
            }
            Speed += SpeedUpBehavior.AcceleratingSpeed();
        }

        public void ChangeSpeedUpBehavior(ISpeedUpBehavior speedUpBehavior)
        {
            SpeedUpBehavior = speedUpBehavior;
        }
        
        public int Speed { get; private set; }

        public int Cylinders { private get; set; }
    }
}