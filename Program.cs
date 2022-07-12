string saisie, s;
bool condition = false;
while (!condition){
    System.Console.WriteLine("\t \t \t \t\t\t\t\t\t Bienvenue sur Resto");
    System.Console.WriteLine("\t \t \t \t \t\t\t Une application pour commander et reserver vos menus preférés \n");
    System.Console.WriteLine("\nResto  \t\t\t\t\t\t\t\t\b Home  Restaurant  Passer une Commande  \t\t\t\t\t\t\t Login \n\n");
    System.Console.WriteLine("ceci étant une version console, veuiller saisir le chiffre comme presenter.\n que voulez-vous faire svp ? \n");

    System.Console.WriteLine("1. Voir les Restaurants");
    System.Console.WriteLine("2. Passer une Commande");
    System.Console.WriteLine("3. Faire une Reservation");
    System.Console.WriteLine("4. Login \n");
    saisie= Console.ReadLine();

    if(saisie == string.Empty){
        System.Console.WriteLine("voulez-vous Continuer ou Quitter l'application ? O/N");
        s = Console.ReadLine();
        if(s == "o" || s == "O"){
            condition = true;
            continue;
        }if (s == "n" || s == "N"){
            condition = false;
            break;
        }
    }
    switch(saisie)
    {
        case "1":
            saisie = "1";
                Console.WriteLine($"\n Vous avez choisi la liste de restaurant \n");
                var voir = new voirrestaurant();
                voir.afficherresto();
                System.Console.WriteLine("Quel est le restaurant que vous voulez ?");
                saisie= Console.ReadLine();
                if(saisie == "1"){
                    voir.afficherresto_lepop();
                }else if(saisie == "2"){
                    voir.afficherresto_ff();
                }else if(saisie == "3"){
                    voir.afficherresto_foodies();
                }else if(saisie == "4"){
                    voir.afficherresto_casa();
                }
                System.Console.WriteLine("voulez-vous Continuer ou Quitter l'application ? O/N");
                s = Console.ReadLine();
                if(s == "o" || s == "O"){
                    condition = false;
                }if (s == "n" || s == "N"){
                    condition = true;
                    break;
                }
            break;
        case "2":
            saisie = "2";
                Console.WriteLine("Vous voulez passer une commande \n");
                var com = new passercommande();
                com.commander();

                System.Console.WriteLine("voulez-vous continuer Quitter l'application ? O/N");
                s = Console.ReadLine();
                if(s == "o" || s == "O"){
                    condition = false;
                }if (s == "n" || s == "N"){
                    condition = true;
                    break;
                }
            break;
            case "3":
            saisie = "3";
                Console.WriteLine("Vous voulez Faire une Reservation \n");
                var ress = new reserv();
                ress.res_simple();

                System.Console.WriteLine("voulez-vous continuer Quitter l'application ? O/N");
                s = Console.ReadLine();
                if(s == "o" || s == "O"){
                    condition = false;
                }if (s == "n" || s == "N"){
                    condition = true;
                    break;
                }
            break;
        case "4" :
            saisie = "4";
                Console.WriteLine("Vous voulez vous logger");
                var log = new login();
                log.seloger();

                System.Console.WriteLine("voulez-vous continuer Quitter l'application ? O/N ");
                s = Console.ReadLine();
                if(s == "o" || s == "O"){
                    condition = false;
                }if (s == "n" || s == "N"){
                    condition = true;
                    break;
                }
            break; 
    }
}



