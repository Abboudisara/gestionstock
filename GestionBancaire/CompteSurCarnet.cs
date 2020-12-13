using System;
using System.Collections.Generic;
using System.Text;

namespace GestionBancaire
{
    class CompteSurCarnet:AbstractCompte
    {
        int NuméroCanret;

        public CompteSurCarnet()
        {

        }
        public CompteSurCarnet(int Ncarnet, int N, string Nom, int solde):base(N,Nom,solde)
        {
            this.NuméroCanret = Ncarnet;
        }


        public int getNcarnet() {

          return this.NuméroCanret;

        }


        public void setNcarnet(int valeure)
        {
            NuméroCanret = valeure;
        }

        public override void crédit(int mantant)
        {
            solde += mantant;

        }



        public override void Débite(int retirer)
        {
            if (retirer <= solde)
            {
                solde -= retirer;
            }

            else if (retirer > 10000)
            {
                throw new Exception();
            }

            else
            {
                throw new Exception();
            }



        }

        public override string GetCompte()
        {
            string Compte = "le Numero de compte : " + Numero + "\n"
                + "le numero de cartnet : " + NuméroCanret + "\n"
            + "le nom de proproetaire  : " + NomProprietaire + "\n"
               + "le solde  : " + solde + " DH \n";

               
              

            return Compte;
        }



    }
   


}
