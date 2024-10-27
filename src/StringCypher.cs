using NKDot.Cons;
using System.Text;

namespace NKDot.Cyphers
{
    public static class StringCypher
    {


        #region Layers
        public static string FirstLayer(string data, string[] seed,bool isChar = false)
        {
            StringBuilder sb = new();

            sb.Append(SecondLayer(data));
            sb.Append(ThirdLayer(data));

            return sb.ToString();
        }

        public static string SecondLayer(string data)
        {
            StringBuilder sb = new();

            return sb.ToString();
        }

        public static string ThirdLayer(string data)
        {
            StringBuilder sb = new();

            return sb.ToString();
        }


        #endregion

    }
}
