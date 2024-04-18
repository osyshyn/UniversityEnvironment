using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft;
using Newtonsoft.Json;
using UniversityEnvironment.Interfaces;
using System.Xml.Linq;

namespace UniversityEnvironment.Models
{
    public abstract class EnvironmentObject : IManualWritingToFile
    {
        private Guid _id;
        public Guid Id { get => _id; set => _id = value; }
        public EnvironmentObject()
        {
            _id = Guid.NewGuid();
        }

        public virtual string GetJson()
        {
            return "";
        }
    }
}
