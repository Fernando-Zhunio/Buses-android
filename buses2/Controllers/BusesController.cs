using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using buses2.Models;
namespace buses2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BusesController : ControllerBase
    {
        public readonly AppDbContext _context;

        public BusesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "IndexBuses")]
        public async Task<IActionResult> Index()
        {
            try
            {
                var listBuses = await _context.bus.ToListAsync();
                return Ok(listBuses);
            }
            catch (Exception ex)
            {
                return  BadRequest(ex);

            }
        }


        // GET: BusesController
        //    public ActionResult Index()
        //    {
        //        return View();
        //    }

        //    // GET: BusesController/Details/5
        //    public ActionResult Details(int id)
        //    {
        //        return View();
        //    }

        //    // GET: BusesController/Create
        //    public ActionResult Create()
        //    {
        //        return View();
        //    }

        // POST: BusesController/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromBody] Bus bus)
        {
            try
            {
                _context.Add(bus);
                await _context.SaveChangesAsync();
                return Ok(bus);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //    // GET: BusesController/Edit/5
        //    public ActionResult Edit(int id)
        //    {
        //        return View();
        //    }

        //    // POST: BusesController/Edit/5
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public ActionResult Edit(int id, IFormCollection collection)
        //    {
        //        try
        //        {
        //            return RedirectToAction(nameof(Index));
        //        }
        //        catch
        //        {
        //            return View();
        //        }
        //    }

        //    // GET: BusesController/Delete/5
        //    public ActionResult Delete(int id)
        //    {
        //        return View();
        //    }

        //    // POST: BusesController/Delete/5
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public ActionResult Delete(int id, IFormCollection collection)
        //    {
        //        try
        //        {
        //            return RedirectToAction(nameof(Index));
        //        }
        //        catch
        //        {
        //            return View();
        //        }
        //    }
    }
}
