using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stageOOP
{
    public class personne // la classe est en public pour pouvoir y accéder
    {
        // on déclare les propriétés de la classe en privé
        // en privé pour éviter les utilisateurs du programme de changer les propriétés
        private string nom;
        private string prenom;
        private int age;

        // comme toute classe, celle là a une constructeur
        public personne(string unNom, string unPrenom, int unAge) // on ajoute les paramètres de la classe dans le constructeur (string unNom, string unPrenom, int unAge)
        {
            Console.WriteLine("coucou");
        }
    }
}
