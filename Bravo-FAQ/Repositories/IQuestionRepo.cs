using Bravo_FAQ.Models;
using System.Collections.Generic;

namespace Bravo_FAQ.Repositories
{
    public interface IQuestionRepo
    {
        List<Question> GetAll();
    }
}
