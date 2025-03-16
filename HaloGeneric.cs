using System;
namespace tpmodul5_1302204106
{
    public class HaloGeneric
    {
        public void SapaUser<T>(T user)
        {
            Console.WriteLine($"Halo user {user}");
        }
    }

}

