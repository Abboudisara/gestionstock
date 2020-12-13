using System;
using System.Collections.Generic;
using System.Text;

namespace GestionBancaire
{
     public abstract class AbstractCompte
    {
        // ********champs
        protected int Numero;
        protected string NomProprietaire;
        protected int solde;



        
        public  AbstractCompte(int N,string Nom, int solde)
        {
            this.Numero = N;
            this.NomProprietaire = Nom;
            this.solde = solde;
        }

        public AbstractCompte() { // constructeur par defeaut
            
        }

        // ****************************getres
      public int GetNum() // accesseur de numero
        {
            return this.Numero;
        }

        public int GetSold() // accesseur de solde
        {
            return this.solde;
        }


        //**************************setter

        public void Setslod(int valeur)
        {
             solde = valeur;
        }

        public abstract  void crédit(int mantant); // methode de abstract classe san cort
        public abstract void Débite(int retirer);
        public abstract string GetCompte();

    }
}
