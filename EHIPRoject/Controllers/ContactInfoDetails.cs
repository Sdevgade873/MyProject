using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EHIProject.Models;
using EHIProject.Interface;

namespace EHIPRoject.Controllers
{
    public class ContactInfoDetails : ApiController
    {
        // GET api/values
        private IContacts _contact;
        private MemberInfo _contactdetails;

        public ContactInfoDetails(IContacts contact,MemberInfo contactdetails)
        {
            _contact = contact;
            _contactdetails = contactdetails;
        }

        // GET api/values/5
        public MemberInfo GetByID(int id)
        {
            // MemberInfo  = new MemberInfo();
            _contactdetails = _contact.ContactByID(id);

            return _contactdetails;
        }

        // POST api/values
        [HttpPost]
        public void SaveContact([FromBody]MemberInfo value)
        {
            _contact.SaveContact(value);
        }

        // PUT api/values/5
        [HttpPut]
        public void Put([FromBody]MemberInfo value)
        {
            _contact.UpdateContact(value);
        }

        // DELETE api/values/5
        [HttpDelete]
        public void Delete(int id)
        {
            _contact.DeleteContact(id);
        }
    }
}
