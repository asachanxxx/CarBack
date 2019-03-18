using CarAuctionSL.Model;
using CarAuctionSL.Model.ViewModels;
using CarAuctionSL.Repository;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CarAuctionSL.UnitOfWorks.Process
{
    public class ItemSearchUOM
    {
        RepoBase<ItemListingVM> Db;
        public ItemSearchUOM()
        {
            Db = new RepoBase<ItemListingVM>("ItemMasters");
            Conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SysConn"].ConnectionString);
        }

        public IDbConnection Conn;// = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SysConn"].ConnectionString);





        public async Task<IEnumerable<ItemListingVM>> GetItemList() {
            try
            {
                return  await Db.FindALLViaStorePrcedure();
            }
            catch (Exception ex) {
                throw ex;
            }

        }

        public async Task<IEnumerable<SaveReturnVM>> GetSaveItemPartial(ItemMaster model)
        {

            try
            {
                string xml = ObjectToXMLGeneric(model);
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@xml", xml);
                string sql = "SP_Process_SaveItemPArtial";

                using (IDbConnection db = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SysConn"].ConnectionString))
                {
                    var val = await db.QueryAsync<SaveReturnVM>(sql, queryParameters,commandType: CommandType.StoredProcedure);
                    return val;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }


        public async Task<IEnumerable<SaveReturnVM>> GetSaveItemFull(ItemDetailFullVM model)
        {
            try
            {

                string xml = ObjectToXMLGeneric(model);
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@xml", xml);
                string sql = "SP_Process_SaveItemFull";


                
                using (IDbConnection db = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SysConn"].ConnectionString))
                {
                    var val = await db.QueryAsync<SaveReturnVM>(sql, queryParameters, commandType: CommandType.StoredProcedure);
                    return val;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public static String ObjectToXMLGeneric<T>(T filter)
        {

            string xml = null;
            using (StringWriter sw = new StringWriter())
            {

                XmlSerializer xs = new XmlSerializer(typeof(T));
                xs.Serialize(sw, filter);
                try
                {
                    xml = sw.ToString();

                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            return xml;
        }


    }
}
