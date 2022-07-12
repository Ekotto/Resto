using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class voirrestaurant
    {
        public  string one= "Lepop";

        public  string two= "Friends food";

        public  string three= "Foodies";

        public  string four= "Casa de Papel 237";
        public string  saisie;
        public string res="Reservation";
        public string comm="Commande";


        public voirrestaurant(){
            one="1. Lepop";
            two="2. Friends food";
            three="3. Foodies";
            four="4. Casa de Papel 237";
            res= "1. Reservation";
            comm= "2. Passer Commande";
            saisie="";
        }

        public void afficherresto(){
            System.Console.WriteLine($"Les restaurants sont\n {one}\n {two}\n {three}\n {four} \n");
        }

        public void afficherresto_lepop(){
            System.Console.WriteLine($"Le Restaurant choisis est: {one}\n");
            System.Console.WriteLine("voir le menu ? o/n \n");
            saisie= Console.ReadLine();
            if(saisie == "o" || saisie== "O"){
                var com= new listemenu();
                com.menu_lep();
            }else if(saisie == "n" || saisie== "N"){
                System.Console.WriteLine("ok");;
            }
            System.Console.WriteLine("voulez vous faire une reservation ou un passer une commande ?\n");
            System.Console.WriteLine($"{res}");
            System.Console.WriteLine($"{comm}");
            //saisie = Console.ReadLine();
            var ress = new reserv();
            ress.faire_res();
            }

        public void afficherresto_ff(){
            System.Console.WriteLine($"Le Restaurant choisis est: {two}\n");
            System.Console.WriteLine("voir le menu ? o/n \n");
            saisie= Console.ReadLine();
            if(saisie == "o" || saisie== "O"){
                var com= new listemenu();
                com.menu_ff();
            }else if(saisie == "n" || saisie== "N"){
                System.Console.WriteLine("ok");;
            }
            System.Console.WriteLine("voulez vous faire une reservation ou un passer une commande ?\n");
            System.Console.WriteLine($"{res}");
            System.Console.WriteLine($"{comm}");
            var ress = new reserv();
            ress.faire_res();            
        }

        public void afficherresto_foodies(){
            System.Console.WriteLine($"Le Restaurant choisis est: {three}\n");
            System.Console.WriteLine("voir le menu ? o/n \n");
            saisie= Console.ReadLine();
            if(saisie == "o" || saisie== "O"){
                var com= new listemenu();
                com.menu_food();
            }else if(saisie == "n" || saisie== "N"){
                System.Console.WriteLine("ok");;
            }
            System.Console.WriteLine("voulez vous faire une reservation ou un passer une commande ?\n");
            System.Console.WriteLine($"{res}");
            System.Console.WriteLine($"{comm}");
            var ress = new reserv();
            ress.faire_res();
        }
        public void afficherresto_casa(){
            System.Console.WriteLine($"Le Restaurant choisis est: {four}\n");
            System.Console.WriteLine("voir le menu ? o/n \n");
            saisie= Console.ReadLine();
            if(saisie == "o" || saisie== "O"){
                var com= new listemenu();
                com.menu_casa();
            }else if(saisie == "n" || saisie== "N"){
                System.Console.WriteLine("ok");
            }
            System.Console.WriteLine("voulez vous faire une reservation ou un passer une commande ?\n");
            System.Console.WriteLine($"{res}");
            System.Console.WriteLine($"{comm}");
            var ress = new reserv();
            ress.faire_res();
            
        }
    }


