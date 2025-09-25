using System;
class Week2
{
    static void Main()
    {
        int input=int.Parse(Console.ReadLine());
        int[] nums=new int[4];
        for(int i=0;i<4;i++)
        {
            nums[i]=input%10;
            if(nums[i]==0)
            {
                nums[i]=10;
            }
            input/=10;
        }
        int p=1;
        int time=0;
        for(int i=3;i>=0;i--)
        {
            if(p<nums[i])
            {
               while(p!=nums[i])
               {
                   p++;
                   time++;
               }
            }
            else
            {
                while(p!=nums[i])
                {
                    p--;
                    time++;
                }
            }
            time++;
        }
        Console.WriteLine(time);
    }
}