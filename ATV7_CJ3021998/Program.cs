
int opcao;

do
{
    do
    {

        Console.WriteLine("=========MENU=========");
        Console.WriteLine("0 - SAIR");
        Console.WriteLine("1 - EX1");
        Console.WriteLine("2 - EX2");
        Console.WriteLine("3 - EX3");
        Console.WriteLine("4 - EX4");

        opcao = int.Parse(Console.ReadLine());

    } while (opcao < 0 || opcao > 7);

    switch (opcao)
    {
        case 0:
            Console.WriteLine("Obrigado por usar o sistema!");
            break;
        case 1:
            int n, a = 1;

            Console.WriteLine("Dê qualquer valor inteiro");
            n = int.Parse(Console.ReadLine());
            while (a <= n)
            {
                Console.WriteLine(a);
                a++;
            }
            break;
        case 2:
            int n1;

            Console.WriteLine("Digite um número inteiro: \n");

            n1 = int.Parse(Console.ReadLine());
            int par = 1;
            while (par < n1)

            {
                par++;
                if (par % 2 == 0)

                {

                    Console.WriteLine(par);

                }

            }
            break;

        case 3:

            int z;

            Console.WriteLine("Digite um número inteiro: \n");

            z = int.Parse(Console.ReadLine());

            if (z < 1000)

            {
                int w = 0;
                while (w <= z)
                {
                    w++;
                    if (w % 2 == 0)
                    {
                        Console.WriteLine(w);
                    }
                }

            }
            break;
        case 4:
            int n5 = 0;

            while (n5 < 200)

            {
                n5++;
                Console.WriteLine("Digite um valor");

                int n3 = int.Parse(Console.ReadLine());

                if (n3 > 0)

                {

                    Console.WriteLine(n3);

                    n5 += n3;

                }

                Console.WriteLine("A soma dos números é {0}", n5);

            }
            break;
        case 5:
            Console.WriteLine("Digite um número inteiro:");
            int nmr = int.Parse(Console.ReadLine());

            Console.WriteLine("Os divisores de {0} são: ", nmr);
            int ii = 1;
            while (ii <= nmr)
            {
                ii++;
                if (nmr % ii == 0)
                {
                    Console.WriteLine(ii);
                }
            }
            break;
        case 6:
            int mir;
            int mnr;

            Console.WriteLine("Digite o 1º número: ");
            int numero1 = int.Parse(Console.ReadLine());
            mir = numero1;
            mnr = numero1;
            int i = 1;
            while (i < 10)
            {
                i++;
                Console.WriteLine($"Digite o {i}° número: ");
                numero1 = int.Parse(Console.ReadLine());

                if (numero1 > mir)
                {
                    mir = numero1;
                }

                if (numero1 < mnr)
                {
                    mnr = numero1;
                }
            }

            Console.WriteLine($"O maior número digitado foi: {mir}");


            Console.WriteLine($"O menor número digitado foi: {mnr}\n");
            break;
            case 7:
            int smPares = 0;
            int smImpares = 0;

            Console.WriteLine("Digite uma sequência de números (digite 0 para parar):");

            while (true)
            {
                Console.Write("Digite um número: ");
                int n10 = Convert.ToInt32(Console.ReadLine());

                if (n10 == 0)
                {
                    break;
                }

                if (n10 % 2 == 0)
                {
                    smPares += n10;
                }

                else
                {
                    smImpares += n10;
                }
            }

            Console.WriteLine($"A soma dos números pares é: {smPares}");
            break;
    }
} while (opcao != 0) ;