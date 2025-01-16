


//MyDegegate g = GetMsg;
//Console.WriteLine(g("欢迎来到筑梦信仰----www.xyjy.top"));



Console.WriteLine(Person.Sayhi(GetAge));



static string GetMsg(string Msg)
{
    return $"消息是{Msg}";
}

static string GetAge(string age)
{
    return $"年龄是{age}";
}

public delegate string MyDegegate(string Msg);

public class Person
{
    public static string Sayhi(MyDegegate g)
    {
       return g("欢迎来到筑梦信仰----www.xyjy.top");
    }


    public static string Sayhi1()
    {
        return Student.GetAge("欢迎来到筑梦信仰----www.xyjy.top");
    }
}


public class Student {
    
    public  static  string GetMsg(string Msg)
    {
        return $"消息是{Msg}";
    }

    public static string GetAge(string age)
    {
        return $"年龄是{age}";
    }
}