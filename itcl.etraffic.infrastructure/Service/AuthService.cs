using itcl.etraffic.application.Interface;
using itcl.etraffic.application.ViewDto;
using itcl.etraffic.domain.Entity;
using itcl.etraffic.persistance.DataConnection;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itcl.etraffic.infrastructure.Service
{
    public class AuthService : IAuth
    {

        private readonly DMPDBContext _dmpdbcontext;

        public AuthService(DMPDBContext dmpdbcontext)
        {
            _dmpdbcontext = dmpdbcontext;
        }
        public async Task<(string Message, bool Status, List<RoleGetAllDto> rolelist)> getRoleDataAsync()
        {
            try
            {
                var whereParam = new SqlParameter("@WhereClause", DBNull.Value);
                var orderParam = new SqlParameter("@OrderBy", DBNull.Value);
                var result = await _dmpdbcontext.RoleGetAllDto
                               .FromSqlRaw("EXEC RoleGetAll @WhereClause, @OrderBy", whereParam, orderParam)
                               .AsNoTracking()
                               .ToListAsync();

                return ("Data Retrieved Successfully.", true, result);

            }
            catch (Exception ex)
            {
                string actionName = $"{nameof(AuthService)}.{nameof(getRoleDataAsync)}";
                return ($"{actionName} : {ex.Message}", false, new List<RoleGetAllDto>());
            }
        }
    }
}
