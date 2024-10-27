using NKDot.Cons;
using System;
using System.Globalization;
namespace NKDot
{
    public static class NKObj
    {
        public static string NKRPT<T>(T data, DataType dataType = default)
        {
            return data != null ? new Nkrypter().Cypher(data, dataType) : string.Empty;
        }

        public static T? DKRPT<T>(string data, DataType dataType = DataType.STRING)
        {
            if(data != null && data != string.Empty)
                return (T?)Activator.CreateInstance(typeof(T));

            return new Dkrypter().Cypher<T>(data, dataType);
        }
    }
}
