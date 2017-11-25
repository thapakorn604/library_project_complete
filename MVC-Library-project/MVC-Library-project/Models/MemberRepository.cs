using System;
using MVCLibraryproject.Abstract;

namespace MVCLibraryproject.Models
{
    public class MemberRepository : IMemberRepository
    {

        private static MemberRepository MemberRepository = new MemberRepository();

        private List<Member> MemberList;

        private MemberRepository()
        {
            MemberList = new List<Member>();
        }

        public static MemberRepository Instance => MemberRepository;

    }
}
