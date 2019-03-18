using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAuctionSL.Model;

namespace CarAuctionSL.Repository
{
    public interface IRepoBase<T> where T:class
    {
        Task<T> Find(int Id);
        Task<IEnumerable<T>> FindALL();
        Task<int> Save(T Entity, int Action);
        Task<bool> Delete(T Entity);
        Task<bool> Delete(int Id);

        Task<IEnumerable<KeyValuePear>> ReturnKeyValue(string _IdField, string _ValueFIeld);

    }
}
