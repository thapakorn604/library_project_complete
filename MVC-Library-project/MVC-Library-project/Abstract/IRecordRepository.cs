using System;
using System.Collections.Generic;
using MVCLibraryproject.Entities;

namespace MVCLibraryproject.Abstract
{
    public interface IRecordRepository
    {
        void AddRecord(Record record);
        void RemoveRecord(Record record);
        void ReplaceRecord(Record previousRecord, Record currentRecord);
        Record GetRecord(String RecordID);
        List<Record> GetRecordList(string query);
        int Size();
    }
}
