using System;
using System.Collections.Generic;
using System.Linq;

namespace ThePianist
{
    class ThePianist
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, PianoPiece> pieces = new Dictionary<string, PianoPiece>();
            for (int i = 0; i < n; i++)
            {
                string[] piece = Console.ReadLine().Split('|');
                PianoPiece currentPianoPiece = new PianoPiece(piece[1], piece[2]);
                pieces.Add(piece[0], currentPianoPiece);
            }

            string[] command = Console.ReadLine().Split('|');
            while (command[0] != "Stop")
            {
                switch (command[0])
                {
                    case "Add":
                        string piece = command[1];
                        string composer = command[2];
                        string key = command[3];
                        if (!pieces.ContainsKey(piece))
                        {
                            pieces.Add(piece, new PianoPiece(composer, key));
                            Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                        }
                        else
                        {
                            Console.WriteLine($"{piece} is already in the collection!");
                        }
                        break;
                    case "Remove":
                        string pieceRem = command[1];
                        if (pieces.ContainsKey(pieceRem))
                        {
                            pieces.Remove(pieceRem);
                            Console.WriteLine($"Successfully removed {pieceRem}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {pieceRem} does not exist in the collection.");
                        }

                        break;
                    case "ChangeKey":
                        string pieceCont = command[1];
                        string newKey = command[2];
                        if (pieces.ContainsKey(pieceCont))
                        {
                            pieces[pieceCont].Key = newKey;
                            Console.WriteLine($"Changed the key of {pieceCont} to {newKey}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {pieceCont} does not exist in the collection.");
                        }

                        break;
                }
                command = Console.ReadLine().Split('|');
            }

            foreach (var pianoPiece in pieces.OrderBy(p => p.Key).ThenBy(p => p.Value.Composer))
            {
                Console.WriteLine($"{pianoPiece.Key} -> Composer: {pianoPiece.Value.Composer}, Key: {pianoPiece.Value.Key}");
            }
        }
    }

    class PianoPiece
    {
        public PianoPiece(string composer, string key)
        {
            Composer = composer;
            Key = key;
        }
        public string Composer { get; set; }
        public string Key { get; set; } 
    }
}
