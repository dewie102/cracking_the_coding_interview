namespace pset3
{
    public class BruteReverse
    {
        static public void URLify(char[] Str, int StrSize)
        {
            int wordEndIndex = StrSize - 1;
            int currCharIndex = Str.Length - 1;
            for(int i = StrSize -1; i > 0; i--)
            {
                if(Str[i] == ' ')
                {
                    int wordSize = wordEndIndex - i;
                    for(int k = 0; k < wordSize; k++)
                    {
                        Str[currCharIndex - k] = Str[wordEndIndex - k];
                    }
                    Str[currCharIndex-(wordSize)] = '0';
                    Str[currCharIndex-(wordSize + 1)] = '2';
                    Str[currCharIndex-(wordSize + 2)] = '%';
                    currCharIndex -= wordSize + 3;
                    wordEndIndex -= i - 1;
                }
            }
        }
    }
}