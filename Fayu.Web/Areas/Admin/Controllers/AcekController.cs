using Fayu.DataAccess.Repository.IRepository;
using Fayu.Models;
using Fayu.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Fayu.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class AcekController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public AcekController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Acek> objAcekList = _unitOfWork.Acek.GetAll().ToList();

            return View(objAcekList);
        }

        public IActionResult Upsert(int? id)
        {

            if (id == null || id == 0)
            {
                //create
                return View(new Acek());
            }
            else
            {
                //update
                Acek acekObj = _unitOfWork.Acek.Get(u => u.Id == id);
                return View(acekObj);
            }

        }
        [HttpPost]
        public IActionResult Upsert(Acek AcekObj)
        {
            if (ModelState.IsValid)
            {

                if (AcekObj.Id == 0)
                {
                    _unitOfWork.Acek.Add(AcekObj);
                }
                else
                {

                    _unitOfWork.Acek.Update(AcekObj);
                }

                _unitOfWork.Save();
                TempData["success"] = "Acek created successfully";
                return RedirectToAction("Index");
            }
            else
            {

                return View(AcekObj);
            }
        }


        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Acek> objAcekList = _unitOfWork.Acek.GetAll().ToList();
            return Json(new { data = objAcekList });
        }


        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var AcekToBeDeleted = _unitOfWork.Acek.Get(u => u.Id == id);
            if (AcekToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _unitOfWork.Acek.Remove(AcekToBeDeleted);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Delete Successful" });
        }

        #endregion
    }
}
