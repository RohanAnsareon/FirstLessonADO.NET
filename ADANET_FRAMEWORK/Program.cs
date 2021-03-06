﻿using ADANET_FRAMEWORK.Models;
using ADANET_FRAMEWORK.Repos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADANET_FRAMEWORK {
    class Program {
        static void Main(string[] args) {
            var connString = ConfigurationManager.ConnectionStrings["Default"];

            var repo = new UserRepo(connString);

            //repo.DeleteMultipleWithTransaction(new List<int> { 22, 23, 24, -5 });

            var id = repo.Create(new User
            {
                Name = "Nikolay",
                Age = 24
            });

            //Console.WriteLine(repo.Read(id));

            //repo.Update(id, new User
            //{
            //   Name = "John Doe",
            //   Age = 25
            //});

            //Console.WriteLine(repo.Read(id));

            //repo.Delete(id);
        }
    }
}
