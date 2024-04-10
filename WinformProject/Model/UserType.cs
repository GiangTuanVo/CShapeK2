using System.Text;

namespace WinformProject
{
    public class UserType : LibConnection.IDataTransfer
    {
        private LibConnection.Core.IByteTransform ByteTransform = new LibConnection.Core.RegularByteTransform();
        public ushort ReadCount => 10;

        public void ParseSource(byte[] Content)
        {
            int count = ByteTransform.TransInt32(Content, 0);
            float temp = ByteTransform.TransSingle(Content, 4);
            short name1 = ByteTransform.TransInt16(Content, 8);
            string barcode = Encoding.ASCII.GetString(Content, 10, 10);
        }

        public byte[] ToSource()
        {
            byte[] buffer = new byte[20];
            ByteTransform.TransByte(count).CopyTo(buffer, 0);
            ByteTransform.TransByte(temp).CopyTo(buffer, 4);
            ByteTransform.TransByte(name1).CopyTo(buffer, 8);
            Encoding.ASCII.GetBytes(barcode).CopyTo(buffer, 10);
            return buffer;
        }
        public int count { get; set; }

        public float temp { get; set; }

        public short name1 { get; set; }

        public string barcode { get; set; }
    }
}
