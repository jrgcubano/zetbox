using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace API.Server.Tests
{
    public class CustomActionsManagerAPITest : Kistl.API.ICustomActionsManager
    {
        public void AttachEvents(Kistl.API.IDataObject obj)
        {
            // Do nothing!
        }

        public void Init()
        {
            // Do nothing!
        }
    }
}
