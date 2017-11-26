using System;
using System.Collections.Generic;
using MVCLibraryproject.Abstract;
using MVCLibraryproject.Entities;

namespace MVCLibraryproject.Models
{
    public class RecordRepository : IRecordRepository
    {

        private static RecordRepository _RecordRepository = new RecordRepository();

        private List<Record> RecordList;

        private RecordRepository()
        {
            RecordList = new List<Record>();
        }

        public static RecordRepository Instance => _RecordRepository;

        public void AddRecord(Record record)
        {
            throw new NotImplementedException();
        }

        public Record GetRecord(string RecordID)
        {
            throw new NotImplementedException();
        }

        public List<Record> GetRecordList(string query)
        {
            throw new NotImplementedException();
        }

        public void RemoveRecord(Record record)
        {
            throw new NotImplementedException();
        }

        public void ReplaceRecord(Record previousRecord, Record currentRecord)
        {
            throw new NotImplementedException();
        }

        public int Size()
        {
            throw new NotImplementedException();
        }
    }
}
