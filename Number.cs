using System;

public class Number
{
      public int DigitalRoot(long n)
        {
                // Your awesome code here!
                
                if(n % 10 == n) return (int)n;
                long temp = n;
                int count = 0;
                while (temp > 0)
                {
                temp /= 10;
                count++;
                }
                temp = 1;
                while(count > 0)
                {
                temp *= 10;
                count--;
                }
                while(temp > 0)
                {
                count += (int)(n/temp);
                temp /= 10;
                }
                n = count;
                return DigitalRoot(n);
        }
}