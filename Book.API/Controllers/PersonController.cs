using Microsoft.AspNetCore.Mvc;
using Phonebook.Business.Interfaces;
using Phonebook.Entities.Book;

namespace Book.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {

        private readonly ILogger<PersonController> _logger;
        private IGenericService<Person> _personRepository;

        public PersonController(ILogger<PersonController> logger, IGenericService<Person> personRepository)
        {
            _logger = logger;
            _personRepository = personRepository;
        }
        [HttpGet]
        public async Task<List<Person>> GetPersons()
        {
            return await _personRepository.GetAllAsync();
        }
        [HttpPost]
        public async Task CreateOrEditPerson(Person input)
        {
            if (input.Id == 0)
                await _personRepository.AddAsync(input);
            else
                await _personRepository.UpdateAsync(input);
        }
        [HttpDelete]
        public async Task DeletePerson(int id)
        {
            await _personRepository.RemoveAsync(await _personRepository.GetAsync(e => e.Id == id));
        }
    }
}