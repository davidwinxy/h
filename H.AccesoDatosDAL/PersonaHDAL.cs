using H.EntidadesNegocioEN;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.AccesoDatosDAL
{
    public class PersonaHDAL
    {

        public static async Task<PersonaH> GetById(int id)
        {
            var personas = new PersonaH();
            using (var bdContext = new ComunDB())
            {
                personas = await bdContext.PersonasH.FirstOrDefaultAsync(s => s.Id == id);
            }
            return personas;
            
        }

        public static async Task<int> Create(PersonaH pPersona)
        {
            int result = 0;
            using (var bdContext = new ComunDB())
            {
                bdContext.Add(pPersona);
                result = await bdContext.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<int> Update(PersonaH pPersona)
        {
            int result = 0;
            using (var DbContext = new ComunDB())
            {
                var datos = await DbContext.PersonasH.FirstOrDefaultAsync(r => r.Id == pPersona.Id);

                datos.NombreH = pPersona.NombreH;
                datos.ApellidoH = pPersona.ApellidoH;
                datos.FechaNacimientoH = pPersona.FechaNacimientoH;
                datos.SueldoH = pPersona.SueldoH;
                datos.EstatusH = pPersona.EstatusH;
                datos.ComentarioH = pPersona.ComentarioH;
                DbContext.Update(datos);
                result = await DbContext.SaveChangesAsync();
            }
            return result;
        }

        public static async Task<int> Delete(PersonaH pPersona)
        {
            int result = 0;
            using (var bdContext = new ComunDB())
            {
               
                bdContext.Remove(pPersona);
                result = await bdContext.SaveChangesAsync();
            }
            return result;
        }

        public static async Task<List<PersonaH>> GetAll()
        {
            var personas = new List<PersonaH>();
            using (var bdContext = new ComunDB())
            {
                personas = await bdContext.PersonasH.ToListAsync();
            }
            return personas;
        }
    }

}

