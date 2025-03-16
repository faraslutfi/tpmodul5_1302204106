using tpmodul5_1302204106;

class Program
{
    static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("1302204106");  // memanggil method dengan input NIM

        DataGeneric<string> data = new DataGeneric<string>("1302204106");
        data.PrintData();  // Memanggil PrintData() untuk mencetak data yang tersimpan

        Console.ReadLine(); // supaya console ga ketutup
    }
}

