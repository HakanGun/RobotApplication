# RobotApp

## Beskrivning

RobotApp är en konsolapplikation som låter dig styra en robot i ett rum. Du kan ge kommandon för att få roboten att röra sig och rapportera sin position.

## Funktioner

- Flytta roboten framåt (F).
- Vända roboten åt vänster (L) eller höger (R).
- Förhindra att roboten går utanför rummets gränser.
- Rapportera robotens aktuella position och riktning.

-
### Förutsättningar
Systemkrav
Operativsystem: Windows 64-bit
.NET Runtime: Kräver inte installation av .NET.


### Klona repositoryt

```bash
git clone https://github.com/HakanGun/RobotApplication.git

Kör följande kommandon i en terminal:

```bash
cd RobotApp\bin\Release\net8.0\win-x64\publish
RobotApp.exe

Exempel på körning:
Enter room size (width height):
5 5
Enter starting position (x y direction):
1 2 N
Enter navigation commands:
RFRFFRFRF

Output:
Report: 1 1 N


Finns även unit tests
på https://github.com/HakanGun/RobotApplication/RobotAppTest
