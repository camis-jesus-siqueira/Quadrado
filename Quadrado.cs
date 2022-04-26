public class Quadrado{
    
    public double Lado { get; set; }
    public double Area { get => Lado * Lado; }
    public double Perimetro { get => 4 * Lado; }
    public Quadrado(double lado) => Lado = lado;
    
}

public class Retangulo{

    public double Base {get; set;}

    public double Altura {get; set;}
    public double Area {get => Base * Altura;}

    public double Perimetro { get => 2 * (Base+Altura); }
    public Retangulo(double _base, double altura){
        Base = _base;
        Altura = altura;
    }
}

