
using Abp.Runtime.Validation;
using Cloud.BookList.Dtos;
using Cloud.BookList.CloudBookList.BookTagManagement;

namespace Cloud.BookList.CloudBookList.BookTagManagement.Dtos
{
    public class GetBookTagsInput : PagedSortedAndFilteredInputDto, IShouldNormalize
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
