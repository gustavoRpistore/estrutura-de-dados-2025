using System;
using System.Collections.Generic;

Console.WriteLine("sistema genenciamento de codigos de entrega");

var mapaRastreamento = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
while (true)
{
    Console.WriteLine("\nEscolha uma opção:");
    Console.WriteLine("1 - adicinar novo registro(rastreador de codigo de barras)");
    Console.WriteLine("2 - consultar status da entrega");
    Console.WriteLine("3 - acompanhar entregas pendentes");
    Console.WriteLine("4 _ sair do sistema");
    var opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1":
            Console.WriteLine("digite o codigo de barras do rastreador:");
            var codigoBarras = Console.ReadLine();
            Console.WriteLine("digite o status da entrega:");
            var statusEntrega = Console.ReadLine();
            mapaRastreamento[codigoBarras] = statusEntrega;
            Console.WriteLine("registro adicionado com sucesso!");
            break;

        case "2":
            Console.WriteLine("digite o codigo de barras do rastreador para cosultar o status da entrega:");
            var codigoConsulta = Console.ReadLine();
            if (mapaRastreamento.TryGetValue(codigoConsulta, out var statusconsulta))
            {
                Console.WriteLine($"status da entrega para o codigo {codigoConsulta}: {statusconsulta}");
            }
            else
            {
                Console.WriteLine("codigo de barras nao encotrado no sistema.");
            }
            break;

        case "3":
            Console.WriteLine("entregas pendentes:");
            foreach (var registro in mapaRastreamento)
            {
                if (registro.Value.Equals("pendente", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine($"codigo de barras: {registro.Key} - status: {registro.Value}");
                }
            }
            break;

        case "4":
            Console.WriteLine("saindo do sistema. ate logo!");
            return;

        default:
            Console.WriteLine("opcao invalida. por favor, tente novamente.");
            break;
    }                    

    }

