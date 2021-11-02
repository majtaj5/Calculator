
namespace calculator
{
    class Power
    {
        
        public int GetPower(int baseNumner, int power)
        {
            int result = 1;

            for(int i=0; i<power; i++)
            {

                result = result * baseNumner;

            }
            return result;



        }



    }
}
