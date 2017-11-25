using System;
using MVCLibraryproject.Abstract;

namespace MVCLibraryproject.Models
{
    public class RecordRepository : IRecordRepository
    {

        private static RecordRepository RecordRepository = new RecordRepository();

        private List<Record> RecordList;

        private RecordRepository()
        {
            RecordList = new List<Record>();
        }

        public static RecordRepository Instance => RecordRepository;

    }
}
