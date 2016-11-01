using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewComponentDemo.Models;

namespace ViewComponentDemo.ViewComponents
{

  public class TripViewComponent : ViewComponent
  {

    public TripViewComponent(TripRepository repository)
    {
      this.Repository = repository;
    }

    public TripRepository Repository { get; }

    public async Task<ViewViewComponentResult> InvokeAsync()
    {
      var trips = Repository.Get();
      await Task.FromResult(0);
      return View(trips);
    }

  }

}
