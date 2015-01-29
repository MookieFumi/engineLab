using engineLab.console.model.proto.behaviors;

namespace engineLab.console.model.proto
{
    public class BusEngine : ProtoEngine
    {
        public BusEngine()
        {
        }

        public BusEngine(ISpeedUpBehavior speedUpBehavior)
        {
            SpeedUpBehavior = speedUpBehavior;
        }
    }
}