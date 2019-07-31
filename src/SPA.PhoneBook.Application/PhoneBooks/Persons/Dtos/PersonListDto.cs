

using System;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using SPA.PhoneBook.PhoneBooks.Persons;
using System.Collections.Generic;
using SPA.PhoneBook.PhoneBooks.PhoneNumbers;

namespace SPA.PhoneBook.PhoneBooks.Persons.Dtos
{
    public class PersonListDto : FullAuditedEntityDto 
    {

        
		/// <summary>
		/// Name
		/// </summary>
[MaxLength(PhoneBookConsts.MaxNameLength)]
		[Required(ErrorMessage="Name不能为空")]
		public string Name { get; set; }



		/// <summary>
		/// EmailAddress
		/// </summary>
[MaxLength(PhoneBookConsts.MaxEmailAddressLength)]
		public string EmailAddress { get; set; }



		/// <summary>
		/// Address
		/// </summary>
[MaxLength(PhoneBookConsts.MaxAdressLength)]
		public string Address { get; set; }



		/// <summary>
		/// PhoneNumbers
		/// </summary>
		public ICollection<PhoneNumber> PhoneNumbers { get; set; }




    }
}