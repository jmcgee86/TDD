using System;

namespace ThirtyDaysOfTDD.Service
{
    public class StringUtils
    {
        public int FindNumberOfOccurences(string sentenceToScan, string charToScanFor)
        {
            if(charToScanFor.Length!=1)
                throw new ArgumentException();
                  
                var stringToCheckAsCharacterArray = sentenceToScan.ToCharArray();
                var characterToCheckFor = Char.Parse(charToScanFor);

                var numberOfOccurences = 0;

                for(var index = 0; index<stringToCheckAsCharacterArray.Length; index++)
                {
                    if (stringToCheckAsCharacterArray[index] == characterToCheckFor)
                        numberOfOccurences++;
                }
                return numberOfOccurences; 
        }
    }
}
