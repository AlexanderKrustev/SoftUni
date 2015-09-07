using System;

    class PrintCompanyInfo
    {
        static void Main()
        {
        String companyName = "";
        string companyAddress = "";
        string companyPhone = "";
        string fax = "";
        string webSite = "";
        string mngFirstName = "";
        string mngLastName = "";
        byte mngAge = 0;
        string mngPhone = "";
        Console.Write("Company Name:");
        companyName = Console.ReadLine();
        Console.Write("Company Address:");
        companyAddress = Console.ReadLine();
        Console.Write("Phone Number:");
        companyPhone = Console.ReadLine();
        Console.Write("Fax Number:");
        fax = Console.ReadLine();
        if (fax == "")
        {
            fax = "(no fax)";
        }
        Console.Write("Web site");
        webSite = Console.ReadLine();
        Console.Write("Manager first name:");
        mngFirstName = Console.ReadLine();
        Console.Write("Manager last name:");
        mngLastName = Console.ReadLine();
        Console.Write("Manager Age:");
        mngAge = byte.Parse(Console.ReadLine());
        Console.Write("Manager phone:");
        mngPhone = Console.ReadLine();
        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}",companyAddress);
        Console.WriteLine("Tel. {0}",companyPhone);
        Console.WriteLine("FAX {0}", fax);
        Console.WriteLine("Web site: {0}", companyAddress);
        Console.WriteLine("Manager: {0} {1} ({2}, tel. {3})", mngFirstName,mngLastName,mngAge,mngPhone);

    }
    }
