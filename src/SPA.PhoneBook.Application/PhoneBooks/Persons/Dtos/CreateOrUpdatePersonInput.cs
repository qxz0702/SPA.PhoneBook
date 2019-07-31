

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SPA.PhoneBook.PhoneBooks.Persons;

namespace SPA.PhoneBook.PhoneBooks.Persons.Dtos
{
    public class CreateOrUpdatePersonInput
    {
        [Required]
        public PersonEditDto Person { get; set; }

    }
}