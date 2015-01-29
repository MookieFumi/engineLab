namespace engineLab.console.model.old
{
    public class CarEngine : Engine
    {
        public CarEngine()
        {
            base.Cylinders = 1;
        }

        public CarEngine(int cylinders)
        {
            base.Cylinders = cylinders;
        }

        public override void SpeedUp()
        {
            Speed += 6;
        }
    }
}