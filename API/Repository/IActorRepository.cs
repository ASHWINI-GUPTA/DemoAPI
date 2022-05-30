using System.Collections.Generic;
using DemoApi.Models;

namespace DemoApi.Repository
{
    public interface IActorRepository
    {
        public IEnumerable<Actor> GetAll();
    }
}
