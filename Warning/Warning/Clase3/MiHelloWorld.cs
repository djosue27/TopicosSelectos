using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warning.Clase3
{
    class MiHelloWorld
    {
        // idioma en que se muetra el mensaje
        private EnumIdiomas language = EnumIdiomas.Ingles;

        //Lista de usuarios que son bloqueados para saludarse personalizadamente
        private readonly string[] BLOCKEDUSERS = {"Bryan","Li","Chope","Maduro"};
        public readonly string[] HELLOWORLDMESSAGE = {"Hola mundo", "Hello world" };
        //propiedad
        public int IdiomaEnInt
        {
            get { return (Convert.ToInt32(language)); }
        }

        public MiHelloWorld(EnumIdiomas selectedLanguage) 
        { 
            
        }

        //mensajes de HelloWorld en diferentes idiomas
        public string HelloWorld ()
        {
            string resultado = HELLOWORLDMESSAGE[IdiomaEnInt];
            return resultado;
        }
        //overloading
        public string HelloWorld(string userName)
        {
            string resultado = HelloWorld() + ", " + userName;
            return resultado;
        }
        public string HelloWorldBaneado(string userName)
        {
            string resultado = "Hello world";
            if (!BLOCKEDUSERS.Contains(userName))
            {
                resultado = HelloWorld(userName);
            }
            return resultado;
        }
    }
}
