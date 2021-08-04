﻿using System;

namespace figuras2
{
    class Figura
    {
        int lado, area, b,altura,radio;

        static void Main(string[] args)
        {
            Figura cuadrado2 = new Figura();
            cuadrado2.cuadrado(cuadrado2);
            Figura triangulo = new Figura();
            triangulo.triangulo(triangulo);
            Figura circulo = new Figura();
            circulo.circulo(circulo);
            Figura rectangulo = new Figura();
            rectangulo.rectangulo(rectangulo);
        }
        public void cuadrado(Figura cuadrado) {
            
            Console.WriteLine("Digite el lado del cuadrado");
            cuadrado.lado = Int32.Parse(Console.ReadLine());
            cuadrado.area = cuadrado.lado * cuadrado.lado;
            Console.WriteLine("El area del cuadrado es: " + cuadrado.area);
            Console.ReadLine();
        }
        public void triangulo(Figura triangulo)
        {

            Console.WriteLine("Digite la base del triangulo");
            triangulo.b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite la altura del triangulo");
            triangulo.altura = Int32.Parse(Console.ReadLine());
            triangulo.area = (triangulo.b * triangulo.altura)/2;
            Console.WriteLine("El area del triangulo es: " + triangulo.area);
            Console.ReadLine();
        }
        public void circulo(Figura circulo) {
                
            Console.WriteLine("Digite el radio del circulo");
            circulo.radio = Int32.Parse(Console.ReadLine());
            circulo.area = (int)(Math.PI * (radio * radio));
            
            Console.WriteLine("El area del circulo es: " + circulo.area);
            Console.ReadLine();
        }
        public void rectangulo(Figura rectangulo)
        {

            Console.WriteLine("Digite la base del rectángulo");
            rectangulo.b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite la altura del rectángulo");
            rectangulo.altura = Int32.Parse(Console.ReadLine());
            rectangulo.area = rectangulo.b * rectangulo.altura;
            Console.WriteLine("El area del rectangulo es: " + rectangulo.area);
            Console.ReadLine();
        }
    }
}
