using DesignPatterns.Models;

namespace DesignPatterns.Factories
{
    // Aplicacion de Factory Method
    public abstract class CarFactory
    {
        public abstract Vehicle Create();
    }
}
