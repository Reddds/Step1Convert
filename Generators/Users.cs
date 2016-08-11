using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Step1Convert.Generators
{
    class Users : XmlGenerator
    {
        public Users()
        {
            var users = CreateDocument("users");
        }
    }
}
