using IBMiX.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBMiX.Model
{
    public class Book : IBook
    {
        public string Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public float Price { get; set; }
        public DateTime PublishDate { get; set; }
        public string Description { get; set; }
    }
}
