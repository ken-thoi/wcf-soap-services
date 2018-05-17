using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ServiceModel.Activation;
using System.ServiceModel.Syndication;
using System.ServiceModel.Web;
using WcfServicesApp.DataLayer;
using WcfServicesApp.DataLayer.DataContext;
using WcfServicesApp.DataLayer.DataContract;
using WcfServicesApp.DataLayer.Helpers;

namespace WcfServicesApp.WcfServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "KenService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select KenService.svc or KenService.svc.cs at the Solution Explorer and start debugging.

    // The attribute AspNetCompabilityRequirements is used for specifying an ASP.NET compatible environment for WCF service execution.
    //[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class KenService : IKenService
    {
        public StaffDto[] GetAllStaffs()
        {
            var staffs = new StaffService().GetAllStaffs();
            Console.WriteLine($"Staffs all: {JsonConvert.SerializeObject(staffs)}");
            var result = MapperHelper.MapList<Staff, StaffDto>(staffs);

            return result.ToArray();
        }

        public StaffDto[] GetAllStaffsByJson()
        {
            var staffs = new StaffService().GetAllStaffs();
            Console.WriteLine($"Staffs all: {JsonConvert.SerializeObject(staffs)}");
            var result = MapperHelper.MapList<Staff, StaffDto>(staffs);
            return result.ToArray();
        }

        public Atom10FeedFormatter Search(string format)
        {
            // Initialize return object
            var staffs = new StaffService().GetAllStaffs();

            // Populate your return object here

            // Decide which format to return
            switch (format)
            {
                case "atom":
                    var items = new List<SyndicationItem>();
                    foreach (Staff staff in staffs)
                    {
                        SyndicationItem item = new SyndicationItem(staff.FullName, new XmlSyndicationContent("application/xml", new SyndicationElementExtension(staff)),
                            new Uri(String.IsNullOrWhiteSpace(staff.ExternalLink) ? "http://promote.fm" : staff.ExternalLink),
                            staff.Id.ToString(),
                            new DateTimeOffset(staff.Modified == null ? (DateTime)staff.Created : (DateTime)staff.Modified));
                        item.Summary = new TextSyndicationContent(staff.Descriptions);
                        items.Add(item);
                    }

                    SyndicationFeed feed = new SyndicationFeed("Promote.fm Staff", "The latest staff promoted via promote.fm", new Uri("http://promote.fm"), items);
                    feed.Authors.Add(new SyndicationPerson("info@promote.fm", "Promote.fm", "http://promote.fm"));
                    feed.Categories.Add(new SyndicationCategory("Staff"));
                    feed.LastUpdatedTime = DateTime.Now;

                    WebOperationContext.Current.OutgoingResponse.ContentType = ContentTypes.Atom;
                    Atom10FeedFormatter result = feed.GetAtom10Formatter();
                    return result;

                case "json":
                    WebOperationContext.Current.OutgoingResponse.Format = WebMessageFormat.Json;
                    return null;

                default:
                    WebOperationContext.Current.OutgoingResponse.Format = WebMessageFormat.Xml;
                    return null;
            }
        }
    }

    public static class ContentTypes
    {
        public static string Atom = "Atom";
    }
}