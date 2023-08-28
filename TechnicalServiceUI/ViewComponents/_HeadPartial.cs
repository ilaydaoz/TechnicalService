using Microsoft.AspNetCore.Mvc;

namespace TechnicalServiceUI.ViewComponents
{
    public class _HeadPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
