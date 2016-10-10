using AutoMapper;
using DependancyWithWidgets.Data.Domain;
using DependancyWithWidgets.Data.Soap.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependancyWithWidgets.Data.Soap
{
  public class DataMapper
  {
    MapperConfiguration StateMapper = new MapperConfiguration(m => m.CreateMap<States, StateDao>().ReverseMap());
    MapperConfiguration WidgetMapper = new MapperConfiguration(w => w.CreateMap<Widget, WidgetDao>().ReverseMap());

    public StateDao MapToDao(States s)
    {
      var mapper = StateMapper.CreateMapper();
      return mapper.Map<StateDao>(s);
    }

    public States MapToEntity(StateDao s)
    {
      var mapper = StateMapper.CreateMapper();
      return mapper.Map<States>(s);
    }

    public WidgetDao MapToDao(Widget w)
    {
      var mapper = StateMapper.CreateMapper();
      return mapper.Map<WidgetDao>(w);
    }

    public Widget MapToEntity(WidgetDao w)
    {
      var mapper = StateMapper.CreateMapper();
      return mapper.Map<Widget>(w);
    }
  }
}