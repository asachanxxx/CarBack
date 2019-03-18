using CarAuctionSL.Model;
using CarAuctionSL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAuctionSL.UnitOfWorks
{
    public class LoadReferanceUOW
    {

        public async Task<IEnumerable<KeyValuePearWithbool>> LoadAllMilagesForDropDownsWithBool()
        {
            try
            {
                RepoBase<Make> MakeRepo = new RepoBase<Make>("Mileages");
                var retval = await MakeRepo.ReturnKeyValueWithBool("Id", "DisplayName");
                return retval;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<KeyValuePearWithbool>> LoadAllYearssForDropDownsWithBool()
        {
            try
            {
                RepoBase<Make> MakeRepo = new RepoBase<Make>("YearMasters");
                var retval = await MakeRepo.ReturnKeyValueWithBool("Id", "DisplayName");
                return retval;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task<IEnumerable<KeyValuePearWithbool>> LoadAllBodyTypeForDropDownsWithBool()
        {
            try
            {
                RepoBase<Make> MakeRepo = new RepoBase<Make>("BodyTypeMasters");
                var retval = await MakeRepo.ReturnKeyValueWithBool("Id", "DisplayName");
                return retval;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<KeyValuePearWithbool>> LoadAllMakesForDropDownsWithBool()
        {
            try
            {
                RepoBase<Make> MakeRepo = new RepoBase<Make>("Makes");
                var retval = await MakeRepo.ReturnKeyValueWithBool("Id", "DisplayName");
                return retval;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<KeyValuePear>> LoadAllMakesForDropDowns()
        {
            try
            {
                RepoBase<Make> MakeRepo = new RepoBase<Make>("Makes");
                var retval = await MakeRepo.ReturnKeyValue("Id", "DisplayName");
                return retval;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       

        public  async Task<IEnumerable<KeyValuePear>> LoadAllModelMasterRepoDropDowns(int MakeId)
        {
            try
            {
                RepoBase<ModelMaster> MakeRepo = new RepoBase<ModelMaster>("ModelMasters");
                var retval = await MakeRepo.ReturnKeyValueWithFK("Id", "DisplayName", "makeid" , MakeId.ToString());
                return retval;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public  async Task<IEnumerable<KeyValuePear>> LoadAllMilagesForDropDowns()
        {
            try
            {
                RepoBase<Mileage> MakeRepo = new RepoBase<Mileage>("Mileages");
                var retval = await MakeRepo.ReturnKeyValue("Id", "DisplayName", "Fromistance" , false);
                return retval;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public  async Task<IEnumerable<KeyValuePear>> LoadAllYearsForDropDowns()
        {
            try
            {
                RepoBase<YearMaster> MakeRepo = new RepoBase<YearMaster>("YearMasters");
                var retval = await MakeRepo.ReturnKeyValue("Id", "DisplayName", "Sequence", true);
                return retval;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public  async Task<IEnumerable<KeyValuePear>> LoadAllBodyTypeForDropDowns()
        {
            try
            {
                RepoBase<BodyTypeMaster> MakeRepo = new RepoBase<BodyTypeMaster>("BodyTypeMasters");
                var retval = await MakeRepo.ReturnKeyValue("Id", "DisplayName", "Sequence", true);
                return retval;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<KeyValuePear>> LoadAllmilagesForDropDowns()
        {
            try
            {
                RepoBase<BodyTypeMaster> MakeRepo = new RepoBase<BodyTypeMaster>("Mileages");
                var retval = await MakeRepo.ReturnKeyValue("Id", "DisplayName", "DisplayName", true);
                return retval;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        

        public  async Task<IEnumerable<Key2ValuePear>> LoadAllCarseForDropDowns()
        {
            try
            {
                RepoBase<ItemMaster> MakeRepo = new RepoBase<ItemMaster>("ItemMasters");
                var retval = await MakeRepo.ReturnKey2Value("Id", "DisplayName", "MakeId", "DisplayName", true);
                return retval;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public  async Task<IEnumerable<KeyValuePear>> LoadAllCitiesForDropDowns()
        {
            try
            {
                RepoBase<City> MakeRepo = new RepoBase<City>("Cities");
                var retval = await MakeRepo.ReturnKeyValue("Id", "DisplayName");
                return retval;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public  async Task<IEnumerable<KeyValuePear>> LoadAllTownsForDropDowns(int cityid)
        {
            try
            {
                RepoBase<Town> MakeRepo = new RepoBase<Town>("Towns");
                var retval = await MakeRepo.ReturnKeyValueWithFK("Id", "DisplayName", "CityId", cityid.ToString());
                return retval;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
