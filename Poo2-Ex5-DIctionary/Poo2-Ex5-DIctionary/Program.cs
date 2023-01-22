using Poo2_Ex5_DIctionary;

Dicionario dic = new Dicionario("C:/workspace/Repositórios/BeTheNext---Mod3/Poo2-Ex5-DIctionary/Poo2-Ex5-DIctionary/Arquivos/dicionario.json");

dic.AddTermo("speak", "falar");
dic.AddTermo("run", "correr");
dic.AddTermo("eat", "comer");
dic.AddTermo("pear", "pêra");
dic.AddTermo("peacock", "pavão");
dic.AddTermo("spears", "lanças");

Console.ReadLine();

dic.ProcurarTermo("pea");


