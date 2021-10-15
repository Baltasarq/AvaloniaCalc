// AvaloniaCalc (c) 2021 Baltasar MIT License <jbgarcia@uvigo.es>


namespace AvaloniaCalc.Core.Operaciones {
    public class Multiplica: Operacion {
        public Multiplica(double op1, double op2)
            :base(op1, op2)
        {
        }

        public override string Operador {
            get {
                return "*";
            }
        }

        public override double Calcula()
        {
            return this.Op1 * this.Op2;
        }
    }
}