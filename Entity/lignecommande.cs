using System;
using System.Collections.Generic;
using System.Text;

namespace Menagelec.Entity
{
    class lignecommande
    {
        int produit;
        int commande;
        int quantite;



        public int Produit { get => produit; set => produit = value; }
        public int Commande { get => commande; set => commande = value; }
        public int Quantite { get => quantite; set => quantite = value; }
    }
}
