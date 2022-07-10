using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Labb1
{
   public  class Singleton
    {

        private static Singleton instance;
        private Singleton()
        {

        }
        public static Singleton GetInstance()
        {
            if(instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

       public void Typer(string text)
        {
            foreach (char c in text.ToCharArray())
            {
                Console.Write(c);
                Thread.Sleep(50);
            }
        }
    }
}
