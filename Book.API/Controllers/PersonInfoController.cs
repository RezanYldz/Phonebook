using Microsoft.AspNetCore.Mvc;
using Phonebook.Business.Interfaces;
using Phonebook.Entities.Book;

namespace Book.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonInfoController : ControllerBase
    {

        private readonly ILogger<PersonController> _logger;
        private IGenericService<PersonInfo> _personInfoRepository;

        public PersonInfoController(ILogger<PersonController> logger, IGenericService<PersonInfo> personInfoRepository)
        {
            _logger = logger;
            _personInfoRepository = personInfoRepository;
        }
        [HttpGet]
        public async Task<List<PersonInfo>> GetPersonInfos(int id)
        {
            return await _personInfoRepository.GetAllAsync(e => e.PersonId == id);
        }
        [HttpPost]
        public async Task CreateOrEditPersonInfo(PersonInfo input)
        {
            if (input.Id == 0)
                await _personInfoRepository.AddAsync(input);
            else
                await _personInfoRepository.UpdateAsync(input);
        }
        [HttpDelete]
        public async Task DeletePerson(int id)
        {
            await _personInfoRepository.RemoveAsync(await _personInfoRepository.GetAsync(e => e.Id == id));
        }
    }
}