using Nancy;
using Parcels.Objects;

namespace Parcels
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/form"] = _ => {
        return View["form.cshtml"];
      };
      Get["/quote"] = _ => {
        double inputLength = Request.Query["length"];
        double inputWidth = Request.Query["width"];
        double inputHeight = Request.Query["height"];
        double inputWeight = Request.Query["weight"];
        double inputDistance = Request.Query["distance"];
        Parcel myParcel = new Parcel(inputLength, inputWidth, inputHeight, inputWeight, inputDistance);
        return View["quote.cshtml", myParcel];
      };
    }
  }
}
