namespace Cloud.BookList.CloudBookLists.BookTags.Dtos
{
    public class BookTagSelectListDto : BookTagListDto
    {
        /// <summary>
        /// 是否已选择
        /// </summary>
        public bool IsSelected { get; set; }
    }
}
