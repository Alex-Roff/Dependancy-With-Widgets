using DependancyWithWidgets.Data.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DependancyWithWidgets.Data.Test
{
  public class xUnitTesting
  {
    private readonly DataHelper db = new DataHelper();
    private Widget wid;
    private int Expected;

    private void Init()
    {
      Expected = 1;
      wid = new Widget()
      {
        WidgetID = 1,
        BasePrice = 25.34m,
        Discount = false,
        Name = "Potato",
        ActiveBit = true
      };
    }

    [Fact]
    public void Get_States()
    {
      Init();
      Expected = 51;
      var actual = db.GetStates().Count;
      Assert.True(Expected == actual);
    }

    [Fact]
    public void Get_Widgets()
    {
      Init();
      var actual = db.GetWidgets().Count;
      Assert.True(Expected == actual);
    }

    [Fact]
    public void Insert_Widgets()
    {
      Init();
      Assert.True(db.InsertWidget(wid));
    }

    [Fact]
    public void Update_Widgets()
    {
      Init();
      wid.Name = "Bongos";
      Assert.True(db.UpdateWidget(wid));
    }

    [Fact]
    public void Delete_Widgets()
    {
      Init();
      Assert.True(db.DeleteWidget(wid));
    }
  }
}
