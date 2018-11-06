using System.ComponentModel.DataAnnotations;

namespace  Cloud.BookList.CloudBookLists.BookLists.Dtos
{
    public class BookListEditDto
    {

        /// <summary>
        /// Id
        /// </summary>
        public long? Id { get; set; }         


        
		/// <summary>
		/// 书单名称
		/// </summary>
		[Required(ErrorMessage="书单名称不能为空")]
		public string Name { get; set; }



		/// <summary>
		/// 书单介绍
		/// </summary>
		public string Intro { get; set; }




    }
}