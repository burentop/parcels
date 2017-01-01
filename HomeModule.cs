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
        int inputLength = Request.Query["length"];
        int inputWidth = Request.Query["width"];
        int inputHeight = Request.Query["height"];
        int inputWeight = Request.Query["weight"];
        int inputDistance = Request.Query["distance"];
        Parcel myParcel = new Parcel(inputLength, inputWidth, inputHeight, inputWeight);
        return View["quote.cshtml", myParcel];
      };
    }
  }
}
