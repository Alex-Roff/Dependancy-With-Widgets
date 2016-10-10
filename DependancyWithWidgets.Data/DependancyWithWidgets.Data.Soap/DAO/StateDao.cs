using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DependancyWithWidgets.Data.Soap.DAO
{
  [DataContract]
  public class StateDao
  {
    [DataMember]
    public int StateID { get; set; }
    [DataMember]
    public string StateName { get; set; }
    [DataMember]
    public double StateTax { get; set; }
    [DataMember]
    public bool ActiveBit { get; set; }
  }
}