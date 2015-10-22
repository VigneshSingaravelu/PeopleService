﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PeopleService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class AddressService : IGetAddressService
    {
        public Address[] GetAddressData(int value)
        {
            List<Address> addresses = new List<Address>();
            var creator = new PeopleConstants();
            for (int i = 0; i < value; i++)
            {
                var addy = creator.CreateAddress();
                addy.Id = i + 1;
                addresses.Add(addy);

            }

            return addresses.ToArray();
        }

    }
}