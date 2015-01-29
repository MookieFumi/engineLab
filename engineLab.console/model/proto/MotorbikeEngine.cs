using engineLab.console.model.proto.behaviors;

namespace engineLab.console.model.proto
{
    public class MotorbikeEngine : ProtoEngine
    {
        public MotorbikeEngine()
        {
        }

        public MotorbikeEngine(ISpeedUpBehavior speedUpBehavior)
        {
            SpeedUpBehavior = speedUpBehavior;
        }

    }
}