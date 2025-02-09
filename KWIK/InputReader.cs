﻿using System;
using System.Collections.Generic;

namespace KWIK
{
    class InputReader : IStringListSender
    {
        private List<string> data = new List<string>();

        public void ReadInput()
        {
            while(true)
            {
                string input = Console.ReadLine();

                // Si se encuentra con una oración vacía, se rompe el ciclo y ya no se aceptan mas oraciones.
                if(input == "\"\"" || input == "." || input == " " || input == "")
                {
                    return;
                }
                else
                {
                    // Remueve las comillas al inicio y fin.
                    if(input[0] == '"' && input[input.Length - 1] == '"')
                    {
                        input = input.Remove(input.Length - 1, 1);
                        input = input.Remove(0, 1);
                    }
                    
                    // Remueve el punto al final.
                    if(input[input.Length - 1] == '.')
                    {
                        input = input.Remove(input.Length - 1, 1);
                    }

                    // Convierte las mayúsculas en minúsculas.
                    for(int i = 0; i < input.Length; i++)
                    {
                        if(input[i] >= 65 && input[i] <= 90)
                        {
                            char oldChar = input[i];

                            input.Remove(i, 1);

                            input = input.Substring(0, i) + (char)(oldChar + 32) + input.Substring(i + 1);
                        }
                    }

                    data.Add(input);
                }
            }
        }

        public List<string> GetData()
        {
            ReadInput();

            return data;
        }
    }
}
