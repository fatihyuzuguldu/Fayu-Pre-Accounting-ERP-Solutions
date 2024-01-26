using Fayu.DataAccess.Repository.IRepository;
using Fayu.Models;
using Fayu.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Fayu.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class BillController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public BillController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            List<Bill> objBillList = _unitOfWork.Bill.GetAll(includeProperties: "Company,Supplier").ToList();
            return View(objBillList);
        }
        public IActionResult Company(int? id)
        {
            if (!id.HasValue)
            {
                return RedirectToAction("Index");
            }
            else if (id.HasValue)
            {
                ViewBag.IdFromUrl = id;
                List<Bill> objBillList = _unitOfWork.Bill.GetAll(includeProperties: "Company").ToList();
                int veriSayisi = objBillList.Count(b => b.CompanyId == id);
                ViewBag.VeriSayisi = veriSayisi;

                return View(objBillList);
            }
            else
            {
                return RedirectToAction("Index");
            }

        }
        public IActionResult Supplier(int? id)
        {
            if (!id.HasValue)
            {
                return RedirectToAction("Index");
            }
            else if (id.HasValue)
            {
                ViewBag.IdFromUrl = id;
                List<Bill> objBillList = _unitOfWork.Bill.GetAll(includeProperties: "Supplier").ToList();
                int veriSayisi = objBillList.Count(b => b.SupplierId == id);
                ViewBag.VeriSayisi = veriSayisi;

                return View(objBillList);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public IActionResult Upsert(int? id,int? supp, int? comp)
        {
            if (comp.HasValue && id.HasValue)
            {
                Bill billObj = _unitOfWork.Bill.Get(u => u.Id == id, includeProperties: "Company");
                return View(billObj);
            }
            else if (supp.HasValue && id.HasValue)
            {
                Bill billObj = _unitOfWork.Bill.Get(u => u.Id == id, includeProperties: "Supplier");
                return View(billObj);
            }
            else if (!id.HasValue && comp.HasValue)
            {
                ViewBag.IdFromUrl = comp;
                ViewBag.Csd = "Comp";
                return View(new Bill());
            }
            else if (!id.HasValue && supp.HasValue)
            {
                ViewBag.IdFromUrl = supp;
                ViewBag.Csd = "Supp";
                return View(new Bill());
            }
            else
            {
                return RedirectToAction("Index");
            }

        }
        [HttpPost]
        public IActionResult Upsert(Bill BillObj)
        {
            if (ModelState.IsValid)
            {

                if (BillObj.Id == 0)
                {
                    _unitOfWork.Bill.Add(BillObj);
                }
                else
                {

                    _unitOfWork.Bill.Update(BillObj);
                }

                _unitOfWork.Save();
                TempData["success"] = "Bill created successfully";
                return RedirectToAction("Index");
            }
            else
            {

                return View(BillObj);
            }
        }

        #region API CALLS
        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var billToBeDeleted = _unitOfWork.Bill.Get(u => u.Id == id);
            if (billToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }


            _unitOfWork.Bill.Remove(billToBeDeleted);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Delete Successful" });
        }

        #endregion
    }
}
