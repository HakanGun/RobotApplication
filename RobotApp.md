# RobotApp

## Beskrivning

RobotApp �r en konsolapplikation som l�ter dig styra en robot i ett rum. Du kan ge kommandon f�r att f� roboten att r�ra sig och rapportera sin position.

## Funktioner

- Flytta roboten fram�t (F).
- V�nda roboten �t v�nster (L) eller h�ger (R).
- F�rhindra att roboten g�r utanf�r rummets gr�nser.
- Rapportera robotens aktuella position och riktning.

-
### F�ruts�ttningar
Systemkrav
Operativsystem: Windows 64-bit
.NET Runtime: Kr�ver inte installation av .NET.


### Klona repositoryt

```bash
git clone https://github.com/HakanGun/RobotApplication.git

K�r f�ljande kommandon i en terminal:

```bash
cd RobotApp\bin\Release\net8.0\win-x64\publish
RobotApp.exe

Exempel p� k�rning:
Enter room size (width height):
5 5
Enter starting position (x y direction):
1 2 N
Enter navigation commands:
RFRFFRFRF

Output:
Report: 1 1 N


Finns �ven unit tests
p� https://github.com/HakanGun/RobotApplication/RobotAppTest
