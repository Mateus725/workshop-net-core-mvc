﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Seller
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double Salary { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> Sale { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthDate, double salary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            Salary = salary;
            Department = department;
        }

        public void AddSales(SalesRecord sr)
        {
            Sale.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {
            Sale.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {

            return Sale.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);

        }

    }
}
