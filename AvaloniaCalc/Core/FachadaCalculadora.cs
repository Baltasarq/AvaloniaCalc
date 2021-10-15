// AvaloniaCalc (c) 2021 Baltasar MIT License <jbgarcia@uvigo.es>


namespace AvaloniaCalc.Core {
    using Operaciones;
    
    
    /// <summary>
    /// La fachada para la lógica de negocio.
    /// Si bien es una exageración, esto demuestra cómo debe
    /// ser la separación entre "core" o lógica de negocio,
    /// y "ui" o vista para reducir el número de enlaces entre
    /// clases de la vista y la lógica de negocio.
    /// </summary>
    public static class FachadaCalculadora {
        public static double Suma(double op1, double op2)
        {
            return new Suma( op1, op2 ).Calcula();
        }
        
        public static double Resta(double op1, double op2)
        {
            return new Resta( op1, op2 ).Calcula();
        }
        
        public static double Multiplica(double op1, double op2)
        {
            return new Multiplica( op1, op2 ).Calcula();
        }
        
        public static double Divide(double op1, double op2)
        {
            return new Divide( op1, op2 ).Calcula();
        }
    }
}
