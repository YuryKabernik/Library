﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryObjects.Books
{
    class Technical : AbstractBook<Technical>
    {
        public override void Change()
        {
            throw new NotImplementedException();
        }
    }
}
