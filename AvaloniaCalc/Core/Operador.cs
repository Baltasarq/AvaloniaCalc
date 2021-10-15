// AvaloniaCalc (c) 2021 Baltasar MIT License <jbgarcia@uvigo.es>


namespace AvaloniaCalc.Core {
    
    /// <summary>Clase base para todas las operaciones.</summary>
    public abstract class Operador {
        protected Operador(double op1, double op2)
        {
            this.Op1 = op1;
            this.Op2 = op2;
        }
        
        /// <summary>Devuelve o modifica el operando 1.</summary>
        public double Op1 { get; set; }
        
        /// <summary>Devuelve o modifica el operando 2.</summary>
        public double Op2 { get; set; }
        
        /// <summary>Devuelve el operador como cadena de caracteres.</summary>
        public abstract string Nombre { get; }
        
        /// <summary>
        /// Realiza la operación indicada. 
        /// </summary>
        /// <returns>El resultado, como double.</returns>
        public abstract double Calcula();
        
        public override string ToString()
        {
            return $"{this.Op1} {this.Nombre} {this.Op2}";
        }
    }
}
