using Abp.Runtime.Validation;
using Cloud.BookList.Dtos;

namespace Cloud.BookList.CloudBookLists.Books.Dtos
{
    public class GetBooksInput : PagedSortedAndFilteredInputDto, IShouldNormalize
    {

        /// <summary>
        /// 正常化排序使用
        /// </summary>
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
        }

    }
}
