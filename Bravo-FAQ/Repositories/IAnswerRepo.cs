using Bravo_FAQ.Models;
using System.Collections.Generic;

namespace Bravo_FAQ.Repositories
{
    public interface IAnswerRepo
    {

        void Add(Answer answer);
        List<Answer> GetAll();
        void Update(Answer answer);
    }
}
