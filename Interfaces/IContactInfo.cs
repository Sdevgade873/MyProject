using System;
using System.Collections.Generic;
using System.Linq;
using EHIPRoject.Models;


namespace EHIProject.Interfaces
{
    public interface IGetContact
    {
        void SaveContact(MemberInfo info);
        void UpdateContact(MemberInfo info);
        IQueryable<MemberInfo> ShowContact(string sortColumn, string sortColumnDir, string Search);
        IEnumerable<MemberInfo> ShowAllContact();
        int DeleteContact(int id);
        MemberInfo ContactByID(int id);
        bool CheckContactNameAlready(string venueName);
    }
}
