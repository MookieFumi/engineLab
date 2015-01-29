using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using engineLab.console.model.old;
using engineLab.console.model.proto;

namespace engineLab.console
{
    public static class Utilities
    {
        public static void WriteSpeed(ProtoEngine protoEngine)
        {
            protoEngine.Start();
            protoEngine.SpeedUp();
            protoEngine.Stop();
            Console.WriteLine("{0}. Speed {1}", protoEngine.GetType().Name, protoEngine.Speed);
        }

        public static void WriteSpeed(Engine engine)
        {
            engine.Start();
            engine.SpeedUp();
            engine.Stop();
            Console.WriteLine("{0}. Speed {1}", engine.GetType().Name, engine.Speed);
        }
    }
}
