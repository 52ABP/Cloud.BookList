

using Abp.Domain.Services;

namespace Cloud.BookList
{
	public abstract class BookListDomainServiceBase : DomainService
	{
		/* Add your common members for all your domain services. */
		/*在领域服务中添加你的自定义公共方法*/





		protected BookListDomainServiceBase()
		{
			LocalizationSourceName = BookListConsts.LocalizationSourceName;
		}
	}
}
