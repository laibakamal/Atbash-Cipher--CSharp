
//This algorithm converts A to Z, B to Y, C to X and so on

// ABCDEFGHIJKLMNOPQRSTUVWXYZ converts this string to
// ZYXWVUTSRQPONMLKJIHGFEDCBA

using System;
namespace EncrytionDecryption
{
    class EncrytionDecryptionn
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string record = "";
            int x, y;
            char c;
            for (int i = 0; i < str.Length; i++)
            {
                //c=str[i];
                //if c='B' means c=66
                //c-65=1 -->    x=1
                //26-x=25 -->   y=25
                //answer= y+64 = 89 = 'Y'
                if (str[i]>='A'&&str[i]<='Z')
                {
                    x=str[i]-65;
                    y=26-x;
                    c=(char)(y+64);
                    record+=c.ToString();
                }


                //c=str[i];
                //if c='b' means c=98
                //c-97=1 -->    x=1
                //26-x=25 -->   y=25
                //answer= y+96 = 121 = 'y'
                else if (str[i]>='a'&&str[i]<='z')
                {
                    x=str[i]-97;
                    y=26-x;
                    c=(char)(y+96);
                    record+=c.ToString();
                }
                //c=str[i];
                //if c='4'
                //x='9'- c
                //answer = '5'
                else if (str[i]>='0'&&str[i]<='9')
                {
                    x='9'-str[i];
                    record+=x.ToString();
                }

                else if (str[i]==' ')
                {
                    record+=' ';
                }
            }

            Console.WriteLine(record);

        }//main
    }//class
}//namespace