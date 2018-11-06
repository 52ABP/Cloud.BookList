using AutoMapper;
using Cloud.BookList.CloudBookLists.BookTags.Dtos;

namespace Cloud.BookList.CloudBookLists.BookTags.Mapper
{

    /// <summary>
    /// 配置BookTag的AutoMapper
    /// </summary>
    internal static class BookTagMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<BookTag, BookTagListDto>()
                .ForMember(o => o.TenancyName, options => options.Ignore())
                .ForMember(o => o.TenancyDisplayName, options => options.Ignore());
            configuration.CreateMap<BookTagListDto, BookTag>();

            configuration.CreateMap<BookTagEditDto, BookTag>();
            configuration.CreateMap<BookTag, BookTagEditDto>();

            configuration.CreateMap<BookTag, BookTagSelectListDto>()
               .ForMember(o => o.TenancyName, options => options.Ignore())
               .ForMember(o => o.TenancyDisplayName, options => options.Ignore())
               .ForMember(o => o.IsSelected, options => options.Ignore());

        }
    }
}
