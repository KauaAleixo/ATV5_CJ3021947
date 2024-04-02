
        Console.WriteLine("escolha uma opção");

        int opç = int.Parse(Console.ReadLine());

switch (opç)
{
    case 1:
        //att1
        int numero;
        Console.WriteLine("Até q número deseja contar?");
        numero = int.Parse(Console.ReadLine());
        for (int cont = 1; cont <= numero; cont++)
            Console.WriteLine("{0}", cont);
        break;
    case 2:
        //att2
        int nmr;
        Console.WriteLine("Até q número deseja contar?(os números pares)");
        nmr = int.Parse(Console.ReadLine());
        for (int cont = 0; cont <= nmr; cont = cont + 2)
            Console.WriteLine("{0}", cont);
        break;

    case 3:
        //att3
        int nmr1;
        Console.WriteLine("Insira um número menor que 1000");
        nmr1 = int.Parse(Console.ReadLine());
        for (int cont = 1000; cont >= nmr1; cont = cont - 2)
            Console.WriteLine("{0}", cont);

        break;

    case 4:
        //att4
        int nmr2;
        Console.WriteLine("Insira um número menor que 1000");
        nmr2 = int.Parse(Console.ReadLine());
        for (int cont = 1000; cont >= nmr2; cont = cont - 2)
            Console.WriteLine("{0}", cont);
        break;

    case 5:
        //att5
        int nmr3;
        Console.WriteLine("Digite o número que deseja descobrir os divisores");
        nmr3 = int.Parse(Console.ReadLine());
        for (int cont = 1; cont < nmr3; cont++)
        {
            if (nmr3 % cont == 0)
                Console.WriteLine("{0}", cont);
        }
        break;

    case 6:

        //att6
        Console.WriteLine("Digite 10 números, um por linha: ");
        int[] n6 = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite um número {i + 1}: ");
            string input = Console.ReadLine();
            n6[i] = int.Parse(input);
        }

        int maior_num = n6.Max();
        int menor_num = n6.Min();

        Console.WriteLine($"O maior número é: {maior_num}");
        Console.WriteLine($"O menor número é: {menor_num}");

        break;

    case 7:

        //att7
        for (int nmr4 = 0, pares = 0, impares = 0; ;)
        {
            Console.WriteLine("Digite um valor, somaremos os ímpares e os pares, se digitar '0' o programa é encerrado");
            nmr4 = int.Parse(Console.ReadLine());

            if (nmr4 == 0)
            {
                Console.WriteLine("A soma dos números pares é:{0}}\nA soma dos números ímpares é: {1}", pares, impares);
                break;
            }
            if (nmr4 % 2 == 0)
                pares = pares + nmr4;
            else
                impares = impares + nmr4;
        }
        break;
}




        
