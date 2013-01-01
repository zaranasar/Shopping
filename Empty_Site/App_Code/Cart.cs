using System;
using System.Collections.Generic;
using System.Web;

/// <summary>
/// Summary description for ClassName
/// </summary>
public class Cart
{
    public int PID;
    public string name;
    public string description;
    public double price;
    public string path;
    public int quantity;
    public Cart(int pid,string n,string d,double p,int quan,string image)
    {
        PID=pid;
        name=n;
        description=d;
        price=p;
        quantity=quan;
        path=image;
    }
}
