
using Abp.Runtime.Validation;
using SPA.PhoneBook.Dtos;
using SPA.PhoneBook.PhoneBooks.Persons;

namespace SPA.PhoneBook.PhoneBooks.Persons.Dtos
{
    public class GetPersonsInput : PagedSortedAndFilteredInputDto, IShouldNormalize
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
