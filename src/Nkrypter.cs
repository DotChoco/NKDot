using NKDot.Cons;
using NKDot.Cyphers;
using System.Numerics;

namespace NKDot
{
    public class Nkrypter
    {
        string[] seed = new string[2];
        public string Cypher<T>(T data, DataType dt)
        {
            string dataNKrypted = string.Empty;
            seed = SeedMaker();
            string result = seed[0];
            result = new string(seed[1].Reverse().ToArray()) + result;

            dataNKrypted = DataTypeSelector(dt, data);
            Console.WriteLine(dataNKrypted);

            return result + Shuffling(dataNKrypted, seed);
        }

        string[] SeedMaker()
        {
            sbyte seedLenght = 17;
            sbyte seedHalfLenght = 8;
            string startSeed = string.Empty,
                    endSeed = string.Empty;
            sbyte firstAscii = 33, lastAscii = 127;
            Random random = new();

            for (sbyte i = 0; i < seedHalfLenght; i++)
            {
                startSeed += (char)random.Next(firstAscii, lastAscii);
            }

            for (sbyte j = 0; j < seedHalfLenght + 1; j++)
            {
                endSeed += (char)random.Next(firstAscii, lastAscii);
            }

            if (startSeed.Length + endSeed.Length != seedLenght)
                return SeedMaker();

            return [startSeed, endSeed];
        }

        string DataTypeSelector(DataType dt, object? data)
        {
            string result = string.Empty;
            switch (dt)
            {
                case DataType.STRING: result = StringCypher.FirstLayer((string)data, seed);
                    break;
                case DataType.CHAR: result = StringCypher.FirstLayer((string)data, seed, true);
                    break;
                case DataType.BYTE: result = NumCypher.ByteCypher((byte)data, seed);
                    break;
                case DataType.BOOL: result = NumCypher.BoolCypher((bool)data, seed);
                    break;
                case DataType.DOUBLE: result = NumCypher.DoubleCypher((double)data, seed);
                    break;
                case DataType.FLOAT: result = NumCypher.FloatCypher((float)data, seed);
                    break;
                case DataType.INT: result = NumCypher.IntegerCypher((int)data, seed);
                    break;
            }

            return result;
        }


        string Shuffling(string data, string[] seed)
        {
            string result = string.Empty;


            return result;
        }

    }
}
