using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Foo
    {
        private readonly IService _service;

        public Foo(IService service)
        {
            _service = service;
        }

        public async Task Bar()
        {
            var cat = await _service.GetCat();
            await _service.Process(cat);
        }
    }

    public interface IService
    {
        Task<string> GetCat();
        Task Process(string cat);
    }
}
