

namespace test2
{
    //co ?
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        char Sex { get; }
        void AddGrade();
        void AddGrade(char grade);
        void AddGrade(decimal grade);
        void AddGrade(long grade);
        void AddGrade(double grade);
        void AddGrade(string grade);
        void AddGrade(float grade);
        Statistics GetStatistics();
    }
}
