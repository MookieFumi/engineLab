using engineLab.console.model.old;
using engineLab.console.model.proto;
using engineLab.console.model.proto.behaviors;

namespace engineLab.console.builders
{
    //Patrón Builder
    public class BusEngineBuilder
    {
        private readonly BusEngine _busEngine;

        public BusEngineBuilder()
        {
            _busEngine = new BusEngine();
        }

        public BusEngineBuilder WithCylinders(int cylinders)
        {
            _busEngine.Cylinders = cylinders;
            return this;
        }

        public BusEngineBuilder WithSpeedUpBehavior(ISpeedUpBehavior speedUpBehavior)
        {
            _busEngine.ChangeSpeedUpBehavior(speedUpBehavior);
            return this;
        }

        public BusEngine Build()
        {
            return _busEngine;
        }
    }
}