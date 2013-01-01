using System;
using System.Collections.Generic;
using System.Web;

/// <summary>
/// Summary description for ClassName
/// </summary>
public class Global
{
    public static string Exceptions=null;
    public static List<Cart> list=new List<Cart>();
    public static void delete(int id)
    {
        for(int i=0;i<list.Count;i++)
        {
            if(list[i].PID==id)
            {
                list.RemoveAt(i);
                Exceptions=null;
            }
        }
        Exceptions="Record Not Found in the Cart";
    }

    public static void update(int id,int orgqQuan,int givenQuan)
    {
        if(orgqQuan>=givenQuan)
        {
            for(int i=0;i<list.Count;i++)
            {
                if(list[i].PID==id)
                {
                    list.RemoveAt(i);
                    Exceptions=null;;
                }
            }
        }
        else
        {
            Exceptions="Entered Quantity Exceeds the available Limit";
        }
    }

    public static Cart Get(int pid)
    {
        foreach(var val in list)
        {
            if(val.PID==pid)
            {
                return val;
                Exceptions=null;
            }
        }
        Exceptions="Not found in cart";
        return null;
    }
    public Global()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}
