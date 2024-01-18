using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practicMVVM.DBModel;


namespace practicMVVM.Servise
{
    public class AuthService
    {
        public bool Authenticate(string username, string password)
        {
            using (var db = new KingITEntities())
            {
                if(db.employee.FirstOrDefault(u => u.login == username && u.password == password)!=null)
                {
                    return true;
                } else
                {
                    return false;
                }


            }
        }
    }


}
