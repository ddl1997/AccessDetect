using System;

namespace AccessDetect.Models
{
    public class Access
    {
        public string Id { get; set; }
        public string Ip { get; set; }
        public DateTime AccessTime { get; set; }

        public Access(string id, string ip, DateTime accessTime)
        {
            Id = id;
            Ip = ip;
            AccessTime = accessTime;
        }
    }
}
