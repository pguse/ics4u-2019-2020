# Game Of Life

The game of life was developed by British mathematician John Horton Conway in 1970. It involves a grid (the world) of cells. The grid of cells evolves according to the following rules:

## Death
If a cell is alive (state = 1) it will die (state becomes 0) under the following circumstances.
* Overpopulation: If the cell has four or more alive neighbours, it dies.
* Loneliness: If the cell has one or fewer alive neighbours, it dies.
## Birth
* If a cell is dead (state = 0) it will come to life (state becomes 1) if it has exactly three alive neighbours (no more, no less).
## Stasis. 
In all other cases, the cell state does not change. To be thorough, let's describe those scenarios.
* Staying Alive: If a cell is alive and has exactly two or three live neighbours, it stays alive.
* Staying Dead: If a cell is dead and has anything other than three live neighbours, it stays dead.
