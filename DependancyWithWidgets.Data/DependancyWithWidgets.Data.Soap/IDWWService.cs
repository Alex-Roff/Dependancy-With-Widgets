using DependancyWithWidgets.Data.Soap.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DependancyWithWidgets.Data.Soap
{
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
  [ServiceContract]
  public interface IDWWService
  {

    [OperationContract]
    List<StateDao> GetStates();
    [OperationContract]
    List<WidgetDao> GetWidgets();
    [OperationContract]
    bool InsertWidget(WidgetDao wid);
    [OperationContract]
    bool UpdateWidget(WidgetDao wid);
    [OperationContract]
    bool DeleteWidget(WidgetDao wid);
  }
}
