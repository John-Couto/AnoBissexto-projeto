Console.WriteLine(@"A cada 4 anos, a diferença de horas entre o ano solar e o do calendário convencional 
completa cerca de 24 horas (mais exatamente: 23 horas, 15 minutos e 864 milésimos de segundo). Para compensar
essa diferença e evitar um descompasso em relação às estações do ano, insere-se um dia extra no calendário e o 
mês de fevereiro fica com 29 dias. Essa correção é especialmente importante para atividades atreladas às estações,
 como a agricultura e até mesmo as festas religiosas.");

Console.WriteLine("Escreva o ano que deseja para saber se é bissexto:");

var ano = Convert.ToInt16(Console.ReadLine());

if ((ano % 4) == 0 && (ano % 100) != 0)
    Console.WriteLine("O ano é bissexto");
else if ((ano % 100) != 0 && (ano % 400) == 0)
    Console.WriteLine("o ano é bissexto");
else
    Console.WriteLine("O ano não é bissexto");
