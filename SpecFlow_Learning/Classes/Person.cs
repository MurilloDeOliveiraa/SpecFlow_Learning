using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow_Learning.Classes
{
    public class Person
    {
        private (List<string> FirstName, List<string> LastName) Infos = (new List<string>(), new List<string>());
                
        public (List<string>, List<string>) GetInfos()
        {
            return Infos;
        }

        public void SetInfos((List<string> firstName, List<string> lastName) infos)
        {
            Infos.FirstName.Add(infos.firstName.ToString());
            Infos.LastName.Add(infos.lastName.ToString());
        }

    }
}
