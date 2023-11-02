﻿using ProjetNarratif;
using ProjetNarratif.Rooms;

var game = new Game();
game.Add(new Bedroom());
game.Add(new BedroomChoiceDraps());
game.Add(new BedroomBedChoice());
game.Add(new PorcheRoom());
game.Add(new GameRoom());
game.Add(new UpperHallwayRoom());
game.Add(new UpperBathRoom());
game.Add(new Bathroom());
game.Add(new AtticRoom());
game.Add(new LivingRoom());

while (!game.IsGameOver())
{
    Console.WriteLine("--");
    Console.WriteLine(game.CurrentRoomDescription);
    string? choice = Console.ReadLine()?.ToLower() ?? "";
    Console.Clear();
    game.ReceiveChoice(choice);

}

Console.WriteLine("FIN");
Console.ReadLine();