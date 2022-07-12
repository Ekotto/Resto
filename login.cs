
public class login
{
    
    public string email;
    public string password;

    public string cred;

    public bool result;


    public login(){
        email="";
        password="";
    }
    // public login(string email, string password){
    //     this.email=email;
    //     this.password=password;
    // }

    public void seloger(){
        var path = @"E:\Master Pro\Programmation C#\ProgCshap\resto\logging.txt";
        var content = File.ReadAllText(path);
        System.Console.WriteLine(content);
        System.Console.WriteLine("Welcome ! Entrez vos identifiants svp separer d'une ',' ");
        //System.Console.WriteLine();
        cred = Console.ReadLine();
        System.Console.WriteLine(cred);
        //List<string> current=null;
        //result= string.Equals(content, cred, );
        //System.Console.WriteLine(result);
        if (content.Equals(cred, StringComparison.InvariantCultureIgnoreCase ))
        {
            System.Console.WriteLine("Welcome User");
        }
        else{
            System.Console.WriteLine("wrong credentials");
        }
        

    }
}