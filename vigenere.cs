using System;
using System.Collections.Generic;
using cipher;

namespace cipher {
    class vigenere {
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

            int y = 0;
            for (int x = 0; x < msg.Count; x++){
                int newLetter;
                if (msg[x] != (int)' '){
                    newLetter = msg[x] + key[y]%97;
                    y++;
                }
                else {
                    newLetter = (int)' ';
                }

                if (newLetter > (int)'z' && newLetter != (int)' '){
                    newLetter-=26;
                }
                
                char cLetter = (char)newLetter;
                if (msg[x] != (int)' '){
                    Console.Write(cLetter);
                }
                else {
                    Console.Write(" ");
                }
            }
        }

        static public void decryptMsg(){
            List<int> msg = new List<int>();
            List<int> key = new List<int>();

            getMsgAndKey(out msg, out key);

            Console.Write("Decrypted message: ");
            int y = 0;
            for (int x = 0; x < msg.Count; x++){
                int newLetter;
                if (msg[x] != (int)' '){
                    newLetter = msg[x] - key[y]%97;
                    y++;
                }
                else {
                    newLetter = (int)' ';
                }
                
                if (newLetter < (int)'a' && newLetter != (int)' '){
                    newLetter+=26;
                }

                char cLetter = (char)newLetter;
                if (msg[x] != (int)' '){
                    Console.Write(cLetter);
                }
                else {
                    Console.Write(" ");
                }
            }
        }
    }
}