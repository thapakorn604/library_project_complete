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
            MemberList.Add(new Member("MEMBER-1", "Carol", "Childers", "female", "0000000000", "cchilders", "cchilders"));
            MemberList.Add(new Member("MEMBER-2", "Esther", "Brown", "female", "0000000000", "ebrown", "ebrown"));
            MemberList.Add(new Member("MEMBER-3", "William", "James", "male", "0000000000", "wjames", "wjames"));
            MemberList.Add(new Member("MEMBER-4", "David", "Scott", "male", "0000000000", "dscott", "dscott"));
            MemberList.Add(new Member("MEMBER-5", "Doretta", "Campbell", "female", "0000000000", "dcampbell", "dcampbell"));
        }

        public static MemberRepository Instance => _MemberRepository;

        public void AddMember(Member member)
        {
            MemberList.Add(member);
        }

        public Member GetMember(string memberID)
        {
            foreach (Member item in MemberList)
            {
                if (item.ID.Equals(memberID))
                {
                    return item;
                }
            }
            return null;
        }

        public List<Member> GetMemberList(string query)
        {
            switch (query.ToLower())
            {
                case "all":
                    return MemberList;
                default:
                    return null;
            }
        }

        public void RemoveMember(Member member)
        {
            MemberList.Remove(member);
        }

        public void ReplaceMember(Member previousMember, Member currentMember)
        {
            int index = -1;
            for (int i = 0; i < MemberList.Count; i++)
            {
                if (MemberList[i].ID.Equals(previousMember))
                {
                    index = i;
                }
            }
            MemberList.Remove(previousMember);
            MemberList.Insert(index, currentMember);
        }

        public int Size()
        {
            return MemberList.Count;
        }
    }
}
