using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class reserv
    {
        public string nom;
        public string Prenom;
        public string nom_pers;
        public string date_heure;
        public string saisie;
        public string m,a,b,c,d,f;
        public string spl= ",";
        public string e = ";";
        public reserv(){

        }

        public void faire_res(){

            saisie = Console.ReadLine();
            if(saisie == "1"){
                System.Console.WriteLine("Veuillez entrer le nom du restaurant");
                c = Console.ReadLine();
                System.Console.WriteLine("veuillez entrez votre nom :\n");
                m = Console.ReadLine();
                System.Console.WriteLine("Numéro de Tel:");
                f = Console.ReadLine();
                System.Console.WriteLine("Nombre de personne");
                a = Console.ReadLine();
                System.Console.WriteLine("date et l'heure");
                b = Console.ReadLine();
                System.Console.WriteLine("Merci pour la confiance");

                var contents = (""+ c +spl + m +spl +f +spl  + a +spl  + b +spl  + d +spl + e).Split(',');
                //System.Console.WriteLine(contents);

                var path=@"E:\Master Pro\Programmation C#\ProgCshap\resto\fich reserv.txt";
                File.AppendAllLines(path,contents);
            }else if(saisie == "2"){
                var commm = new passercommande();
                commm.commander();
            }
            
        }
        public void res_simple(){
            System.Console.WriteLine("Veuillez entrer le nom du restaurant");
                c = Console.ReadLine();
                System.Console.WriteLine("veuillez entrez votre nom :\n");
                m = Console.ReadLine();
                System.Console.WriteLine("Numéro de Tel:");
                f = Console.ReadLine();
                System.Console.WriteLine("Nombre de personne");
                a = Console.ReadLine();
                System.Console.WriteLine("date et l'heure");
                b = Console.ReadLine();
                System.Console.WriteLine("Votre Requete a bien été reçu, nous vous appelerons pour confirmation");
                System.Console.WriteLine("Merci pour la confiance");

                var contents = (""+ c +spl + m +spl +f +spl  + a +spl  + b +spl  + d +spl + e).Split(',');
                //System.Console.WriteLine(contents);

                var path=@"E:\Master Pro\Programmation C#\ProgCshap\resto\fich reserv.txt";
                File.AppendAllLines(path,contents);
        }
    }
