using System;

namespace IOC.Web.Models
{
    public interface IDateService
    {
        DateTime GetDateTime { get; }
    }


    public interface ISingletonDateService : IDateService { }

    public interface IScopedDateService : IDateService { }

    public interface ITransientDateService : IDateService { }


    /*Dependency Injection (DI)
     * 
     * 3 türlü yöntem vardir
     * 
     * 1.Constructor üzerinden DI (En cok bu kullanilir) 
     * 2.Method üzerinden DI    
     * 3.Property üzerinden DI
     *
     * IOC/DI Container
     * 
     * ASP.Net Mvc DI/IOC Container destegi olmadigi icin Third Party Framework (Autofac,Ninjet,Unity) kullanilir.
     * 
     * ASP.Net Core DI/IOC Container default olarak bünyesinde destekler. Ancak sadece Property üzerinden desteklemedigi icin bu yüzden Third Party frameworklere ihtiya duymaktadir.
     * 
     * 3 türlü IOC/DI Container yasam döngüsü mevcuttur
     * 
     * 1.Singleton : Bir uygulamada bir bagimli nesne DI ye ihtiyac duydugu anda olusturulur ve uygulama sonlanincaya ayni nesne örnegi nereden ihtiyac duyulursa orada kullanilir.
     * 
     * 2.Scoped :  Bir request boyunca gecerli olur. Ikinci defa ihtiyac halinde yeniden olusturulur.
     * 
     * 3.Transient : Her ihtiyac halinde enjekte edildigi yerde kullanilir.
     */
}
