namespace Library
{
    public class Class1
    {
        public int upperBound;
        public String wordForThree;
        public String wordForFive;
        public int firstNumber;
        public int secondNumber;

        public Class1(int num, String word1, String word2, int firstNum, int secondNum)
        {
            if (num <= 0)
            {
                num = 100;
            }
            if (firstNum <= 0)
            {
                firstNum = 3;
            }
            if (secondNum <= 0)
            {
                secondNum = 5;
            }
            this.upperBound = num;
            this.firstNumber = firstNum;
            this.secondNumber = secondNum;
            if (word1 == null || word1.Equals(""))
            {
                word1 = "fizz";
            }
            this.wordForThree = word1;
            if (word2 == null || word2.Equals(""))
            {
                word2 = "buzz";
            }
            this.wordForFive = word2;
        }

        public IEnumerable<String> printNums()
        {
            int i = 0, j = 0;
            for (i = 0; i <= upperBound - 1; i++)
            {
                j = i + 1;

                if (j % firstNumber == 0)
                {
                    if (j % secondNumber == 0)
                    {
                        yield return wordForThree + wordForFive;
                    }
                    else
                    {
                        yield return wordForThree;
                    }

                }
                else if (j % secondNumber == 0)
                {
                    yield return wordForFive;
                }
                else
                {
                    yield return j.ToString();
                }
            }
        }
    }
}