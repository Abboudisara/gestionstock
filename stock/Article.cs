using System;
using System.Collections.Generic;
using System.Text;

namespace stock
{
   class Article //décalaration dune classe
    {
        private int Numréf;
        private string nom;
        private int prixD;  // les champs d une classe
        private int prixV;


      
        public Article(int reference,string Nom,int achat,int vente){// constructeur 

            this.Numréf = reference;
            this.nom = Nom;        // inisialisation des champs
            this.prixD = achat;
            this.prixV = vente;

            if (vente < achat) 
            {

                throw new Exception();

            }

        

        }
        public string Getrec() // mehode pour récuperer les données de stockage
        {
            string rec = "le numero de référence de l article est : " + Numréf + "\n"
                + "leur Nom est :" + nom + "\n"
                + "leur prix d achat est " + prixD + "\n"
                + "leur prix de vente est " + prixV + "\n";
            return rec;
        }
       
        public int Getref() 
        {
            return this.Numréf; // methode pour récuperer Num réference
        }
        public int GetAchat()
        {
            return prixD;
        }
        public string Getnam()
        {
            return nom;
        }



        public void SetPrixAchat(int value)   // methode pour modifier
        {
            prixD= value;
        }
        public void SetPrixVente(int value)
        {
            prixV = value;
        }

        public void SetNom(string value)
        {
            nom = value;
        }
    }

}
