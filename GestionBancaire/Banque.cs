using System;
using System.Collections.Generic;
using System.Text;

namespace GestionBancaire
{
    class Banque
    {
        public List<AbstractCompte> listcompte;


        
        public Banque()
        {
            listcompte = new List<AbstractCompte>();
        }
        

        public void recherche(int Numero) // pour la recherche
        {
            AbstractCompte abstractCompte = listcompte.Find(abstractCompte => abstractCompte.GetNum() == Numero);
            if (abstractCompte != null) {

                Console.WriteLine("l index de compte rechercher est : " + listcompte.IndexOf(abstractCompte));

            }
            else
            {
                Console.WriteLine(-1);
            }

        }

        public void AjouterCarnet(int N, int Ncarnet, string Nom, int solde)
        {
            bool exist = listcompte.Exists(AbstractCompte => AbstractCompte.GetNum()== Ncarnet);

            if (exist == true)
            {
                Console.WriteLine("Ce Compte déja enregistrer");
            }
            else
            {
                listcompte.Add(new CompteSurCarnet(N, Ncarnet,Nom, solde));
            }
        }


        public void AjouterCheque(int Ncheque, string DF, int Ncarte, int N, string Nom, int solde) // ajoute sur compte cheque
        {
            bool exist = listcompte.Exists(AbstractCompte => AbstractCompte.GetNum() == Ncheque);

            if (exist == true)
            {
                Console.WriteLine("Ce Compte déja enregistrer");
            }
            else
            {
                listcompte.Add(new CompteSurCheque( Ncheque, DF, Ncarte,  N, Nom, solde));
            }
        }



        public void supprimerCompte(int Num) // supprimer un compte 
        {
            if (listcompte.Count > 0)
            {
                listcompte.RemoveAll(abstractCompte => abstractCompte.GetNum() == Num);
            }
            else
            {
                Console.WriteLine("le compte n'existe pas");
            }
        }


        public void GetCompte(int Num)  // trouver un compte
        {
            AbstractCompte abstractCompte = listcompte.Find(abstractCompte => abstractCompte.GetNum() == Num);

            if (abstractCompte != null)
            {
                Console.WriteLine(abstractCompte.GetCompte());

            }
            else
            {
                Console.WriteLine(" Ce Numéro de Compte Introuvable ");
            }


        }

        public void afficher() // l affichage de contenu de chaque Compte
        {
            foreach(AbstractCompte abstractCompte in listcompte)
            {
                Console.WriteLine(abstractCompte.GetCompte());
            }
        }


        public void operationD(int Num,int retirer)  // retirer de  votre compte
        {
            AbstractCompte abstractCompte = listcompte.Find(abstractCompte => abstractCompte.GetNum() == Num);

            if (abstractCompte != null)
            {
                Console.WriteLine("Votre Numero de Compte  : " + abstractCompte.GetNum());
                Console.WriteLine("Votre Solde : " + abstractCompte.GetSold() + " DH");
                Console.WriteLine("Le Montant Debité  : " + retirer + " DH");
                abstractCompte.Débite(retirer);
                Console.WriteLine("Votre Nouveau Solde : " + abstractCompte.GetSold() + " DH");
            }
            else
            {
                Console.WriteLine("Ce Numero de compte est Introuvable!!!");
            }

        }


        public void operationC(int Num,int mantant)
        {
            AbstractCompte abstractCompte = listcompte.Find(abstractCompte => abstractCompte.GetNum() == Num);


            if (abstractCompte != null)
            {
                Console.WriteLine("Votre Numero de Compte  : " + abstractCompte.GetNum());
                Console.WriteLine("Votre Solde : " + abstractCompte.GetSold() + " DH");
                Console.WriteLine("Le Montant Credité  : " +mantant + " DH");
                abstractCompte.crédit(mantant);
                Console.WriteLine("Votre Nouveau Solde : " +abstractCompte.GetSold() + " DH");
            }

            else
            {
                Console.WriteLine("Ce Numero de compte est Introuvable!!!");
            }
        }

        



    }
}
