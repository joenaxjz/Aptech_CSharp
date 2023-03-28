namespace DemoSession_1.Models;

public class QuestionModel
{
	private List<Question>		questions;
	private List<Answer>  answers;

	public QuestionModel() {
		questions = new List<Question> {
			new Question
			{
				Id = 1,
				Content = "1 + 1 bằng mấy ?",
				Answers = new List<Answer>
				{
					new Answer
					{
						Id = 1,
						Content = "bằng 1",
						IsCorret = false
					},

					new Answer
					{
						Id = 2,
						Content = "bằng 2",
						IsCorret = true
					},

					new Answer
					{
						Id = 3,
						Content = "bằng 3",
						IsCorret = false
					},

					new Answer {
						Id = 4,
						Content = "bằng 4",
						IsCorret = false
					}
				}
			}


			};
	}

	public List<Question> findAll()
	{
		return questions;
	}
		 
	public bool isCorret (int questionId, int answerId)
	{
		var question = questions.SingleOrDefault(q => q.Id == questionId);
		var answerIsCorrect = question.Answers.SingleOrDefault(a => a.IsCorret).Id;
		return answerIsCorrect == answerId;
	}
}
