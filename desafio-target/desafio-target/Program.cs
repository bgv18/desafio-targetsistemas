Console.WriteLine("***** Desafio Target Sistemas *****");
Console.WriteLine();
Console.WriteLine(Questao1());
Console.WriteLine();
Console.WriteLine(Questao2());
Console.WriteLine();
Console.WriteLine(Questao3());
Console.WriteLine();
Console.WriteLine("Questao 4 -> Arquivo no projeto");
Console.WriteLine();
Console.WriteLine(Questao5());

#region Questao 1
string Questao1()
{
    int i = 12;
    decimal soma = 0;
    var k = 1;

    while (k < i)
    {
        k++;
        soma = soma + k;
    }

    return $"Questao 1 -> O valor da soma é: {soma}";
}
#endregion

#region Questao 2
string Questao2()
{
    string resposta = "";

    resposta += "\na) 1, 3, 5, 7, {9}";
    resposta += "\nb) 2, 4, 8, 16, 32, 64, {128}";
    resposta += "\nc) 0, 1, 4, 9, 16, 25, 36, {49}"; // 7^2 = 49
    resposta += "\nd) 4, 16, 36, 64, {100}"; // 10 ^ 2 
    resposta += "\ne) 1, 1, 2, 3, 5, 8, {13}"; //5 + 8 
    resposta += "\nf) 2, 10, 12, 16, 17, 18, 19, {?}"; 

    return $"Questao 2 -> {resposta} ";
}
#endregion

#region Questao 3
string Questao3()
{
    double[] vetor_faturamento = GeraDadosFaturamento();

    vetor_faturamento = vetor_faturamento
        .Where(x => x > 0)
        .ToArray();

    //utilizando metodos do proprio framework

    var menorValor = vetor_faturamento.Min();

    var maiorValor = vetor_faturamento.Max();

    var media = vetor_faturamento.Average();
    var numeroDiasMaiorMedia = vetor_faturamento.Count(x => x > media);

    return $"Questao 3 -> Menor valor: {menorValor}, Maior valor: {maiorValor}, Média: {media}, Dias com faturamento acima da média: {numeroDiasMaiorMedia}";
}

double[] GeraDadosFaturamento()
{
    Random random = new Random();
    Random multiplicador = new Random();
    double[] faturamento = new double[365];

    for (int i = 0; i < 365; i++)
    {
        int diaDaSemana = i % 7;
        if (diaDaSemana == 5 || diaDaSemana == 6) //sabado ou domingo
            faturamento[i] = 0;
        else
            faturamento[i] = Math.Round((random.NextDouble() * multiplicador.Next(0, 10000)), 3);
    }

    return faturamento;
}
#endregion

#region Questao 5

string Questao5()
{
    double distancia_total = 125.0;
    double velocidade_carro = 90.0;
    double velocidade_caminhao = 80.0;
    int numero_pedagios = 3;
    double tempo_pedagio = 5.0 / 60.0;
    double tempo_adicional_carro = numero_pedagios * tempo_pedagio;
    double velocidade_relativa = velocidade_carro + velocidade_caminhao;
    double tempo_encontro = distancia_total / velocidade_relativa;
    double distancia_carro = velocidade_carro * (tempo_encontro + tempo_adicional_carro);
    double distancia_caminhao = velocidade_caminhao * tempo_encontro;

    var resposta = "Quem esta mais proximo de Ribeirao Preto? R: ";

    if(distancia_carro < distancia_caminhao)
        resposta += "O carro";
    else if (distancia_carro > distancia_caminhao)
        resposta += "O caminhao";
    else
        resposta += "Ambos";

    return $"Questao 5 -> {resposta}";
}
#endregion