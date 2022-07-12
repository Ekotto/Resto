using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class passercommande
    {
        public string Nom;
        public string Prenom;
        public string menus;
        public string quantité;
        public string quartier;
        public string m,a,b,c,d,f;
        public string spl= ",";
        public string e = ";";
        public string p = "";

        public passercommande(){
            // var Nom="";
            // var Prenom="";
            // var menus= new voirrestaurant();
            // var quantité="";
            // var quartier="";
        }
        public void commander(){
            System.Console.WriteLine("veuillez remplir comme demander svp \n");
            System.Console.WriteLine("Quel est le restaurant :");
            m = Console.ReadLine();
            System.Console.WriteLine("quelle est le menu :");
            a = Console.ReadLine();
            System.Console.WriteLine("Quantité :");
            c = Console.ReadLine();
            System.Console.WriteLine("Votre Nom :");
            b = Console.ReadLine();
            System.Console.WriteLine("Numéro de Tel:");
            f = Console.ReadLine();
            System.Console.WriteLine("Localisation :");
            d = Console.ReadLine();
            System.Console.WriteLine("Votre Commande a été enregistré, Merci pour la Confiance");
            var contents = ("" + m +spl  + a +spl + c +spl  + b +spl +f +spl  + d +spl + e).Split(',');
            //System.Console.WriteLine(contents);

            var path=@"E:\Master Pro\Programmation C#\ProgCshap\resto\fich commande.txt";
            File.AppendAllLines(path,contents);
        }
    }
