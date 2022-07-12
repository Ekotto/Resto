using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class listemenu
    {
        public string ff;
        public string Foodies;
        public string Lepop;
        public string casa;
        public string m;

        public string path;

        public listemenu(){
            path="";

        }

        public void menu_lep(){
            path=@"E:\Master Pro\Programmation C#\ProgCshap\resto\menu\lepop_menu.txt";
            var content= File.ReadAllText(path);
            System.Console.WriteLine(content);
        }
        public void menu_food(){
            path=@"E:\Master Pro\Programmation C#\ProgCshap\resto\menu\foodies_menu.txt";
            var content= File.ReadAllText(path);
            System.Console.WriteLine(content);
        }
        public void menu_casa(){
            path=@"E:\Master Pro\Programmation C#\ProgCshap\resto\menu\casa_menu.txt";
            var content= File.ReadAllText(path);
            System.Console.WriteLine(content);
        }
        public void menu_ff(){
            path=@"E:\Master Pro\Programmation C#\ProgCshap\resto\menu\ff_menu.txt";
            var content= File.ReadAllText(path);
            System.Console.WriteLine(content);
        }
    }
