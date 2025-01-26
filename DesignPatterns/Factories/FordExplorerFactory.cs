using DesignPatterns.ModelBuilders;
using DesignPatterns.Models;

namespace DesignPatterns.Factories
{
    // Aplicacion de Factory Method
    public class FordExplorerFactory : CarFactory
    {
        public override Vehicle Create()
        {
            return new CarModelBuilder()               
                .setModel("Explorer")
                .setColor("black")
                .Build();
        }
    }
}
