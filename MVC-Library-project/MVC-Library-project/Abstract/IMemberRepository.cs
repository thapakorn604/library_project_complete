using System;
using System.Collections.Generic;
using MVCLibraryproject.Entities;

namespace MVCLibraryproject.Abstract
{
    public interface IMemberRepository
    {
        void AddMember(Member member);
        void RemoveMember(Member member);
        void ReplaceMember(Member previousMember, Member currentMember);
        Member GetMember(String MemberID);
        List<Member> GetMemberList(string query);
        int Size();
    }
}
