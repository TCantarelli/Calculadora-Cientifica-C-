
using System;

class Calculadora
{
    
    static int Main(string[] args)
    {
        Console.WriteLine("Digite Qual deseja");
        Console.WriteLine("1-Soma");
        Console.WriteLine("2-Subtracao");
        Console.WriteLine("3-Multiplicação");
        Console.WriteLine("4-Divisão");
        Console.WriteLine("5-Baskhara");
        Console.WriteLine("6-Pitagoras");
        Console.WriteLine("7-Raiz Quadrada");
        Console.WriteLine("8-Potenciação");
        Console.WriteLine("9-Determinante de Matriz");
        Console.WriteLine("10-Matriz inversa");                                                     
        int option = int.Parse(Console.ReadLine()!);
        if(option == 1)
        {
            int nr1, nr2;
            Console.WriteLine("Digite o valor do primeiro numero:\n");
            nr1 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite o valor do outro numero:\n");
            nr2 = int.Parse(Console.ReadLine()!);
            int resul;
            resul = nr1+nr2;
            Console.WriteLine($"{resul} e a soma\n");
        }
        else if(option == 2)
        {     
            int nr1, nr2;
            Console.WriteLine("Digite o primeiro valor:\n");
            nr1 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite o proximo numero:\n");
            nr2 = int.Parse(Console.ReadLine()!);
            int resul = nr1 - nr2;
            Console.WriteLine($"A subtração de {nr1} e {nr2} eh {resul}");
        }
        else if(option == 3)
        {       
            double nr1, nr2;
            Console.WriteLine("Digite o primeiro valor");
            nr1 = double.Parse(Console.ReadLine()!);
            nr2 = double.Parse(Console.ReadLine()!);
            double resul = nr1 * nr2;
            Console.WriteLine($"A multiplicação de {nr1} com {nr2} eh {resul}");
        }
        else if(option == 4)
        {
            double nr1, nr2;
            Console.WriteLine("Digite os os dois valores:\n");
            nr1 = double.Parse(Console.ReadLine()!);
            nr2 = double.Parse(Console.ReadLine()!);
            if(nr2 != 0 )
            {
                double resul;
                resul = nr1 / nr2;
                Console.WriteLine($"O resultado eh {resul}\n");
            }
            else
            {
                Console.WriteLine("Erro!, não e possivel dividir por zero!");
                return 1;
            }
        }       
        else if(option == 5)
        {
            int a, b, c;
            Console.WriteLine("Digite o valor do coeficiente A");
            a = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Agora Digite o Coeficiente B");
            b = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Por fim, digite o coeficiente C");
            c = int.Parse(Console.ReadLine()!);
            int delta;
            delta = (b*b) -(4*a*c);
            if(delta > 0 )
            {
                double x1, x2;
                x1 = (((double)-b)+Math.Sqrt(delta))/((double)2*a);
                x2 = (((double)-b)-Math.Sqrt(delta))/((double)2*a);
                Console.WriteLine($"Delta maior que zero, x1 = {x1} e x2 = {x2}");
            }
            else if(delta == 0)
            {
                double x1;
                x1 = (((double)-b)+Math.Sqrt(delta))/((double)2*a);
                Console.WriteLine($"Delta = 0, duas raizes iguais à {x1}");
            }
            else
                Console.WriteLine("Delta negativo, sem raiz nos reais");
        }
        else if(option == 6)
        {
            Console.WriteLine("Digite qual Opção deseja:");
            Console.WriteLine("1-Descobrir Hipotenusa");
            Console.WriteLine("2-Descobrir o outro cateto");
            int option2;
            option2 = int.Parse(Console.ReadLine()!);
            if(option2 == 1)
            {
                double a,b,c;
                Console.WriteLine("Digite o valor do primeiro cateto:");
                a = double.Parse(Console.ReadLine()!);
                Console.WriteLine("Digite o valor do outro cateto:");
                b = double.Parse(Console.ReadLine()!);
                c = Math.Sqrt((a*a) + (b*b));
                Console.WriteLine($"O valor da hipotenusa eh {c}");
            }
            else if(option2 == 2)
            {
                double a, b,c;
                Console.WriteLine("Digite o valor da hipotenusa:");
                c = double.Parse(Console.ReadLine()!);
                Console.WriteLine("Digite o valor do cateto:");
                a = double.Parse(Console.ReadLine()!);
                b = Math.Sqrt((c*c) - (a*a));
                Console.WriteLine($"O valor do outro caterto eh {b}");
            }
        }
        else if(option == 7)
        {       
            double nr;
            Console.WriteLine("Digite o valor que queira saber a raiz:");
            nr = double.Parse(Console.ReadLine()!);
            if(nr >=0)
                Console.WriteLine($"A raiz de {nr} eh {Math.Sqrt(nr)}");
            else
                Console.WriteLine($"A raiz de {nr} eh {Math.Sqrt(-nr)}i");
        }
        else if(option == 8)
        {
            Console.WriteLine("Digite o valor da base");
            int a;
            a = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite o valor do expoente");
            int b = int.Parse(Console.ReadLine()!);
            if(b > 0)
            {
                int resul = 1;
                for(int i=0;i<b;i++)
                    resul *=a; 
                Console.WriteLine($"{a} elevado a {b} eh {resul}");
            }
            else if(b < 0)
            {       
                double resul =1;
                for(int i=0;i<-b;i++)
                    resul *=a;
                resul = 1/ resul;
                Console.WriteLine($"{a} elevado a {b} eh {resul}");
            }
            else
                Console.WriteLine($"{a} elevado a 0 eh 1");
        }
        else if(option == 9)
        {
            Console.WriteLine("1- matriz 2x2");
            Console.WriteLine("2-matriz 3x3");
            int option2 = int.Parse(Console.ReadLine()!);
            if(option2 == 1)
            {
                double [,] m = new double[2,2];
                for(int i=0;i<2;i++)
                {
                    for(int j=0;j<2;j++)
                    {
                        m[i,j] = double.Parse(Console.ReadLine()!);
                    }
                }
                double determinante;
                determinante = (m[0,0] *m[1,1]) - (m[0,1]* m[1,0]);
                Console.WriteLine($"O determinante da matriz M eh {determinante}");
            }
            else
            {
                double [,] m = new double [3,3];
                for(int i=0;i<3;i++)
                {
                    for(int j=0;j<3;j++)
                    {
                        m[i,j] = double.Parse(Console.ReadLine()!);
                    }
                }
                double det;
                det = +(((m[1,1])*m[2,2]) - (m[2,1]*m[1,2]))*m[0,0] - (((m[1,0])*m[2,2]) - (m[2,0]*m[1,2]))*m[0,1] + (((m[1,0])*m[2,1]) - (m[2,0]*m[1,1]))*m[0,2];
                Console.WriteLine($"O determinante da matriz M eh {det}");
            }
        }
        else if(option == 10)
        {
            Console.WriteLine("1-matriz 2x2\n2-Matriz 3x3");
            int option2 = int.Parse(Console.ReadLine()!);
            if(option2 == 1)
            {
                double [,]m = new double [2,2];
                Console.WriteLine("Digite a primeira linha");
                for(int i=0;i<2;i++)
                {
                    for(int j=0;j<2;j++)
                    {
                        m[i,j] = double.Parse(Console.ReadLine()!);
                    }
                    Console.WriteLine("Digite a 2 linha");
                }
                double det = (m[0,0] *m[1,1]) - (m[0,1]* m[1,0]);
                if(det == 0)
                {
                    Console.WriteLine("Determinante = 0, Portanto não existe uma inversa");
                    return 0;
                }
                double aux;
                aux = m[0,0];
                m[0,0] = m[1,1];
                m[1,1] = aux;
                m[0,1] *= -1;
                m[1,0] *= -1;
                for(int i=0;i<2;i++)
                {
                    for(int j=0;j<2;j++)
                    {
                        m[i,j] /= det;
                        if(m[i,j] > -0.00001 && m[i,j] < 0.00001)
                        {
                            m[i,j] = 0;
                        }
                    }
                }
                for(int i=0;i<2;i++)
                {
                    for(int j=0;j<2;j++)
                    {
                        Console.Write($"{m[i,j],8}");
                    }
                    Console.Write("\n");
                }
            }
            else if(option2 == 2)
            {
                double [,]m = new double [3,3];
                Console.WriteLine("Digite a primeira Linha");
                for(int i=0;i<3;i++)
                {
                    for(int j=0;j<3;j++)
                    {   
                        m[i,j] = double.Parse(Console.ReadLine()!);
                    }
                    Console.WriteLine("Digite a proxima Linha");
                }
                double [,]inv = new double [3,3];
                double detm;
                detm = ((+((m[1,1]*m[2,2]-(m[1,2]*m[2,1])))*(m[0,0])) -((m[1,0]*m[2,2])-(m[1,2]*m[2,0]))*(m[0,1]) +(((m[1,0]*m[2,1])-(m[1,1]*m[2,0]))*m[0,2]));
                if(detm == 0)
                {
                    Console.WriteLine("Determinante = 0, portanto a matriz M não tem inversa");
                    return 0;
                }
                inv[0,0] = (double)((m[1,1]*m[2,2])-(m[1,2]*m[2,1]))/detm;
                inv[0,1] = (double)((m[2,1]*m[0,2])-(m[2,2]*m[0,1]))/detm;
                inv[0,2] = (double)((m[0,1]*m[1,2])-(m[0,2]*m[1,1]))/detm;
                //2 linha da inversa
                inv[1,0] = (double)((m[1,2]*m[2,0])-(m[1,0]*m[2,2]))/detm;
                inv[1,1] = (double)((m[2,2]*m[0,0])-(m[2,0]*m[0,2]))/detm;
                inv[1,2] = (double)((m[0,2]*m[1,0])-(m[0,0]*m[1,2]))/detm;
                //3 linha da inversa
                inv[2,0] = (double)((m[1,0]*m[2,1])-(m[2,0]*m[1,1]))/detm;
                inv[2,1] = (double)((m[2,0]*m[0,1])-(m[2,1]*m[0,0]))/detm;
                inv[2,2] = (double)((m[0,0]*m[1,1])-(m[1,0]*m[0,1]))/detm;
                Console.WriteLine($"O determinante da matriz M eh {detm}");

                for(int i=0;i<3;i++)
                {
                    for(int j=0;j<3;j++)
                    {
                        if(inv[i,j] > -0.00001 && inv[i,j] < 0.00001)
                            inv[i,j] =0;
                        Console.Write($"{inv[i,j],8}");

                    }
                    Console.Write("\n");
                }
            }
        }
        return 0;
    }
}