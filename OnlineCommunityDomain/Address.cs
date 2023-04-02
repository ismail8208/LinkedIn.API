namespace OnlineCommunityDomain
{
    public class Address
    {
        public int AddressId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = new User();
        public string Country { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
    }
}
