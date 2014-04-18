using System;

class CompanyInformation
{
    static void Main()
    {
        Console.WriteLine("Please enter some info for the company\n");
        Console.Write("Company name: ");
        string CompanyName = Console.ReadLine();
        Console.Write("Company address: ");
        string CompanyAddress = Console.ReadLine();
        Console.Write("Phone number: ");
        string CompanyPhoneNum = Console.ReadLine();
        Console.Write("Fax number: ");
        string CompanyFaxNumber = Console.ReadLine();
        Console.Write("Web Site: ");
        string WebSite = Console.ReadLine();
        Console.Write("Manager First Name: ");
        string ManagerName = Console.ReadLine();
        Console.Write("Manager Last Name: ");
        string ManagerSecName = Console.ReadLine();
        Console.Write("Manager Age: ");
        string ManagerAge = Console.ReadLine();
        Console.Write("Manager Phone Number: ");
        string ManagerPhone = Console.ReadLine();
        Console.WriteLine("\n\n");
        Console.WriteLine("{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\nManager: {5} {6}(age:\n{7},tel. {8}",CompanyName,CompanyAddress,CompanyPhoneNum,CompanyFaxNumber,WebSite,ManagerName,ManagerSecName,ManagerAge,ManagerPhone);
    }
}

