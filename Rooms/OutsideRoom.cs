﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class OutsideRoom : Room
    {
        internal override string CreateDescription() =>
@"Tu es sur le patio de ta maison.
Lorsque tu regardes vers l'horizon, tu ne vois presque rien.
Un épais brouillard bloque ton champs de vision
À tes pieds tu trouves un tapis de bienvenu [tapis]
À ta gauche se trouve une boite au lettre [boite]
Malgré le brouillard, tu arrives à percevoir un arbre au loin. [arbre]
Tu décides de rentrer à l'intérieur [rentre] 
";
        static bool backdoorkey = false;
        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "tapis":
                    Console.WriteLine("Tu regardes en dessous du tapis, mais tu ne trouves rien");
                    
                    break;
                case "boite":
                    Console.WriteLine("Tu regardes dans la boite au lettre, elle est vide...");

                    break;
                case "arbre":
                    string choix = "", ch = "";
                    Console.WriteLine("Tu te diriges vers l'arbre que tu vois au loin." +
                        "\nSur le chemin, tu rescents l'herbe froide humide sous tes pieds.");
                    Console.WriteLine("Tu es devant l'arbre, tu ne te sens pas normal...");
                   qst: Console.Write("Faire demi-tour?" +
                        "\nOui" +
                        "\nNon" +
                        "\nTon choix : ");
                    try
                    {
                        choix = Convert.ToString(Console.ReadLine());
                    } catch { Console.WriteLine("Commande invalide :\n "); goto qst; }
                    if (choix == "Oui" || choix == "oui")
                    {
                        Console.WriteLine("Tu te retournes vers ta maison et commence à marcher");
                        Console.WriteLine("Tu entends un cris au loin!");
                    qst1: Console.Write("Tu vas investiguer?" +
                    "\nOui" +
                    "\nNon" +
                    "\nTon choix : ");
                        try
                        {
                            ch = Convert.ToString(Console.ReadLine());
                        }
                        catch { Console.WriteLine("Commande invalide :\n "); goto qst1; }
                        if (ch == "Oui" || ch == "oui")
                        {
                            Console.WriteLine("Tu te retournes et cours vers les cris");
                        }
                        if (ch == "Non" || ch == "non")
                        {
                            Console.WriteLine("Tu fais de ton mieu pour ignorer les cris, mais tu en ai incapable...");
                            Console.WriteLine("Tu te retournes et cours vers les cris");
                            Console.WriteLine("Tu t'enfonce dans le brouillard, les cris se rapprochent, tu y es, mais..." +
                           "\nPersonne n'est là?" +
                           "\nTu es seul..." +
                           "\nUne lumière t'aveugle" +
                           "\nTu cris");
                            Console.WriteLine("Fin 4 : Mort sur la route");
                            Bedroom.fourthdeath = true;
                            Game.Transition<Bedroom>();
                            //Bruit de camion
                            //System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = "https://www.youtube.com/watch?v=oavMtUWDBTM", UseShellExecute = true });
                        }

                    }
                    if (choix == "Non" || choix == "non")
                    {
                        Console.WriteLine("Tu entends un cris au loin!");
                        Console.WriteLine("Tu ne peux pas t'empêcher d'aller voir." +
                            "\nTu cours en direction des cris");
                        Console.WriteLine("Tu t'enfonce dans le brouillard, les cris se rapprochent, tu y es, mais..." +
                            "\nPersonne n'est là?" +
                            "\nTu es seul..." +
                            "\nUne lumière t'aveugle" +
                            "\nTu cris");
                        Console.WriteLine("Fin 4 : Mort sur la route");
                        Bedroom.fourthdeath = true;
                        Game.Transition<Bedroom>();
                        //Bruit de camion
                        //System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = "https://www.youtube.com/watch?v=oavMtUWDBTM", UseShellExecute = true });
                    }
                    break;
                case "rentre":
                    Console.WriteLine("Le bruis de la télévision s'intensifie, tu n'entends que ça...");

                    break;
                case "clef":
                    Console.WriteLine("Tu plonge ta mains dans la boite au lettre et tâtes les rebords du bout des doigts." +
                        "\nTu trouves la clef que ton père avait caché");
                             backdoorkey = true;
                    break;

                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
