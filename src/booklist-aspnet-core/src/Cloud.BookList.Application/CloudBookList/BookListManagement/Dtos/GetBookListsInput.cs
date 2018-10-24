
using Abp.Runtime.Validation;
using Cloud.BookList.Dtos;
using Cloud.BookList.CloudBookList.BookListManagement;

namespace Cloud.BookList.CloudBookList.BookListManagement.Dtos
{
    public class GetBookListsInput : PagedSortedAndFilteredInputDto, IShouldNormalize
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
