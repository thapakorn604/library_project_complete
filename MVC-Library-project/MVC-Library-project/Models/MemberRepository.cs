using System;
using System.Collections.Generic;
using MVCLibraryproject.Abstract;
using MVCLibraryproject.Entities;

namespace MVCLibraryproject.Models
{
    public class MemberRepository : IMemberRepository
    {

        private static MemberRepository _MemberRepository = new MemberRepository();

        private List<Member> MemberList;

        private MemberRepository()
        {
            MemberList = new List<Member>();
        }

        public static MemberRepository Instance => _MemberRepository;

        public void AddMember(Member member)
        {
            throw new NotImplementedException();
        }

        public Member GetMember(string MemberID)
        {
            throw new NotImplementedException();
        }

        public List<Member> GetMemberList(string query)
        {
            throw new NotImplementedException();
        }

        public void RemoveMember(Member member)
        {
            throw new NotImplementedException();
        }

        public void ReplaceMember(Member previousMember, Member currentMember)
        {
            throw new NotImplementedException();
        }

        public int Size()
        {
            throw new NotImplementedException();
        }
    }
}
