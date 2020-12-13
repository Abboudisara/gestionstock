using System;

namespace GestionBancaire
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Banque op = new Banque();
                op.AjouterCarnet  (51,100,"sara",5000);
                op.AjouterCarnet(11, 200, "omaya", 1000);
               

                
                op.AjouterCheque(51, "31/12/2020", 111,10, "Kamal",100);
                op.AjouterCheque(11, "01/01/2020", 222, 20,"yassin",200);

                op.afficher();

                Console.WriteLine("entrez le Numero de compte que vous souhaiter recherchez");

                int N = int.Parse(Console.ReadLine());
                op.recherche(N);

                Console.WriteLine("entrez le Numero de compte que vous souhaiter le supprimer");
                int Num= int.Parse(Console.ReadLine());
                op.supprimerCompte(Num);
                op.afficher();


                Console.WriteLine("entrez votre Numero de compte pour voire plus de détaille");
                int N1= int.Parse(Console.ReadLine());
                op.GetCompte(N1);


                Console.WriteLine("votre solde maintenant apres cette operation");
                op.operationC(200, 100);
                Console.WriteLine("votre solde maintenant apres cette operation");
                op.operationD(200,100);




            }
            catch
            {
                Console.WriteLine("error");
            }
        }
    }
}
