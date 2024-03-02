using System;
using System.Collections.Generic;

namespace cipher {
    class normalToVig {
        static public void getMsgAndKey(out List<int> asciiMsg, out List<int> finalKey){
            Console.Write("Message: ");
            string message = Console.ReadLine();

            Console.Write("Key: ");
            string key = Console.ReadLine();

            asciiMsg = new List<int>();
            finalKey = new List<int>();

            List<int> asciiKey = new List<int>();

            for (int x = 0; x < message.Length; x++){
                asciiMsg.Add(Convert.ToInt32(message[x]));
            }

            for (int x = 0; x < key.Length; x++){
                asciiKey.Add(Convert.ToInt32(key[x]));
            }

            if (asciiKey.Count < asciiMsg.Count){
                while(finalKey.Count < asciiMsg.Count){
                    for (int y = 0; y < asciiKey.Count; y++){
                        finalKey.Add(asciiKey[y]);
                    }
                }
            }
            asciiKey = null;
        }

        static public void encryptMsg(){
            List<int> msg = new List<int>();
            List<int> key = new List<int>();

            getMsgAndKey(out msg, out key);

            Console.Write("Encrypted message: ");

            for (int x = 0; x < msg.Count; x++){
                int newLetter = msg[x] + key[x]%97;
                if (newLetter > (int)'z'){
                    newLetter-=26;
                }
                
                char cLetter = (char)newLetter;
                if (msg[x] != 32){
                    Console.Write(cLetter);
                }
                else {
                    Console.Write(" ");
                }
            }
        }
    }
}