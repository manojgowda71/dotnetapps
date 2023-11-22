namespace Firstapi.Models
{
    public class Car
    {
        private IEngine _engine;
        public Car(IEngine e)
        {
            _engine = e;

        }
    }
    public interface IEngine { }
    public interface IAccessories { }
    public class CarAccessories : IAccessories { }

    public class SuzukiEngine : IEngine { }
    public class ToyotaEngine : IEngine { }

}