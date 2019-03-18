using CarAuctionSL.Model;
using CarAuctionSL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAuctionSL.UnitOfWorks
{
    public class ExistanceCheckUOW
    {
        public static async Task<bool> CheckUserEsitanceViaEmail(string Email)
        {
            try
            {
                if (Email.Trim() != string.Empty)
                {
                    RepoBase<User> MakeRepo = new RepoBase<User>("Makes");
                    var retval = await MakeRepo.FindExistance("Email", Email);
                    return retval;
                }
                else {

                    return false;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static async Task<bool> CheckUserEsitanceViaMobile(string Mobile)
        {
            try
            {
                if (Mobile.Trim() != string.Empty)
                {
                    RepoBase<User> MakeRepo = new RepoBase<User>("Makes");
                    var retval = await MakeRepo.FindExistance("Mobile", Mobile);
                    return retval;
                }
                else
                {

                    return false;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
