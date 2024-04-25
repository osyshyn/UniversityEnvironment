using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.ComponentModel.DataAnnotations;

namespace UniversityEnvironment.Data.Model
{
    public abstract class EnvironmentObject
    {
        [Key]
        private Guid _id;
        public Guid Id { get => _id; set => _id = value; }
        public EnvironmentObject()
        {
            _id = Guid.NewGuid();
        }
        public EnvironmentObject(Guid id)
        {
            _id = id;
        }
    }
}
