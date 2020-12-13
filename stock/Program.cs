using System;

namespace stock
{
    
 
    class Program
    {
        static void Main(string[] args)
        {
            try // try f 7alat la condition mt7a9a l éxécution ghadi tkoun hna 
            {
                stock produit = new stock();// creation d objet 
              
                produit.Ajouter(111, "livre", 70, 100);// ajouter un article
                produit.Ajouter(222, "ordinateur", 40, 70);
                produit.Ajouter(333, "carnet", 30, 50);
                produit.Affichage(); // affichage d une stock 


                // recherche a un article
               
                Console.WriteLine("entrer le reference de l 'article que vous souhaitez à rechercher : ");
                
               int refe = int.Parse(Console.ReadLine());// convesion de entrer de recherche
               produit.Cherche(refe); // methode recherche avec attribue refe
                
                Console.WriteLine(" tu peux faire une recherche sur les article qui ne dépasse pas certain prix "); // recherche avec prix
                int prix = int.Parse(Console.ReadLine());
                produit.FilterArticle(prix);

              

              
             
               Console.WriteLine("tu peux supprimer une Article"); //pour supprission d'une article
               string nom= Console.ReadLine();
               produit.Delete(nom);

                produit.modification(111, "camion", 700, 900); //modification dune article
                produit.Affichage();



            }
            catch (Exception)// si la condiotion n ést ps trover l éxécution de msg d'errreur
            {
                Console.WriteLine("FATAL : LE PRIX DE VENTE DOIT ETRE PLUS GRAND QUE PRIX D'ACHAT");
            }
        }
    }
}
