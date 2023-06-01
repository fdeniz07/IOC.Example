namespace IOC.Example
{
    public interface IDAL //This Interface for DI
    {
        List<Product> GetProducts();

        //int Calculate(); // Eger bu metot yazilmazsa BL'in bu metotdan haberi olmaz.
                           // Bu da da bazi bilgilerin disa acilmasini engellemis olur!

    }
}
