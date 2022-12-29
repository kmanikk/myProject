using BookShopping_Project_DataAccess.Repository.IRepository;
using BookShopping_Project_Models;
using BookShopping_Project_Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_BookShopping_Project5.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_User_Admin)]
    public class CoverTypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CoverTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;   
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Upsert(int? id)
        {
            CoverType coverType = new CoverType();
            if (id == null)
                return View(coverType);
            var coverTypeList = _unitOfWork.CoverType.Get(id.GetValueOrDefault());
            return View(coverTypeList);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(CoverType coverType)
        {
            if (ModelState.IsValid)
            {
                if (coverType == null)
                    return NotFound();
                if (coverType.Id == 0)
                    _unitOfWork.CoverType.Add(coverType);
                else
                    _unitOfWork.CoverType.Update(coverType);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(coverType);
        }

        #region APIs
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _unitOfWork.CoverType.GetAll() });
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var coverInDb = _unitOfWork.CoverType.Get(id);
            if (coverInDb == null)
                return Json(new { success = false, message = "Error While Deleting Data!!" });
            _unitOfWork.CoverType.Remove(coverInDb);
            _unitOfWork.Save();
            return Json(new { success = true, message="Data Deleted Successfully!!"});
        }

        #endregion
    }
}
    

