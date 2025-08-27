using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeringosoJuli
{
    internal class Jeringozo
    {

        public static string Encriptar(string texto)
        {
            string vocales = "aeiouAEIOU";
            string textoEncriptado = "";
            foreach (char c in texto)
            {
                if (vocales.Contains(c))
                {
                    textoEncriptado += c + "p" + char.ToLower(c);
                }
                else
                {
                    textoEncriptado += c;
                }
            }
            return textoEncriptado;
        }
        public static string Desencriptar(string texto)
        {
                        string vocales = "aeiouAEIOU";
            string textoDesencriptado = "";
            int i = 0;
            while (i < texto.Length)
            {
                char c = texto[i];
                if (vocales.Contains(c) && i + 2 < texto.Length && texto[i + 1] == 'p' && char.ToLower(texto[i + 2]) == char.ToLower(c))
                {
                    textoDesencriptado += c;
                    i += 3; 
                }
                else
                {
                    textoDesencriptado += c;
                    i++;
                }
            }
            return textoDesencriptado;
        }
    }
}

        
            
