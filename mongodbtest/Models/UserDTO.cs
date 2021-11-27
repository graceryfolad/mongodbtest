using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mongodbtest.Models
{
    public class UserDTO
    {
        public UserDTO()
        {
            address = new AddressDTO();
        }

  //      "id": "32215c1a-10d7-454d-a7ef-a3703cd528ba",

  //"name": "Leanne Graham",

  //"username": "Bret",

  //"phone": "12345678",

  //"email": Sincere @april.biz,

  //"address": {

        public Guid id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string phone { get; set; }
        public AddressDTO address { get; set; }
    }

    public class AddressDTO
    {
        //    "id": "9a9738ad-26d5-4b35-898e-8a58faba01a4",

        //"street": "Kulas Light",

        //"city": "Gwenborough",

        //"zipcode": "92998-3874"

        public Guid id { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string zipcode { get; set; }


    }

    }
