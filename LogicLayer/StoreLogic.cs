﻿using DataAccess;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class StoreLogic
    {
        StoreDataAccess storeData = new StoreDataAccess();

        public List<String> returnIdStore()
        {
            return storeData.returnIdsStore();
        }

        public bool AddStores(Store store)
        {
            return storeData.AddStores(store);
        }
    }
}
