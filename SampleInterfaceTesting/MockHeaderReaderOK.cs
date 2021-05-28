using System;
using System.Collections.Generic;
using System.Text;

namespace SampleInterfaceTesting
{
    class MockHeaderReaderOK : IHeaderReader
    {
        public bool ReaderHeader()
        {
            return true;
        }
    }
}
