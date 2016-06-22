﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame3Lib
{
    interface ICardPackageProvider
    {
        void CreateCardPackage();
        List<Card> GetCards();
    }
}