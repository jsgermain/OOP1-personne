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
            // pour que la personne instancée puisse recupérer les valeurs passer en paraamètres
            //this. concerne la classe, il prend la valeur correspondant aux propriétés et les lie à ceux du paramètre
            this.nom = unNom;
            this.prenom = unPrenom;
            this.age = unAge;
        }

        // pour changer la valeur d'un paramètre de la classe (ici age)
        public  void setAge(int value)
        {
            age = value;
        }

        // Pour cibler un élément passé en paramètre (ici age)
        public string getAge() 
        {
            return age.ToString();
        }
        

        // on crée une méthode nous permettant d'afficher ses infos

        public string affichage()
        {
            return nom + " " + prenom + " " + age +" ans";
        }


    }
}
