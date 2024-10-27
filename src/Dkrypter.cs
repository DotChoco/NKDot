using System.Text;
using NKDot.Cons;
namespace NKDot
{
    public class Dkrypter
    {
        string[] seed = new string[2];
        public T Cypher<T>(string data, DataType dt)
        {
            string result = string.Empty;

            seed = SeedGetter(data);
            Type type = typeof(T);
            return (T)DataTypeSelector(dt, data);
        }


        #region Layers

        string Layer_1(string data)
        {
            StringBuilder sb = new();

            sb.Append(Layer_2(data));
            sb.Append(Layer_3(data));

            return sb.ToString();
        }

        string Layer_2(string data)
        {
            StringBuilder sb = new();

            return sb.ToString();
        }

        string Layer_3(string data)
        {
            StringBuilder sb = new();

            return sb.ToString();
        }



        #endregion


        object DataTypeSelector(DataType dt, object data)
        {
            object result = default;
            switch (dt)
            {
                case DataType.STRING:
                    result = Layer_1(data as string);
                    break;
                case DataType.CHAR:
                    result = Layer_1(data as string);
                    break;
                case DataType.BYTE: //NumCypher
                    break;
                case DataType.BOOL: //NumCypher
                    break;
                case DataType.DOUBLE: //NumCypher
                    break;
                case DataType.FLOAT: //NumCypher
                    break;
                case DataType.INT: //NumCypher
                    break;
                default: break;
            }

            return result;
        }
        string[] SeedGetter(string data)
        {
            StringBuilder sb = new();
            string startSeed = string.Empty,
                    endSeed = string.Empty;


            return [startSeed, endSeed];
        }


    }
}
