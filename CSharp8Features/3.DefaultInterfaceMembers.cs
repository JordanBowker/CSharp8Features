using System;

namespace CSharp8Features
{
    // Define implementations onto an interface
    // Very disputable feature 
    // I can see it being useful to combat the multiple inheritance problem

    public interface IOrganisation
    {
        string OrgansationNumber { get; set; }
        string Name { get; set; }
        string GetOrganisationIdentifier();

//        public string GetOrganisationIdentifier()
//        {
//            return $"{Name} - {OrgansationNumber}";
//        }
    }

    public abstract class AbstractOrganisation : IOrganisation
    {
        public string OrgansationNumber { get; set; }
        public string Name { get; set; }
        public string GetOrganisationIdentifier()
        {
            return $"{Name} - {OrgansationNumber}";
        }
    }

    public interface IPersistable
    {
        Guid? Id { get; set; }
        bool IsPersisted();

//        public bool IsPersisted()
//        {
//            return Id.HasValue;
//        }
    }

    public abstract class AbstractPersistable : IPersistable
    {
        public Guid? Id { get; set; }

        public bool IsPersisted()
        {
            return Id.HasValue;
        }
    }

//    public class Company : IOrganisation, IPersistable
//    {
//    }

}
