using Microsoft.AspNetCore.Identity;

namespace LeaveManagement.Web.Data
{
    public class Employee : IdentityUser
    {
        public string FirstName { get; set; }

        public string? LastName { get; set; }

        public string? TxId { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime DateOfJoining { get; set; }

    }
}
