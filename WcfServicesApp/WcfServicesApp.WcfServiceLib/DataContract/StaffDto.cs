using System.Runtime.Serialization;

namespace WcfServicesApp.WcfServiceLib.DataContract
{
    [DataContract]
    public class StaffDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string FullName { get; set; }
        [DataMember]
        public System.DateTime BirthOfDay { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Descriptions { get; set; }
    }
}
