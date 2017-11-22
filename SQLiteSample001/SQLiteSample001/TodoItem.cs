using System;
using SQLite.Net.Attributes;

namespace SQLiteSample001
{
    public class TodoItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Delete { get; set; }
    }
}