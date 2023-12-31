# DIO - Trilha .NET - Programação orientada a objetos
www.dio.me

# Mais Implementações:
Além do que era necessário para comprir o projeto com exito, eu me dei a liberdade de adicionar mais coisas a fim de me desafiar e deixar o código mais cheio!

- Fora as classes solicitadas, me dei ao trabalho de fazer a implementação de mais 2 class, sendo a Class Motorola e a Class Samsung, ambas também sendo herdadas da Class Smartphone e recebendo os mesmos parâmetros.

- Foi criado uma Função/Metodo Abstrato DesinstalarAplicativo(); dentro da Class Smartphone e sendo herdado para implementação obrigatória nas suas classes filhas. Foi criado esse método pensando na lógica de que se é possível instalar um aplicativo, também deveria ser possível desinstalar !

- Criei uma propriedade pública Chip, sendo instânciada na Class Abstract Smartphone e passando para as suas classes filhas. A propriedade recebeu os parametros {Get; Set;}, pois assim como o número, um chip também pode ser trocado por outro pelo seu usuário.

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de orientação a objetos, da trilha .NET da DIO.

## Contexto
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Você deve criar as suas classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Solução
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.