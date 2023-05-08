using AutoMapper;
using DPM205XXX_QLHS.Models;
using Infrastructure.Entities;
using Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DPM205XXX_QLHS.Controllers
{
    public class HocSinhController : Controller
    {
        private readonly IHocSinhService hocSinhService;
        private readonly IMapper mapper;
        public HocSinhController(IHocSinhService hocSinhService, IMapper mapper)
        {
            this.hocSinhService = hocSinhService;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            return View(hocSinhService.GetTatCaHocSinh());
        }

        public IActionResult AddOrEdit(int id = 0)
        {
            HocSinhViewModel data = new HocSinhViewModel();
            ViewBag.RenderedHtmlTitle = id == 0 ? "THÊM MỚI HỌC SINH" : "CẬP NHẬT HỌC SINH";

            if (id != 0)
            {
                HocSinh res = hocSinhService.GetHocSinh(id);
                data = mapper.Map<HocSinhViewModel>(res);
                if (data == null)
                {
                    return NotFound();
                }
            }

            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOrEdit(int id, HocSinhViewModel data)
        {
            ViewBag.RenderedHtmlTitle = id == 0 ? "THÊM MỚI HỌC SINH" : "CẬP NHẬT HỌC SINH";

            if (ModelState.IsValid)
            {
                try
                {
                    HocSinh res = mapper.Map<HocSinh>(data);
                    if (id != 0)
                    {
                        hocSinhService.UpdateHocSinh(res);
                    }
                    else
                    {

                        hocSinhService.InsertHocSinh(res);
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }

                return RedirectToAction("Index", "HocSinh");
            }

            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            HocSinh res = hocSinhService.GetHocSinh(id);
            hocSinhService.DeleteHocSinh(res);

            return RedirectToAction("Index", "HocSinh");
        }
    }
}
