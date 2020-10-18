using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overiding_example
{
    class human
    {
        public string name;
        public virtual void walk()
        {
            Console.WriteLine(name + "는(은) 걷기를 사용했다!\n"+ name +": 뚜벅뚜벅\n");
        }
    }
    class Straight : human
    {
        public Straight()
        {
            this.name = "직모";
        }
    }
    class halfCurl : human
    { 
        public halfCurl()
        {
            this.name = "반곱슬";
        }
    }
    class Curl : human
    {
        public Curl()
        {
            this.name = "곱슬";
        }
    }
    class Bald : human
    {
        public Bald()
        {
            this.name = "대머리";
        }
        public override void walk()
        {
            Console.WriteLine(name + "는(은) 걷기를 사용했다!\n" + name + "는 두발이 없어 걸을 수 없다!\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            human[] h = new human[4] { new Straight(), new halfCurl(), new Curl(), new Bald() };
            for(int i = 0; i<4; i++)
            {
                h[i].walk();
            }
            Console.WriteLine("효과는 굉장했다!");
        }
    }
}
