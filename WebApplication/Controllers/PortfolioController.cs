using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using WebApplication.Core.Domain;
using WebApplication.Infrastructure.DTO;
using WebApplication.Infrastructure.Services;

namespace WebApplication.Controllers
{
    [Produces("application/json")]
    [Route("api/portfolio")]
    [ApiController]
    public class PortfolioController : Controller
    {
        private readonly IPortfolioService _portfolioService;
        private readonly IMemoryCache _cache;

        public PortfolioController(IPortfolioService portfolioService, IMemoryCache cache)
        {
            _portfolioService = portfolioService;
            _cache = cache;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetPortfolios()
        {
            var portfolios = _cache.Get<IEnumerable<PortfolioDTO>>("portfolios");
            if (portfolios == null)
            {
                Console.WriteLine("Fetching from service");
                portfolios = await _portfolioService.BrowseAsync();
                _cache.Set("portfolios", portfolios, TimeSpan.FromMinutes(1));
            }
            else
            {
                Console.WriteLine("Fetching from cache");
            }

            return Json(portfolios);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> GetPortfolio(string isin, DateTime date)
        {
            var @portfolio = await _portfolioService.GetAsync(isin, date);
            if (@portfolio == null)
            {
                return NotFound();
            }

            return Json(@portfolio);
        }

        // POST: Portfolio/Create
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public ActionResult CreatePortfolio([FromBody] Portfolio portfolio)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _portfolioService.CreateAsync(portfolio);
            return Json(@portfolio);
        }

        // POST: Portfolio/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(GetPortfolios));
            }
            catch
            {
                return View();
            }
        }

        // POST: Portfolio/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(GetPortfolios));
            }
            catch
            {
                return View();
            }
        }
    }
}