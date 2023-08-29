using Microsoft.AspNetCore.Mvc;

namespace TechnicalServiceUI.ViewComponents
{
    public class _FooterPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
