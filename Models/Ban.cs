namespace tGhWebsite.Models
{
    public class Ban
    {
        public int BanId { get; set; }

        public string BanUsername { get; set; }
        public string BanIp { get; set; }
        public string BanEmail { get; set; }
        public int BanExpireDate { get; set; }
    }
}