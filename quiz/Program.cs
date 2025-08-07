using System;

class QuizApp
{
    static void Main()
    {
        int pontuacao = 0;

        Console.WriteLine("=== QUIZ DE CONHECIMENTOS GERAIS ===\n");

        Console.WriteLine("1. Qual o maior planeta do sistema solar?");
        Console.WriteLine("A) Terra");
        Console.WriteLine("B) Júpiter");
        Console.WriteLine("C) Marte");
        Console.Write("Sua resposta: ");
        string resposta1 = Console.ReadLine().ToUpper();
        if (resposta1 == "B") { Console.WriteLine("✅ Correto!\n"); pontuacao++; }
        else { Console.WriteLine("❌ Errado! A resposta correta é: B) Júpiter\n"); }

        Console.WriteLine("2. Qual é a capital da França?");
        Console.WriteLine("A) Berlim");
        Console.WriteLine("B) Roma");
        Console.WriteLine("C) Paris");
        Console.Write("Sua resposta: ");
        string resposta2 = Console.ReadLine().ToUpper();
        if (resposta2 == "C") { Console.WriteLine("✅ Correto!\n"); pontuacao++; }
        else { Console.WriteLine("❌ Errado! A resposta correta é: C) Paris\n"); }

        Console.WriteLine("3. Quantos lados tem um hexágono?");
        Console.WriteLine("A) 5");
        Console.WriteLine("B) 6");
        Console.WriteLine("C) 8");
        Console.Write("Sua resposta: ");
        string resposta3 = Console.ReadLine().ToUpper();
        if (resposta3 == "B") { Console.WriteLine("✅ Correto!\n"); pontuacao++; }
        else { Console.WriteLine("❌ Errado! A resposta correta é: B) 6\n"); }

        Console.WriteLine("4. Em que continente fica o Egito?");
        Console.WriteLine("A) África");
        Console.WriteLine("B) Ásia");
        Console.WriteLine("C) Europa");
        Console.Write("Sua resposta: ");
        string resposta4 = Console.ReadLine().ToUpper();
        if (resposta4 == "A") { Console.WriteLine("✅ Correto!\n"); pontuacao++; }
        else { Console.WriteLine("❌ Errado! A resposta correta é: A) África\n"); }

        Console.WriteLine("5. Quem escreveu 'Dom Quixote'?");
        Console.WriteLine("A) William Shakespeare");
        Console.WriteLine("B) Miguel de Cervantes");
        Console.WriteLine("C) José Saramago");
        Console.Write("Sua resposta: ");
        string resposta5 = Console.ReadLine().ToUpper();
        if (resposta5 == "B") { Console.WriteLine("✅ Correto!\n"); pontuacao++; }
        else { Console.WriteLine("❌ Errado! A resposta correta é: B) Miguel de Cervantes\n"); }

        Console.WriteLine("6. Qual é o símbolo químico da água?");
        Console.WriteLine("A) CO2");
        Console.WriteLine("B) H2O");
        Console.WriteLine("C) O2");
        Console.Write("Sua resposta: ");
        string resposta6 = Console.ReadLine().ToUpper();
        if (resposta6 == "B") { Console.WriteLine("✅ Correto!\n"); pontuacao++; }
        else { Console.WriteLine("❌ Errado! A resposta correta é: B) H2O\n"); }

        Console.WriteLine("7. Quantas cores tem o arco-íris?");
        Console.WriteLine("A) 6");
        Console.WriteLine("B) 7");
        Console.WriteLine("C) 8");
        Console.Write("Sua resposta: ");
        string resposta7 = Console.ReadLine().ToUpper();
        if (resposta7 == "B") { Console.WriteLine("✅ Correto!\n"); pontuacao++; }
        else { Console.WriteLine("❌ Errado! A resposta correta é: B) 7\n"); }

        Console.WriteLine("8. Quem pintou a Mona Lisa?");
        Console.WriteLine("A) Pablo Picasso");
        Console.WriteLine("B) Leonardo da Vinci");
        Console.WriteLine("C) Van Gogh");
        Console.Write("Sua resposta: ");
        string resposta8 = Console.ReadLine().ToUpper();
        if (resposta8 == "B") { Console.WriteLine("✅ Correto!\n"); pontuacao++; }
        else { Console.WriteLine("❌ Errado! A resposta correta é: B) Leonardo da Vinci\n"); }

        Console.WriteLine("9. Em que país se localiza a Muralha da China?");
        Console.WriteLine("A) Japão");
        Console.WriteLine("B) China");
        Console.WriteLine("C) Índia");
        Console.Write("Sua resposta: ");
        string resposta9 = Console.ReadLine().ToUpper();
        if (resposta9 == "B") { Console.WriteLine("✅ Correto!\n"); pontuacao++; }
        else { Console.WriteLine("❌ Errado! A resposta correta é: B) China\n"); }

        Console.WriteLine("10. Qual animal é conhecido como o rei da selva?");
        Console.WriteLine("A) Leão");
        Console.WriteLine("B) Tigre");
        Console.WriteLine("C) Elefante");
        Console.Write("Sua resposta: ");
        string resposta10 = Console.ReadLine().ToUpper();
        if (resposta10 == "A") { Console.WriteLine("✅ Correto!\n"); pontuacao++; }
        else { Console.WriteLine("❌ Errado! A resposta correta é: A) Leão\n"); }

        Console.WriteLine($"Você acertou {pontuacao} de 10 perguntas!");
        Console.WriteLine("Obrigado por jogar!");
    }
}