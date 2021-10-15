// AvaloniaCalc (c) 2021 Baltasar MIT License <jbgarcia@uvigo.es>


namespace AvaloniaCalc.Core.Operaciones {
    public class Suma: Operador {
        public Suma(double op1, double op2)
            :base(op1, op2)
        {
        }

        public override string Nombre {
            get {
                return "+";
            }
        }

        public override double Calcula()
        {
            return this.Op1 + this.Op2;
        }
    }
}
