using System;
using System.Collections.Generic;
using UshtrimeProvim1B.Validations;


#nullable disable

namespace UshtrimeProvim1B.Entities
{
    public partial class Application
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public decimal Amount { get; set; }

        [ApplicationIdValidationAttribute]
        public string ApplicationId { get; set; }

        public virtual Person Person { get; set; }
    }
}
