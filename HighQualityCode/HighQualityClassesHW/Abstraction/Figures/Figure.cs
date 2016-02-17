namespace Abstraction.Figures
{
    using Contracts;

    /// <summary>
    /// The Figure Class
    /// </summary>
    /// <seealso cref="Abstraction.Contracts.IFigure" />
    public abstract class Figure : IFigure
    {
        public abstract double CalcPerimeter();

        public abstract double CalcSurface();

        public override string ToString()
        {
            string str = string.Format("I am a {0}. " + "My perimeter is {1:f2}. My surface is {2:f2}.",
                this.GetType().Name, this.CalcPerimeter(), this.CalcSurface());

            return str;
        }
    }
}
