using System.Collections.Generic;
using DemoApi.Models;

namespace DemoApi.Services
{
    public interface IActorService
    {
        public IEnumerable<Actor> GetAll();
    }
}
