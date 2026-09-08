using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task3
{

    public class GenericListManager<T>
    {
        List<T> iteams= new List<T>();
        List<string> logs= new List<string>();
        DateTime? LastCreditAt;
        DateTime? LastSearchAt;

        public void Add(T iteam)
        {
            iteams.Add(iteam);
            LastCreditAt = DateTime.Now;
            logs.Add("New item added at '2026-07-14 10:30:00'");
            
        }
        public void Edit(Predicate<T> predicate,T UpdatedIteam )
        {
            int value = iteams.FindIndex(predicate);
            if (value != -1) {
                iteams[value]= UpdatedIteam;
                logs.Add("Item edited at '2026-07-14 10:35:00'");
            }
           
        }
        public void Delete(Predicate<T> predicate)
        {
            int value = iteams.FindIndex(predicate);
            if (value != -1)
            {
                iteams.RemoveAt(value);
                logs.Add("Item deleted at '2026-07-14 10:40:00'");
            }
        }
        public T?   Find(Predicate<T> predicate)
        {
            LastSearchAt = DateTime.Now;

            foreach (T iteam in iteams)
            {
                if (predicate(iteam))
                {
                    return  iteam;
                }
            }
            return default;
        }
       public  List<T> Where(Predicate<T> predicate)
        {
            LastSearchAt = DateTime.Now;
            List<T> results = new List<T>();
            for (int i = 0; i < iteams.Count; i++) {
                if(predicate(iteams[i]))
                {
                    results.Add(iteams[i]);
                }

            }
            return results;
        }
        public int GetCount()
        {
            return iteams.Count;
        }
        public DateTime? GetLastCreatedAt()
        {
            return LastCreditAt;
        }
        public DateTime? GetLastSearchAt()
        {
            return LastSearchAt;
        }
        public List<string> GetLogs()
        {
              return logs;
        }



    };
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary}";
        }
    }
    public class Client
    {
         public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Email: {Email}";
        }
    }
}
