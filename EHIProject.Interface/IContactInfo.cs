using System;
using System.Collections.Generic;
using System.Linq;
using EHIProject.Models;

namespace EHIProject.Interface
{
    public interface IContacts
    {
        void SaveContact(MemberInfo info);
        void UpdateContact(MemberInfo info);
        IEnumerable<MemberInfo> ShowAllContact();
        int DeleteContact(int id);
        MemberInfo ContactByID(int id);
        bool CheckContactNameAlready(Guid Name);
    }
}