namespace IOC.Example
{
    public class DALFactory //Loosely Coupled Class
    {
        //This is a concrete object
        //public static DAL GetDal()
        //{   
        //    return new DAL();
        //}

        //This is a abstract object
        public static IDAL GetDal()
        {
            return new MsDAL();
        }
    }
}
