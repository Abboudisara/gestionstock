using System;
using System.Collections.Generic;
using System.Text;

namespace GestionBancaire
{
  class CompteSurCheque : AbstractCompte
    {
        int NuméroChèque;
        string DateFinValiditéCarte;
        int NuméroCarte;





        public CompteSurCheque(int Ncheque, string DF, int Ncarte, int N, string Nom, int solde) :base(N,Nom,solde)
        {
            this.NuméroChèque = Ncheque;
            this.DateFinValiditéCarte = DF;
            this.NuméroCarte = Ncarte;


        }

        public CompteSurCheque()
        {
          


        }

        public int GetNcheque()
        {
            return this.NuméroChèque;
        }

        public int Getcart()
        {
            return this.NuméroCarte;
        }

        public string GetDateF()
        {
            return this.DateFinValiditéCarte;
        }

        




        public override void crédit(int mantant)
        {
            solde += mantant;

        }

        public override void Débite(int retirer)
        {
            if (retirer<=solde)
            {
                solde -= retirer;
            }

            else 
            {
                throw new Exception();
            }

           

        }

        public override string GetCompte()
        {
            string Compte = "le Numero de compte : " + Numero + "\n"
               + "le nom de proproetaire  : " + NomProprietaire + "\n"
               + "le solde  : " + solde + " DH \n"
               + "le numero de cheque : " + NuméroChèque + "\n"
               + "le numero de carte : " + NuméroCarte + "\n"
               + "la date de validité de la cart  : " + DateFinValiditéCarte + "  \n";


            return Compte;
        }







    }
}







       
