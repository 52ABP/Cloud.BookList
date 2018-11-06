using AutoMapper;
using Cloud.BookList.CloudBookLists.BookLists.Dtos;

namespace Cloud.BookList.CloudBookLists.BookLists.Mapper
{

    /// <summary>
    /// 配置BookList的AutoMapper
    /// </summary>
    internal static class BookListMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<CloudBookList.BookListManagement.BookList, BookListListDto>();
            configuration.CreateMap<BookListListDto, CloudBookList.BookListManagement.BookList>();

            configuration.CreateMap<BookListEditDto, CloudBookList.BookListManagement.BookList>();
            configuration.CreateMap<CloudBookList.BookListManagement.BookList, BookListEditDto>();

            configuration.CreateMap<CloudBookList.BookListManagement.BookList, BookListShareDto>()
                .ForMember(o => o.UserName, options => options.Ignore())
                .ForMember(o => o.Books, options => options.Ignore());

        }
    }
}
