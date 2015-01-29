using engineLab.console.model.old;

namespace engineLab.console.builders
{
    public class CarEngineBuilder
    {
        private readonly CarEngine _carEngine;

        public CarEngineBuilder()
        {
            _carEngine = new CarEngine();
        }

        public CarEngineBuilder WithCylinders(int cylinders)
        {
            _carEngine.Cylinders = cylinders;
            return this;
        }

        public CarEngine Build()
        {
            return _carEngine;
        }
    }
}