
using Abp.Runtime.Validation;
using Cloud.BookList.Dtos;
using Cloud.BookList.CloudBookList.BookManagement;

namespace Cloud.BookList.CloudBookList.BookManagement.Dtos
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
