using System;
using System.Collections.Generic;
using MVCLibraryproject.Abstract;
using MVCLibraryproject.Entities;

namespace MVCLibraryproject.Models
{
    public class RecordRepository : IRecordRepository
    {

      //  private static RecordRepository RecordRepository = new RecordRepository();

        private List<Record> RecordList;

        private RecordRepository()
        {
            RecordList = new List<Record>();
        }

      //  public static RecordRepository Instance => RecordRepository;

    }
}
