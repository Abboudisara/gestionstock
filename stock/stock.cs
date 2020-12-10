using System;
using System.Collections.Generic;
using System.Text;

namespace stock
{
    public class stock
    {


        private List<Article> stockage;// Déclaration de la collection




        public stock()
        {
            stockage = new List<Article>(); //création dune liste
        }

        public void Ajouter(int reference, string Nom, int achat, int vente) // pour instancier un article
        {
            stockage.Add(new Article(reference, Nom, achat, vente)); // pour ajouter un article dans la liste
        }


        public void Affichage()                     // methode pour parcourir la list et afficher les objets et leurs details
        {
            foreach (Article produit in stockage)
            {
                Console.WriteLine(produit.Getrec());

            }
        }// recherche article par Numéro de réfférence
        public void Cherche(int refe)
        {

            foreach (Article article in stockage)
            {
                if (article.Getref() == refe)
                {
                    Console.WriteLine(article.Getrec());
                }

            }

        }
        //afficher avec filtre 
        public void FilterArticle(int prix)
        {
            foreach (Article article in stockage)
            {
                if (article.GetAchat() > prix)
                {
                    Console.WriteLine(article.Getrec());
                }
              

            }

        }

        // supprimer une article 
        public void Delete(string nom)
        {
            foreach (Article article in stockage)
            {
                if (article.Getnam() == nom)
                {
                   stockage.Remove(article);
                    Console.WriteLine("l'article de nom {0} est supprimer", nom);
                }

            }
        }

        // Modification d une article :

        public void modification(int refe, string n,int pd,int v)
        {
            foreach(Article article in stockage)
            {
                if (article.Getref() == refe)
                {
                    article.SetNom(n);
                    article.SetPrixAchat(pd);
                    article.SetPrixVente(v);
                }
            }
        }
    }

    
}
