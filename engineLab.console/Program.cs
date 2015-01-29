using System;
using engineLab.console.builders;
using engineLab.console.model.old;
using engineLab.console.model.proto;
using engineLab.console.model.proto.behaviors;

namespace engineLab.console
{
    class Program
    {
        private static readonly CarEngineBuilder CarEngineBuilder = new CarEngineBuilder();
        private static readonly BusEngineBuilder BusEngineBuilder = new BusEngineBuilder();

        static void Main(string[] args)
        {
            //Herencia
            Engine truckEngine = new TruckEngine(6);
            Utilities.WriteSpeed(truckEngine);
            Engine carEngine = CarEngineBuilder.WithCylinders(2).Build();
            Utilities.WriteSpeed(carEngine);

            //Composicion
            ProtoEngine motorbikeEngine = new MotorbikeEngine(new HyperSpeedBehavior());
            Utilities.WriteSpeed(motorbikeEngine);
            ProtoEngine busEngine = BusEngineBuilder.WithCylinders(4).WithSpeedUpBehavior(new PublicTransportSpeedBehavior()).Build();
            Utilities.WriteSpeed(busEngine);

            busEngine.ChangeSpeedUpBehavior(new HyperSpeedBehavior());
            Utilities.WriteSpeed(busEngine);

            Console.ReadKey();
        }
    }
}
