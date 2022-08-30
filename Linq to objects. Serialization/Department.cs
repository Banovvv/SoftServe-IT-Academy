using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SoftServe_IT_Academy.Linq_to_objects._Serialization
{
    public class Department
    {
        public Department()
        {
        }

        public Department(string Name, int Id, Worker Manager)
        {
            this.Name = Name;
            this.Id = Id;
            this.Manager = Manager;
        }

        public string Name { get; set; }
        public int Id { get; set; }
        public Worker Manager { get; set; }
    }

    public class Worker
    {
        public Worker()
        {
        }

        public Worker(string Name, decimal Salary, Department department)
        {
            this.Name = Name;
            this.Salary = Salary;
            this.Department = department;
        }

        [JsonIgnore]
        public int Id { get; set; }
        [JsonPropertyName("Full name")]
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Department Department { get; set; }

        public string Serialize() => JsonSerializer.Serialize<Worker>(this, new JsonSerializerOptions { WriteIndented = true, IgnoreNullValues = true });
        public static Worker Deserialize(string param) => JsonSerializer.Deserialize<Worker>(param);
    }
}
