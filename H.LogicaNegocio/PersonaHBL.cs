using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H.EntidadesNegocioEN;
using H.AccesoDatosDAL;


namespace H.LogicaDatosBL
{
    public class PersonaHBL
    {
        public static async Task<PersonaH> GetById(int id)
        {
            return await PersonaHDAL.GetById(id);
        }

        public static async Task<int> Create(PersonaH pPersona)
        {
            return await PersonaHDAL.Create(pPersona);
        }

        public static async Task<int> Update(PersonaH pPersona)
        {
            return await PersonaHDAL.Update(pPersona);
        }
        public static async Task<int> Delete(PersonaH pPersona)
        {
            return await PersonaHDAL.Delete(pPersona);
        }

        public static async Task<List<PersonaH>> GetAll()
        {
            return await PersonaHDAL.GetAll();
        }
    }
}
