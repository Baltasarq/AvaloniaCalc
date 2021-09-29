// AvaloniaCalc (c) 2021 Baltasar MIT License <jbgarcia@uvigo.es>


namespace AvaloniaCalc.Core {
    /// <summary>
    /// La lógica de negocio.
    /// Si bien es una exageración, esto demuestra cómo debe
    /// ser la separación entre "core" o lógica de negocio,
    /// y "ui" o vista.
    /// </summary>
    public static class Calculadora {
        public static double Suma(double op1, double op2)
        {
            return op1 + op2;
        }
        
        public static double Resta(double op1, double op2)
        {
            return op1 - op2;
        }
        
        public static double Multiplica(double op1, double op2)
        {
            return op1 * op2;
        }
        
        public static double Divide(double op1, double op2)
        {
            return op1 / op2;
        }
    }
}
