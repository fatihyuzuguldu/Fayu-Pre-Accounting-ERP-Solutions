using Fayu.DataAccess.Repository.IRepository;
using Fayu.Models;
using Fayu.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Fayu.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class OcekController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public OcekController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Ocek> objOcekList = _unitOfWork.Ocek.GetAll().ToList();

            return View(objOcekList);
        }

        public IActionResult Upsert(int? id)
        {

            if (id == null || id == 0)
            {
                //create
                return View(new Ocek());
            }
            else
            {
                //update
                Ocek ocekObj = _unitOfWork.Ocek.Get(u => u.Id == id);
                return View(ocekObj);
            }

        }
        [HttpPost]
        public IActionResult Upsert(Ocek OcekObj)
        {
            if (ModelState.IsValid)
            {

                if (OcekObj.Id == 0)
                {
                    _unitOfWork.Ocek.Add(OcekObj);
                }
                else
                {
                    _unitOfWork.Ocek.Update(OcekObj);
                }

                _unitOfWork.Save();
                TempData["success"] = "Ocek created successfully";
                return RedirectToAction("Index");
            }
            else
            {

                return View(OcekObj);
            }
        }


        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Ocek> objOcekList = _unitOfWork.Ocek.GetAll().ToList();
            return Json(new { data = objOcekList });
        }


        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var OcekToBeDeleted = _unitOfWork.Ocek.Get(u => u.Id == id);
            if (OcekToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _unitOfWork.Ocek.Remove(OcekToBeDeleted);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Delete Successful" });
        }

        #endregion
    }
}
