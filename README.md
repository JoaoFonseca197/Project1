# Projeto 1 de Linguagens de Programação I 2019/2020

##  Wolf and Sheep
---
### Autoria - Grupo 15

- António Branco (a21906811)

        Fez o tabuleiro inicial e algumas melhorias visuais. Fez os métodos da 
        escolha das ovelhas para jogar e dos seus respetivos movimentos.
        Adaptou os métodos das ovelhas para não sairem do tabuleiro, fez o game loop com a verificação se as Ovelhas ganham.

- João Fonseca (a21905441)

        Criou o repositório online, melhorou o método do tabuleiro. Fez as funções 
        que geram a posição aleatória do lobo inicial e que o movem. Fez os métodos
        que impedem o lobo de sair do tabuleiro e a verificação se o lobo venceu. Ajudou na criação do game loop, do movimento e deteção das ovelhas.

- Rodrigo Carvalho (a21902084)

        Verificação das posições das ovelhas e dos lobos para não colidirem.

---

### [Repositório git](https://github.com/JoaoFonseca197/Project1) 

---

## Arquitetura da Solução
O método main contêm o game loop do jogo, onde a passagem de turnos acontece com a verificação de vitória.

Criámos dois métodos principais, o "Player_Wolf" e "Player_Sheep" que são responsáveis pelos turnos dos respetivos Lobo e Ovelha.
Por sua vez, estes métodos vão ser complementados por outros métodos, estes respónsaveis pelo movimento e deteção de colisão entre as bordas e ovelhas.

Para além disto temos um terceiro método, "Board" que é chamado sempre que um dos jogadores termina o seu turno. O método "Board" desenha o tabuleiro com a posição dos jogadores. 

---
## Fluxograma
![alt text](https://github.com/JoaoFonseca197/Project1/blob/master/Flowchart.png?raw=true)

---

### Referências

https://stackoverflow.com/questions/14297853/how-to-get-random-values-from-array-in-c-sharp

https://www.youtube.com/watch?v=lYdcY5zulXA

https://unicode-table.com/pt/sets/arrow-symbols/

https://github.com/VideojogosLusofona/fp_2019_exemplos/blob/master/adventure10.py

---