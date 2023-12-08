using System;
using System.Collections.Generic;
using System.Text;

namespace Menagelec1.Entity
{
    class produit
    {
        int idProduit;
        string designaiton;
        string description;
        DateTime dateAjout;
        float prix;
        string fichierImage;
        int qte;

        public int IdProduit { get => idProduit; set => idProduit = value; }
        public string Designaiton { get => designaiton; set => designaiton = value; }
        public string Description { get => description; set => description = value; }
        public DateTime DateAjout { get => dateAjout; set => dateAjout = value; }
        public float Prix { get => prix; set => prix = value; }
        public string FichierImage { get => fichierImage; set => fichierImage = value; }
        public int Qte { get => qte; set => qte = value; }
    }
}
