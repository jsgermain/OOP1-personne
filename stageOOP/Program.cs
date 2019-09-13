using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stageOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            personne unePersonne; // on a variable de la classe personne qui s'appelle unePersonne 
            unePersonne = new personne("Saint Germain", "Johnes", 31); // pour le constructeur puisse bien faire son travail, 
                                                                       //il faut que les paramètres soient respectés ("Saint Germain", "Johnes", 31)
/*
            // Pour changer l'age de la personne avec l'accesseur setAge créée dans la classe
            unePersonne.setAge(26);
*/
            // on appelle la méthode getAge ciblant l'âge de la personne 
            Console.WriteLine(unePersonne.getAge());

            


        }
    }
}
