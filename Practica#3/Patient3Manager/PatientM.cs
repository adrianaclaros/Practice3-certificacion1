using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient3Manager
{
    public class PatientM
    {
        public string GeneratePatientCode(string name, string lastName, string ci)
        {
            string initials = $"{name[0]}{lastName[0]}"; // Extraer las iniciales del nombre y apellido
            return $"{initials.ToUpper()}-{ci}";
        }
    }
}
