namespace PersonalBlog.DAL.Results
{
    public class ResultOrProblem<T>
    {
        public T Result { get; set; }

        public ProblemType ProblemType { get; set; }

        public ResultOrProblem(T result)
        {
            Result = result;
            ProblemType = ProblemType.NoProblem;
        }

        public ResultOrProblem(ProblemType problemType)
        {
            ProblemType = problemType;
        }
    }
}
