namespace aula_11_programacao_orientada_objetos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : ControllerBase
    {
        public PeopleController() {

        }

        private PersonRepository _repository = new PersonRepository();

        [HttpGet()]
        public IEnumerable<Person> Get()
        {
            if(_repository.GetAll().Count == 0)
            {
            _repository.Create(new Person(10, "Teste", "Rua 1"));
            _repository.Create(new Person(11, "Teste", "Rua 2"));
            _repository.Create(new Person(12, "Teste", "Rua 3"));
            }
            return _repository.GetAll();
        }

        [HttpGet("{Id}")]
        public Person Get(int id) 
        {
            return _repository.GetById(id);
        }
    }
}