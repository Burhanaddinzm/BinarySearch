
using BinarySearch.Core.Models;
using BinarySearch.Service.Services.Interfaces;

namespace BinarySearch.Service.Services
{
    public class SearchingService : ISearchingService
    {
        public int Search()
        {
            SearchData searchData = new SearchData();

            int Value = 72;
            int Start = 0;
            int End = searchData.Numbers.Length - 1;

            while (Start <= End)
            {
                int Middle = (Start + End) / 2;
                if (searchData.Numbers[Middle] == Value)
                {
                    return Middle;
                }
                else if (searchData.Numbers[Middle] < Value)
                {
                    Start = Middle + 1;
                }
                else
                {
                    End = Middle - 1;
                }

            }
            return -1;
        }
    }
}
