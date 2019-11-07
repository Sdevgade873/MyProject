using System;
using EHIProject.Interface;
using EHIProject.Models;
using EHIProject.DataConcreate;
using System.Collections.Generic;
using System.Linq;

namespace EHIProject.ConcreateOperation
{
    public class ContactInfoConcreate : IContacts

    {
        private DatabaseContext _context;
        public ContactInfoConcreate(DatabaseContext context)
        {
            _context = context;
        }

        public bool CheckContactNameAlready(Guid UserId)
        {
            var ContactCount = (from data in _context.dataMemberInfo
                              where data.Id == UserId
                              select data).Count();

            if (ContactCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public MemberInfo ContactByID(int id)
        {
            try
            {
                MemberInfo contactmemberinfo = _context.dataMemberInfo.Find(id);
                return contactmemberinfo;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int DeleteContact(int id)
        {
            try
            {
                MemberInfo contact = _context.dataMemberInfo.Find(id);
                _context.dataMemberInfo.Remove(contact);
                return _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void SaveContact(MemberInfo info)
        {
            try
            {
                _context.dataMemberInfo.Add(info);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<MemberInfo> ShowAllContact()
        {
            return _context.dataMemberInfo.ToList();
        }

        public void UpdateContact(MemberInfo info)
        {
            try
            {
                if (info.Id != null)
                {
                    _context.Entry(info).Property(x => x.FirstName).IsModified = true;
                    _context.Entry(info).Property(x => x.LastName).IsModified = true;
                    _context.Entry(info).Property(x => x.Email).IsModified = true;
                    _context.Entry(info).Property(x => x.PhoneNumber).IsModified = true;
                    _context.Entry(info).Property(x => x.Address).IsModified = true;
                    _context.Entry(info).Property(x => x.PostalCode).IsModified = true;
                    _context.Entry(info).Property(x => x.Status).IsModified = true;
                    _context.SaveChanges();

                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
