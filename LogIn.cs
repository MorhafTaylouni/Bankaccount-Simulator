using System.Xml;

namespace Bankaccount;

public class LogIn
{
    private string username;
    private string password;
    private string joinOrexit;

    public LogIn(string passw, string user)
    {
        this.username = user;
        this.password = passw;
    }

    public string Setusername
    {
        get { return username;}
        set
        {
            if (value.Length > 2)
            {
                username = value;
            }
            else
            {
                username = "";
            }
        }
        
    }

    public string PasswordInput
    {
        get { return password;}
        set
        {
                if (value.Length > 7)
                {
                    password = value;
                }
                else
                {
                    password = "";
                }
            
        }
    }
    private string GetSaving()
    {
        return joinOrexit;
    }

    public void SetSaving(string value)
    {
        switch (value)
        {
            case "y":
                joinOrexit = GetSaving();
                break;
            case "n": System.Environment.Exit(1);
                break;
            default: System.Environment.Exit(1);
                break;
        }
    }
}