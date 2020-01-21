using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspnetMvcDemo.Models
{
    public class CreateFactory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public Nullable<double> ProductionCapacity { get; set; }
        public Nullable<double> DailyProductionRate { get; set; }
        public Nullable<int> NumberofMixers { get; set; }
        public Nullable<int> NumberofTrucks { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string MailBox { get; set; }
        public string Email { get; set; }
        public Nullable<double> Latitude { get; set; }
        public Nullable<double> Longitude { get; set; }
        public string OwnerName { get; set; }
        public string OwnerEmail { get; set; }
        public string OwnerPhoneNumber { get; set; }
        public string ManagerName { get; set; }
        public string ManagerPhoneNumber { get; set; }
        public string ManagerEmail { get; set; }
        public Nullable<double> ManagerExperience { get; set; }
        public string EngineerName { get; set; }
        public string EngineerPhoneNumber { get; set; }
        public string EngineerEmail { get; set; }
        public Nullable<double> EngineerExperience { get; set; }
    }

    public class MixingDesignDetails
    {
        public string Name { set; get; }
        public string Area { set; get; }
        public string Owner { set; get; }
        public string ConcreteRank { set; get; }
        public string Comments { set; get; }
        public string Status { set; get; }
    }

    public class Fact
    {
        public int FactoryId { get; set; }
        public string FactoryName { get; set; }
    }

    public class AddMixDesign : ConcreteMixingDesign
    {
        public List<Fact> Factories { get; set; }
    }

    public class ApproveMixingDesign : ConcreteMixingDesign
    {
        public string FactoryName { get; set; }
        public string OwnerName { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
    }
}