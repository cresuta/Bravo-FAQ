using Bravo_FAQ.Models;
using System.Collections.Generic;

namespace Bravo_FAQ.Repositories
{
    public interface IQuestionRepo
    {
        void Add(Question question);
        List<Question> GetAll();
        void Update(Question question);
    }
}
