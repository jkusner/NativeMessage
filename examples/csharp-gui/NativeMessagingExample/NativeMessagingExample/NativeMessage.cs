using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;

namespace NativeMessagingTest
{
    public class NativeMessage
    {
        public int Length;
        public byte[] Data;

        public string UTF8()
        {
            return Encoding.UTF8.GetString(Data);
        }

        public T Get<T>()
        {
            return JsonConvert.DeserializeObject<T>(UTF8());
        }

        public NativeMessage(int length, byte[] data)
        {
            Length = length;
            Data = data;
        }

        public NativeMessage(string utf8)
        {
            byte[] data = Encoding.UTF8.GetBytes(utf8);

            Length = data.Length;
            Data = data;
        }

        public NativeMessage(object obj)
        {
            string utf8 = JsonConvert.SerializeObject(obj);
            byte[] data = Encoding.UTF8.GetBytes(utf8);

            Length = data.Length;
            Data = data;
        }

        public NativeMessage Send(Stream s = null)
        {
            if (s == null)
            {
                s = Console.OpenStandardOutput();
            }

            s.Write(BitConverter.GetBytes(Length), 0, sizeof(int));
            s.Write(Data, 0, Length);
            s.Flush();

            return this;
        }

        public static NativeMessage Read(Stream s = null)
        {
            if (s == null)
            {
                s = Console.OpenStandardInput();
            }

            byte[] i = new byte[sizeof(int)];
            s.Read(i, 0, sizeof(int));
            int len = BitConverter.ToInt32(i, 0);

            byte[] data = new byte[len];
            s.Read(data, 0, len);

            return new NativeMessage(len, data);
        }
    }
}
