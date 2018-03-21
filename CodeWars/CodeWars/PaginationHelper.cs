using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace CodeWars
{
    public class PaginationHelper<T>
    {

        /*
            For this exercise you will be strengthening your page-fu mastery. You will complete the PaginationHelper class, which is a utility class helpful for querying paging information related to an array.

            The class is designed to take in an array of values and an integer indicating how many items will be allowed per each page. The types of values contained within the collection/array are not relevant.

            The following are some examples of how this class is used:

            var helper = new PaginationHelper<char>(new List<char>{'a', 'b', 'c', 'd', 'e', 'f'}, 4);
            helper.PageCount; //should == 2
            helper.ItemCount; //should == 6
            helper.PageItemCount(0); //should == 4
            helper.PageItemCount(1); // last page - should == 2
            helper.PageItemCount(2); // should == -1 since the page is invalid

            // pageIndex takes an item index and returns the page that it belongs on
            helper.PageIndex(5); //should == 1 (zero based index)
            helper.PageIndex(2); //should == 0
            helper.PageIndex(20); //should == -1
            helper.PageIndex(-10); //should == -1  
        */

        private readonly IList<T> collection;

        public IList<T> Collection => collection ?? new List<T>();

        private readonly int itemsPerPage;

        public int ItemsPerPage => itemsPerPage;

        /// <summary>
        /// Constructor, takes in a list of items and the number of items that fit within a single page
        /// </summary>
        /// <param name="collection">A list of items</param>
        /// <param name="itemsPerPage">The number of items that fit within a single page</param>
        public PaginationHelper(IList<T> collection, int itemsPerPage)
        {
            this.collection = collection;
            this.itemsPerPage = itemsPerPage;
        }

        /// <summary>
        /// The number of items within the collection
        /// </summary>
        public int ItemCount => Collection.Count;

        /// <summary>
        /// The number of pages
        /// </summary>
        public int PageCount => ItemCount / ItemsPerPage + 1;

        /// <summary>
        /// Returns the number of items in the page at the given page index 
        /// </summary>
        /// <param name="pageIndex">The zero-based page index to get the number of items for</param>
        /// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
        public int PageItemCount(int pageIndex)
        {
            if (pageIndex > PageCount - 1) return -1;
            if (pageIndex < PageCount - 1) return ItemsPerPage;

            return ItemCount % ItemsPerPage;
        }

        /// <summary>
        /// Returns the page index of the page containing the item at the given item index.
        /// </summary>
        /// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
        /// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
        public int PageIndex(int itemIndex)
        {
            if (itemIndex >= ItemCount || itemIndex < 0) return -1;

            var index = 0;
            for (int i = 1; i < ItemCount; i++)
                if (itemIndex < ItemsPerPage * (i))
                {
                    index = i-1;
                    break;
                }

            return index;
        }
    }
}
