using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DependancyWithWidgets.Data.Soap.DAO;
using DependancyWithWidgets.Data.Domain;

namespace DependancyWithWidgets.Data.Soap
{
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
  // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
  public class Service1 : IDWWService
  {
    private readonly DataHelper Dh = new DataHelper();
    private DataMapper dm = new DataMapper();

    public bool DeleteWidget(WidgetDao wid)
    {
      try
      {
        if (Dh.InsertWidget(dm.MapToEntity(wid)))
        {
          return true;
        }

        return false;
      }
      catch (Exception)
      {
        return false;
      }
    }

    public List<StateDao> GetStates()
    {
      var returnlist = new List<StateDao>();
      foreach (var item in Dh.GetStates())
      {
        returnlist.Add(dm.MapToDao(item));
      }
      return returnlist;
    }

    public List<WidgetDao> GetWidgets()
    {
      var returnlist = new List<WidgetDao>();
      foreach (var item in Dh.GetWidgets())
      {
        returnlist.Add(dm.MapToDao(item));
      }
      return returnlist;
    }

    public bool InsertWidget(WidgetDao wid)
    {
      try
      {
        if(Dh.InsertWidget(dm.MapToEntity(wid)))
        {
          return true;
        }

        return false;
      }
      catch (Exception)
      {
        return false;
      }
    }

    public bool UpdateWidget(WidgetDao wid)
    {
      try
      {
        if (Dh.UpdateWidget(dm.MapToEntity(wid)))
        {
          return true;
        }

        return false;
      }
      catch (Exception)
      {
        return false;
      }
    }
  }
}
