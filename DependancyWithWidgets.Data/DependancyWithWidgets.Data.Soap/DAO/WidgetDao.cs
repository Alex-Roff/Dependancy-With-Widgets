using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DependancyWithWidgets.Data.Soap.DAO
{
  [DataContract]
  public class WidgetDao
  {
    [DataMember]
    public int WidgetID { get; set; }
    [DataMember]
    public string Name { get; set; }
    [DataMember]
    public decimal BasePrice { get; set; }
    [DataMember]
    public bool Discount { get; set; }
    [DataMember]
    public bool ActiveBit { get; set; }
  }
}