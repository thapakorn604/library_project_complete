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
           RecordList.Add(record);
        }

        public Record GetRecord(string recordID)
        {
            foreach (Record item in RecordList)
            {
                if (item.ID.Equals(recordID))
                {
                    return item;
                }
            }
            return null;
        }

        public List<Record> GetRecordList(string query)
        {
            switch (query.ToLower())
            {
                case "all":
                    return RecordList;
                default:
                    return null;
            }
        }

        public void RemoveRecord(Record record)
        {
            RecordList.Remove(record);   
        }

        public void ReplaceRecord(Record previousRecord, Record currentRecord)
        {
            int index = -1;
            for (int i = 0; i < RecordList.Count; i++)
            {
                if (RecordList[i].ID.Equals(previousRecord))
                {
                    index = i;
                }
            }
            RecordList.Remove(previousRecord);
            RecordList.Insert(index, currentRecord);
        }

        public int Size => RecordList.Count;
    }
}
