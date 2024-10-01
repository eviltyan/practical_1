using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_1
{
    public class FileDescription
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public DateTime DateTimeModification { get; set; }
        public string isDirectory { get; set; }

        public FileDescription(string Name = "Unnamed", int Size = 0, DateTime DateTimeModification = new DateTime(), string isDirectory = "file")
        {
            this.Name = Name;
            this.Size = Size;
            this.DateTimeModification = DateTimeModification;
            if (this.Name.Contains('.'))
            {
                this.isDirectory = "file";
            }
            else
                this.isDirectory = "folder";
        }
    }
}
