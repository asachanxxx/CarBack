using CarAuctionSL.Model;
using CarAuctionSL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAuctionSL.UnitOfWorks
{
    public class SecurityManager
    {


        //public static async Task<bool> Login(string username, string password)
        //{
        //    RepoBase<User> db = new RepoBase<User>("Users");
        //    var user = db.FindExistance_ReturnObject("UserName", username).Result;
        //    if (user != null)
        //    {
        //        return await Task.FromResult<bool>(true);
        //    }
        //    else
        //    {
        //        return await Task.FromResult<bool>(true);
        //    }
        //}



        public static bool Login(string username, string password)
        {
            RepoBase<User> db = new RepoBase<User>("Users");
            var user=  db.FindExistance_ReturnObject("UserName", username);
            if (user != null)
            {
                if (password.Equals(user.Password))
                {
                    return true;

                }
                else {
                    return false;
                }

            }
            else {
                return false;
            }
        }


    }


  
}
