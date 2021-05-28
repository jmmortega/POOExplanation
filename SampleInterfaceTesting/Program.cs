using System;

namespace SampleInterfaceTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        private void TestOK()
        {
            var isHeader = ReadHeader(new MockHeaderReaderOK());

            if(isHeader)
            {

            }
            else
            {

            }
        }

        private void TestNOK()
        {
            var isHeader = ReadHeader(new MockHeaderReaderNOK());
        }

        private bool ReadHeader(IHeaderReader headerReader)
        {
            return headerReader.ReaderHeader();
        }
    }
}
