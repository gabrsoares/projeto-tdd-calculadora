using System;
using System.Collections.Generic;
using System.Text;

namespace projeto_dio_csharp
{
    public class Calculadora
    {
        private Queue<string> filaHistorico;
        private string data;
        public Calculadora(string data)
        {
            filaHistorico = new Queue<string>();
            this.data = data;
        }
        public int Somar(int n1, int n2)
        {
            int res = n1 + n2;
            addFila($" {n1} + {n2} = {res}");
            return res; 
        }
        public int Subtrair(int n1, int n2)
        {
            int res = n1 - n2;
            addFila($" {n1} - {n2} = {res}");
            return res;
        }
        public int Multiplicar(int n1, int n2)
        {
            int res = n1 * n2;
            addFila($" {n1} * {n2} = {res}");
            return res; 
        }
        public int Dividir(int n1, int n2)
        {
            int res;
            if (n2 == 0)
            {
                throw new DivideByZeroException();
            } else
            {
                res = n1 / n2;
            }
            addFila($" {n1} / {n2} = {res}");
            return res; 
        }
        private void addFila(string stringResultado)
        {
            if (filaHistorico.Count >= 3)
            {
                filaHistorico.Dequeue();
            }
            filaHistorico.Enqueue(stringResultado + $" - data: {data}");
        }
        public Queue<string> Historico()
        {
            return filaHistorico;
        }
    }
}
