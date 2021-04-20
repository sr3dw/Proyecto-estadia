using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAppConcentracionDeCargaHoraria.Models
{
    public class clsUsuarios
    {
        BDDistribucionDeCargasHorariasEntities context = new BDDistribucionDeCargasHorariasEntities();
        public string Registrar(tblUsuarios user) {
            string r=String.Empty;
            try
            {
                context.spInsertUsuarios(user.vchEmail, user.vchPass);
                r = "ok";
            }
            catch (Exception ex)
            {
                r = ex.Message;
                throw;
            }
            return r;
        }
    }
}