using System;
using System.Collections.Generic;
using MVCLibraryproject.Abstract;
using MVCLibraryproject.Entities;

namespace MVCLibraryproject.Models
{
    public class MemberRepository : IMemberRepository
    {

        //private static MemberRepository MemberRepository = new MemberRepository();

        private List<Member> MemberList;

        private MemberRepository()
        {
            MemberList = new List<Member>();
        }

     //   public static MemberRepository Instance => MemberRepository;

    }
}
