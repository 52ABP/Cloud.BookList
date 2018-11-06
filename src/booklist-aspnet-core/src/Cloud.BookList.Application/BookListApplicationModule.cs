using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Cloud.BookList.Authorization;
using Cloud.BookList.CloudBookLists.BookLists.Mapper;
using Cloud.BookList.CloudBookLists.Books.Authorization;
using Cloud.BookList.CloudBookLists.Books.Mapper;
using Cloud.BookList.CloudBookLists.BookTags.Authorization;
using Cloud.BookList.CloudBookLists.BookTags.Mapper;

namespace Cloud.BookList
{
    [DependsOn(
        typeof(BookListCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class BookListApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<BookListAuthorizationProvider>();


            #region 云书单权限

            // 书籍标签权限
            Configuration.Authorization.Providers.Add<BookTagAuthorizationProvider>();

            // 书籍权限
            Configuration.Authorization.Providers.Add<BookAuthorizationProvider>();

            // 书单权限
          Configuration.Authorization.Providers.Add<CloudBookLists.BookLists.Authorization.BookListAuthorizationProvider>();

            #endregion


            // 自定义类型映射
            Configuration.Modules.AbpAutoMapper().Configurators.Add(configuration =>
            {

                #region 云书单Mapper

                // 书籍标签
                BookTagMapper.CreateMappings(configuration);

                // 书籍
                BookMapper.CreateMappings(configuration);

                // 书单
                BookListMapper.CreateMappings(configuration);

                #endregion

            });
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(BookListApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
