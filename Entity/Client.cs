using System;
using System.Collections.Generic;
using System.Text;

namespace Menagelec1.Entity
{
    class Client
    {
        int idClient;
        string civilite;
        string nom;
        string prenom;
        string adresse;
        string ville;
        string cp;
        string mail;
        string tel;

        public int IdClient { get => idClient; set => idClient = value; }
        public string Civilite { get => civilite; set => civilite = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Ville { get => ville; set => ville = value; }
        public string Cp { get => cp; set => cp = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Tel { get => tel; set => tel = value; }
    }
}
