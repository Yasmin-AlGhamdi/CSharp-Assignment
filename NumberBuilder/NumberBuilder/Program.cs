using System;

namespace NumberBuilder
{
    class Builder
    {
        private string value;
        public Builder()
        {
            this.value = "";
        }

        public Builder setContent(string val)
        {
            int reverse = 0, rem;

            int v = Convert.ToInt32(val);
            while (v != 0)
            {
                rem = v % 10;
                reverse = reverse * 10 + rem;
                v /= 10;
            }

            this.value += val + reverse;

            return this;
        }
        public string get()
        {
            return this.value;
        }
        static bool checkorder(string val)
        {
            return false;
        }
        static bool match(string source)
        {

            if(source.Length %2!=0)
            {
                return false;
            }

            int temp = -1;
            bool unclosed = false;
            int count = 0;


            for (int i = 0 ; i< source.Length; i++)
            {
                for (int j = i+1; j < source.Length; j++)
                {
                    temp = j;
                    if((((j-(i+1))%2)!=0)&&(j-(i+1))!=0)
                    {
                        return false;
                    }
                    else
                    {
                        Console.WriteLine("matched " + source[i] + " at " + i+" with "+ source[j] + " at " + j);
                        unclosed = true;
                    }
                    count++;
                    break;
                }
            }
            if (count == source.Length / 2)
                return true;
            else
                return false;
         
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Builder b = new Builder();

            string result = b.setContent("1267").get();
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
