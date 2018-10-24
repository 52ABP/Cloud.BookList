
using AutoMapper;
using Cloud.BookList.CloudBookList.BookManagement;
using Cloud.BookList.CloudBookList.BookManagement.Dtos;

namespace Cloud.BookList.CloudBookList.BookManagement.Mapper
{

	/// <summary>
    /// 配置Book的AutoMapper
    /// </summary>
	internal static class BookMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap <Book,BookListDto>()
                .ForMember(o => o.TenancyName, options => options.Ignore())
                .ForMember(o => o.TenancyDisplayName, options => options.Ignore());
            configuration.CreateMap <BookListDto,Book>();

            configuration.CreateMap <BookEditDto,Book>();
            configuration.CreateMap <Book,BookEditDto>();

            configuration.CreateMap<Book, BookSelectListDto>()
                .ForMember(o => o.TenancyName, options => options.Ignore())
                .ForMember(o => o.TenancyDisplayName, options => options.Ignore())
                .ForMember(o => o.IsSelected, options => options.Ignore());


            configuration.CreateMap<Book, BookAndBookTagDto>()
              .ForMember(o => o.BookTags, options => options.Ignore());

        }
    }
}
