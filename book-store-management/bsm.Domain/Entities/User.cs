using System.ComponentModel.DataAnnotations;
using bsm.Domain.Enums;

namespace bsm.Domain.Entities
{
    public class User
    {
        [Key]
        public Guid UserId
        {
            get; set;
        } = new Guid();
        public string UserName
        {
            get; set;
        } = string.Empty;
        public string Password
        {
            get; set;
        } = string.Empty;
        public string Email
        {
            get; set;
        } = string.Empty;
        public DateTime DateOfBirth
        {
            get; set;
        } = DateTime.Now;
        public UserStatus Status
        {
            get; set;
        } = UserStatus.Active;
    }
}
