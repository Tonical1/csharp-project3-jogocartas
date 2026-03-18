Pedro Gaspar - RM: 554887

Enrico Ricarte - RM: 558571

Victor Freire - RM: 556191

# 🃏 Jogo de Buraco em C#

Este projeto é uma implementação básica do clássico jogo de cartas **Buraco**, desenvolvido em C#. Ele fornece a estrutura principal para gerenciar jogadores, baralho e turnos, servindo como base para criar um jogo completo.

---

## ⚙️ Funcionalidades

* **Gerenciamento de jogadores**
  Permite adicionar de 2 a 4 jogadores, garantindo que o número mínimo e máximo seja respeitado.

* **Cartas e baralho**

  * Naipes: **Diamonds, Hearts, Spades, Clubs**
  * Valores: **A (1) até K (13) + Joker (0)**
  * Estrutura preparada para criar, embaralhar e distribuir cartas.

* **Controle de turno**
  Mantém o jogador atual e permite avançar o turno de forma circular entre todos os participantes.

* **Limite de jogadores**
  O jogo suporta de 2 a 4 jogadores por partida.

---

## 📦 Estrutura do projeto

A classe principal do jogo é responsável por:

* Gerenciar a lista de jogadores.
* Controlar o turno atual de cada jogador.
* Representar o baralho de cartas e os valores correspondentes.
* Preparar a lógica para embaralhar e distribuir cartas.
