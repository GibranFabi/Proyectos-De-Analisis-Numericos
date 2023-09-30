namespace NCalc
{
    internal class Expression
    {
        private string funcion;

        public Expression(string funcion)
        {
            this.funcion = funcion;
        }

        public object Parameters { get; internal set; }
    }
}