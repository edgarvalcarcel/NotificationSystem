//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ADX.Entities.DomainModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class AspNetUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AspNetUser()
        {
            this.AspNetUsers1 = new HashSet<AspNetUser>();
            this.NotificationByUsers = new HashSet<NotificationByUser>();
            this.UserNotifications = new HashSet<UserNotification>();
        }
    
        public string Id { get; set; }
        public int AccessFailedCount { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public Nullable<int> GroupId { get; set; }
        public bool LockoutEnabled { get; set; }
        public Nullable<System.DateTimeOffset> LockoutEnd { get; set; }
        public string ManagerId { get; set; }
        public string NormalizedEmail { get; set; }
        public string NormalizedUserName { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public string Photo { get; set; }
        public bool ResetPasswordNeeded { get; set; }
        public string SecurityStamp { get; set; }
        public Nullable<int> State { get; set; }
        public string Title { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public int UserCode { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserName { get; set; }
        public string Zip { get; set; }
        public System.DateTimeOffset CreatedOn { get; set; }
        public bool Status { get; set; }
        public string CellphoneNumber { get; set; }
        public bool CellphoneConfirmed { get; set; }
        public bool InfoUpdateNeeded { get; set; }
        public string CellphoneVerificationCode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetUser> AspNetUsers1 { get; set; }
        public virtual AspNetUser AspNetUser1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotificationByUser> NotificationByUsers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserNotification> UserNotifications { get; set; }
    }
}
