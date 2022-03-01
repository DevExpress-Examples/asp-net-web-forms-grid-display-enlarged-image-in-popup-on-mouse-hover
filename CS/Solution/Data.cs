using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solution
{
    public class Data
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }

    public class DataHelper
    {
        public static List<Data> GenerateData()
        {
            return new List<Data>() {
                new Data() { ID = 0, Description = "Basket", ImageUrl = @"Images/Basket.png" },
                new Data() { ID = 1, Description = "Customer", ImageUrl = @"Images/Customer.png" },
                new Data() { ID = 2, Description = "Home", ImageUrl = @"Images/Home.png" },
                new Data() { ID = 3, Description = "Mail", ImageUrl = @"Images/Mail.png" },
                new Data() { ID = 4, Description = "Check", ImageUrl = @"Images/Check.png" },
                new Data() { ID = 5, Description = "Folder", ImageUrl = @"Images/Folder.png" },
                new Data() { ID = 6, Description = "Key", ImageUrl = @"Images/Key.png" },
                new Data() { ID = 7, Description = "Printing", ImageUrl = @"Images/Printing.png" }
            };
        }
    }
}