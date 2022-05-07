using Bravo_FAQ.Models;
using Bravo_FAQ.Utils;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace Bravo_FAQ.Repositories
{
    public class AnswerRepo : BaseRepo, IAnswerRepo
    {
        public AnswerRepo(IConfiguration configuration) : base(configuration) { }

        public List<Answer> GetAll()
        {
            using (var conn = Connection)
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                              
                       SELECT a.QuestionId, a.Id as AnswerId, a.Content, q.Content as Question
                         FROM Answer as a
                         LEFT JOIN Question as q ON a.QuestionId = q.Id;";

                    var reader = cmd.ExecuteReader();

                    var answers = new List<Answer>();
                    while (reader.Read())
                    {
                        answers.Add(NewAnswerFromReader(reader));
                    }

                    reader.Close();

                    return answers;
                }
            }
        }

        public void Add(Answer answer)
        {
            using (var conn = Connection)
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        INSERT INTO Answer (
                            Content, QuestionId)
                        OUTPUT INSERTED.ID
                        VALUES (
                             @Content, @QuestionId)";

                    DbUtils.AddParameter(cmd, "@Content", answer.Content);
                    DbUtils.AddParameter(cmd, "@QuestionId", answer.QuestionId);

                    answer.Id = (int)cmd.ExecuteScalar();
                }
            }
        }

        public void Update(Answer answer)
        {
            using (var conn = Connection)
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        UPDATE Answer 
                            SET Content = @Content
                    
                        WHERE Id = @Id";

                    DbUtils.AddParameter(cmd, "@Content", answer.Content);
                    DbUtils.AddParameter(cmd, "@Id", answer.Id);

                    cmd.ExecuteNonQuery();
                }

            }
        }

        private Answer NewAnswerFromReader(SqlDataReader reader)
        {
            return new Answer()
            {
                Id = DbUtils.GetInt(reader, "AnswerId"),
                Content = DbUtils.GetString(reader, "Content"),
                QuestionId = DbUtils.GetInt(reader, "QuestionId"), 
                Question = new Question()
                {
                    Id = DbUtils.GetInt(reader, "QuestionId"),
                    Content = DbUtils.GetString(reader,"Question")
                }
            };
        }
    }
}

