using System;
using System.Collections.Generic;
using System.Text;

namespace SampleInterfaceTesting
{
    class MockHeaderReaderNOK : IHeaderReader
    {
        public bool ReaderHeader()
        {
            return false;
        }
    }
}
