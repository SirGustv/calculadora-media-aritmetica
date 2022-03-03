## Sobre o Projeto

Este projeto tem, de forma simples, realizar um calculo de média aritmética afim de por meus conhecimentos em prática.

### O Desafio

Leia quatro números (N1, N2, N3, N4), cada um deles com uma casa decimal, correspondente às quatro notas de um aluno. Calcule a média com pesos 2, 3, 4 e 1, respectivamente, para cada uma destas notas e mostre esta média acompanhada pela mensagem "Media: ". Se esta média for maior ou igual a 7.0, imprima a mensagem "Aluno aprovado.". Se a média calculada for inferior a 5.0, imprima a mensagem "Aluno reprovado.". Se a média calculada for um valor entre 5.0 e 6.9, inclusive estas, o programa deve imprimir a mensagem "Aluno em exame.".

No caso do aluno estar em exame, leia um valor correspondente à nota do exame obtida pelo aluno. Imprima então a mensagem "Nota do exame: " acompanhada pela nota digitada. Recalcule a média (some a pontuação do exame com a média anteriormente calculada e divida por 2). e imprima a mensagem "Aluno aprovado." (caso a média final seja 5.0 ou mais ) ou "Aluno reprovado.", (caso a média tenha ficado 4.9 ou menos). Para estes dois casos (aprovado ou reprovado após ter pego exame) apresente na última linha uma mensagem "Media final: " seguido da média final para esse aluno.

### Como Utilizar

Primeiro é preciso ter a SDK do .NET para a biblioteca de códigos reconhecer os códigos no editor de texto (neste eu recomendo o .NET 5.0.405, pois foi a que eu utilizei). Também irá ser necessário um editor de texto (recomendo o Visual Studio Code) ou um ambiente de desenvolvimento integrado (IDE), como o Visual Studio Comunity (versão gratuita do Visual Studio). Algumas extensões no VScode é interessante também se ter, que são as bibliotecas C# e C# Extensions. Após ter atingido todos estes requisitos é só abrir um terminal (no próprio VScode) e, confirmando estar na pasta correta, executar o comando "dotnet run" que a aplicação console começará a pedir as entradas.