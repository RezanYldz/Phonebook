using Microsoft.AspNetCore.Mvc;
using Phonebook.Business.Interfaces;

namespace Report.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReportController : ControllerBase
    {
        private readonly ILogger<ReportController> _logger;
        private IGenericService<Phonebook.Entities.Report.Report> _reportRepository;

        public ReportController(ILogger<ReportController> logger, IGenericService<Phonebook.Entities.Report.Report> reportRepository)
        {
            _logger = logger;
            _reportRepository = reportRepository;
        }
        [HttpGet]
        public async Task<List<Phonebook.Entities.Report.Report>> GetReports(int id)
        {
            return await _reportRepository.GetAllAsync(e => e.PersonId == id);
        }
        [HttpPost]
        public async Task CreateOrEditReport(Phonebook.Entities.Report.Report input)
        {
            if (input.Id == 0)
                await _reportRepository.AddAsync(input);
            else
                await _reportRepository.UpdateAsync(input);
        }
        [HttpDelete]
        public async Task DeleteReport(int id)
        {
            await _reportRepository.RemoveAsync(await _reportRepository.GetAsync(e => e.Id == id));
        }
    }
}