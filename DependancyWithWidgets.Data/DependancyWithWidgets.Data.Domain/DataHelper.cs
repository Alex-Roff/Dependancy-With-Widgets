using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependancyWithWidgets.Data.Domain
{
  public class DataHelper
  {
    private readonly DepWithWidgetsEntities db = new DepWithWidgetsEntities();

    public List<States> GetStates()
    {
      return db.States.ToList();
    }

    public List<Widget> GetWidgets()
    {
      return db.Widget.ToList();
    }

    public bool InsertWidget(Widget newWid)
    {
      try
      {
        if(newWid == null)
        {
          return false;
        }

        db.Widget.Add(newWid);

        if(db.SaveChanges() > 0)
        {
          return true;
        }

        return false;
      }
      catch(Exception)
      {
        return false;
      }
    }

    public bool UpdateWidget(Widget newWid)
    {
      try
      {
        if (newWid == null)
        {
          return false;
        }

        var oldWid = 
        db.Widget.Add(newWid);

        if (db.SaveChanges() > 0)
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
