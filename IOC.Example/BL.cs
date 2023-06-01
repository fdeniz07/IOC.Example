namespace IOC.Example
{
    public class BL //--> Dependent Object : Bir sinif(BL) görevini yerine getirebilmek icin bir baska sinifa(DAL) bagli ise "Bagli Obje" denir
    {

        // private DAL _dal { get; set; } //This is a concrete object
        private IDAL _dal { get; set; }  //This is a abstract object


        //public BL() //Bu bölümde DalFactory nin GetDal() metoduna bagimlilik var
        //{
        //    //Tightly Coupling
        //    //_dal = new DAL();

        //    _dal = DALFactory.GetDal(); //IoC Implm.
        //}


        public BL(IDAL dal) //Bu bölüm yukaridaki bölüme göre daha gevsek bir bagimlilik olusturur.
        {                   //Bagimli Nesne(Dependency object) --> Baska bir arkadasin(DAL) görevini yerine getirmek icin bu nesneye(IDAL)                        ihtiyac duymasidir.
                            // Constructor üzerinden Dependeny Injection denir.                                
            _dal = dal;
        }

        public List<Product> GetProducts()
        {
            //_dal.Calculate(); --> Eger biz bu metodu interface yazmasaydik BL'in bundan haberi olmayacakti!
            return _dal.GetProducts();
        }
    }
}


/* Dependency Injection (DI)
 * 
 * 3 türlü yöntem vardir
 * 
 * 1.Constructor üzerinden DI (En cok bu kullanilir) 
 * 2.Method üzerinden DI    
 * 3.Property üzerinden DI
 * 
 * 
 */