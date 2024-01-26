using Fayu.DataAccess.Repository.IRepository;
using Fayu.Models;
using Fayu.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Fayu.Web.Areas.Admin.Controllers
{
        [Area("Admin")]
        [Authorize(Roles = SD.Role_Admin)]
    public class SupplierController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public SupplierController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Supplier> objSupplierList = _unitOfWork.Supplier.GetAll().ToList();

            return View(objSupplierList);
        }

        public IActionResult Upsert(int? id)
        {

            if (id == null || id == 0)
            {
                //create
                return View(new Supplier());
            }
            else
            {
                //update
                Supplier supplierObj = _unitOfWork.Supplier.Get(u => u.Id == id);
                return View(supplierObj);
            }

        }
        [HttpPost]
        public IActionResult Upsert(Supplier SupplierObj)
        {
            if (ModelState.IsValid)
            {

                if (SupplierObj.Id == 0)
                {
                    SupplierObj.CreatedAt = DateTime.Now;
                    _unitOfWork.Supplier.Add(SupplierObj);
                }
                else
                {
                    
                    _unitOfWork.Supplier.Update(SupplierObj);
                }

                _unitOfWork.Save();
                TempData["success"] = "Supplier created successfully";
                return RedirectToAction("Index");
            }
            else
            {

                return View(SupplierObj);
            }
        }


        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Supplier> objSupplierList = _unitOfWork.Supplier.GetAll().ToList();
            return Json(new { data = objSupplierList });
        }


        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            // Bill tablosundaki ilgili verileri sil
            var billsToBeDeleted = _unitOfWork.Bill.Get(u => u.SupplierId == id);
            if (billsToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error While Deleting" });
            }
            _unitOfWork.Bill.Remove(billsToBeDeleted);
            _unitOfWork.Save();

            var SupplierToBeDeleted = _unitOfWork.Supplier.Get(u => u.Id == id);
            if (SupplierToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _unitOfWork.Supplier.Remove(SupplierToBeDeleted);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Delete Successful" });
        }

        #endregion
    }
}
