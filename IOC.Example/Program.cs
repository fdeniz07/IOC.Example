// See https://aka.ms/new-console-template for more information
using IOC.Example;


//BL bl = new BL(); -->DI öncesi 

BL bl = new BL(new MsDAL()); // --> DI sonrasi
BL bl2 = new BL(new OracleDAL()); // -->Ilgili Interface bagli her türlü class kodlarimizi bozmadan cagrilabilir
                                  // Bu sayede kodlarimiz gelismeye ve genisletmeye acik, degismeye kapali oldu.

bl.GetProducts().ForEach(x =>
{
    Console.WriteLine($"{x.Id}-{x.Name}-{x.Price}-{x.Stock}");
});

Console.WriteLine("-----------------------------------------------------");

bl2.GetProducts().ForEach(x =>
{
    Console.WriteLine($"{x.Id}-{x.Name}-{x.Price}-{x.Stock}");
});

Console.ReadLine();