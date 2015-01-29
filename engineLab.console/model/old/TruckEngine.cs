namespace engineLab.console.model.old
{
    public class TruckEngine : Engine
    {
        public TruckEngine()
        {
            base.Cylinders = 1;
        }

        public TruckEngine(int cylinders)
        {
            base.Cylinders = cylinders;
        }

        public override void SpeedUp()
        {
            Speed += 2;
        }
    }
}