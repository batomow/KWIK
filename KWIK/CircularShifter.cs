using System.Collections.Generic;
using System.Linq;

namespace KWIK
{
    class CircularShifter : IStringListReceiver, IStringListSender
    {
        private List<string> data;

        private void CircularShift()
        {
            // Lista usada para guardar todas las líneas nuevas que se agregaron a causa de los circular shifts.
            List<string> addedData = new List<string>();

            // Hace circular shift a todas las líneas con todas las palabras.
            foreach(string line in data)
            {
                List<string> lineWords = line.Split(' ').ToList();

                int wordCount = lineWords.Count;

                // Hace un circular shift con cada palabra de la línea.
                for(int i = 0; i < wordCount - 1; i++)
                {
                    string firstWord = lineWords[0];

                    lineWords.RemoveAt(0);

                    lineWords.Add(firstWord);

                    addedData.Add(ConcatenateStringList(lineWords));
                }
            }

            // Se agregan todas las líneas nuevas que se agregaron a causa de los circular shifts.
            foreach(string s in addedData)
            {
                data.Add(s);
            }
        }

        private string ConcatenateStringList(List<string> list)
        {
            if(list.Count == 0)
            {
                return "";
            }

            string concatenatedString = "";

            concatenatedString += list[0];

            for(int i = 1; i < list.Count; i++)
            {
                concatenatedString += " " + list[i];
            }

            return concatenatedString;
        }

        public List<string> GetData()
        {
            return data;
        }

        public void SetData(List<string> data)
        {
            this.data = data;

            CircularShift();
        }
    }
}
