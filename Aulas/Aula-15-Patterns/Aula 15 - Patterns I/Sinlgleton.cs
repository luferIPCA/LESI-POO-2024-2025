using System;
using System.Collections;
using System.Text;

namespace Patterns
{
    class Singleton
    {
        private static Singleton instance = null;

        private static ArrayList dados;

        private Singleton()
        {
            //...
            dados = new ArrayList();
	    }

        /// <summary>
        /// Property que devolve a instância
        /// </summary>
        public static Singleton Instance
        {
            get{
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
	
	    public void doSomething()
            {
		    //
	        }
        }
}
