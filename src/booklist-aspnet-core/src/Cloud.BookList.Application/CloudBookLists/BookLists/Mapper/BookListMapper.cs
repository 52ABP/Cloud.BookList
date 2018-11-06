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
            configuration.CreateMap<BookList, BookListListDto>();
            configuration.CreateMap<BookListListDto, BookList>();

            configuration.CreateMap<BookListEditDto, BookList>();
            configuration.CreateMap<BookList, BookListEditDto>();

            configuration.CreateMap<BookList, BookListShareDto>()
                .ForMember(o => o.UserName, options => options.Ignore())
                .ForMember(o => o.Books, options => options.Ignore());

        }
    }
}
