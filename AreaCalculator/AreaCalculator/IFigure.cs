using JetBrains.Annotations;

namespace AreaCalculator
{
    public interface IFigure
    {
        [PublicAPI]
        double GetArea();
    }
}
